using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHouseOOP
{
    /// ShoppingCartItemsUserControl class inherited from UserControl class
    public partial class ShoppingCartItemsUserControl : UserControl
    {
        public string id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double unitPriceValue { get; set; }
        private double totalPriceValue = 0;
        public Type type;
        public string picture { get; set; }
        /**  
        * @brief Getter function of the totalPriceValue attribute   
        * @return totalPriceValue
       */
        public double getTotalPriceValue()
        {
            return totalPriceValue;
        }
        /**  
         * @brief Setter function of the totalPriceValue attribute   
         * @param double value (must be greater than zero)  
         */
        public void setTotalPriceValue(double value)
        {
            totalPriceValue = value;
        }

        public ShoppingCartItemsUserControl()
        {
            InitializeComponent();
        }
        ///adding to shopping cart panel from  the added books in the admin panel.
        private void ShoppingCartItemsUserControl_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            nudQuantity.Value = quantity;
            pbShoppingCart.ImageLocation = @"Resources\AllPictures\" + picture;
            lblUnitPriceValue.Text = unitPriceValue.ToString();
            lblTotalPriceValue.Text = (quantity * unitPriceValue).ToString();
            totalPriceValue += (quantity * unitPriceValue);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUnitPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
