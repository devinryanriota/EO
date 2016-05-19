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
    public partial class frmPelunasan : Form
    {
        public frmPelunasan()
        {
            InitializeComponent();
        }

        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";

        private void frmPelunasan_Load(object sender, EventArgs e)
        {
            String idDB = "";
            String tglJatuhTempoDB = "";
            int biayaDB = 0;

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_kontrak, tanggal_jatuh_tempo, biaya FROM perjanjian_kerja");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    idDB = iDataReader.GetString(0);
                    tglJatuhTempoDB = iDataReader.GetString(1);
                    biayaDB = iDataReader.GetInt32(2);

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
            int biayaDB = 0;
            int bayarDpDB = 0;

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_kontrak, tanggal_jatuh_tempo, p.biaya, bayar_dp FROM perjanjian_kerja p JOIN payment pm USING (id_kontrak) WHERE id_kontrak = '" + idDB + "'");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    idDB = iDataReader.GetString(0);
                    tglJatuhTempoDB = iDataReader.GetString(1);
                    biayaDB = iDataReader.GetInt32(2);
                    bayarDpDB = iDataReader.GetInt32(3);

                    cboSuratKontrak.Text = idDB;
                    txtTotalBiaya.Text = biayaDB.ToString();
                    txtTglJatuhTempo.Text = tglJatuhTempoDB.ToString();

                    txtTagihan.Text = (biayaDB - bayarDpDB).ToString();
                    
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String idKontrak = cboSuratKontrak.Text;
            int pembayaran = Int32.Parse(txtPembayaran.Text);
            int denda = Int32.Parse(txtDenda.Text);

            DateTime now = DateTime.Now;
            String date = now.DayOfWeek.ToString() + ", " + now.ToString("MMMM") + " " + now.ToString("dd") + ", " + now.ToString("yyyy");

            try
            {
                this.conn = new MySqlConnection(connString);
                conn.Open();

                comm = conn.CreateCommand();
                comm.CommandText = "UPDATE payment SET bayar_lunas = @a, denda = @b WHERE id_kontrak = '" + idKontrak + "'";
                comm.Parameters.AddWithValue("@a", pembayaran);
                comm.Parameters.AddWithValue("@b", denda);

                comm.ExecuteNonQuery();
                
                //insert into transaksi
                //insert into transaksi
                comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO transaksi(id_kontrak,jenis_transaksi, tanggal_transaksi, jumlah_transaksi) VALUES(@a, @b, @c,@d)";
                comm.Parameters.AddWithValue("@a", idKontrak);
                comm.Parameters.AddWithValue("@b", "PELUNASAN");
                comm.Parameters.AddWithValue("@c", date);
                comm.Parameters.AddWithValue("@d", pembayaran);

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Pembayaran berhasil di simpan!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}