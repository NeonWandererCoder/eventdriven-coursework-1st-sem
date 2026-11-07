namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Basic Calculator";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Consolas", 14F);
            this.txtNumber1.Location = new System.Drawing.Point(20, 55);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(250, 30);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.Text = "0";
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.Font = new System.Drawing.Font("Consolas", 11F);
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(115, 95);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(60, 25);
            this.cbOperator.TabIndex = 2;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Consolas", 14F);
            this.txtNumber2.Location = new System.Drawing.Point(20, 130);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(250, 30);
            this.txtNumber2.TabIndex = 3;
            this.txtNumber2.Text = "0";
            this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.Black;
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.lblTotalCaption);
            this.pnlTotal.Location = new System.Drawing.Point(20, 175);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(250, 85);
            this.pnlTotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 20F);
            this.lblTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotal.Location = new System.Drawing.Point(8, 35);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(114, 32);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "000000";
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalCaption.Location = new System.Drawing.Point(8, 10);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(56, 16);
            this.lblTotalCaption.TabIndex = 0;
            this.lblTotalCaption.Text = "Total:";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(95, 280);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(100, 30);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 330);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.btnCompute);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Button btnCompute;
    }
}
