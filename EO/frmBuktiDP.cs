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
    public partial class frmBuktiDP : Form
    {
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

                MessageBox.Show(idKontrak);
                
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

                MessageBox.Show(idKontrak);

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

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO payment(id_kontrak, biaya, bayar_dp) VALUES(@a, @b, @c)";
                comm.Parameters.AddWithValue("@a", idKontrak);
                comm.Parameters.AddWithValue("@b", biaya);
                comm.Parameters.AddWithValue("@c", bayarDp);

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
    }
}
