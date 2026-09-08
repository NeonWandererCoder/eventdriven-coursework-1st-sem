namespace BasicQueuingCashier
{
    partial class CustomerView
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
            this.lblNowServingCaption = new System.Windows.Forms.Label();
            this.lblNowServing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNowServingCaption
            // 
            this.lblNowServingCaption.AutoSize = true;
            this.lblNowServingCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNowServingCaption.Location = new System.Drawing.Point(30, 30);
            this.lblNowServingCaption.Name = "lblNowServingCaption";
            this.lblNowServingCaption.Size = new System.Drawing.Size(150, 24);
            this.lblNowServingCaption.TabIndex = 0;
            this.lblNowServingCaption.Text = "*Now Serving";
            // 
            // lblNowServing
            // 
            this.lblNowServing.AutoSize = true;
            this.lblNowServing.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblNowServing.Location = new System.Drawing.Point(30, 70);
            this.lblNowServing.Name = "lblNowServing";
            this.lblNowServing.Size = new System.Drawing.Size(0, 55);
            this.lblNowServing.TabIndex = 1;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblNowServingCaption);
            this.Controls.Add(this.lblNowServing);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNowServingCaption;
        private System.Windows.Forms.Label lblNowServing;
    }
}