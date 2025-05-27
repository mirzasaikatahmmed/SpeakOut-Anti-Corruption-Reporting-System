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
using System.Configuration;

namespace SpeakOut___Anti_Corruption_Reporting_System
{
    public partial class Registration : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Registration()
        {
            InitializeComponent();
        }

        private void rRegistrationBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsEmailUnique(rEmailTextBox.Text))
                {
                    MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string role = "Reporter";
                string passwordHash = rPasswordTextBox.Text;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "INSERT INTO Users (Name, Email, PasswordHash, Role) VALUES (@Name, @Email, @PasswordHash, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", rNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", rEmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        cmd.Parameters.AddWithValue("@Role", role);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsEmailUnique(string email)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @EMAIL";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EMAIL", email);

                con.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                return count == 0;
            }
        }

        private void rLoginBTN_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void RCLOSEBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
