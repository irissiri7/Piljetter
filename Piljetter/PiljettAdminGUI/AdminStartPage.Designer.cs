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
            this.concertOverview = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addConcertBtn
            // 
            this.addConcertBtn.Location = new System.Drawing.Point(23, 88);
            this.addConcertBtn.Name = "addConcertBtn";
            this.addConcertBtn.Size = new System.Drawing.Size(310, 55);
            this.addConcertBtn.TabIndex = 0;
            this.addConcertBtn.Text = "Add concert";
            this.addConcertBtn.UseVisualStyleBackColor = true;
            this.addConcertBtn.Click += new System.EventHandler(this.addConcertBtn_Click);
            // 
            // concertOverview
            // 
            this.concertOverview.Location = new System.Drawing.Point(23, 162);
            this.concertOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.concertOverview.Name = "concertOverview";
            this.concertOverview.Size = new System.Drawing.Size(309, 52);
            this.concertOverview.TabIndex = 1;
            this.concertOverview.Text = "Concerts Overview";
            this.concertOverview.UseVisualStyleBackColor = true;
            this.concertOverview.Click += new System.EventHandler(this.concertsOverviewBtn_Click);
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Location = new System.Drawing.Point(23, 238);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(309, 56);
            this.statisticsBtn.TabIndex = 7;
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // AdminStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 337);
            this.Controls.Add(this.statisticsBtn);
            this.Controls.Add(this.concertOverview);
            this.Controls.Add(this.addConcertBtn);
            this.Name = "AdminStartPage";
            this.Text = "Start page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addConcertBtn;
        private System.Windows.Forms.Button concertOverview;
        private System.Windows.Forms.Button statisticsBtn;
    }
}

