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
    public partial class Macdonals : Form
    {
        public Macdonals()
        {
            InitializeComponent();
            mdcCostumersNametextBox.Text = MyGlobals.CustomersName;
            mdcCostumersPhonetextBox.Text = MyGlobals.CustomersPhone;
            mdcCostumersAddresstextBox.Text = MyGlobals.CustomersAddress;
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BigMacTxt_Click(object sender, EventArgs e)
        {

        }

        private void RanchSnackTxt_Click(object sender, EventArgs e)
        {

        }

        private void Deluxenumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Mcdonalds_Load(object sender, EventArgs e)
        {

        }

        private void mdcform_Click(object sender, EventArgs e)
        {

        }

        private void CalculatetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdcExitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mdcCostumersNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            //MyGlobals.OrderTotal = 0m

            if (BigMacnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * BigMacnumeric.Value;
                MyGlobals.Order_Totals += BigMacnumeric.Value + " " + BigMacTxt.Text + '\n';

            }
            if (QuarterPoundernumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 4.99m * QuarterPoundernumeric.Value;
                MyGlobals.Order_Totals += QuarterPoundernumeric.Value + " "  + QuarterPounderTxt.Text + '\n';
            }
            if (Baconnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 4.99m * Baconnumeric.Value;
                MyGlobals.Order_Totals += Baconnumeric.Value + " " + BaconTxt.Text + '\n';
            }
            if (Deluxenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 4.99m * Deluxenumeric.Value;
                MyGlobals.Order_Totals += Deluxenumeric.Value + " " + DeluxeTxt.Text + '\n';
            }
            if (Doublenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 4.99m * Doublenumeric.Value;
                MyGlobals.Order_Totals += Doublenumeric.Value + " " + DoublerQuarterTxt.Text + '\n';
            }
            if (ChickenCrispynumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * ChickenCrispynumeric.Value;
                MyGlobals.Order_Totals += ChickenCrispynumeric.Value + " " + ChickenCrispyTxt.Text + '\n';
            }
            if (ChickenGrillednumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * ChickenGrillednumeric.Value;
                MyGlobals.Order_Totals += ChickenGrillednumeric.Value + " " + ChickenGrilledTxt.Text + '\n';
            }
            if (mdcSSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.25m * mdcSSoftDrinknumeric.Value;
                MyGlobals.Order_Totals += mdcSSoftDrinknumeric.Value + " " + sSoftDrinkTxt.Text + '\n';
            }
            if (mdcMSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * mdcMSoftDrinknumeric.Value;
                MyGlobals.Order_Totals += mdcMSoftDrinknumeric + " " + mSoftDrinkTxt.Text + '\n';
            }
            if (mdcLSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * mdcLSoftDrinknumeric.Value;
                MyGlobals.Order_Totals += mdcLSoftDrinknumeric.Value + " " + lSoftDrinkTxt.Text + '\n';
            }
            if (Shakenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * Shakenumeric.Value;
                MyGlobals.Order_Totals += Shakenumeric.Value + " " + ShakeTxt.Text + '\n';
            }
            if (Smoothienumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * Smoothienumeric.Value;
                MyGlobals.Order_Totals += Smoothienumeric.Value + " " + SmoothieTxt.Text + '\n';
            }
            if (mdcsFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.25m * mdcsFriesnumeric.Value;
                MyGlobals.Order_Totals += mdcsFriesnumeric.Value + " " + sFriesTxt.Text + '\n';
            }
            if (mdcmFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * mdcmFriesnumeric.Value;
                MyGlobals.Order_Totals += mdcmFriesnumeric.Value + " " + mFriesTxt.Text + '\n';
            }
            if (mdclFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * mdclFriesnumeric.Value;
                MyGlobals.Order_Totals += mdclFriesnumeric.Value + " " + mdclFriesTxt.Text + '\n';
            }
            if (Wingsnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.25m * Wingsnumeric.Value;
                MyGlobals.Order_Totals += Wingsnumeric.Value + " " + WingsTxt.Text + '\n';
            }
            if (RanchSnacknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * RanchSnacknumeric.Value;
                MyGlobals.Order_Totals += RanchSnacknumeric.Value + " " + RanchSnackTxt.Text + '\n';
            }
            if (RanchSnackGnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * RanchSnackGnumeric.Value;
                MyGlobals.Order_Totals += RanchSnackGnumeric.Value + " " + RanchSnackGTxt.Text + '\n';
            
            }
            Decimal Tax = 0.07m;

            mdcCalculatetextBox.Text = String.Format("{0:c}" , MyGlobals.OrderTotal );
            mdcTaxtextBox.Text= String.Format("{0:c}", MyGlobals.OrderTotal * Tax );
            mdcTotaltextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal * Tax + MyGlobals.OrderTotal);
        }   

        private void TaxtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Taxbutton_Click(object sender, EventArgs e)
        {
             
        }

        private void Totalbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Orderbutton_Click(object sender, EventArgs e)
        {
            MyGlobals.CustomersAddress = mdcCostumersAddresstextBox.Text;
            MyGlobals.CustomersName = mdcCostumersNametextBox.Text;
            MyGlobals.CustomersPhone = mdcCostumersPhonetextBox.Text;
            MyGlobals.OrderConfirmation = mdcCalculatetextBox.Text;
            MyGlobals.OrderTax = mdcTaxtextBox.Text;
            MyGlobals.str_orderTotal = mdcTotaltextBox.Text;
            

            //Getting customers order items.


            Order_Confirmation oCostumersName = new Order_Confirmation();
            oCostumersName.Show();

              
        }

        private void Wingsnumeric_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
