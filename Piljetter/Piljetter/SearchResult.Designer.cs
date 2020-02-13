namespace Piljetter
{
    partial class SearchResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.buy_ticketBtn = new System.Windows.Forms.Button();
            this.back_to_my_pageBtn = new System.Windows.Forms.Button();
            this.searchResultView = new System.Windows.Forms.DataGridView();
            this.BackToMyPageBtn = new System.Windows.Forms.Button();
            this.BuyTicketBtn = new System.Windows.Forms.Button();
            this.amountTicketsLbl = new System.Windows.Forms.Label();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            this.SuspendLayout();
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
            // searchResultView
            // 
            this.searchResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultView.Location = new System.Drawing.Point(0, 0);
            this.searchResultView.Name = "searchResultView";
            this.searchResultView.RowHeadersWidth = 62;
            this.searchResultView.RowTemplate.Height = 28;
            this.searchResultView.Size = new System.Drawing.Size(1503, 352);
            this.searchResultView.TabIndex = 4;
            // 
            // BackToMyPageBtn
            // 
            this.BackToMyPageBtn.Location = new System.Drawing.Point(12, 553);
            this.BackToMyPageBtn.Name = "BackToMyPageBtn";
            this.BackToMyPageBtn.Size = new System.Drawing.Size(172, 45);
            this.BackToMyPageBtn.TabIndex = 6;
            this.BackToMyPageBtn.Text = "Back to my page";
            this.BackToMyPageBtn.UseVisualStyleBackColor = true;
            this.BackToMyPageBtn.Click += new System.EventHandler(this.BackToMyPageBtn_Click);
            // 
            // BuyTicketBtn
            // 
            this.BuyTicketBtn.Location = new System.Drawing.Point(12, 388);
            this.BuyTicketBtn.Name = "BuyTicketBtn";
            this.BuyTicketBtn.Size = new System.Drawing.Size(172, 112);
            this.BuyTicketBtn.TabIndex = 7;
            this.BuyTicketBtn.Text = "Buy ticket";
            this.BuyTicketBtn.UseVisualStyleBackColor = true;
            this.BuyTicketBtn.Click += new System.EventHandler(this.BuyTicketBtn_Click);
            // 
            // amountTicketsLbl
            // 
            this.amountTicketsLbl.AutoSize = true;
            this.amountTicketsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTicketsLbl.Location = new System.Drawing.Point(194, 388);
            this.amountTicketsLbl.Name = "amountTicketsLbl";
            this.amountTicketsLbl.Size = new System.Drawing.Size(175, 25);
            this.amountTicketsLbl.TabIndex = 10;
            this.amountTicketsLbl.Text = "How many tickets?";
            // 
            // numTickets
            // 
            this.numTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTickets.Location = new System.Drawing.Point(394, 388);
            this.numTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(86, 30);
            this.numTickets.TabIndex = 11;
            this.numTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(205, 456);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 29);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Use coupons?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 610);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numTickets);
            this.Controls.Add(this.amountTicketsLbl);
            this.Controls.Add(this.BuyTicketBtn);
            this.Controls.Add(this.BackToMyPageBtn);
            this.Controls.Add(this.searchResultView);
            this.Controls.Add(this.back_to_my_pageBtn);
            this.Controls.Add(this.buy_ticketBtn);
            this.Controls.Add(this.label1);
            this.Name = "SearchResult";
            this.Text = "Search result";
            ((System.ComponentModel.ISupportInitialize)(this.searchResultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buy_ticketBtn;
        private System.Windows.Forms.Button back_to_my_pageBtn;
        private System.Windows.Forms.DataGridView searchResultView;
        private System.Windows.Forms.Button BackToMyPageBtn;
        private System.Windows.Forms.Button BuyTicketBtn;
        private System.Windows.Forms.Label amountTicketsLbl;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}