using System.Windows.Forms;

namespace jollibe_menu
{
    public partial class RegisterForm : Form
    {
        public RegisterForm() => InitializeComponent();

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string firstName = txtFname.Text.Trim();
            string lastName = txtLname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
            }
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter a firstname.");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a lastname.");
            }
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please choose a role.");
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email.");
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "INSERT INTO employee_table123";
                query += "(username, password, firstname, lastname, role, email)";
                query += "VALUES (@usernameValue, @passwordValue, @firstNameValue, @lastNameValue, @roleValue, @emailValue)";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@usernameValue", username);
                cmd.Parameters.AddWithValue("@passwordValue", password);
                cmd.Parameters.AddWithValue("@firstNameValue", firstName);
                cmd.Parameters.AddWithValue("@emailValue", email);
                cmd.Parameters.AddWithValue("@lastNameValue", lastName);
                cmd.Parameters.AddWithValue("@roleValue", role);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful!");
                new Form1().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                db.Close();
            }
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}