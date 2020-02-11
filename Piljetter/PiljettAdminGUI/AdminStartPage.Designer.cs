namespace PiljettAdminGUI
{
    partial class AdminStartPage
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
            this.addConcertBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.comingConcertsView = new System.Windows.Forms.DataGridView();
            this.comingConcertsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passedConcertsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.comingConcertsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passedConcertsView)).BeginInit();
            this.SuspendLayout();
            // 
            // addConcertBtn
            // 
            this.addConcertBtn.Location = new System.Drawing.Point(60, 67);
            this.addConcertBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addConcertBtn.Name = "addConcertBtn";
            this.addConcertBtn.Size = new System.Drawing.Size(207, 36);
            this.addConcertBtn.TabIndex = 0;
            this.addConcertBtn.Text = "Add concert";
            this.addConcertBtn.UseVisualStyleBackColor = true;
            this.addConcertBtn.Click += new System.EventHandler(this.addConcertBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(61, 118);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(206, 34);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel Concert";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // comingConcertsView
            // 
            this.comingConcertsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comingConcertsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.comingConcertsView.Location = new System.Drawing.Point(430, 67);
            this.comingConcertsView.Name = "comingConcertsView";
            this.comingConcertsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comingConcertsView.Size = new System.Drawing.Size(450, 186);
            this.comingConcertsView.TabIndex = 2;
            // 
            // comingConcertsLbl
            // 
            this.comingConcertsLbl.AutoSize = true;
            this.comingConcertsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingConcertsLbl.Location = new System.Drawing.Point(425, 36);
            this.comingConcertsLbl.Name = "comingConcertsLbl";
            this.comingConcertsLbl.Size = new System.Drawing.Size(159, 25);
            this.comingConcertsLbl.TabIndex = 3;
            this.comingConcertsLbl.Text = "Coming concerts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Passed concerts";
            // 
            // passedConcertsView
            // 
            this.passedConcertsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passedConcertsView.Enabled = false;
            this.passedConcertsView.Location = new System.Drawing.Point(430, 321);
            this.passedConcertsView.MultiSelect = false;
            this.passedConcertsView.Name = "passedConcertsView";
            this.passedConcertsView.Size = new System.Drawing.Size(450, 186);
            this.passedConcertsView.TabIndex = 5;
            // 
            // AdminStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 554);
            this.Controls.Add(this.passedConcertsView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comingConcertsLbl);
            this.Controls.Add(this.comingConcertsView);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addConcertBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminStartPage";
            this.Text = "Start page";
            ((System.ComponentModel.ISupportInitialize)(this.comingConcertsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passedConcertsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addConcertBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridView comingConcertsView;
        private System.Windows.Forms.Label comingConcertsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView passedConcertsView;
    }
}

