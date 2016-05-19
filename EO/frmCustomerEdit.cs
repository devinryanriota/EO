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
    public partial class frmCustomerEdit : Form
    {
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";


        private String id_customer;
        private String nama;
        private String phone;
        private String alamat;
        private String email;
        public frmCustomerEdit(String id_costumer, String nama, String phone, String alamat, String email)
        {
            InitializeComponent();
            this.id_customer = id_costumer;
            this.nama = nama;
            this.phone = phone;
            this.alamat = alamat;
            this.email = email;
        }

        private void frmCustomerEdit_Load(object sender, EventArgs e)
        {
            txtCustID.Text = id_customer;
            txtNama.Text = nama;
            txtPhone.Text = phone;
            txtAlamat.Text = alamat;
            txtEmail.Text = email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.conn = new MySqlConnection(connString);
            conn.Open();

            comm = conn.CreateCommand();
            comm.CommandText = "UPDATE customer SET   id_customer = @a, name = @b, phone = @c, alamat = @d, email = @e";
            
            comm.Parameters.AddWithValue("@a", txtCustID.Text);
            comm.Parameters.AddWithValue("@b", txtNama.Text);
            comm.Parameters.AddWithValue("@c", txtPhone.Text);
            comm.Parameters.AddWithValue("@d", txtAlamat.Text);
            comm.Parameters.AddWithValue("@e", txtEmail.Text);

            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Succesful!");
            this.Close();
        }
    }
}
