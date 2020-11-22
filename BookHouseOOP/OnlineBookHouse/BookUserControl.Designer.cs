namespace BookHouseOOP
{
    partial class BookUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBookAddToCart = new ns1.BunifuThinButton2();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbBook);
            this.panel1.Location = new System.Drawing.Point(14, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 154);
            this.panel1.TabIndex = 7;
            // 
            // pbBook
            // 
            this.pbBook.Location = new System.Drawing.Point(4, 11);
            this.pbBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(128, 128);
            this.pbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBook.TabIndex = 0;
            this.pbBook.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBookAddToCart);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lbl_stock);
            this.panel2.Controls.Add(this.nudQuantity);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Controls.Add(this.lblBookAuthor);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Location = new System.Drawing.Point(14, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 343);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBookAddToCart
            // 
            this.btnBookAddToCart.ActiveBorderThickness = 1;
            this.btnBookAddToCart.ActiveCornerRadius = 20;
            this.btnBookAddToCart.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnBookAddToCart.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnBookAddToCart.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnBookAddToCart.BackColor = System.Drawing.Color.White;
            this.btnBookAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookAddToCart.BackgroundImage")));
            this.btnBookAddToCart.ButtonText = "Add to cart";
            this.btnBookAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnBookAddToCart.IdleBorderThickness = 1;
            this.btnBookAddToCart.IdleCornerRadius = 20;
            this.btnBookAddToCart.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnBookAddToCart.IdleForecolor = System.Drawing.Color.White;
            this.btnBookAddToCart.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnBookAddToCart.Location = new System.Drawing.Point(5, 274);
            this.btnBookAddToCart.Margin = new System.Windows.Forms.Padding(5);
            this.btnBookAddToCart.Name = "btnBookAddToCart";
            this.btnBookAddToCart.Size = new System.Drawing.Size(159, 58);
            this.btnBookAddToCart.TabIndex = 21;
            this.btnBookAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBookAddToCart.Click += new System.EventHandler(this.btnBookAddToCart_Click);
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(83, 241);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(79, 20);
            this.lbl_stock.TabIndex = 11;
            this.lbl_stock.Text = "book left";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudQuantity.Location = new System.Drawing.Point(172, 274);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(57, 52);
            this.nudQuantity.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(18, 241);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 28);
            this.lblStock.TabIndex = 6;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.ForeColor = System.Drawing.Color.Blue;
            this.lblBookName.Location = new System.Drawing.Point(19, 169);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(0, 29);
            this.lblBookName.TabIndex = 1;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.Location = new System.Drawing.Point(20, 204);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(0, 25);
            this.lblBookAuthor.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Blue;
            this.lblPrice.Location = new System.Drawing.Point(162, 64);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 32);
            this.lblPrice.TabIndex = 3;
            // 
            // BookUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Name = "BookUserControl";
            this.Size = new System.Drawing.Size(279, 362);
            this.Load += new System.EventHandler(this.BookUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblPrice;
        private ns1.BunifuThinButton2 btnBookAddToCart;
    }
}
