namespace Piljetter
{
    partial class PurchaseHistoryResults
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
            this.PurchaseHistoryGrid = new System.Windows.Forms.DataGridView();
            this.backToMypageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseHistoryGrid
            // 
            this.PurchaseHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.PurchaseHistoryGrid.Name = "PurchaseHistoryGrid";
            this.PurchaseHistoryGrid.RowHeadersWidth = 62;
            this.PurchaseHistoryGrid.RowTemplate.Height = 28;
            this.PurchaseHistoryGrid.Size = new System.Drawing.Size(797, 295);
            this.PurchaseHistoryGrid.TabIndex = 0;
            // 
            // backToMypageBtn
            // 
            this.backToMypageBtn.Location = new System.Drawing.Point(36, 345);
            this.backToMypageBtn.Name = "backToMypageBtn";
            this.backToMypageBtn.Size = new System.Drawing.Size(161, 47);
            this.backToMypageBtn.TabIndex = 2;
            this.backToMypageBtn.Text = "Back to my page";
            this.backToMypageBtn.UseVisualStyleBackColor = true;
            this.backToMypageBtn.Click += new System.EventHandler(this.backToMypageBtn_Click);
            // 
            // PurchaseHistoryResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToMypageBtn);
            this.Controls.Add(this.PurchaseHistoryGrid);
            this.Name = "PurchaseHistoryResults";
            this.Text = "PurchaseHistoryResults";
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchaseHistoryGrid;
        private System.Windows.Forms.Button backToMypageBtn;
    }
}