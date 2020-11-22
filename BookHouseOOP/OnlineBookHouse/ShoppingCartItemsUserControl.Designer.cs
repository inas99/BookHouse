namespace BookHouseOOP
{
    partial class ShoppingCartItemsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartItemsUserControl));
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblUnitPriceValue = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblTotalPRice = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbShoppingCart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(146, 265);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(67, 28);
            this.lblTotalPriceValue.TabIndex = 22;
            this.lblTotalPriceValue.Text = "label2";
            // 
            // lblUnitPriceValue
            // 
            this.lblUnitPriceValue.AutoSize = true;
            this.lblUnitPriceValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPriceValue.Location = new System.Drawing.Point(146, 233);
            this.lblUnitPriceValue.Name = "lblUnitPriceValue";
            this.lblUnitPriceValue.Size = new System.Drawing.Size(64, 28);
            this.lblUnitPriceValue.TabIndex = 21;
            this.lblUnitPriceValue.Text = "label1";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(151, 203);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(76, 26);
            this.nudQuantity.TabIndex = 20;
            // 
            // lblTotalPRice
            // 
            this.lblTotalPRice.AutoSize = true;
            this.lblTotalPRice.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPRice.Location = new System.Drawing.Point(15, 265);
            this.lblTotalPRice.Name = "lblTotalPRice";
            this.lblTotalPRice.Size = new System.Drawing.Size(120, 29);
            this.lblTotalPRice.TabIndex = 19;
            this.lblTotalPRice.Text = "Total Price";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPrice.Location = new System.Drawing.Point(15, 235);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(110, 29);
            this.lblUnitPrice.TabIndex = 18;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.Click += new System.EventHandler(this.lblUnitPrice_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(15, 200);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(97, 29);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 35);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbShoppingCart);
            this.panel1.Location = new System.Drawing.Point(20, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 124);
            this.panel1.TabIndex = 15;
            // 
            // pbShoppingCart
            // 
            this.pbShoppingCart.Location = new System.Drawing.Point(20, 2);
            this.pbShoppingCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbShoppingCart.Name = "pbShoppingCart";
            this.pbShoppingCart.Size = new System.Drawing.Size(125, 110);
            this.pbShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShoppingCart.TabIndex = 0;
            this.pbShoppingCart.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // ShoppingCartItemsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalPriceValue);
            this.Controls.Add(this.lblUnitPriceValue);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblTotalPRice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Name = "ShoppingCartItemsUserControl";
            this.Size = new System.Drawing.Size(260, 309);
            this.Load += new System.EventHandler(this.ShoppingCartItemsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lblUnitPriceValue;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblTotalPRice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbShoppingCart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
