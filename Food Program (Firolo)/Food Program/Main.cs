using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Food_Program
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyGlobals.CustomersName = CostumersNametextBox.Text;
            MyGlobals.CustomersPhone = CostumersPhonetextBox.Text;
            MyGlobals.CustomersAddress = CostumersAddresstextBox.Text;

            if (checkBoxDelivery.Checked)
            {
                MyGlobals.OrderTotal += 5.00m;
                MyGlobals.str_delivery = checkBoxDelivery.Text;
                MyGlobals.str_pickup += "3149 W 3500 S, West Valley City, UT 84119";
            }
            if (checkBoxPickup.Checked)
            {
                MyGlobals.str_pickup += "3149 W 3500 S, West Valley City, UT 84119";
            }

            Wendys wCostumersNametextBox = new Wendys();
            wCostumersNametextBox.Show();

        }

        private void CostumersNameTxt_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMcdonals_Click(object sender, EventArgs e)
        {
            MyGlobals.CustomersName = CostumersNametextBox.Text;
            MyGlobals.CustomersPhone = CostumersPhonetextBox.Text;
            MyGlobals.CustomersAddress = CostumersAddresstextBox.Text;


            if (checkBoxDelivery.Checked)
            {
                MyGlobals.OrderTotal += 5.00m;
                MyGlobals.str_delivery = checkBoxDelivery.Text;
                MyGlobals.str_pickup += "4217 S Redwood Rd, Salt Lake City, UT 84123";
            }
            if (checkBoxPickup.Checked)
            {
                MyGlobals.str_pickup += "4217 S Redwood Rd, Salt Lake City, UT 84123";
            }
        
            Macdonals mdcCostumersNametextBox = new Macdonals();
            mdcCostumersNametextBox.Show();
        }

        private void checkBoxPickup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDelivery_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBoxDelivery.Checked)
            {
                MyGlobals.Delivery += MyGlobals.OrderTotal;
            }*/


        }

        private void CostumersAddressTxt_Click(object sender, EventArgs e)
        {

        }

        private void buttonInNOut_Click(object sender, EventArgs e)
        {
            MyGlobals.CustomersName = CostumersNametextBox.Text;
            MyGlobals.CustomersPhone = CostumersPhonetextBox.Text;
            MyGlobals.CustomersAddress = CostumersAddresstextBox.Text;
            if (checkBoxDelivery.Checked)
            {
                MyGlobals.OrderTotal += 5.00m;
                MyGlobals.str_delivery = checkBoxDelivery.Text;
                MyGlobals.str_pickup += "3715 Constitution Blvd, West Valley City, UT 84119";
            }
            if (checkBoxPickup.Checked)
            {
                MyGlobals.str_pickup += "3715 Constitution Blvd, West Valley City, UT 84119";
            }
            In_N_Out iCostumersNametextBox = new In_N_Out();
            iCostumersNametextBox.Show();
        }

        private void CostumersPhoneTxt_Click(object sender, EventArgs e)
        {

        }

        private void txtCostumersPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostumersAddresstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostumersNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
