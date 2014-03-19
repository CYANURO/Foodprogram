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
            wCostumersAddresstextBox.Text = MyGlobals.CustomersAddress;
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
            //MyGlobals.OrderTotal = 0m;


            if (Baconatornumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * Baconatornumeric.Value;
                MyGlobals.Order_Totals += Baconatornumeric.Value + " " + BaconatorTxt.Text + '\n';
            }
            if (SonOfBaconatornumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * SonOfBaconatornumeric.Value;
                MyGlobals.Order_Totals += SonOfBaconatornumeric.Value + " " + SonOfBaconatorTxt.Text + '\n';
            }
            if (wSpicynumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * wSpicynumeric.Value;
                MyGlobals.Order_Totals += wSpicynumeric.Value + " " + SpicyChipotleTxt.Text + '\n';
            }
            if (JrHamburgernumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * JrHamburgernumeric.Value;
                MyGlobals.Order_Totals += JrHamburgernumeric.Value + " " + JrHamburgerTxt.Text + '\n';
            }
            if (JrCheeseburgernumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * JrCheeseburgernumeric.Value;
                MyGlobals.Order_Totals += JrCheeseburgernumeric.Value + " " + JrCheeseburgerTxt.Text + '\n';
            }
            if (Asiagonumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * Asiagonumeric.Value;
                MyGlobals.Order_Totals += Asiagonumeric.Value + " " + AsiagoTxt.Text + '\n';
            }
            if (wCrispynumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * wCrispynumeric.Value;
                MyGlobals.Order_Totals += wCrispynumeric.Value + " " + CripsyChickenTxt.Text + '\n';
            }
            if (wsSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.25m * wsSoftDrinknumeric.Value;
                MyGlobals.Order_Totals += wsSoftDrinknumeric.Value + " " + wsSoftDrinkTxt.Text + '\n';
            }
            if (wmSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * wmSoftDrinknumeric.Value;
                MyGlobals.Order_Totals += wmSoftDrinknumeric.Value + " " + wmSoftDrinkTxt.Text + '\n';
            }
            if (wlSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * wlSoftDrinknumeric.Value;
                MyGlobals.Order_Totals += wlSoftDrinknumeric.Value+ " " + wlSoftDrinkTxt.Text + '\n';
            }
            if (wStrawberrynumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * wStrawberrynumeric.Value;
                MyGlobals.Order_Totals += wStrawberrynumeric.Value + " " + wStrawberryTxt.Text + '\n';
            }
            if (Coffeenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += .99m * Coffeenumeric.Value;
                MyGlobals.Order_Totals += Coffeenumeric.Value + " " + CoffeeTxt.Text + '\n';
            }
            if (SmallChilinumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * SmallChilinumeric.Value;
                MyGlobals.Order_Totals += SmallChilinumeric.Value + " " + SmallChiliTxt.Text + '\n';
            }
            if (LargeChilinumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.50m * LargeChilinumeric.Value;
                MyGlobals.Order_Totals += LargeChilinumeric.Value + " " + LargeChiliTxt.Text + '\n';
            }
            if (wsFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.25m * wsFriesnumeric.Value;
                MyGlobals.Order_Totals += wsFriesnumeric.Value + " " + wsFriesTxt.Text + '\n';
            }
            if (wmFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * wmFriesnumeric.Value;
                MyGlobals.Order_Totals += wmFriesnumeric.Value + " " + wmFriesTxt.Text + '\n';
            }
            if (wlFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * wlFriesnumeric.Value;
                MyGlobals.Order_Totals += wlFriesnumeric.Value + " " + wlFriesTxt.Text + '\n';
            }
            if (ChiliChesenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * ChiliChesenumeric.Value;
                MyGlobals.Order_Totals += ChiliChesenumeric.Value + " " + ChiliFriesTxt.Text + '\n';
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
            MyGlobals.str_orderTotal = wTotaltextBox.Text;
            MyGlobals.CustomersAddress = wCostumersAddresstextBox.Text;


            Order_Confirmation wCostumersName = new Order_Confirmation();
            wCostumersName.Show();
        }
    }
}

