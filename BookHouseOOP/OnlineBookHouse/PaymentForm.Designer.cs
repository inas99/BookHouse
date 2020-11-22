namespace BookHouseOOP
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCreditCard = new System.Windows.Forms.TabPage();
            this.panelCreditCard = new System.Windows.Forms.Panel();
            this.btnPay = new ns1.BunifuThinButton2();
            this.pBPayment = new System.Windows.Forms.PictureBox();
            this.lblPaymentAmountValue = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.mtbSecurity = new System.Windows.Forms.MaskedTextBox();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.mtbExpiry = new System.Windows.Forms.MaskedTextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.mtxtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.tabPageCash = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelCash = new System.Windows.Forms.Panel();
            this.btnPaymentCash = new ns1.BunifuThinButton2();
            this.lblPaymentAmountCashValue = new System.Windows.Forms.Label();
            this.lblPaymentAmountCash = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbminimize = new System.Windows.Forms.Label();
            this.lbclose = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageCreditCard.SuspendLayout();
            this.panelCreditCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPayment)).BeginInit();
            this.tabPageCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCash.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCreditCard);
            this.tabControl1.Controls.Add(this.tabPageCash);
            this.tabControl1.Location = new System.Drawing.Point(418, 182);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 629);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageCreditCard
            // 
            this.tabPageCreditCard.BackColor = System.Drawing.Color.Black;
            this.tabPageCreditCard.Controls.Add(this.panelCreditCard);
            this.tabPageCreditCard.Location = new System.Drawing.Point(4, 29);
            this.tabPageCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCreditCard.Name = "tabPageCreditCard";
            this.tabPageCreditCard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCreditCard.Size = new System.Drawing.Size(678, 596);
            this.tabPageCreditCard.TabIndex = 0;
            this.tabPageCreditCard.Text = "Credit Card";
            // 
            // panelCreditCard
            // 
            this.panelCreditCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCreditCard.Controls.Add(this.btnPay);
            this.panelCreditCard.Controls.Add(this.pBPayment);
            this.panelCreditCard.Controls.Add(this.lblPaymentAmountValue);
            this.panelCreditCard.Controls.Add(this.lblPaymentAmount);
            this.panelCreditCard.Controls.Add(this.mtbSecurity);
            this.panelCreditCard.Controls.Add(this.lblSecurityCode);
            this.panelCreditCard.Controls.Add(this.mtbExpiry);
            this.panelCreditCard.Controls.Add(this.lblExpiryDate);
            this.panelCreditCard.Controls.Add(this.txtNameOnCard);
            this.panelCreditCard.Controls.Add(this.lblNameOnCard);
            this.panelCreditCard.Controls.Add(this.mtxtCardNumber);
            this.panelCreditCard.Controls.Add(this.lblCardNumber);
            this.panelCreditCard.Location = new System.Drawing.Point(3, 0);
            this.panelCreditCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCreditCard.Name = "panelCreditCard";
            this.panelCreditCard.Size = new System.Drawing.Size(679, 590);
            this.panelCreditCard.TabIndex = 11;
            // 
            // btnPay
            // 
            this.btnPay.ActiveBorderThickness = 1;
            this.btnPay.ActiveCornerRadius = 20;
            this.btnPay.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPay.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPay.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPay.BackColor = System.Drawing.Color.Black;
            this.btnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPay.BackgroundImage")));
            this.btnPay.ButtonText = "Make your payement";
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.IdleBorderThickness = 1;
            this.btnPay.IdleCornerRadius = 20;
            this.btnPay.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPay.IdleForecolor = System.Drawing.Color.White;
            this.btnPay.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPay.Location = new System.Drawing.Point(184, 506);
            this.btnPay.Margin = new System.Windows.Forms.Padding(5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(347, 77);
            this.btnPay.TabIndex = 15;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pBPayment
            // 
            this.pBPayment.Image = ((System.Drawing.Image)(resources.GetObject("pBPayment.Image")));
            this.pBPayment.Location = new System.Drawing.Point(75, 19);
            this.pBPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBPayment.Name = "pBPayment";
            this.pBPayment.Size = new System.Drawing.Size(521, 122);
            this.pBPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBPayment.TabIndex = 11;
            this.pBPayment.TabStop = false;
            // 
            // lblPaymentAmountValue
            // 
            this.lblPaymentAmountValue.AutoSize = true;
            this.lblPaymentAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblPaymentAmountValue.Location = new System.Drawing.Point(250, 458);
            this.lblPaymentAmountValue.Name = "lblPaymentAmountValue";
            this.lblPaymentAmountValue.Size = new System.Drawing.Size(0, 25);
            this.lblPaymentAmountValue.TabIndex = 10;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentAmount.ForeColor = System.Drawing.Color.White;
            this.lblPaymentAmount.Location = new System.Drawing.Point(33, 458);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(189, 25);
            this.lblPaymentAmount.TabIndex = 9;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // mtbSecurity
            // 
            this.mtbSecurity.Location = new System.Drawing.Point(246, 391);
            this.mtbSecurity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbSecurity.Mask = "000";
            this.mtbSecurity.Name = "mtbSecurity";
            this.mtbSecurity.Size = new System.Drawing.Size(349, 26);
            this.mtbSecurity.TabIndex = 7;
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecurityCode.ForeColor = System.Drawing.Color.White;
            this.lblSecurityCode.Location = new System.Drawing.Point(46, 390);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(160, 25);
            this.lblSecurityCode.TabIndex = 6;
            this.lblSecurityCode.Text = "Security Code";
            // 
            // mtbExpiry
            // 
            this.mtbExpiry.Location = new System.Drawing.Point(246, 320);
            this.mtbExpiry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbExpiry.Mask = "00/00";
            this.mtbExpiry.Name = "mtbExpiry";
            this.mtbExpiry.Size = new System.Drawing.Size(350, 26);
            this.mtbExpiry.TabIndex = 5;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExpiryDate.ForeColor = System.Drawing.Color.White;
            this.lblExpiryDate.Location = new System.Drawing.Point(46, 321);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(134, 25);
            this.lblExpiryDate.TabIndex = 4;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(246, 254);
            this.txtNameOnCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(350, 26);
            this.txtNameOnCard.TabIndex = 3;
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameOnCard.ForeColor = System.Drawing.Color.White;
            this.lblNameOnCard.Location = new System.Drawing.Point(46, 255);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(166, 25);
            this.lblNameOnCard.TabIndex = 2;
            this.lblNameOnCard.Text = "Name On Card";
            // 
            // mtxtCardNumber
            // 
            this.mtxtCardNumber.Location = new System.Drawing.Point(246, 183);
            this.mtxtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCardNumber.Mask = "0000-0000-0000-0000";
            this.mtxtCardNumber.Name = "mtxtCardNumber";
            this.mtxtCardNumber.Size = new System.Drawing.Size(349, 26);
            this.mtxtCardNumber.TabIndex = 1;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCardNumber.ForeColor = System.Drawing.Color.White;
            this.lblCardNumber.Location = new System.Drawing.Point(46, 184);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(150, 25);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number";
            // 
            // tabPageCash
            // 
            this.tabPageCash.BackColor = System.Drawing.Color.Black;
            this.tabPageCash.Controls.Add(this.pictureBox2);
            this.tabPageCash.Controls.Add(this.panelCash);
            this.tabPageCash.Location = new System.Drawing.Point(4, 29);
            this.tabPageCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCash.Name = "tabPageCash";
            this.tabPageCash.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCash.Size = new System.Drawing.Size(678, 596);
            this.tabPageCash.TabIndex = 1;
            this.tabPageCash.Text = "Cash";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(147, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(385, 205);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panelCash
            // 
            this.panelCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCash.Controls.Add(this.btnPaymentCash);
            this.panelCash.Controls.Add(this.lblPaymentAmountCashValue);
            this.panelCash.Controls.Add(this.lblPaymentAmountCash);
            this.panelCash.Location = new System.Drawing.Point(138, 283);
            this.panelCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCash.Name = "panelCash";
            this.panelCash.Size = new System.Drawing.Size(395, 260);
            this.panelCash.TabIndex = 14;
            // 
            // btnPaymentCash
            // 
            this.btnPaymentCash.ActiveBorderThickness = 1;
            this.btnPaymentCash.ActiveCornerRadius = 20;
            this.btnPaymentCash.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPaymentCash.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPaymentCash.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPaymentCash.BackColor = System.Drawing.Color.Black;
            this.btnPaymentCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaymentCash.BackgroundImage")));
            this.btnPaymentCash.ButtonText = "Make your payement";
            this.btnPaymentCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentCash.ForeColor = System.Drawing.Color.White;
            this.btnPaymentCash.IdleBorderThickness = 1;
            this.btnPaymentCash.IdleCornerRadius = 20;
            this.btnPaymentCash.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPaymentCash.IdleForecolor = System.Drawing.Color.White;
            this.btnPaymentCash.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.btnPaymentCash.Location = new System.Drawing.Point(30, 149);
            this.btnPaymentCash.Margin = new System.Windows.Forms.Padding(5);
            this.btnPaymentCash.Name = "btnPaymentCash";
            this.btnPaymentCash.Size = new System.Drawing.Size(328, 77);
            this.btnPaymentCash.TabIndex = 16;
            this.btnPaymentCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPaymentCash.Click += new System.EventHandler(this.btnPaymentCash_Click);
            // 
            // lblPaymentAmountCashValue
            // 
            this.lblPaymentAmountCashValue.AutoSize = true;
            this.lblPaymentAmountCashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentAmountCashValue.ForeColor = System.Drawing.Color.White;
            this.lblPaymentAmountCashValue.Location = new System.Drawing.Point(269, 52);
            this.lblPaymentAmountCashValue.Name = "lblPaymentAmountCashValue";
            this.lblPaymentAmountCashValue.Size = new System.Drawing.Size(0, 25);
            this.lblPaymentAmountCashValue.TabIndex = 13;
            // 
            // lblPaymentAmountCash
            // 
            this.lblPaymentAmountCash.AutoSize = true;
            this.lblPaymentAmountCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentAmountCash.ForeColor = System.Drawing.Color.White;
            this.lblPaymentAmountCash.Location = new System.Drawing.Point(25, 52);
            this.lblPaymentAmountCash.Name = "lblPaymentAmountCash";
            this.lblPaymentAmountCash.Size = new System.Drawing.Size(189, 25);
            this.lblPaymentAmountCash.TabIndex = 12;
            this.lblPaymentAmountCash.Text = "Payment Amount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.lbminimize);
            this.panel2.Controls.Add(this.lbclose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 14);
            this.panel2.TabIndex = 2;
            // 
            // lbminimize
            // 
            this.lbminimize.AutoSize = true;
            this.lbminimize.BackColor = System.Drawing.Color.Transparent;
            this.lbminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbminimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbminimize.Location = new System.Drawing.Point(1277, 9);
            this.lbminimize.Name = "lbminimize";
            this.lbminimize.Size = new System.Drawing.Size(28, 37);
            this.lbminimize.TabIndex = 30;
            this.lbminimize.Text = "-";
            // 
            // lbclose
            // 
            this.lbclose.AutoSize = true;
            this.lbclose.BackColor = System.Drawing.Color.Transparent;
            this.lbclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbclose.Location = new System.Drawing.Point(1311, 9);
            this.lbclose.Name = "lbclose";
            this.lbclose.Size = new System.Drawing.Size(39, 37);
            this.lbclose.TabIndex = 29;
            this.lbclose.Text = "X";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(122, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 216);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 101);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "BookHouse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1165, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1209, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 37);
            this.label6.TabIndex = 28;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(593, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(332, 143);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1269, 877);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCreditCard.ResumeLayout(false);
            this.panelCreditCard.ResumeLayout(false);
            this.panelCreditCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPayment)).EndInit();
            this.tabPageCash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCash.ResumeLayout(false);
            this.panelCash.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCreditCard;
        private System.Windows.Forms.Panel panelCreditCard;
        private System.Windows.Forms.PictureBox pBPayment;
        private System.Windows.Forms.MaskedTextBox mtbSecurity;
        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.MaskedTextBox mtbExpiry;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.MaskedTextBox mtxtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TabPage tabPageCash;
        private System.Windows.Forms.Panel panelCash;
        private ns1.BunifuThinButton2 btnPay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbminimize;
        private System.Windows.Forms.Label lbclose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ns1.BunifuThinButton2 btnPaymentCash;
        private System.Windows.Forms.Label lblPaymentAmountValue;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmountCashValue;
        private System.Windows.Forms.Label lblPaymentAmountCash;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}