using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakOut___Anti_Corruption_Reporting_System.Admin
{
    public partial class AdminAddInvestigator : Form
    {
        public AdminAddInvestigator()
        {
            InitializeComponent();
        }

        private void registrationBTN_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && emailTextBox.Text != "" && passwordTextBox.Text != "")
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
                {
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@Email", emailTextBox.Text);

                    con.Open();
                    int emailExists = (int)checkCmd.ExecuteScalar();
                    con.Close();

                    if (emailExists > 0)
                    {
                        MessageBox.Show("This email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string insertQuery = "INSERT INTO Users (Name, Email, PasswordHash, Role) VALUES (@Name, @Email, @PasswordHash, 'Investigator')";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(passwordTextBox.Text));

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    con.Close();

                    if (a > 0)
                    {
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        private void ClearForm()
        {
            nameTextBox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void backPictureBoxBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
