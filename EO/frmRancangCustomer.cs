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

namespace EO
{
    public partial class frmRancangCustomer : Form
    {
        public frmRancangCustomer()
        {
            InitializeComponent();
        }

        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            ofdConcept.Title = "Open Concept Files";
            ofdConcept.FileName = "";
            //ofdConcept.Filter = "JPEG Files|*.jpeg|JPG Files|*jpg|PNG Files|*.png";
            ofdConcept.AddExtension = true;

            if (ofdConcept.ShowDialog() == DialogResult.OK)
            {
                String pathFotoLokal = ofdConcept.FileName;
                //Image image = Image.FromFile(pathFotoLokal);

                
                txtDirectory.Text = pathFotoLokal;

                //image.Dispose();
            }
            else txtDirectory.Text = "";
        }

        private void frmRancangCustomer_Load(object sender, EventArgs e)
        {
            String idDB = "";
            String nameDB = "";

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_customer, name FROM customer");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    idDB = iDataReader.GetString(0);
                    nameDB = iDataReader.GetString(1);

                    cboIdCustomer.Items.Add(idDB + " - " + nameDB);
                }
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
            String tema = txtTema.Text;
            String concept = txtDirectory.Text;
            int tempat = Int32.Parse(txtTempat.Text), pegawai = Int32.Parse(txtPegawai.Text), akomodasi = Int32.Parse(txtAkomodasi.Text);
            int peralatan = Int32.Parse(txtPeralatan.Text), dekorasi = Int32.Parse(txtDekorasi.Text), konsumsi = Int32.Parse(txtKonsumsi.Text);
            int keamanan = Int32.Parse(txtKeamanan.Text), asuransi = Int32.Parse(txtAsuransi.Text), komunikasi = Int32.Parse(txtKomunikasi.Text);

            try
            {
                String cbo = cboIdCustomer.Text;
                String[] words = cbo.Split(null);
                idCustomer = words[0];
                this.conn = new MySqlConnection(connString);
                conn.Open();

                comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO rancangan(id_customer, tema, concept, biaya_tempat, biaya_pegawai, biaya_akomodasi, biaya_peralatan, biaya_dekorasi, biaya_konsumsi, biaya_keamanan, biaya_asuransi, biaya_komunikasi) VALUES(@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k, @l)";
                comm.Parameters.AddWithValue("@a", idCustomer);
                comm.Parameters.AddWithValue("@b", tema);
                comm.Parameters.AddWithValue("@c", concept);
                comm.Parameters.AddWithValue("@d", tempat);
                comm.Parameters.AddWithValue("@e", pegawai);
                comm.Parameters.AddWithValue("@f", akomodasi);
                comm.Parameters.AddWithValue("@g", peralatan);
                comm.Parameters.AddWithValue("@h", dekorasi);
                comm.Parameters.AddWithValue("@i", konsumsi);
                comm.Parameters.AddWithValue("@j", keamanan);
                comm.Parameters.AddWithValue("@k", asuransi);
                comm.Parameters.AddWithValue("@l", komunikasi);

                comm.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Form berhasil di simpan!");
                this.Close();
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
    }
}
