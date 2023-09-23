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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True");
            String ID, password;
            ID = txtID.Text;
            password = txtpassword.Text;


            try
            {
                String querry = "SELECT * FROM admin Where Username = '" + txtID.Text + "'AND password='" + txtpassword.Text + "'";
                SqlDataAdapter login = new SqlDataAdapter(querry, con);
                DataTable table = new DataTable();
                login.Fill(table);
                if (table.Rows.Count > 0)
                {
                    ID = txtID.Text;
                    password = txtpassword.Text;
                    adminmainpage admain = new adminmainpage();
                    admain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ivalid login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtpassword.Clear();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }
    }
}
