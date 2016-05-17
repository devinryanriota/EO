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
    public partial class frmLogin : Form
    {
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        StringBuilder stringBuilder = null;
        IDataReader iDataReader = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            String password = txtPassword.Text;
            String idDB = "";
            String passwordDB = "";
            String nameDB = "";

            try
            {
                String connString = @"Server=ap-cdbr-azure-southeast-b.cloudapp.net;Database=eo;Uid=b1572a96e5f99a;Pwd=daf015bd;";
                this.conn = new MySqlConnection(connString);
                conn.Open();
                
                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"SELECT id_employee, name, password FROM employee WHERE id_employee ='" + id + "'");

                comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = stringBuilder.ToString();
                

                iDataReader = comm.ExecuteReader();
                while (iDataReader.Read())
                {
                    idDB = iDataReader.GetString(0);
                    nameDB = iDataReader.GetString(1);
                    passwordDB = iDataReader.GetString(2);
                }

                if (password == passwordDB)
                {
                    MessageBox.Show("Login Success! Welcome " + nameDB);
                }
                else MessageBox.Show("Wrong ID/Password Combination!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
