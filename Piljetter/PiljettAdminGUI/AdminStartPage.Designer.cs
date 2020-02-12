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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.comingConcertsView = new System.Windows.Forms.DataGridView();
            this.comingConcertsLbl = new System.Windows.Forms.Label();
            this.checkBoxCoupons = new System.Windows.Forms.CheckBox();
            this.statisticsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comingConcertsView)).BeginInit();
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
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(23, 162);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(309, 52);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel Concert";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // comingConcertsView
            // 
            this.comingConcertsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comingConcertsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.comingConcertsView.Location = new System.Drawing.Point(402, 88);
            this.comingConcertsView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comingConcertsView.Name = "comingConcertsView";
            this.comingConcertsView.RowHeadersWidth = 62;
            this.comingConcertsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comingConcertsView.Size = new System.Drawing.Size(565, 588);
            this.comingConcertsView.TabIndex = 2;
            // 
            // comingConcertsLbl
            // 
            this.comingConcertsLbl.AutoSize = true;
            this.comingConcertsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingConcertsLbl.Location = new System.Drawing.Point(396, 36);
            this.comingConcertsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comingConcertsLbl.Name = "comingConcertsLbl";
            this.comingConcertsLbl.Size = new System.Drawing.Size(238, 36);
            this.comingConcertsLbl.TabIndex = 3;
            this.comingConcertsLbl.Text = "Coming concerts";
            // 
            // checkBoxCoupons
            // 
            this.checkBoxCoupons.AutoSize = true;
            this.checkBoxCoupons.Location = new System.Drawing.Point(23, 222);
            this.checkBoxCoupons.Name = "checkBoxCoupons";
            this.checkBoxCoupons.Size = new System.Drawing.Size(201, 24);
            this.checkBoxCoupons.TabIndex = 6;
            this.checkBoxCoupons.Text = "and also give coupons?";
            this.checkBoxCoupons.UseVisualStyleBackColor = true;
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Location = new System.Drawing.Point(103, 380);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(154, 90);
            this.statisticsBtn.TabIndex = 7;
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // AdminStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 852);
            this.Controls.Add(this.statisticsBtn);
            this.Controls.Add(this.checkBoxCoupons);
            this.Controls.Add(this.comingConcertsLbl);
            this.Controls.Add(this.comingConcertsView);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addConcertBtn);
            this.Name = "AdminStartPage";
            this.Text = "Start page";
            ((System.ComponentModel.ISupportInitialize)(this.comingConcertsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addConcertBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridView comingConcertsView;
        private System.Windows.Forms.Label comingConcertsLbl;
        private System.Windows.Forms.CheckBox checkBoxCoupons;
        private System.Windows.Forms.Button statisticsBtn;
    }
}

