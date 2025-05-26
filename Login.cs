using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SpeakOut___Anti_Corruption_Reporting_System
{
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CLOSEBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Close();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rloginBTN_Click(object sender, EventArgs e)
        {
            string email = emailtextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT Role FROM Users WHERE Email = @email AND PasswordHash = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    string role = dr.GetString(0);

                    MessageBox.Show("Login successful! Role: " + role);

                    if (role == "Admin")
                    {
                        AdminMenu admin = new AdminMenu();
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Investigator")
                    {
                        InvestigatorMenu investigator = new InvestigatorMenu();
                        investigator.Show();
                        this.Hide();
                    }
                    else if (role == "Reporter")
                    {
                        ReporterMenu reporter = new ReporterMenu();
                        reporter.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role: " + role);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }
        }
    }
}
