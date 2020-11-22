namespace BookHouseOOP
{
    partial class MagazineUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazineUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMagazine = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMagazineAddToCart = new ns1.BunifuThinButton2();
            this.lbl_magazine_stock = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMagazineName = new System.Windows.Forms.Label();
            this.lblMagazineIssue = new System.Windows.Forms.Label();
            this.lblMagazinePrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagazine)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbMagazine);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 142);
            this.panel1.TabIndex = 9;
            // 
            // pbMagazine
            // 
            this.pbMagazine.Location = new System.Drawing.Point(3, 2);
            this.pbMagazine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMagazine.Name = "pbMagazine";
            this.pbMagazine.Size = new System.Drawing.Size(128, 128);
            this.pbMagazine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMagazine.TabIndex = 0;
            this.pbMagazine.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMagazineAddToCart);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lbl_magazine_stock);
            this.panel2.Controls.Add(this.nudQuantity);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.lblMagazineName);
            this.panel2.Controls.Add(this.lblMagazineIssue);
            this.panel2.Controls.Add(this.lblMagazinePrice);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 348);
            this.panel2.TabIndex = 10;
            // 
            // btnMagazineAddToCart
            // 
            this.btnMagazineAddToCart.ActiveBorderThickness = 1;
            this.btnMagazineAddToCart.ActiveCornerRadius = 20;
            this.btnMagazineAddToCart.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnMagazineAddToCart.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnMagazineAddToCart.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnMagazineAddToCart.BackColor = System.Drawing.Color.White;
            this.btnMagazineAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMagazineAddToCart.BackgroundImage")));
            this.btnMagazineAddToCart.ButtonText = "Add to cart";
            this.btnMagazineAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagazineAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagazineAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnMagazineAddToCart.IdleBorderThickness = 1;
            this.btnMagazineAddToCart.IdleCornerRadius = 20;
            this.btnMagazineAddToCart.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnMagazineAddToCart.IdleForecolor = System.Drawing.Color.White;
            this.btnMagazineAddToCart.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnMagazineAddToCart.Location = new System.Drawing.Point(5, 272);
            this.btnMagazineAddToCart.Margin = new System.Windows.Forms.Padding(5);
            this.btnMagazineAddToCart.Name = "btnMagazineAddToCart";
            this.btnMagazineAddToCart.Size = new System.Drawing.Size(159, 58);
            this.btnMagazineAddToCart.TabIndex = 21;
            this.btnMagazineAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMagazineAddToCart.Click += new System.EventHandler(this.btnMagazineAddToCart_Click);
            // 
            // lbl_magazine_stock
            // 
            this.lbl_magazine_stock.AutoSize = true;
            this.lbl_magazine_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_magazine_stock.Location = new System.Drawing.Point(60, 231);
            this.lbl_magazine_stock.Name = "lbl_magazine_stock";
            this.lbl_magazine_stock.Size = new System.Drawing.Size(117, 20);
            this.lbl_magazine_stock.TabIndex = 15;
            this.lbl_magazine_stock.Text = "magazine left";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudQuantity.Location = new System.Drawing.Point(172, 278);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(59, 52);
            this.nudQuantity.TabIndex = 8;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(8, 222);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 29);
            this.lblStock.TabIndex = 6;
            // 
            // lblMagazineName
            // 
            this.lblMagazineName.AutoSize = true;
            this.lblMagazineName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineName.ForeColor = System.Drawing.Color.Blue;
            this.lblMagazineName.Location = new System.Drawing.Point(8, 165);
            this.lblMagazineName.Name = "lblMagazineName";
            this.lblMagazineName.Size = new System.Drawing.Size(0, 29);
            this.lblMagazineName.TabIndex = 1;
            // 
            // lblMagazineIssue
            // 
            this.lblMagazineIssue.AutoSize = true;
            this.lblMagazineIssue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineIssue.Location = new System.Drawing.Point(8, 194);
            this.lblMagazineIssue.Name = "lblMagazineIssue";
            this.lblMagazineIssue.Size = new System.Drawing.Size(0, 28);
            this.lblMagazineIssue.TabIndex = 2;
            // 
            // lblMagazinePrice
            // 
            this.lblMagazinePrice.AutoSize = true;
            this.lblMagazinePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazinePrice.ForeColor = System.Drawing.Color.Blue;
            this.lblMagazinePrice.Location = new System.Drawing.Point(183, 79);
            this.lblMagazinePrice.Name = "lblMagazinePrice";
            this.lblMagazinePrice.Size = new System.Drawing.Size(0, 32);
            this.lblMagazinePrice.TabIndex = 3;
            // 
            // MagazineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Name = "MagazineUserControl";
            this.Size = new System.Drawing.Size(273, 363);
            this.Load += new System.EventHandler(this.MagazineUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMagazine)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMagazine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_magazine_stock;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMagazineName;
        private System.Windows.Forms.Label lblMagazineIssue;
        private System.Windows.Forms.Label lblMagazinePrice;
        private ns1.BunifuThinButton2 btnMagazineAddToCart;
    }
}
