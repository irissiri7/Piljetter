namespace Piljetter
{
    partial class CouponRecord
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
            this.couponGridView = new System.Windows.Forms.DataGridView();
            this.backToMyPageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.couponGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // couponGridView
            // 
            this.couponGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couponGridView.Location = new System.Drawing.Point(0, 0);
            this.couponGridView.Name = "couponGridView";
            this.couponGridView.RowHeadersWidth = 62;
            this.couponGridView.RowTemplate.Height = 28;
            this.couponGridView.Size = new System.Drawing.Size(763, 301);
            this.couponGridView.TabIndex = 0;
            // 
            // backToMyPageBtn
            // 
            this.backToMyPageBtn.Location = new System.Drawing.Point(12, 318);
            this.backToMyPageBtn.Name = "backToMyPageBtn";
            this.backToMyPageBtn.Size = new System.Drawing.Size(192, 88);
            this.backToMyPageBtn.TabIndex = 1;
            this.backToMyPageBtn.Text = "Back to my page";
            this.backToMyPageBtn.UseVisualStyleBackColor = true;
            this.backToMyPageBtn.Click += new System.EventHandler(this.backToMyPageBtn_Click);
            // 
            // CouponRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 422);
            this.Controls.Add(this.backToMyPageBtn);
            this.Controls.Add(this.couponGridView);
            this.Name = "CouponRecord";
            this.Text = "CouponRecord";
            ((System.ComponentModel.ISupportInitialize)(this.couponGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView couponGridView;
        private System.Windows.Forms.Button backToMyPageBtn;
    }
}