using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Leave empty or add code here if needed
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Quantity
                int quantity = int.Parse(txtQuantity.Text);
                double pricePerShirt = 0;

                // Determine selected size
                if (rbSmall.Checked)
                    pricePerShirt = 125;
                else if (rbMedium.Checked)
                    pricePerShirt = 175;
                else if (rbLarge.Checked)
                    pricePerShirt = 250;
                else
                {
                    MessageBox.Show("Please select a T-shirt size.");
                    return;
                }

                // Calculate subtotal
                double totalPrice = pricePerShirt * quantity;

                // Apply promo code discount (10% if "TRUEBLUE")
                if (txtPromoCode.Text.ToUpper() == "TRUEBLUE")
                {
                    totalPrice *= 0.90; // Apply 10% discount
                }

                // Apply GST (9%)
                totalPrice *= 1.09;

                // Display final price
                lblTotalPrice.Text = "Final Price: Rs. " + totalPrice.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }
    }
}
