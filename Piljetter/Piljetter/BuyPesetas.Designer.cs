namespace Piljetter
{
    partial class BuyPesetas
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
            this.amountLbl = new System.Windows.Forms.Label();
            this.numOfPesetasUpDown = new System.Windows.Forms.NumericUpDown();
            this.buyBtn = new System.Windows.Forms.Button();
            this.backToMyPageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPesetasUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.Location = new System.Drawing.Point(119, 47);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(571, 36);
            this.amountLbl.TabIndex = 0;
            this.amountLbl.Text = "How much pesetas would you like to buy?";
            // 
            // numOfPesetasUpDown
            // 
            this.numOfPesetasUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPesetasUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numOfPesetasUpDown.Location = new System.Drawing.Point(295, 105);
            this.numOfPesetasUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numOfPesetasUpDown.Name = "numOfPesetasUpDown";
            this.numOfPesetasUpDown.Size = new System.Drawing.Size(180, 41);
            this.numOfPesetasUpDown.TabIndex = 1;
            this.numOfPesetasUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buyBtn
            // 
            this.buyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.Location = new System.Drawing.Point(250, 168);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(253, 105);
            this.buyBtn.TabIndex = 2;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // backToMyPageBtn
            // 
            this.backToMyPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMyPageBtn.Location = new System.Drawing.Point(12, 312);
            this.backToMyPageBtn.Name = "backToMyPageBtn";
            this.backToMyPageBtn.Size = new System.Drawing.Size(191, 51);
            this.backToMyPageBtn.TabIndex = 3;
            this.backToMyPageBtn.Text = "Back to my page";
            this.backToMyPageBtn.UseVisualStyleBackColor = true;
            this.backToMyPageBtn.Click += new System.EventHandler(this.backToMyPageBtn_Click);
            // 
            // BuyPesetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.backToMyPageBtn);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.numOfPesetasUpDown);
            this.Controls.Add(this.amountLbl);
            this.Name = "BuyPesetas";
            this.Text = "BuyPesetas";
            ((System.ComponentModel.ISupportInitialize)(this.numOfPesetasUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.NumericUpDown numOfPesetasUpDown;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button backToMyPageBtn;
    }
}