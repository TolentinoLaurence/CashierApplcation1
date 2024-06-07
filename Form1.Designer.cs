namespace CashierApplcation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemDiscount = new System.Windows.Forms.TextBox();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtPaymentRecieve = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payment Recieve:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Change:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(47, 40);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(118, 20);
            this.txtItemName.TabIndex = 7;
            // 
            // txtItemDiscount
            // 
            this.txtItemDiscount.Location = new System.Drawing.Point(308, 40);
            this.txtItemDiscount.Name = "txtItemDiscount";
            this.txtItemDiscount.Size = new System.Drawing.Size(118, 20);
            this.txtItemDiscount.TabIndex = 8;
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(351, 78);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(118, 20);
            this.txtItemQuantity.TabIndex = 9;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(77, 78);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(118, 20);
            this.txtItemPrice.TabIndex = 10;
            // 
            // txtPaymentRecieve
            // 
            this.txtPaymentRecieve.Location = new System.Drawing.Point(201, 184);
            this.txtPaymentRecieve.Name = "txtPaymentRecieve";
            this.txtPaymentRecieve.Size = new System.Drawing.Size(118, 20);
            this.txtPaymentRecieve.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(235, 152);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalAmount.TabIndex = 14;
            this.lblTotalAmount.Text = "label8";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(235, 225);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(35, 13);
            this.lblChange.TabIndex = 15;
            this.lblChange.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 309);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPaymentRecieve);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.txtItemDiscount);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemDiscount;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.TextBox txtPaymentRecieve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblChange;
    }
}

