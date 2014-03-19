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
    public partial class In_N_Out : Form
    {
        public In_N_Out()
        {
            InitializeComponent();
            iCostumersNametextBox.Text = MyGlobals.CustomersName;
            iCostumersPhonetextBox.Text = MyGlobals.CustomersPhone;
            iCostumersAddresstextBox.Text = MyGlobals.CustomersAddress;
        }

        private void iExitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iCalculate_Click(object sender, EventArgs e)
        {
           // MyGlobals.OrderTotal = 0m;

            if (iDoubleDoublenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * iDoubleDoublenumeric.Value;
                MyGlobals.Order_Totals += iDoubleDoublenumeric.Value + " " + iDoubleDoubleTxt.Text + '\n';
            }
            if (iCheeseburgernumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * iCheeseburgernumeric.Value;
                MyGlobals.Order_Totals += iCheeseburgernumeric.Value + " " + iChesseburgerTxt.Text + '\n';
            }
            if (iHamburgernumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.50m * iHamburgernumeric.Value;
                MyGlobals.Order_Totals += iHamburgernumeric.Value + " " + iHamburgerTxt.Text + '\n';
            }
            if (iDoubleMeatnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * iDoubleMeatnumeric.Value;
                MyGlobals.Order_Totals += iDoubleMeatnumeric.Value + " " + iDoubleMeatTxt.Text + '\n';
            }
            if (i4x4numeric.Value > 0)
            {
                MyGlobals.OrderTotal += 4.99m * i4x4numeric.Value;
                MyGlobals.Order_Totals += i4x4numeric.Value + " " + i4x4Txt.Text + '\n';
            }
            if (i3x3numeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * i3x3numeric.Value;
                MyGlobals.Order_Totals += i3x3numeric.Value + " " + i3x3Txt.Text + '\n';
            }
            if (iAnimalnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * iAnimalnumeric.Value;
                MyGlobals.Order_Totals += iAnimalnumeric.Value + " " + iAnimalTxt.Text + '\n';
            }
            if (isSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.25m * isSoftDrinknumeric.Value;
                MyGlobals.Order_Totals += isSoftDrinknumeric.Value + " " + isSoftDrinkTxt.Text + '\n';
            }
            if (imSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * imSoftDrinknumeric.Value;
                MyGlobals.Order_Totals += imSoftDrinknumeric.Value + " " + imSoftDrinkTxt.Text + '\n';
            }
            if (ilSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * ilSoftDrinknumeric.Value;
                MyGlobals.Order_Totals += ilSoftDrinknumeric.Value + " " + ilSoftDrinkTxt.Text + '\n';
            }
            if (iShakenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.50m * iShakenumeric.Value;
                MyGlobals.Order_Totals += iShakenumeric.Value + " " + iShakesTxt.Text+ '\n';
            }
            if (iFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * iFriesnumeric.Value;
                MyGlobals.Order_Totals += iFriesnumeric.Value + " " + iFriesTxt.Text + '\n';
            }
            if (iChiliCheesenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.50m * iChiliCheesenumeric.Value;
                MyGlobals.Order_Totals += iChiliCheesenumeric.Value + " " + iChiliCheeseTxt.Text + '\n';
            }
            Decimal Tax = 0.07m;

            iCalculatetextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal);
            iTaxtextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal * Tax);
            iTotaltextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal * Tax + MyGlobals.OrderTotal);
        }

        private void iOrderbutton_Click(object sender, EventArgs e)
        {
            MyGlobals.CustomersAddress = iCostumersAddresstextBox.Text;
            MyGlobals.CustomersName = iCostumersNametextBox.Text;
            MyGlobals.CustomersPhone = iCostumersPhonetextBox.Text;
            MyGlobals.OrderConfirmation = iCalculatetextBox.Text;
            MyGlobals.str_orderTotal = iTotaltextBox.Text;
            MyGlobals.OrderTax = iTaxtextBox.Text;

            Order_Confirmation iCostumersName = new Order_Confirmation();
            iCostumersName.Show();
        }
    }
}