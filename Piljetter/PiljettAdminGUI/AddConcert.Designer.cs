﻿namespace PiljettAdminGUI
{
    partial class AddConcert
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
            this.addBtn = new System.Windows.Forms.Button();
            this.backToMainPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.availableArtistsView = new System.Windows.Forms.DataGridView();
            this.availableScenesView = new System.Windows.Forms.DataGridView();
            this.artistIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.sceneIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.concertDateSelect = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availableArtistsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableScenesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistIdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneIdUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(8, 346);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(80, 32);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backToMainPage
            // 
            this.backToMainPage.Location = new System.Drawing.Point(8, 393);
            this.backToMainPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backToMainPage.Name = "backToMainPage";
            this.backToMainPage.Size = new System.Drawing.Size(80, 32);
            this.backToMainPage.TabIndex = 1;
            this.backToMainPage.Text = "Back to main page";
            this.backToMainPage.UseVisualStyleBackColor = true;
            this.backToMainPage.Click += new System.EventHandler(this.backToMainPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available artists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available scenes";
            // 
            // availableArtistsView
            // 
            this.availableArtistsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableArtistsView.Location = new System.Drawing.Point(279, 36);
            this.availableArtistsView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.availableArtistsView.Name = "availableArtistsView";
            this.availableArtistsView.RowHeadersWidth = 62;
            this.availableArtistsView.RowTemplate.Height = 28;
            this.availableArtistsView.Size = new System.Drawing.Size(453, 175);
            this.availableArtistsView.TabIndex = 4;
            // 
            // availableScenesView
            // 
            this.availableScenesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableScenesView.Location = new System.Drawing.Point(279, 255);
            this.availableScenesView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.availableScenesView.Name = "availableScenesView";
            this.availableScenesView.RowHeadersWidth = 62;
            this.availableScenesView.RowTemplate.Height = 28;
            this.availableScenesView.Size = new System.Drawing.Size(453, 164);
            this.availableScenesView.TabIndex = 5;
            // 
            // artistIdUpDown
            // 
            this.artistIdUpDown.Location = new System.Drawing.Point(96, 79);
            this.artistIdUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artistIdUpDown.Name = "artistIdUpDown";
            this.artistIdUpDown.Size = new System.Drawing.Size(80, 20);
            this.artistIdUpDown.TabIndex = 6;
            // 
            // sceneIdUpDown
            // 
            this.sceneIdUpDown.Location = new System.Drawing.Point(96, 126);
            this.sceneIdUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sceneIdUpDown.Name = "sceneIdUpDown";
            this.sceneIdUpDown.Size = new System.Drawing.Size(80, 20);
            this.sceneIdUpDown.TabIndex = 7;
            // 
            // concertDateSelect
            // 
            this.concertDateSelect.Location = new System.Drawing.Point(96, 168);
            this.concertDateSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.concertDateSelect.Name = "concertDateSelect";
            this.concertDateSelect.Size = new System.Drawing.Size(135, 20);
            this.concertDateSelect.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Artist Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Scene Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter details and press \"Add\"";
            // 
            // AddConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.concertDateSelect);
            this.Controls.Add(this.sceneIdUpDown);
            this.Controls.Add(this.artistIdUpDown);
            this.Controls.Add(this.availableScenesView);
            this.Controls.Add(this.availableArtistsView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToMainPage);
            this.Controls.Add(this.addBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddConcert";
            this.Text = "AddConcert";
            ((System.ComponentModel.ISupportInitialize)(this.availableArtistsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableScenesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistIdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneIdUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backToMainPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView availableArtistsView;
        private System.Windows.Forms.DataGridView availableScenesView;
        private System.Windows.Forms.NumericUpDown artistIdUpDown;
        private System.Windows.Forms.NumericUpDown sceneIdUpDown;
        private System.Windows.Forms.DateTimePicker concertDateSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}