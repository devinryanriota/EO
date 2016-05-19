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
    public partial class frmSuratPerizinan : Form
    {

        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";
        String nameDB = "";
        public frmSuratPerizinan(String nameDB)
        {
            InitializeComponent();
            this.nameDB = nameDB;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSuratPerizinan_Load(object sender, EventArgs e)
        {
            String idDB = "";

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT perjanjian_kerja.id_kontrak
                                        FROM perjanjian_kerja");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    idDB = iDataReader.GetString(0);
                    cboIDKontrakKerja.Items.Add(idDB);
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

        private void cboIDKontrakKerja_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idDB = "";
            DateTime now = DateTime.Now;
            String date = now.DayOfWeek.ToString() + ", " + now.ToString("MMMM") + " " + now.ToString("dd") + ", " + now.ToString("yyyy");

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT 
                                        perjanjian_kerja.id_customer,
                                        rancangan.tema,
                                        rancangan.biaya_tempat,
                                        rancangan.biaya_pegawai,
                                        rancangan.biaya_akomodasi,
                                        rancangan.biaya_peralatan,
                                        rancangan.biaya_dekorasi,
                                        rancangan.biaya_konsumsi,
                                        rancangan.biaya_keamanan,
                                        rancangan.biaya_asuransi,
                                        rancangan.biaya_komunikasi,
                                        payment.bayar_dp,
                                        perjanjian_kerja.tanggal_acara,
                                        perjanjian_kerja.tanggal_jatuh_tempo
                                        FROM perjanjian_kerja
                                        JOIN payment ON (perjanjian_kerja.id_kontrak=payment.id_kontrak)
                                        JOIN rancangan ON (perjanjian_kerja.id_customer=rancangan.id_customer)
                                        WHERE perjanjian_kerja.id_kontrak = '");
                stringBuilder.Append(cboIDKontrakKerja.Text);
                stringBuilder.Append(@"'");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    txtIDClient.Text = iDataReader.GetString(0);
                    txtTema.Text = iDataReader.GetString(1);
                    txtTempat.Text = iDataReader.GetString(2);
                    txtPegawai.Text = iDataReader.GetString(3);
                    txtAkomodasi.Text = iDataReader.GetString(4);
                    txtPeralatan.Text = iDataReader.GetString(5);
                    txtDekorasi.Text = iDataReader.GetString(6);
                    txtKonsumsi.Text = iDataReader.GetString(7);
                    txtKeamanan.Text = iDataReader.GetString(8);
                    txtAsuransi.Text = iDataReader.GetString(9);
                    txtKomunikasi.Text = iDataReader.GetString(10);
                    txtTglDP.Text = iDataReader.GetString(11);
                    txtTglAcara.Text = iDataReader.GetString(12);
                    txtTglJatuhTempo.Text = iDataReader.GetString(13);
                    lblTotal.Text = (iDataReader.GetInt32(2) + iDataReader.GetInt32(3) + iDataReader.GetInt32(4) + iDataReader.GetInt32(5) + iDataReader.GetInt32(6) + iDataReader.GetInt32(7) + iDataReader.GetInt32(8) + iDataReader.GetInt32(9) + iDataReader.GetInt32(10)).ToString();
                    lblTimestamp.Text = date;
                    lblUser.Text = nameDB;
                    lblClient.Text = iDataReader.GetString(0);
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
