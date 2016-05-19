using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.IO;

using System.Drawing.Imaging;
using System.Drawing.Printing;



namespace EO
{
    public partial class frmBuktiDP : Form
    {
     /*   [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]

        private System.IO.Stream streamToPrint;
        string streamType;
        private static extern bool BitBlt
        (
            IntPtr hdcDest, // handle to destination DC
            int nXDest, // x-coord of destination upper-left corner
            int nYDest, // y-coord of destination upper-left corner
            int nWidth, // width of destination rectangle
            int nHeight, // height of destination rectangle
            IntPtr hdcSrc, // handle to source DC
            int nXSrc, // x-coordinate of source upper-left corner
            int nYSrc, // y-coordinate of source upper-left corner
            System.Int32 dwRop // raster operation code
        );*/

        public frmBuktiDP()
        {

            InitializeComponent();
        }

        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";

        private void frmBuktiDP_Load(object sender, EventArgs e)
        {
            String idDB = "";
            String nameDB = "";
            String idKontrak = "";
            int biayaDB = 0;

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_customer, name, id_kontrak, biaya FROM customer JOIN perjanjian_kerja USING (id_customer)");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();
                
                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    idDB = iDataReader.GetString(0);
                    nameDB = iDataReader.GetString(1);
                    //idKontrak = iDataReader.GetString(2);
                    //biayaDB = iDataReader.GetInt32(3);

                    cboIdCustomer.Items.Add(idDB + " - " + nameDB);
                    //txtBiaya.Text = biayaDB.ToString();
                    //txtTagihan.Text = biayaDB.ToString();
                }

                //MessageBox.Show(idKontrak);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

                if (iDataReader != null)
                {
                    iDataReader.Close();
                    iDataReader.Dispose();
                }
            }
        }

        String idKontrak = "";

        private void cboIdCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idDB = cboIdCustomer.Text;
            String[] words = idDB.Split(null);
            String nameDB = "";
            
            int biayaDB = 0;

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_customer, name, id_kontrak, biaya FROM customer JOIN perjanjian_kerja USING (id_customer) WHERE id_customer = '" + words[0] + "'");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    idDB = iDataReader.GetString(0);
                    nameDB = iDataReader.GetString(1);
                    idKontrak = iDataReader.GetString(2);
                    biayaDB = iDataReader.GetInt32(3);

                    cboIdCustomer.Items.Add(idDB + " - " + nameDB);
                    txtBiaya.Text = biayaDB.ToString();
                    txtTagihan.Text = biayaDB.ToString();
                }

               // MessageBox.Show(idKontrak);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

                if (iDataReader != null)
                {
                    iDataReader.Close();
                    iDataReader.Dispose();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String idCustomer = cboIdCustomer.Text;
            String[] words = idCustomer.Split(null);
            int biaya = Int32.Parse(txtBiaya.Text);
            int bayarDp = Int32.Parse(txtPembayaran.Text);

            DateTime now = DateTime.Now;
            String date = now.DayOfWeek.ToString() + ", " + now.ToString("MMMM") + " " + now.ToString("dd") + ", " + now.ToString("yyyy");
           
            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                //insert into payment
                comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO payment(id_kontrak, biaya, bayar_dp,tanggal_pelunasan) VALUES(@a, @b, @c,@d)";
                comm.Parameters.AddWithValue("@a", idKontrak);
                comm.Parameters.AddWithValue("@b", biaya);
                comm.Parameters.AddWithValue("@c", bayarDp);
                comm.Parameters.AddWithValue("@d", date);

                comm.ExecuteNonQuery();

                //insert into transaksi
                comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO transaksi(id_kontrak,jenis_transaksi, tanggal_transaksi, jumlah_transaksi) VALUES(@a, @b, @c,@d)";
                comm.Parameters.AddWithValue("@a", idKontrak);
                comm.Parameters.AddWithValue("@b", "DP");
                comm.Parameters.AddWithValue("@c", date);
                comm.Parameters.AddWithValue("@d", bayarDp);

                comm.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Form berhasil di isi!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
                e.Graphics.DrawImage(memoryImage, 0, 0);
            

            /*System.Drawing.Image image = System.Drawing.Image.FromStream(this.streamToPrint);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;
            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }
            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);*/
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument.Print();
            /*Graphics g1 = this.CreateGraphics();
            Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            MyImage.Save(@"c:\PrintPage.jpg", ImageFormat.Jpeg);
            FileStream fileStream = new FileStream(@"c:\PrintPage.jpg", FileMode.Open, FileAccess.Read);
            StartPrint(fileStream, "Image");
            fileStream.Close();
            if (System.IO.File.Exists(@"c:\PrintPage.jpg"))
            {
                System.IO.File.Delete(@"c:\PrintPage.jpg");
            }*/
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        public void StartPrint(Stream streamToPrint, string streamType)
        {
            /*this.printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            this.streamToPrint = streamToPrint;
            this.streamType = streamType;
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
                //docToPrint.Print();
            }*/
        }
    }
}
