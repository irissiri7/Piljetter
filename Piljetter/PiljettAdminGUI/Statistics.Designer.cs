namespace PiljettAdminGUI
{
    partial class Statistics
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
            this.statisticsView = new System.Windows.Forms.DataGridView();
            this.topArtistsBtn = new System.Windows.Forms.Button();
            this.couponOverviewBtn = new System.Windows.Forms.Button();
            this.couponOvervBtn = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsView)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsView
            // 
            this.statisticsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsView.Location = new System.Drawing.Point(464, 57);
            this.statisticsView.Name = "statisticsView";
            this.statisticsView.RowHeadersWidth = 62;
            this.statisticsView.RowTemplate.Height = 28;
            this.statisticsView.Size = new System.Drawing.Size(657, 568);
            this.statisticsView.TabIndex = 0;
            // 
            // topArtistsBtn
            // 
            this.topArtistsBtn.Location = new System.Drawing.Point(73, 212);
            this.topArtistsBtn.Name = "topArtistsBtn";
            this.topArtistsBtn.Size = new System.Drawing.Size(294, 90);
            this.topArtistsBtn.TabIndex = 1;
            this.topArtistsBtn.Text = "Top selling artists";
            this.topArtistsBtn.UseVisualStyleBackColor = true;
            this.topArtistsBtn.Click += new System.EventHandler(this.TopArtistsBtn_Click);
            // 
            // couponOverviewBtn
            // 
            this.couponOverviewBtn.Location = new System.Drawing.Point(73, 357);
            this.couponOverviewBtn.Name = "couponOverviewBtn";
            this.couponOverviewBtn.Size = new System.Drawing.Size(294, 84);
            this.couponOverviewBtn.TabIndex = 2;
            this.couponOverviewBtn.Text = "Cancelled concerts overview";
            this.couponOverviewBtn.UseVisualStyleBackColor = true;
            this.couponOverviewBtn.Click += new System.EventHandler(this.CancelledConcertsOverviewBtn_Click);
            // 
            // couponOvervBtn
            // 
            this.couponOvervBtn.Location = new System.Drawing.Point(73, 485);
            this.couponOvervBtn.Name = "couponOvervBtn";
            this.couponOvervBtn.Size = new System.Drawing.Size(294, 87);
            this.couponOvervBtn.TabIndex = 3;
            this.couponOvervBtn.Text = "Coupon overview";
            this.couponOvervBtn.UseVisualStyleBackColor = true;
            this.couponOvervBtn.Click += new System.EventHandler(this.CouponOvervBtn_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(167, 134);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(167, 166);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerTo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back to start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "See top selling artists for a given period.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start by selecting from and to dates.";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 689);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.couponOvervBtn);
            this.Controls.Add(this.couponOverviewBtn);
            this.Controls.Add(this.topArtistsBtn);
            this.Controls.Add(this.statisticsView);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.statisticsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticsView;
        private System.Windows.Forms.Button topArtistsBtn;
        private System.Windows.Forms.Button couponOverviewBtn;
        private System.Windows.Forms.Button couponOvervBtn;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}