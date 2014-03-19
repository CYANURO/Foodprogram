namespace Food_Program
{
    partial class Order_Confirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Confirmation));
            this.OrderConfirmationTxt = new System.Windows.Forms.Label();
            this.oCustomersNameTxt = new System.Windows.Forms.Label();
            this.oCostumersAddressTxt = new System.Windows.Forms.Label();
            this.oCostumersPhoneTxt = new System.Windows.Forms.Label();
            this.oSubtotalTxt = new System.Windows.Forms.Label();
            this.oTaxTxt = new System.Windows.Forms.Label();
            this.oTotalTxt = new System.Windows.Forms.Label();
            this.oCostumersNametextBox = new System.Windows.Forms.TextBox();
            this.oCostumersAddresstextBox = new System.Windows.Forms.TextBox();
            this.oCostumersPhonetextBox = new System.Windows.Forms.TextBox();
            this.oSubtotaltextBox = new System.Windows.Forms.TextBox();
            this.oTaxtextBox = new System.Windows.Forms.TextBox();
            this.oTotaltextBox = new System.Windows.Forms.TextBox();
            this.orderSummary = new System.Windows.Forms.Label();
            this.odelivery = new System.Windows.Forms.Label();
            this.omcdTxt = new System.Windows.Forms.Label();
            this.oExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderConfirmationTxt
            // 
            this.OrderConfirmationTxt.AutoSize = true;
            this.OrderConfirmationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderConfirmationTxt.Location = new System.Drawing.Point(192, 9);
            this.OrderConfirmationTxt.Name = "OrderConfirmationTxt";
            this.OrderConfirmationTxt.Size = new System.Drawing.Size(116, 24);
            this.OrderConfirmationTxt.TabIndex = 0;
            this.OrderConfirmationTxt.Text = "Final Order";
            // 
            // oCustomersNameTxt
            // 
            this.oCustomersNameTxt.AutoSize = true;
            this.oCustomersNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oCustomersNameTxt.Location = new System.Drawing.Point(12, 93);
            this.oCustomersNameTxt.Name = "oCustomersNameTxt";
            this.oCustomersNameTxt.Size = new System.Drawing.Size(118, 16);
            this.oCustomersNameTxt.TabIndex = 1;
            this.oCustomersNameTxt.Text = "Costumers Name :";
            this.oCustomersNameTxt.Click += new System.EventHandler(this.oCustomersNameTxt_Click);
            // 
            // oCostumersAddressTxt
            // 
            this.oCostumersAddressTxt.AutoSize = true;
            this.oCostumersAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oCostumersAddressTxt.Location = new System.Drawing.Point(10, 130);
            this.oCostumersAddressTxt.Name = "oCostumersAddressTxt";
            this.oCostumersAddressTxt.Size = new System.Drawing.Size(132, 16);
            this.oCostumersAddressTxt.TabIndex = 2;
            this.oCostumersAddressTxt.Text = "Costumers Address :";
            // 
            // oCostumersPhoneTxt
            // 
            this.oCostumersPhoneTxt.AutoSize = true;
            this.oCostumersPhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oCostumersPhoneTxt.Location = new System.Drawing.Point(10, 168);
            this.oCostumersPhoneTxt.Name = "oCostumersPhoneTxt";
            this.oCostumersPhoneTxt.Size = new System.Drawing.Size(130, 16);
            this.oCostumersPhoneTxt.TabIndex = 3;
            this.oCostumersPhoneTxt.Text = "Costumers Phone # :";
            // 
            // oSubtotalTxt
            // 
            this.oSubtotalTxt.AutoSize = true;
            this.oSubtotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oSubtotalTxt.Location = new System.Drawing.Point(304, 84);
            this.oSubtotalTxt.Name = "oSubtotalTxt";
            this.oSubtotalTxt.Size = new System.Drawing.Size(58, 15);
            this.oSubtotalTxt.TabIndex = 4;
            this.oSubtotalTxt.Text = "Subtotal :";
            // 
            // oTaxTxt
            // 
            this.oTaxTxt.AutoSize = true;
            this.oTaxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oTaxTxt.Location = new System.Drawing.Point(304, 126);
            this.oTaxTxt.Name = "oTaxTxt";
            this.oTaxTxt.Size = new System.Drawing.Size(33, 15);
            this.oTaxTxt.TabIndex = 5;
            this.oTaxTxt.Text = "Tax :";
            // 
            // oTotalTxt
            // 
            this.oTotalTxt.AutoSize = true;
            this.oTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oTotalTxt.Location = new System.Drawing.Point(304, 164);
            this.oTotalTxt.Name = "oTotalTxt";
            this.oTotalTxt.Size = new System.Drawing.Size(74, 15);
            this.oTotalTxt.TabIndex = 6;
            this.oTotalTxt.Text = "Order Total :";
            // 
            // oCostumersNametextBox
            // 
            this.oCostumersNametextBox.Location = new System.Drawing.Point(153, 89);
            this.oCostumersNametextBox.Name = "oCostumersNametextBox";
            this.oCostumersNametextBox.Size = new System.Drawing.Size(100, 20);
            this.oCostumersNametextBox.TabIndex = 7;
            // 
            // oCostumersAddresstextBox
            // 
            this.oCostumersAddresstextBox.Location = new System.Drawing.Point(153, 126);
            this.oCostumersAddresstextBox.Name = "oCostumersAddresstextBox";
            this.oCostumersAddresstextBox.Size = new System.Drawing.Size(100, 20);
            this.oCostumersAddresstextBox.TabIndex = 8;
            // 
            // oCostumersPhonetextBox
            // 
            this.oCostumersPhonetextBox.Location = new System.Drawing.Point(153, 164);
            this.oCostumersPhonetextBox.Name = "oCostumersPhonetextBox";
            this.oCostumersPhonetextBox.Size = new System.Drawing.Size(100, 20);
            this.oCostumersPhonetextBox.TabIndex = 9;
            // 
            // oSubtotaltextBox
            // 
            this.oSubtotaltextBox.Location = new System.Drawing.Point(383, 79);
            this.oSubtotaltextBox.Name = "oSubtotaltextBox";
            this.oSubtotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.oSubtotaltextBox.TabIndex = 10;
            // 
            // oTaxtextBox
            // 
            this.oTaxtextBox.Location = new System.Drawing.Point(383, 121);
            this.oTaxtextBox.Name = "oTaxtextBox";
            this.oTaxtextBox.Size = new System.Drawing.Size(100, 20);
            this.oTaxtextBox.TabIndex = 11;
            // 
            // oTotaltextBox
            // 
            this.oTotaltextBox.Location = new System.Drawing.Point(384, 159);
            this.oTotaltextBox.Name = "oTotaltextBox";
            this.oTotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.oTotaltextBox.TabIndex = 12;
            // 
            // orderSummary
            // 
            this.orderSummary.AutoSize = true;
            this.orderSummary.Location = new System.Drawing.Point(12, 221);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(79, 13);
            this.orderSummary.TabIndex = 13;
            this.orderSummary.Text = "Order Summary";
            this.orderSummary.Click += new System.EventHandler(this.label1_Click);
            // 
            // odelivery
            // 
            this.odelivery.AutoSize = true;
            this.odelivery.Location = new System.Drawing.Point(391, 182);
            this.odelivery.Name = "odelivery";
            this.odelivery.Size = new System.Drawing.Size(90, 13);
            this.odelivery.TabIndex = 14;
            this.odelivery.Text = "Delivery + ($5.00)";
            // 
            // omcdTxt
            // 
            this.omcdTxt.AutoSize = true;
            this.omcdTxt.Location = new System.Drawing.Point(146, 33);
            this.omcdTxt.Name = "omcdTxt";
            this.omcdTxt.Size = new System.Drawing.Size(0, 13);
            this.omcdTxt.TabIndex = 15;
            // 
            // oExit
            // 
            this.oExit.Location = new System.Drawing.Point(383, 321);
            this.oExit.Name = "oExit";
            this.oExit.Size = new System.Drawing.Size(75, 23);
            this.oExit.TabIndex = 16;
            this.oExit.Text = "Exit";
            this.oExit.UseVisualStyleBackColor = true;
            this.oExit.Click += new System.EventHandler(this.oExit_Click);
            // 
            // Order_Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(508, 356);
            this.Controls.Add(this.oExit);
            this.Controls.Add(this.omcdTxt);
            this.Controls.Add(this.odelivery);
            this.Controls.Add(this.orderSummary);
            this.Controls.Add(this.oTotaltextBox);
            this.Controls.Add(this.oTaxtextBox);
            this.Controls.Add(this.oSubtotaltextBox);
            this.Controls.Add(this.oCostumersPhonetextBox);
            this.Controls.Add(this.oCostumersAddresstextBox);
            this.Controls.Add(this.oCostumersNametextBox);
            this.Controls.Add(this.oTotalTxt);
            this.Controls.Add(this.oTaxTxt);
            this.Controls.Add(this.oSubtotalTxt);
            this.Controls.Add(this.oCostumersPhoneTxt);
            this.Controls.Add(this.oCostumersAddressTxt);
            this.Controls.Add(this.oCustomersNameTxt);
            this.Controls.Add(this.OrderConfirmationTxt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Order_Confirmation";
            this.Text = "Order_Confirmation";
            this.Load += new System.EventHandler(this.Order_Confirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderConfirmationTxt;
        private System.Windows.Forms.Label oCustomersNameTxt;
        private System.Windows.Forms.Label oCostumersAddressTxt;
        private System.Windows.Forms.Label oCostumersPhoneTxt;
        private System.Windows.Forms.Label oSubtotalTxt;
        private System.Windows.Forms.Label oTaxTxt;
        private System.Windows.Forms.Label oTotalTxt;
        private System.Windows.Forms.TextBox oCostumersNametextBox;
        private System.Windows.Forms.TextBox oCostumersAddresstextBox;
        private System.Windows.Forms.TextBox oCostumersPhonetextBox;
        private System.Windows.Forms.TextBox oSubtotaltextBox;
        private System.Windows.Forms.TextBox oTaxtextBox;
        private System.Windows.Forms.TextBox oTotaltextBox;
        private System.Windows.Forms.Label orderSummary;
        private System.Windows.Forms.Label odelivery;
        private System.Windows.Forms.Label omcdTxt;
        private System.Windows.Forms.Button oExit;

    }
}