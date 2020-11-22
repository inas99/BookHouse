namespace BookHouseOOP
{
    partial class MusicCDUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicCDUserControl));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMusicCDs = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMusicCDsAddToCart = new ns1.BunifuThinButton2();
            this.lbl_musicCDs_stock = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMusicCDName = new System.Windows.Forms.Label();
            this.lblMusicCDSinger = new System.Windows.Forms.Label();
            this.lblMusicCDPrice = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusicCDs)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbMusicCDs);
            this.panel2.Location = new System.Drawing.Point(14, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 151);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pbMusicCDs
            // 
            this.pbMusicCDs.Location = new System.Drawing.Point(14, 9);
            this.pbMusicCDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMusicCDs.Name = "pbMusicCDs";
            this.pbMusicCDs.Size = new System.Drawing.Size(128, 128);
            this.pbMusicCDs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMusicCDs.TabIndex = 0;
            this.pbMusicCDs.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnMusicCDsAddToCart);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lbl_musicCDs_stock);
            this.panel3.Controls.Add(this.nudQuantity);
            this.panel3.Controls.Add(this.lblStock);
            this.panel3.Controls.Add(this.lblMusicCDName);
            this.panel3.Controls.Add(this.lblMusicCDSinger);
            this.panel3.Controls.Add(this.lblMusicCDPrice);
            this.panel3.Location = new System.Drawing.Point(17, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 325);
            this.panel3.TabIndex = 14;
            // 
            // btnMusicCDsAddToCart
            // 
            this.btnMusicCDsAddToCart.ActiveBorderThickness = 1;
            this.btnMusicCDsAddToCart.ActiveCornerRadius = 20;
            this.btnMusicCDsAddToCart.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnMusicCDsAddToCart.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnMusicCDsAddToCart.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnMusicCDsAddToCart.BackColor = System.Drawing.Color.White;
            this.btnMusicCDsAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusicCDsAddToCart.BackgroundImage")));
            this.btnMusicCDsAddToCart.ButtonText = "Add to cart";
            this.btnMusicCDsAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusicCDsAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicCDsAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnMusicCDsAddToCart.IdleBorderThickness = 1;
            this.btnMusicCDsAddToCart.IdleCornerRadius = 20;
            this.btnMusicCDsAddToCart.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnMusicCDsAddToCart.IdleForecolor = System.Drawing.Color.White;
            this.btnMusicCDsAddToCart.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnMusicCDsAddToCart.Location = new System.Drawing.Point(14, 254);
            this.btnMusicCDsAddToCart.Margin = new System.Windows.Forms.Padding(5);
            this.btnMusicCDsAddToCart.Name = "btnMusicCDsAddToCart";
            this.btnMusicCDsAddToCart.Size = new System.Drawing.Size(159, 58);
            this.btnMusicCDsAddToCart.TabIndex = 20;
            this.btnMusicCDsAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMusicCDsAddToCart.Click += new System.EventHandler(this.btnMusicCDsAddToCart_Click);
            // 
            // lbl_musicCDs_stock
            // 
            this.lbl_musicCDs_stock.AutoSize = true;
            this.lbl_musicCDs_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_musicCDs_stock.Location = new System.Drawing.Point(61, 229);
            this.lbl_musicCDs_stock.Name = "lbl_musicCDs_stock";
            this.lbl_musicCDs_stock.Size = new System.Drawing.Size(65, 20);
            this.lbl_musicCDs_stock.TabIndex = 19;
            this.lbl_musicCDs_stock.Text = "CD left";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudQuantity.Location = new System.Drawing.Point(181, 254);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(59, 52);
            this.nudQuantity.TabIndex = 12;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(10, 229);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 20);
            this.lblStock.TabIndex = 11;
            // 
            // lblMusicCDName
            // 
            this.lblMusicCDName.AutoSize = true;
            this.lblMusicCDName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDName.ForeColor = System.Drawing.Color.Blue;
            this.lblMusicCDName.Location = new System.Drawing.Point(12, 155);
            this.lblMusicCDName.Name = "lblMusicCDName";
            this.lblMusicCDName.Size = new System.Drawing.Size(0, 29);
            this.lblMusicCDName.TabIndex = 6;
            // 
            // lblMusicCDSinger
            // 
            this.lblMusicCDSinger.AutoSize = true;
            this.lblMusicCDSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDSinger.Location = new System.Drawing.Point(13, 194);
            this.lblMusicCDSinger.Name = "lblMusicCDSinger";
            this.lblMusicCDSinger.Size = new System.Drawing.Size(0, 20);
            this.lblMusicCDSinger.TabIndex = 7;
            // 
            // lblMusicCDPrice
            // 
            this.lblMusicCDPrice.AutoSize = true;
            this.lblMusicCDPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicCDPrice.ForeColor = System.Drawing.Color.Blue;
            this.lblMusicCDPrice.Location = new System.Drawing.Point(194, 64);
            this.lblMusicCDPrice.Name = "lblMusicCDPrice";
            this.lblMusicCDPrice.Size = new System.Drawing.Size(0, 32);
            this.lblMusicCDPrice.TabIndex = 8;
            // 
            // MusicCDUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Name = "MusicCDUserControl";
            this.Size = new System.Drawing.Size(283, 339);
            this.Load += new System.EventHandler(this.MusicCDUserControl_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMusicCDs)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMusicCDs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_musicCDs_stock;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMusicCDName;
        private System.Windows.Forms.Label lblMusicCDSinger;
        private System.Windows.Forms.Label lblMusicCDPrice;
        private ns1.BunifuThinButton2 btnMusicCDsAddToCart;
    }
}
