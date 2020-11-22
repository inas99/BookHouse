namespace BookHouseOOP
{
    partial class CustomerUserControl
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
            this.lblTotalAmountSpentValue = new System.Windows.Forms.Label();
            this.lblSurnameValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalAmountSpentValue
            // 
            this.lblTotalAmountSpentValue.AutoSize = true;
            this.lblTotalAmountSpentValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmountSpentValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmountSpentValue.Location = new System.Drawing.Point(113, 122);
            this.lblTotalAmountSpentValue.Name = "lblTotalAmountSpentValue";
            this.lblTotalAmountSpentValue.Size = new System.Drawing.Size(0, 28);
            this.lblTotalAmountSpentValue.TabIndex = 11;
            // 
            // lblSurnameValue
            // 
            this.lblSurnameValue.AutoSize = true;
            this.lblSurnameValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurnameValue.ForeColor = System.Drawing.Color.Black;
            this.lblSurnameValue.Location = new System.Drawing.Point(113, 69);
            this.lblSurnameValue.Name = "lblSurnameValue";
            this.lblSurnameValue.Size = new System.Drawing.Size(0, 28);
            this.lblSurnameValue.TabIndex = 10;
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameValue.ForeColor = System.Drawing.Color.Black;
            this.lblNameValue.Location = new System.Drawing.Point(113, 24);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(0, 28);
            this.lblNameValue.TabIndex = 9;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(15, 122);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(68, 29);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Spent";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(15, 69);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(95, 29);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(15, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 29);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // CustomerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTotalAmountSpentValue);
            this.Controls.Add(this.lblSurnameValue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CustomerUserControl";
            this.Size = new System.Drawing.Size(308, 194);
            this.Load += new System.EventHandler(this.CustomerUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalAmountSpentValue;
        private System.Windows.Forms.Label lblSurnameValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
    }
}
