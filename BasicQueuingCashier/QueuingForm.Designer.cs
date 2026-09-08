namespace BasicQueuingCashier
{
    partial class QueuingForm
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
            this.btnCashier = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblPositionCaption = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCashier
            // 
            this.btnCashier.Location = new System.Drawing.Point(30, 30);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(120, 90);
            this.btnCashier.TabIndex = 0;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction.Location = new System.Drawing.Point(27, 130);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(112, 13);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "*Click to get a number";
            // 
            // lblPositionCaption
            // 
            this.lblPositionCaption.AutoSize = true;
            this.lblPositionCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPositionCaption.Location = new System.Drawing.Point(200, 30);
            this.lblPositionCaption.Name = "lblPositionCaption";
            this.lblPositionCaption.Size = new System.Drawing.Size(180, 24);
            this.lblPositionCaption.TabIndex = 2;
            this.lblPositionCaption.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblQueue.Location = new System.Drawing.Point(200, 65);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(0, 55);
            this.lblQueue.TabIndex = 3;
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblPositionCaption);
            this.Controls.Add(this.lblQueue);
            this.Name = "QueuingForm";
            this.Text = "QueuingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblPositionCaption;
        private System.Windows.Forms.Label lblQueue;
    }
}