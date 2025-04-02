using System;
using System.Windows.Forms;

namespace TShirtOrderingApp
{
    public partial class Form1 : Form  // ✅ Ensure inheritance from Form
    {
        public Form1()
        {
            InitializeComponent();  // ✅ Make sure this method exists
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
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

                // ✅ Display final price in `lblTotalPrice`, not `btnCalculate`
                lblTotalPrice.Text = "Final Price: Rs. " + totalPrice.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }
    }
}
