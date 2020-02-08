namespace PiljettAdminGUI
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
            this.artistId = new System.Windows.Forms.NumericUpDown();
            this.sceneId = new System.Windows.Forms.NumericUpDown();
            this.concertDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availableArtistsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableScenesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneId)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 316);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 49);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // backToMainPage
            // 
            this.backToMainPage.Location = new System.Drawing.Point(12, 380);
            this.backToMainPage.Name = "backToMainPage";
            this.backToMainPage.Size = new System.Drawing.Size(120, 49);
            this.backToMainPage.TabIndex = 1;
            this.backToMainPage.Text = "Back to main page";
            this.backToMainPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available artists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available scenes";
            // 
            // availableArtistsView
            // 
            this.availableArtistsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableArtistsView.Location = new System.Drawing.Point(419, 56);
            this.availableArtistsView.Name = "availableArtistsView";
            this.availableArtistsView.RowHeadersWidth = 62;
            this.availableArtistsView.RowTemplate.Height = 28;
            this.availableArtistsView.Size = new System.Drawing.Size(240, 150);
            this.availableArtistsView.TabIndex = 4;
            // 
            // availableScenesView
            // 
            this.availableScenesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableScenesView.Location = new System.Drawing.Point(419, 259);
            this.availableScenesView.Name = "availableScenesView";
            this.availableScenesView.RowHeadersWidth = 62;
            this.availableScenesView.RowTemplate.Height = 28;
            this.availableScenesView.Size = new System.Drawing.Size(240, 150);
            this.availableScenesView.TabIndex = 5;
            // 
            // artistId
            // 
            this.artistId.Location = new System.Drawing.Point(144, 121);
            this.artistId.Name = "artistId";
            this.artistId.Size = new System.Drawing.Size(120, 26);
            this.artistId.TabIndex = 6;
            // 
            // sceneId
            // 
            this.sceneId.Location = new System.Drawing.Point(144, 194);
            this.sceneId.Name = "sceneId";
            this.sceneId.Size = new System.Drawing.Size(120, 26);
            this.sceneId.TabIndex = 7;
            // 
            // concertDate
            // 
            this.concertDate.Location = new System.Drawing.Point(144, 259);
            this.concertDate.Name = "concertDate";
            this.concertDate.Size = new System.Drawing.Size(200, 26);
            this.concertDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Artist Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Scene Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter details and press \"Add\"";
            // 
            // AddConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.concertDate);
            this.Controls.Add(this.sceneId);
            this.Controls.Add(this.artistId);
            this.Controls.Add(this.availableScenesView);
            this.Controls.Add(this.availableArtistsView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToMainPage);
            this.Controls.Add(this.addBtn);
            this.Name = "AddConcert";
            this.Text = "AddConcert";
            ((System.ComponentModel.ISupportInitialize)(this.availableArtistsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableScenesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneId)).EndInit();
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
        private System.Windows.Forms.NumericUpDown artistId;
        private System.Windows.Forms.NumericUpDown sceneId;
        private System.Windows.Forms.DateTimePicker concertDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}