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
    public partial class frmLaporan : Form
    {
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";

        public frmLaporan()
        {
            InitializeComponent();
        }

        private void frmLaporan_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cboJenisLaporan.Text == "Laporan Order")
            {
                generateOrder();
                lvwKas.Visible = false;
                lvwOrder.Visible = true;
                lvwPiutang.Visible = false;
            }
            else if (cboJenisLaporan.Text == "Laporan Penerimaan Kas")
            {
                generateKas();
                lvwKas.Visible = true;
                lvwOrder.Visible = false;
                lvwPiutang.Visible = false;
            }
            else if (cboJenisLaporan.Text == "Laporan Pelunasan Piutang")
            {
                generatePiutang();
                lvwKas.Visible = false;
                lvwOrder.Visible = false;
                lvwPiutang.Visible = true;
            }
        }
        public void generateOrder()
        {
            lvwOrder.Items.Clear();
            String periode = dudPeriode.Text;

            ListViewItem lvi = null;
            try
            {

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT perjanjian_kerja.id_kontrak,tanggal_surat,tanggal_acara,tanggal_jatuh_tempo,status_kontrak,tanggal_pelunasan
                                        FROM perjanjian_kerja
								     	JOIN  payment ON (perjanjian_kerja.id_kontrak=payment.id_kontrak)
                                        WHERE tanggal_surat LIKE '%");
                stringBuilder.Append(periode);
                stringBuilder.Append(@"%'");


                this.conn = new MySqlConnection(connString);
                conn.Open();

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();

                // mengambil data dari idatareader
                int ctr = 0;
                while (iDataReader.Read())
                {
                    lvi = new ListViewItem();
                    lvi.Text = iDataReader.GetString(0);
                    lvi.SubItems.Add(iDataReader.GetString(2));
                    lvi.SubItems.Add(iDataReader.GetString(3));
                    lvi.SubItems.Add(iDataReader.GetString(4));
                    lvi.SubItems.Add(iDataReader.GetString(5));
                    lvwOrder.Items.Add(lvi);
                    
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }

                if (iDataReader != null)
                {
                    iDataReader.Close();
                    iDataReader.Dispose();
                }
            }
            
            lvwOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void generateKas()
        {
            lvwKas.Items.Clear();
            String periode = dudPeriode.Text;

            ListViewItem lvi = null;
            try
            {

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_transaksi,jenis_transaksi,tanggal_transaksi,jumlah_transaksi
                                        FROM transaksi
								     	WHERE tanggal_transaksi LIKE '%");
                stringBuilder.Append(periode);
                stringBuilder.Append(@"%'");


                this.conn = new MySqlConnection(connString);
                conn.Open();

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();

                // mengambil data dari idatareader
                while (iDataReader.Read())
                {
                    lvi = new ListViewItem();
                    lvi.Text = iDataReader.GetString(0);
                    lvi.SubItems.Add(iDataReader.GetString(1));
                    lvi.SubItems.Add(iDataReader.GetString(2));
                    lvi.SubItems.Add(iDataReader.GetString(3));
                    lvwKas.Items.Add(lvi);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }

                if (iDataReader != null)
                {
                    iDataReader.Close();
                    iDataReader.Dispose();
                }
            }

            lvwKas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwKas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);



        }
        public void generatePiutang()
        {
            lvwPiutang.Items.Clear();
            String periode = dudPeriode.Text;

            ListViewItem lvi = null;
            try
            {

                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_payment,id_kontrak,bayar_lunas,tanggal_pelunasan,denda
                                        FROM payment
								     	WHERE tanggal_pelunasan LIKE '%");
                stringBuilder.Append(periode);
                stringBuilder.Append(@"%'");


                this.conn = new MySqlConnection(connString);
                conn.Open();

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = stringBuilder.ToString();

                iDataReader = comm.ExecuteReader();

                // mengambil data dari idatareader
                int ctr = 0;
                while (iDataReader.Read())
                {
                    lvi = new ListViewItem();
                    lvi.Text = iDataReader.GetString(0);
                    lvi.SubItems.Add(iDataReader.GetString(1));
                    lvi.SubItems.Add(iDataReader.GetString(2));
                    lvi.SubItems.Add(iDataReader.GetString(3));
                    lvwPiutang.Items.Add(lvi);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            lvwPiutang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwPiutang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

    }
}
