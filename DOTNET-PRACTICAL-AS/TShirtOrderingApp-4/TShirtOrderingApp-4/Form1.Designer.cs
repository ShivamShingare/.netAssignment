namespace TShirtOrderingApp
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPromoCode = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of T-Shirts";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(247, 40);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(272, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select T-Shirt Size";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(247, 77);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(117, 20);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small (Rs. 125)";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(371, 77);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(134, 20);
            this.rbMedium.TabIndex = 4;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = " Medium (Rs. 175)";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(512, 77);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(118, 20);
            this.rbLarge.TabIndex = 5;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large (Rs. 250)";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Promo Code";
            // 
            // txtPromoCode
            // 
            this.txtPromoCode.Location = new System.Drawing.Point(247, 115);
            this.txtPromoCode.Name = "txtPromoCode";
            this.txtPromoCode.Size = new System.Drawing.Size(272, 22);
            this.txtPromoCode.TabIndex = 7;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(247, 197);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(98, 23);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Calculate";
            this.lblTotalPrice.UseVisualStyleBackColor = true;
            this.lblTotalPrice.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "TotalPrice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtPromoCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbSmall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPromoCode;
        private System.Windows.Forms.Button lblTotalPrice;
        private System.Windows.Forms.Label label4;
    }
}

