using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jollibe_menu
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void btnLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Orders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int Total = 0;
            int price = 0;

            if (chkChicken.Checked)
            {
                price += 105;


            }
            if (chkSteak.Checked)
            {
                price += 99;


            }
            if (chkBurger1.Checked)
            {
                price += 135;

            }
            if (chkFamily.Checked)
            {
                price += 299;

            }
            if (chkFries.Checked)
            {
                price += 199;

            }
            if (chkSpha.Checked)
            {
                price += 125;

            }
            if (chkJolly.Checked)
            {
                price += 95;

            }
            if (chkNuggets.Checked)
            {
                price += 599;

            }
            if(chkRoyal.Checked)
            {
                price += 61;
            }
            if(chkFloat.Checked)
            {
                price += 84;
            }
            if(chkSprite.Checked)
            {
                price += 61;
            }
            if(chkCoffee.Checked)
            {
                price += 85;
            }
            if(chkCoffee.Checked)
            {
                price += 90;
            }
            if (chkBrew.Checked)
            {
                price += 53;
            }
            if(chkNestea.Checked)
            {
                price += 66;
            }
            if(chkCoke.Checked)
            {
                price += 61;
            }

            Total = Total + price;
            txtCompute.Text = Total.ToString();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            txtChange.Text = string.Empty;

            int ConvertedFirst = int.Parse(txtCompute.Text);
            int ConvertedChange = int.Parse(txtPay.Text);

            int Change = ConvertedChange - ConvertedFirst;

            if (ConvertedChange > ConvertedFirst)
            {
                txtChange.Text = Change.ToString();
            }
            else
            {
                txtChange.Text = "Not enough payment.";
            }





        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChange.Text = string.Empty;
            txtCompute.Text = string.Empty;
            txtPay.Text = string.Empty;
            chkBurger1.Checked = false;
            chkChicken.Checked = false;
            chkNuggets.Checked = false;
            chkFamily.Checked = false;
            chkFries.Checked = false;
            chkSpha.Checked = false;
            chkJolly.Checked = false;
            chkSteak.Checked = false;
            chkRoyal.Checked = false;
            chkFloat.Checked = false;
            chkCoke.Checked = false;
            chkCoffee.Checked = false;  
            chkNestea.Checked = false;
            chkSprite.Checked = false;
            chkCoffemc.Checked = false;
            chkBrew.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
