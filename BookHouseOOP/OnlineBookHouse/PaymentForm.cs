using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookHouseOOP
{
    public partial class PaymentForm : Form, IMessageFilter
    {
    
        public PaymentForm()
        {
            InitializeComponent();
        }
      
            /// create new object user from UserClass
            UserClass user;
            /**   
             * @brief Default Constructor
             * Constructs the object with default parameters 
             * @param UserClass user
             */
            public PaymentForm(UserClass user)
            {
                this.user = user;
                InitializeComponent();
                Application.AddMessageFilter(this);
                this.FormClosed += (o, e) => Application.RemoveMessageFilter(this);
            }

            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == 0x201 || m.Msg == 0x203)
                {  // Trap left click + double-click
                    string name = "Unknown";
                    Control ctl = Control.FromHandle(m.HWnd);
                    if (ctl != null) name = ctl.Name;
                    //Point pos = new Point(m.LParam.ToInt32());
                    string message = "Username " + user.userName + " Clicked object " + name + " at " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                    FileWriterClass.WriteFile(@"Logs\" + user.userName + "_clicklogs.txt", message);
                    Console.WriteLine("Click {0}", message);
                }
                return false;
            }

            /**
             * call calculateActualTotalPrice() from ShoppingCartClass
             * and assign lblPaymentAmountValue and lblPaymentAmountCashValue
             */
            private void PaymentForm_Load(object sender, EventArgs e)
            {
                lblPaymentAmountValue.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
                lblPaymentAmountCashValue.Text = ShoppingCartClass.calculateActualTotalPrice().ToString();
            }
            /** @brief makePayment() function
             * @param PaymentType paymentType
             * call placeorder from ShoppingCartClass
             * placeorder() function have customerıd and paymenttype parameters
             */
            private void makePayment(PaymentType paymentType)
            {
                ShoppingCartClass.placeOrder(user.customerID, paymentType, ShoppingCartClass.calculateActualTotalPrice());
            }

            /// click credit card button 

            private void btnPay_Click(object sender, EventArgs e)
            {
                if (mtxtCardNumber.Text != "" && txtNameOnCard.Text != "" && mtbExpiry.Text != "" && mtbSecurity.Text != "")
                {
                    MessageBox.Show("Payment is successful");
                    makePayment(PaymentType.CreditCard);
                    ShoppingCartClass.itemsToPurchase.Clear();
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];
                    ((BookShopForm)f).populateShoppingCartView();
                    //((BookShopForm)f).lblShoppinCartValue.Text = quantity.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill all fields");
                }
            }

            /// click cash button
            private void btnPaymentCash_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Payment is successful");
                makePayment(PaymentType.Cash);
                ShoppingCartClass.itemsToPurchase.Clear();
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];
                ((BookShopForm)f).populateShoppingCartView();
                //((BookShopForm)f).lblShoppinCartValue.Text = quantity.ToString();
                this.Close();
            }

        private void label5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}