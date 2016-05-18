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
    public partial class frmJatuhTempo : Form
    {
        public frmJatuhTempo()
        {
            InitializeComponent();
        }

        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";

        private void frmJatuhTempo_Load(object sender, EventArgs e)
        {
            String idDB = "";
            String tglJatuhTempoDB = "";
            String idCustomer = "";
            int biayaDB = 0;

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_kontrak, tanggal_jatuh_tempo, id_customer FROM perjanjian_kerja");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    idDB = iDataReader.GetString(0);
                    tglJatuhTempoDB = iDataReader.GetString(1);

                    cboSuratKontrak.Items.Add(idDB);
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

        private void cboSuratKontrak_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idDB = cboSuratKontrak.Text;
            String tglJatuhTempoDB = "";
            String idCustomer = "";
            String nama = "";
            String alamat = "";
            String noTelepon = "";
            String email = "";

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_kontrak, tanggal_jatuh_tempo, id_customer, name, phone, alamat, email FROM perjanjian_kerja p JOIN customer c USING (id_customer) WHERE id_kontrak = '" + idDB + "'");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    idDB = iDataReader.GetString(0);
                    tglJatuhTempoDB = iDataReader.GetString(1);
                    idCustomer = iDataReader.GetString(2);
                    nama = iDataReader.GetString(3);
                    noTelepon = iDataReader.GetString(4);
                    alamat = iDataReader.GetString(5);
                    email = iDataReader.GetString(6);

                    cboSuratKontrak.Text = idDB;
                    txtTglJatuhTempo.Text = tglJatuhTempoDB;
                    txtIdClient.Text = idCustomer;
                    txtNama.Text = nama;
                    txtAlamat.Text = alamat;
                    txtNoTelepon.Text = noTelepon;
                    txtEmail.Text = email;
                    

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
