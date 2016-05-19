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
using System.Collections;
namespace EO
{
    public partial class frmCustomer : Form
    {
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";

        struct sCustomer
        {
            public String id_customer;
            public String nama;
            public String alamat;
            public String phone;
            public String email;
        };

        ArrayList alCustomer = null;
        public frmCustomer()
        {
            InitializeComponent();
            alCustomer = new ArrayList();
           
        }
       
        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            getCustomer();
            showCustomer();
        }
        public void getCustomer()
        {
            ListViewItem lvi = null;
            lvwCustomer.Items.Clear();
            alCustomer.Clear();
            try
            {
               
                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_customer,name,alamat,phone,email
                                        FROM customer");
                
             
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
                    sCustomer s;
                    s.id_customer = iDataReader.GetString(0);
                    s.nama = iDataReader.GetString(1);
                    s.alamat = iDataReader.GetString(2);
                    s.phone = iDataReader.GetString(3);
                    s.email = iDataReader.GetString(4);
                    alCustomer.Add(s);
                    ctr++;
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
        }



        public void showCustomer()
        {
            ListViewItem lvi = null;
            for (int i = 0; i < alCustomer.Count; i++)
            {
            
                   sCustomer s =(sCustomer) alCustomer[i];
                   lvi = new ListViewItem();
                   lvi.Text = s.id_customer;
                   lvi.SubItems.Add(s.nama);
                   lvi.SubItems.Add(s.alamat);
                   lvi.SubItems.Add(s.phone);
                   lvi.SubItems.Add(s.email);
                   lvwCustomer.Items.Add(lvi);
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            String text = txtSearchCustomer.Text;
            ListViewItem lvi = null;
            lvwCustomer.Items.Clear();
            for (int i = 0; i < alCustomer.Count; i++)
            {
                sCustomer s = (sCustomer)alCustomer[i];
                if (s.id_customer.Contains(text) || s.nama.Contains(text))
                {
                    lvi = new ListViewItem();
                    lvi.Text = s.id_customer;
                    lvi.SubItems.Add(s.nama);
                    lvi.SubItems.Add(s.alamat);
                    lvi.SubItems.Add(s.phone);
                    lvi.SubItems.Add(s.email);
                    lvwCustomer.Items.Add(lvi);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwCustomer.SelectedItems.Count != 0)
            {
                frmCustomerEdit formCustomerEdit = new frmCustomerEdit(
                lvwCustomer.SelectedItems[0].SubItems[0].Text,
                lvwCustomer.SelectedItems[0].SubItems[1].Text,
                lvwCustomer.SelectedItems[0].SubItems[2].Text,
                lvwCustomer.SelectedItems[0].SubItems[3].Text,
                lvwCustomer.SelectedItems[0].SubItems[4].Text
                );
                formCustomerEdit.ShowDialog();
            }
            getCustomer();
            showCustomer();
                
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmRegistrasiCustomer formRegistrasiCustomer = new frmRegistrasiCustomer();
            formRegistrasiCustomer.ShowDialog();
            getCustomer();
            showCustomer();
        }
    }
}
