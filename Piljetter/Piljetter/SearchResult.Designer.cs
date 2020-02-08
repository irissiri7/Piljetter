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
            this.searchResultTable = new System.Windows.Forms.DataGridView();
            this.BackToMyPageBtn = new System.Windows.Forms.Button();
            this.BuyTicketBtn = new System.Windows.Forms.Button();
            this.ConcertIdLbl = new System.Windows.Forms.Label();
            this.amountTicketsLbl = new System.Windows.Forms.Label();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.concertId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertId)).BeginInit();
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
            // searchResultTable
            // 
            this.searchResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultTable.Location = new System.Drawing.Point(0, 0);
            this.searchResultTable.Name = "searchResultTable";
            this.searchResultTable.RowHeadersWidth = 62;
            this.searchResultTable.RowTemplate.Height = 28;
            this.searchResultTable.Size = new System.Drawing.Size(1503, 352);
            this.searchResultTable.TabIndex = 4;
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
            this.BuyTicketBtn.Size = new System.Drawing.Size(172, 148);
            this.BuyTicketBtn.TabIndex = 7;
            this.BuyTicketBtn.Text = "Buy ticket";
            this.BuyTicketBtn.UseVisualStyleBackColor = true;
            this.BuyTicketBtn.Click += new System.EventHandler(this.BuyTicketBtn_Click);
            // 
            // ConcertIdLbl
            // 
            this.ConcertIdLbl.AutoSize = true;
            this.ConcertIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConcertIdLbl.Location = new System.Drawing.Point(202, 388);
            this.ConcertIdLbl.Name = "ConcertIdLbl";
            this.ConcertIdLbl.Size = new System.Drawing.Size(168, 25);
            this.ConcertIdLbl.TabIndex = 9;
            this.ConcertIdLbl.Text = "Enter id of concert";
            // 
            // amountTicketsLbl
            // 
            this.amountTicketsLbl.AutoSize = true;
            this.amountTicketsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTicketsLbl.Location = new System.Drawing.Point(202, 448);
            this.amountTicketsLbl.Name = "amountTicketsLbl";
            this.amountTicketsLbl.Size = new System.Drawing.Size(175, 25);
            this.amountTicketsLbl.TabIndex = 10;
            this.amountTicketsLbl.Text = "How many tickets?";
            // 
            // numTickets
            // 
            this.numTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTickets.Location = new System.Drawing.Point(405, 448);
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
            // concertId
            // 
            this.concertId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concertId.Location = new System.Drawing.Point(405, 386);
            this.concertId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.concertId.Name = "concertId";
            this.concertId.Size = new System.Drawing.Size(88, 30);
            this.concertId.TabIndex = 12;
            this.concertId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 610);
            this.Controls.Add(this.concertId);
            this.Controls.Add(this.numTickets);
            this.Controls.Add(this.amountTicketsLbl);
            this.Controls.Add(this.ConcertIdLbl);
            this.Controls.Add(this.BuyTicketBtn);
            this.Controls.Add(this.BackToMyPageBtn);
            this.Controls.Add(this.searchResultTable);
            this.Controls.Add(this.back_to_my_pageBtn);
            this.Controls.Add(this.buy_ticketBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Search result";
            ((System.ComponentModel.ISupportInitialize)(this.searchResultTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buy_ticketBtn;
        private System.Windows.Forms.Button back_to_my_pageBtn;
        private System.Windows.Forms.DataGridView searchResultTable;
        private System.Windows.Forms.Button BackToMyPageBtn;
        private System.Windows.Forms.Button BuyTicketBtn;
        private System.Windows.Forms.Label ConcertIdLbl;
        private System.Windows.Forms.Label amountTicketsLbl;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.NumericUpDown concertId;
    }
}