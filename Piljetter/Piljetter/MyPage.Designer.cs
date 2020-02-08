namespace Piljetter
{
    partial class MyPage
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
            this.search_concertBtn = new System.Windows.Forms.Button();
            this.My_purchasesBtn = new System.Windows.Forms.Button();
            this.My_CouponsBtn = new System.Windows.Forms.Button();
            this.Refill_pesetasBtn = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.Pesetas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_concertBtn
            // 
            this.search_concertBtn.Location = new System.Drawing.Point(21, 92);
            this.search_concertBtn.Name = "search_concertBtn";
            this.search_concertBtn.Size = new System.Drawing.Size(225, 77);
            this.search_concertBtn.TabIndex = 0;
            this.search_concertBtn.Text = "Search concert";
            this.search_concertBtn.UseVisualStyleBackColor = true;
            this.search_concertBtn.Click += new System.EventHandler(this.search_concertBtn_Click);
            // 
            // My_purchasesBtn
            // 
            this.My_purchasesBtn.Location = new System.Drawing.Point(21, 340);
            this.My_purchasesBtn.Name = "My_purchasesBtn";
            this.My_purchasesBtn.Size = new System.Drawing.Size(225, 77);
            this.My_purchasesBtn.TabIndex = 2;
            this.My_purchasesBtn.Text = "My purchases";
            this.My_purchasesBtn.UseVisualStyleBackColor = true;
            this.My_purchasesBtn.Click += new System.EventHandler(this.My_purchasesBtn_Click);
            // 
            // My_CouponsBtn
            // 
            this.My_CouponsBtn.Location = new System.Drawing.Point(21, 458);
            this.My_CouponsBtn.Name = "My_CouponsBtn";
            this.My_CouponsBtn.Size = new System.Drawing.Size(225, 77);
            this.My_CouponsBtn.TabIndex = 3;
            this.My_CouponsBtn.Text = "My coupons";
            this.My_CouponsBtn.UseVisualStyleBackColor = true;
            this.My_CouponsBtn.Click += new System.EventHandler(this.My_CouponsBtn_Click);
            // 
            // Refill_pesetasBtn
            // 
            this.Refill_pesetasBtn.Location = new System.Drawing.Point(21, 221);
            this.Refill_pesetasBtn.Name = "Refill_pesetasBtn";
            this.Refill_pesetasBtn.Size = new System.Drawing.Size(225, 73);
            this.Refill_pesetasBtn.TabIndex = 4;
            this.Refill_pesetasBtn.Text = "Refill pesetas";
            this.Refill_pesetasBtn.UseVisualStyleBackColor = true;
            this.Refill_pesetasBtn.Click += new System.EventHandler(this.Refill_pesetasBtn_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(15, 19);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(95, 36);
            this.Name.TabIndex = 5;
            this.Name.Text = "label1";
            // 
            // Pesetas
            // 
            this.Pesetas.AutoSize = true;
            this.Pesetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesetas.Location = new System.Drawing.Point(15, 578);
            this.Pesetas.Name = "Pesetas";
            this.Pesetas.Size = new System.Drawing.Size(95, 36);
            this.Pesetas.TabIndex = 6;
            this.Pesetas.Text = "label2";
            // 
            // MyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 638);
            this.Controls.Add(this.Pesetas);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Refill_pesetasBtn);
            this.Controls.Add(this.My_CouponsBtn);
            this.Controls.Add(this.My_purchasesBtn);
            this.Controls.Add(this.search_concertBtn);
            //this.Name = "MyPage";
            this.Text = "My page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_concertBtn;
        private System.Windows.Forms.Button My_purchasesBtn;
        private System.Windows.Forms.Button My_CouponsBtn;
        private System.Windows.Forms.Button Refill_pesetasBtn;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Pesetas;
    }
}