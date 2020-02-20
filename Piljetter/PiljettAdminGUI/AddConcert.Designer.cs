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
            this.concertDateSelect = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availableArtistsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableScenesView)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(736, 473);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(340, 73);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add concert";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backToMainPage
            // 
            this.backToMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainPage.Location = new System.Drawing.Point(736, 564);
            this.backToMainPage.Name = "backToMainPage";
            this.backToMainPage.Size = new System.Drawing.Size(340, 79);
            this.backToMainPage.TabIndex = 1;
            this.backToMainPage.Text = "Back to main page";
            this.backToMainPage.UseVisualStyleBackColor = true;
            this.backToMainPage.Click += new System.EventHandler(this.backToMainPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose scene";
            // 
            // availableArtistsView
            // 
            this.availableArtistsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableArtistsView.Location = new System.Drawing.Point(17, 63);
            this.availableArtistsView.Name = "availableArtistsView";
            this.availableArtistsView.RowHeadersWidth = 62;
            this.availableArtistsView.RowTemplate.Height = 28;
            this.availableArtistsView.Size = new System.Drawing.Size(680, 269);
            this.availableArtistsView.TabIndex = 4;
            // 
            // availableScenesView
            // 
            this.availableScenesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableScenesView.Location = new System.Drawing.Point(17, 391);
            this.availableScenesView.Name = "availableScenesView";
            this.availableScenesView.RowHeadersWidth = 62;
            this.availableScenesView.RowTemplate.Height = 28;
            this.availableScenesView.Size = new System.Drawing.Size(680, 252);
            this.availableScenesView.TabIndex = 5;
            // 
            // concertDateSelect
            // 
            this.concertDateSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concertDateSelect.Location = new System.Drawing.Point(736, 107);
            this.concertDateSelect.MinDate = new System.DateTime(2020, 2, 16, 0, 0, 0, 0);
            this.concertDateSelect.Name = "concertDateSelect";
            this.concertDateSelect.Size = new System.Drawing.Size(261, 30);
            this.concertDateSelect.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(731, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Choose date";
            // 
            // AddConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 666);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.concertDateSelect);
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
        private System.Windows.Forms.DateTimePicker concertDateSelect;
        private System.Windows.Forms.Label label6;
    }
}