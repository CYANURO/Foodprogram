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
    public partial class Order_Confirmation : Form
    {
        public Order_Confirmation()
        {
            InitializeComponent();
            oCostumersNametextBox.Text = MyGlobals.CustomersName;
            oCostumersPhonetextBox.Text = MyGlobals.CustomersPhone;
            oCostumersAddresstextBox.Text = MyGlobals.CustomersAddress;
            oSubtotaltextBox.Text = MyGlobals.OrderConfirmation;
            oTaxtextBox.Text = MyGlobals.OrderTax;
            oTotaltextBox.Text = MyGlobals.str_orderTotal;
            //oTaxtextBox.Text = MyGlobals.OrderTotal.ToString();   // no sirve ... pq?
            orderSummary.Text = MyGlobals.Order_Totals;
            odelivery.Text = MyGlobals.str_delivery;


        }

        private void oCustomersNameTxt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Order_Confirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
