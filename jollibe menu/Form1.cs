namespace jollibe_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
            }
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please choose a role.");
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "SELECT COUNT(*) FROM employee_table123 where username = @usernameValue AND password =@passwordValue AND role = @roleValue";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@usernameValue", username);
                cmd.Parameters.AddWithValue("@passwordValue", password);
                cmd.Parameters.AddWithValue("@roleValue", role);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (role == "Employee")
                {
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful! Welcome, Employee.");
                        new Cashier().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("This Employee Does not exist in our system.");
                    }
                }

                if (role == "Admin")
                {
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful! Welcome, Admin.");
                        new Admin().Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("This Admin Does not exist in our system.");
                    }
                }


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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new Password().Show();
        }
    }
}
