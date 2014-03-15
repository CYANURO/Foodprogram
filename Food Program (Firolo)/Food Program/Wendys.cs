using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Program
{
    public partial class Wendys : Form
    {
        public Wendys()
        {
            InitializeComponent();
            wCostumersNametextBox.Text = MyGlobals.CustomersName;
            wCostumersPhonetextBox.Text = MyGlobals.CustomersPhone;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void wBurgersTxt_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wExitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wlFriesTxt_Click(object sender, EventArgs e)
        {

        }

        private void wCalculatebutton_Click(object sender, EventArgs e)
        {
            // Set the total to 0 to begin.
            MyGlobals.OrderTotal = 0m;


            if (Baconatornumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * Baconatornumeric.Value;
            }
            if (SonOfBaconatornumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * SonOfBaconatornumeric.Value;
            }
            if (wSpicynumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * wSpicynumeric.Value;
            }
            if (JrHamburgernumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * JrHamburgernumeric.Value;
            }
            if (JrCheeseburgernumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * JrCheeseburgernumeric.Value;
            }
            if (Asiagonumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * Asiagonumeric.Value;
            }
            if (wCrispynumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * wCrispynumeric.Value;
            }
            if (wsSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.25m * wsSoftDrinknumeric.Value;
            }
            if (wmSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * wmSoftDrinknumeric.Value;
            }
            if (wlSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * wlSoftDrinknumeric.Value;
            }
            if (wStrawberrynumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * wStrawberrynumeric.Value;
            }
            if (Coffeenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += .99m * Coffeenumeric.Value;
            }
            if (SmallChilinumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * SmallChilinumeric.Value;
            }
            if (LargeChilinumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.50m * LargeChilinumeric.Value;
            }
            if (wsFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.25m * wsFriesnumeric.Value;
            }
            if (wmFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * wmFriesnumeric.Value;
            }
            if (wlFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * wlFriesnumeric.Value;
            }
            if (ChiliChesenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * ChiliChesenumeric.Value;
            }
            Decimal Tax = 0.07m;

            wCalculatetextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal);
            wTaxtextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal * Tax);
            wTotaltextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal * Tax + MyGlobals.OrderTotal);
        }

        private void Wendys_Load(object sender, EventArgs e)
        {

        }

        private void wOrderbutton_Click(object sender, EventArgs e)
        {

            MyGlobals.CustomersName = wCostumersNametextBox.Text;
            MyGlobals.CustomersPhone = wCostumersPhonetextBox.Text;
            MyGlobals.OrderConfirmation = wCalculatetextBox.Text;
            MyGlobals.OrderTax = wTaxtextBox.Text;


            Order_Confirmation wCostumersName = new Order_Confirmation();
            wCostumersName.Show();
        }
    }
}

