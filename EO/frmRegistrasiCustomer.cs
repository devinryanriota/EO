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
    public partial class frmRegistrasiCustomer : Form
    {
        public frmRegistrasiCustomer()
        {
            InitializeComponent();
        }

        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;
        String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String idCustomer = txtIdCustomer.Text;
            String nama = txtNama.Text;
            String alamat = txtAlamat.Text;
            String noTelepon = txtNoTelepon.Text;
            String email = txtEmail.Text;

            this.conn = new MySqlConnection(connString);
            conn.Open();

            comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO customer(id_customer, name, phone, alamat, email) VALUES(@a, @b, @c, @d, @e)";
            comm.Parameters.AddWithValue("@a", idCustomer);
            comm.Parameters.AddWithValue("@b", nama);
            comm.Parameters.AddWithValue("@c", alamat);
            comm.Parameters.AddWithValue("@d", noTelepon);
            comm.Parameters.AddWithValue("@e", email);

            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Registration Succesful!");
            this.Close();

        }
    }
}
