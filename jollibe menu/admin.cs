using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jollibe_menu
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT * FROM stocks";
                MySqlDataAdapter da = new MySqlDataAdapter(query, db.connection);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
            finally
            {
                db.Close();
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string UpdateID = txtID.Text.Trim();
            string UpdateProduct = txtProduct.Text.Trim();
            int UpdatePrice = int.Parse(txtPrice.Text.Trim());
            string UpdateCategory = txtCategory.Text.Trim();
            int UpdateQuantity = int.Parse(txtQuantity.Text.Trim());


            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = " UPDATE admin SET product = @product, price = @price, category = @category, quantity = @quantity WHERE id = @id";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", UpdateID);
                cmd.Parameters.AddWithValue("@product", UpdateProduct);
                cmd.Parameters.AddWithValue("@price", UpdatePrice);
                cmd.Parameters.AddWithValue("@category", UpdateCategory);
                cmd.Parameters.AddWithValue("@quantity", UpdateQuantity);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }

            txtID.Clear();
            txtProduct.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();


        }
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();

            // SQL Query (MySQL syntax)
            string query = "INSERT INTO stocks (id, products, price, category, quantity) " +
                           "VALUES (@id, @prod, @price, @cat, @qty)";

            try
            {
                db.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                // Bind parameters mula sa TextBoxes
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@prod", txtProduct.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record added to MySQL!", "Success");



                // I-refresh ang DataGridView
                LoadDataGridView();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }

        }

        private void ClearFields()
        {
            throw new NotImplementedException();
        }

        private void LoadDataGridView()
        {
            throw new NotImplementedException();
        }
    }
}

