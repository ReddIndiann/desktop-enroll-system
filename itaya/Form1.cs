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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True");
            String ID, password;
            ID = txtID.Text;
            password = txtPassword.Text;


            try
            {
                string querry = "SELECT * FROM detaills Where ID = '" + txtID.Text + "'AND Password='" + txtPassword.Text + "'";
                SqlDataAdapter login = new SqlDataAdapter(querry, con);
                DataTable table = new DataTable();
                login.Fill(table);
                if (table.Rows.Count > 0)
                {
                    studentmainpage mainpage = new studentmainpage();
                    mainpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ivalid login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            adminlogin adlog = new adminlogin();
            adlog.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
