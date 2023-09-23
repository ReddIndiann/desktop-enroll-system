using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itaya
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into detaills values(@id,@FirstName,@LastName,@password,@status)", con);
                cmd.Parameters.AddWithValue("@id", txtUserName.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("You have been Registered");

                studentmainpage studmain = new studentmainpage();
                studmain.Show();
                Hide();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Hide();
        }
    }
}

