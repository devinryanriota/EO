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
    public partial class frmPerjanjianKerja : Form
    {
        public frmPerjanjianKerja()
        {
            InitializeComponent();
        }

        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";

        private void frmPerjanjianKerja_Load(object sender, EventArgs e)
        {
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
                    String idDB = iDataReader.GetString(0);
                    String nameDB = iDataReader.GetString(1);

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
            String idCustomer = "";
            String tglSurat = dtpBuatSurat.Text;
            String tglAcara = dtpAcara.Text;
            String tglJatuhTempo = dtpJatuhTempo.Text;
            int biaya = Int32.Parse(txtBiaya.Text);

            try
            {
                String cbo = cboIdCustomer.Text;
                String[] words = cbo.Split(null);
                idCustomer = words[0];
                this.conn = new MySqlConnection(connString);
                conn.Open();

                comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO perjanjian_kerja(id_customer, tanggal_surat, tanggal_acara, tanggal_jatuh_tempo, biaya, status_kontrak) VALUES(@a, @b, @c, @d, @e, @f)";
                comm.Parameters.AddWithValue("@a", idCustomer);
                comm.Parameters.AddWithValue("@b", tglSurat);
                comm.Parameters.AddWithValue("@c", tglAcara);
                comm.Parameters.AddWithValue("@d", tglJatuhTempo);
                comm.Parameters.AddWithValue("@e", biaya);
                comm.Parameters.AddWithValue("@f", "Belum Lunas");

                comm.ExecuteNonQuery();
                conn.Close();
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

        private void cboIdCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String cbo = cboIdCustomer.Text;
                String[] words = cbo.Split(null); 
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_customer, name, phone, alamat FROM customer where id_customer ='" + words[0] + "'");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();


                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    String idDB = iDataReader.GetString(0);
                    String nameDB = iDataReader.GetString(1);
                    String phoneDB = iDataReader.GetString(2);
                    String alamat = iDataReader.GetString(3);

                    txtNama.Text = nameDB;
                    txtAlamat.Text = phoneDB;
                    txtTelepon.Text = phoneDB;
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
    }
}
