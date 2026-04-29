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
    public partial class Admin : Form
    {
        public Admin()
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
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                DataTable dt = new DataTable();
                MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                // Ilipat ang data mula sa cells papunta sa TextBoxes
                // Ang [0], [1] ay ang index ng columns mo sa database/grid
                txtID.Text = row.Cells[0].Value.ToString();
                txtProduct.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                txtCategory.Text = row.Cells[3].Value.ToString();
                txtQuantity.Text = row.Cells[4].Value.ToString();
            }
            try
            {
                // 1. Kunin ang values (Nasa screenshot mo na ito)
                string UpdateID = txtID.Text.Trim();
                string UpdateProduct = txtProduct.Text.Trim();
                int UpdatePrice = int.Parse(txtPrice.Text.Trim());
                string UpdateCategory = txtCategory.Text.Trim();
                int UpdateQuantity = int.Parse(txtQuantity.Text.Trim());

                // 2. MySQL Connection gamit ang DBConnect
                DBConnect db = new DBConnect();
                db.Connection.Open();

                // 3. Query - Pwedeng INSERT kung bago, o UPDATE kung existing na
                string query = "UPDATE stocks SET products=@prod, price=@price, category=@cat, quantity=@qty WHERE id=@id";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", UpdateID);
                cmd.Parameters.AddWithValue("@prod", UpdateProduct);
                cmd.Parameters.AddWithValue("@price", UpdatePrice);
                cmd.Parameters.AddWithValue("@cat", UpdateCategory);
                cmd.Parameters.AddWithValue("@qty", UpdateQuantity);

                cmd.ExecuteNonQuery();
                db.Connection.Close();

                MessageBox.Show("Record Updated Successfully!");

                // 4. Tawagin ang method para mag-refresh ang DataGridView
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

            try
            {
                string UpdateID = txtID.Text.Trim();
                string UpdateProduct = txtProduct.Text.Trim();
                int UpdatePrice = int.Parse(txtPrice.Text.Trim());
                string UpdateCategory = txtCategory.Text.Trim();
                int UpdateQuantity = int.Parse(txtQuantity.Text.Trim());

                db.Open(); // Siguraduhin na ang method na 'Open' ay nasa DBConnect class mo

                // Mas mainam na i-check kung tama ang table name (stocks ba o admin?)
                string query = "UPDATE stocks SET product=@product, price=@price, category=@category, quantity=@quantity WHERE id=@id";

                // Gamitin ang db.connection (depende sa name sa DBConnect class mo)
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@id", UpdateID);
                cmd.Parameters.AddWithValue("@product", UpdateProduct);
                cmd.Parameters.AddWithValue("@price", UpdatePrice);
                cmd.Parameters.AddWithValue("@category", UpdateCategory);
                cmd.Parameters.AddWithValue("@quantity", UpdateQuantity);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Record Updated Successfully!");
                    LoadDataGridView(); // Tawagin ito para mag-refresh ang table sa screen
                }
                else
                {
                    MessageBox.Show("No record found with that ID.");
                }
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

