namespace BasicQueuingCashier1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            label1 = new Label();
            lblNextCustomer = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(207, 40);
            label1.TabIndex = 0;
            label1.Text = "*Now Serving";
            // 
            // lblNextCustomer
            // 
            lblNextCustomer.AutoSize = true;
            lblNextCustomer.BackColor = Color.Transparent;
            lblNextCustomer.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNextCustomer.ForeColor = Color.Yellow;
            lblNextCustomer.Location = new Point(58, 93);
            lblNextCustomer.Name = "lblNextCustomer";
            lblNextCustomer.Size = new Size(228, 59);
            lblNextCustomer.TabIndex = 1;
            lblNextCustomer.Text = "No Queue";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(277, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 42);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(334, 211);
            Controls.Add(pictureBox1);
            Controls.Add(lblNextCustomer);
            Controls.Add(label1);
            Name = "CustomerView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNextCustomer;
        private PictureBox pictureBox1;
    }
}