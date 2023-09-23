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
    public partial class studentmainpage : Form
    {
        public studentmainpage()
        {
            InitializeComponent();
        }
        public bool Checked (bool cond)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True");
            String ID;
            ID = txtID.Text;
           


            try
            {
                string querry = "SELECT * FROM detaills Where ID = '" + txtID.Text + "'";
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




            return cond;
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (Checked(true))
            {

                try
                {
                    

                  if(comboBox1.SelectedIndex <= 5)
                    {
                        if(comboBox2.SelectedIndex <= 5)
                        {
                            if(comboBox3.SelectedIndex <= 5)
                            {
                                if(comboBox4.SelectedIndex <= 5) {
                                    if(comboBox5.SelectedIndex <= 5)
                                    {
                                        if(comboBox6.SelectedIndex <= 5)
                                        {
                                            string connectionString = "Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True";

                                            // Define the SQL statement to update a record in the database
                                            string updateStatement = "UPDATE detaills SET  status = @status WHERE id = @id";

                                            // Create a new connection to the database
                                            using (SqlConnection connection = new SqlConnection(connectionString))
                                            {
                                                // Create a new command object with the update statement and connection
                                                using (SqlCommand command = new SqlCommand(updateStatement, connection))
                                                {
                                                    // Add parameters to the command object for each value to update
                                                    command.Parameters.AddWithValue("@status", "Qualified");

                                                    command.Parameters.AddWithValue("@id", txtID.Text);
                                                    MessageBox.Show("qualified");
                                                    // Open the database connection
                                                    connection.Open();



                                                    // Execute the update command
                                                    int rowsAffected = command.ExecuteNonQuery();

                                                    // Check if any rows were affected
                                                    if (rowsAffected > 0)
                                                    {


                                                    }
                                                    else
                                                    {


                                                    }

                                                }
                                            }
                                        }
                                        else
                                        {
                                            string connectionString = "Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True";

                                            // Define the SQL statement to update a record in the database
                                            string updateStatement = "UPDATE detaills SET  status = @status WHERE id = @id";

                                            // Create a new connection to the database
                                            using (SqlConnection connection = new SqlConnection(connectionString))
                                            {
                                                // Create a new command object with the update statement and connection
                                                using (SqlCommand command = new SqlCommand(updateStatement, connection))
                                                {
                                                    // Add parameters to the command object for each value to update
                                                    command.Parameters.AddWithValue("@status", "Disqualified");

                                                    command.Parameters.AddWithValue("@id", txtID.Text);
                                                   
                                                    MessageBox.Show("Disqualified");
                                                    // Open the database connection
                                                    connection.Open();



                                                    // Execute the update command
                                                    int rowsAffected = command.ExecuteNonQuery();

                                                    // Check if any rows were affected
                                                    if (rowsAffected > 0)
                                                    {


                                                    }
                                                    else
                                                    {


                                                    }

                                                }
                                            }
                                        }
                                    }else
                                    {
                                        string connectionString = "Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True";

                                        // Define the SQL statement to update a record in the database
                                        string updateStatement = "UPDATE detaills SET  status = @status WHERE id = @id";

                                        // Create a new connection to the database
                                        using (SqlConnection connection = new SqlConnection(connectionString))
                                        {
                                            // Create a new command object with the update statement and connection
                                            using (SqlCommand command = new SqlCommand(updateStatement, connection))
                                            {
                                                // Add parameters to the command object for each value to update
                                                command.Parameters.AddWithValue("@status", "Disqualified");

                                                command.Parameters.AddWithValue("@id", txtID.Text);
                                                MessageBox.Show("Done");
                                                MessageBox.Show("Disqualified");
                                                // Open the database connection
                                                connection.Open();



                                                // Execute the update command
                                                int rowsAffected = command.ExecuteNonQuery();

                                                // Check if any rows were affected
                                                if (rowsAffected > 0)
                                                {


                                                }
                                                else
                                                {


                                                }

                                            }
                                        }
                                    }
                                    
                                }
                                else
                                {
                                    string connectionString = "Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True";

                                    // Define the SQL statement to update a record in the database
                                    string updateStatement = "UPDATE detaills SET  status = @status WHERE id = @id";

                                    // Create a new connection to the database
                                    using (SqlConnection connection = new SqlConnection(connectionString))
                                    {
                                        // Create a new command object with the update statement and connection
                                        using (SqlCommand command = new SqlCommand(updateStatement, connection))
                                        {
                                            // Add parameters to the command object for each value to update
                                            command.Parameters.AddWithValue("@status", "Disqualified");

                                            command.Parameters.AddWithValue("@id", txtID.Text);
                                            MessageBox.Show("Disqualified");
                                            // Open the database connection
                                            connection.Open();



                                            // Execute the update command
                                            int rowsAffected = command.ExecuteNonQuery();

                                            // Check if any rows were affected
                                            if (rowsAffected > 0)
                                            {


                                            }
                                            else
                                            {


                                            }

                                        }
                                    }
                                }
                            }else
                            {
                                string connectionString = "Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True";

                                // Define the SQL statement to update a record in the database
                                string updateStatement = "UPDATE detaills SET  status = @status WHERE id = @id";

                                // Create a new connection to the database
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    // Create a new command object with the update statement and connection
                                    using (SqlCommand command = new SqlCommand(updateStatement, connection))
                                    {
                                        // Add parameters to the command object for each value to update
                                        command.Parameters.AddWithValue("@status", "Disqualified");

                                        command.Parameters.AddWithValue("@id", txtID.Text);
                                        MessageBox.Show("Disqualified");
                                        // Open the database connection
                                        connection.Open();



                                        // Execute the update command
                                        int rowsAffected = command.ExecuteNonQuery();

                                        // Check if any rows were affected
                                        if (rowsAffected > 0)
                                        {


                                        }
                                        else
                                        {


                                        }

                                    }
                                }
                            }
                        }else
                        {
                            string connectionString = "Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True";

                            // Define the SQL statement to update a record in the database
                            string updateStatement = "UPDATE detaills SET  status = @status WHERE id = @id";

                            // Create a new connection to the database
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                // Create a new command object with the update statement and connection
                                using (SqlCommand command = new SqlCommand(updateStatement, connection))
                                {
                                    // Add parameters to the command object for each value to update
                                    command.Parameters.AddWithValue("@status", "Disqulified");

                                    command.Parameters.AddWithValue("@id", txtID.Text);
                                    MessageBox.Show("Disqualified");
                                    // Open the database connection
                                    connection.Open();



                                    // Execute the update command
                                    int rowsAffected = command.ExecuteNonQuery();

                                    // Check if any rows were affected
                                    if (rowsAffected > 0)
                                    {


                                    }
                                    else
                                    {


                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        string connectionString = "Data Source=DESKTOP-V5VSR06;Initial Catalog=grouph;Integrated Security=True";

                        // Define the SQL statement to update a record in the database
                        string updateStatement = "UPDATE detaills SET  status = @status WHERE id = @id";

                        // Create a new connection to the database
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            // Create a new command object with the update statement and connection
                            using (SqlCommand command = new SqlCommand(updateStatement, connection))
                            {
                                // Add parameters to the command object for each value to update
                                command.Parameters.AddWithValue("@status", "Disqualified");

                                command.Parameters.AddWithValue("@id", txtID.Text);
                                MessageBox.Show("Disqualified");
                                // Open the database connection
                                connection.Open();



                                // Execute the update command
                                int rowsAffected = command.ExecuteNonQuery();

                                // Check if any rows were affected
                                if (rowsAffected > 0)
                                {


                                }
                                else
                                {


                                }

                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
        }

        private void studentmainpage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();

        }
    }
}
