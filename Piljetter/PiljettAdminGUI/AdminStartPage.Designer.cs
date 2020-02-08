namespace PiljettAdminGUI
{
    partial class AdminStartPage
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
            this.addConcertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addConcertBtn
            // 
            this.addConcertBtn.Location = new System.Drawing.Point(78, 28);
            this.addConcertBtn.Name = "addConcertBtn";
            this.addConcertBtn.Size = new System.Drawing.Size(141, 55);
            this.addConcertBtn.TabIndex = 0;
            this.addConcertBtn.Text = "Add concert";
            this.addConcertBtn.UseVisualStyleBackColor = true;
            this.addConcertBtn.Click += new System.EventHandler(this.addConcertBtn_Click);
            // 
            // AdminStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.addConcertBtn);
            this.Name = "AdminStartPage";
            this.Text = "Start page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addConcertBtn;
    }
}

