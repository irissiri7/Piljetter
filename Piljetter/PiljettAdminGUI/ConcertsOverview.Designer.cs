namespace PiljettAdminGUI
{
    partial class ConcertsOverview
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
            this.comingConcertsView = new System.Windows.Forms.DataGridView();
            this.cancelConcertBtn = new System.Windows.Forms.Button();
            this.couponsCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backToStartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comingConcertsView)).BeginInit();
            this.SuspendLayout();
            // 
            // comingConcertsView
            // 
            this.comingConcertsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comingConcertsView.Location = new System.Drawing.Point(12, 95);
            this.comingConcertsView.Name = "comingConcertsView";
            this.comingConcertsView.RowHeadersWidth = 62;
            this.comingConcertsView.RowTemplate.Height = 28;
            this.comingConcertsView.Size = new System.Drawing.Size(1281, 361);
            this.comingConcertsView.TabIndex = 0;
            // 
            // cancelConcertBtn
            // 
            this.cancelConcertBtn.Location = new System.Drawing.Point(12, 501);
            this.cancelConcertBtn.Name = "cancelConcertBtn";
            this.cancelConcertBtn.Size = new System.Drawing.Size(154, 69);
            this.cancelConcertBtn.TabIndex = 1;
            this.cancelConcertBtn.Text = "Cancel concert";
            this.cancelConcertBtn.UseVisualStyleBackColor = true;
            this.cancelConcertBtn.Click += new System.EventHandler(this.cancelConcertBtn_Click);
            // 
            // couponsCheckBox
            // 
            this.couponsCheckBox.AutoSize = true;
            this.couponsCheckBox.Location = new System.Drawing.Point(186, 546);
            this.couponsCheckBox.Name = "couponsCheckBox";
            this.couponsCheckBox.Size = new System.Drawing.Size(137, 24);
            this.couponsCheckBox.TabIndex = 2;
            this.couponsCheckBox.Text = "give coupons?";
            this.couponsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Overview of comming concerts and their expected revenue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(901, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select the concert you wish to cancel from the table and press \'Cancel concert\'. " +
    "Don\'t forget to grant coupons if its short notice!";
            // 
            // backToStartBtn
            // 
            this.backToStartBtn.Location = new System.Drawing.Point(18, 587);
            this.backToStartBtn.Name = "backToStartBtn";
            this.backToStartBtn.Size = new System.Drawing.Size(148, 72);
            this.backToStartBtn.TabIndex = 5;
            this.backToStartBtn.Text = "Back to start";
            this.backToStartBtn.UseVisualStyleBackColor = true;
            this.backToStartBtn.Click += new System.EventHandler(this.backToStartBtn_Click);
            // 
            // ConcertsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 671);
            this.Controls.Add(this.backToStartBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.couponsCheckBox);
            this.Controls.Add(this.cancelConcertBtn);
            this.Controls.Add(this.comingConcertsView);
            this.Name = "ConcertsOverview";
            this.Text = "ConcertsOverview";
            ((System.ComponentModel.ISupportInitialize)(this.comingConcertsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView comingConcertsView;
        private System.Windows.Forms.Button cancelConcertBtn;
        private System.Windows.Forms.CheckBox couponsCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backToStartBtn;
    }
}