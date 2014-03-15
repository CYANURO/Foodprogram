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
        }

        private void iExitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iCalculate_Click(object sender, EventArgs e)
        {
            MyGlobals.OrderTotal = 0m;

            if (iDoubleMeatnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * iDoubleMeatnumeric.Value;

            }
            if (iCheeseburgernumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * iCheeseburgernumeric.Value;
            }
            if (iHamburgernumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.50m * iHamburgernumeric.Value;
            }
            if (iDoubleMeatnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * iDoubleMeatnumeric.Value;
            }
            if (i4x4numeric.Value > 0)
            {
                MyGlobals.OrderTotal += 4.99m * i4x4numeric.Value;
            }
            if (i3x3numeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * i3x3numeric.Value;
            }
            if (iAnimalnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 3.99m * iAnimalnumeric.Value;
            }
            if (isSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.25m * isSoftDrinknumeric.Value;
            }
            if (imSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 1.99m * imSoftDrinknumeric.Value;
            }
            if (ilSoftDrinknumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.69m * ilSoftDrinknumeric.Value;
            }
            if (iShakenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.50m * iShakenumeric.Value;
            }
            if (iFriesnumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.99m * iFriesnumeric.Value;
            }
            if (iChiliCheesenumeric.Value > 0)
            {
                MyGlobals.OrderTotal += 2.50m * iChiliCheesenumeric.Value;
            }
            Decimal Tax = 0.07m;

            iCalculatetextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal);
            iTaxtextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal * Tax);
            iTotaltextBox.Text = String.Format("{0:c}", MyGlobals.OrderTotal * Tax + MyGlobals.OrderTotal);
        }
    }
}