namespace Piljetter
{
    partial class Form4
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
            this.searchResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buy_ticketBtn = new System.Windows.Forms.Button();
            this.back_to_my_pageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchResult
            // 
            this.searchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult.FormattingEnabled = true;
            this.searchResult.ItemHeight = 20;
            this.searchResult.Location = new System.Drawing.Point(0, 89);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(4028, 720);
            this.searchResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Results";
            // 
            // buy_ticketBtn
            // 
            this.buy_ticketBtn.Location = new System.Drawing.Point(83, 682);
            this.buy_ticketBtn.Name = "buy_ticketBtn";
            this.buy_ticketBtn.Size = new System.Drawing.Size(270, 122);
            this.buy_ticketBtn.TabIndex = 2;
            this.buy_ticketBtn.Text = "Buy ticket";
            this.buy_ticketBtn.UseVisualStyleBackColor = true;
            // 
            // back_to_my_pageBtn
            // 
            this.back_to_my_pageBtn.Location = new System.Drawing.Point(417, 682);
            this.back_to_my_pageBtn.Name = "back_to_my_pageBtn";
            this.back_to_my_pageBtn.Size = new System.Drawing.Size(270, 122);
            this.back_to_my_pageBtn.TabIndex = 3;
            this.back_to_my_pageBtn.Text = "Back to my page";
            this.back_to_my_pageBtn.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 919);
            this.Controls.Add(this.back_to_my_pageBtn);
            this.Controls.Add(this.buy_ticketBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchResult);
            this.Name = "Form4";
            this.Text = "Search result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox searchResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buy_ticketBtn;
        private System.Windows.Forms.Button back_to_my_pageBtn;
    }
}