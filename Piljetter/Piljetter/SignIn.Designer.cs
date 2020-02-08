namespace Piljetter
{
    partial class SignIn
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
            this.Name = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(29, 69);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(92, 36);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(29, 120);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(147, 36);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(46, 371);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(130, 60);
            this.LogIn.TabIndex = 2;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(243, 371);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(117, 60);
            this.Register.TabIndex = 3;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(203, 79);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(203, 26);
            this.Nametxt.TabIndex = 4;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(203, 130);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(203, 26);
            this.Passwordtxt.TabIndex = 5;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 507);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Name);
            //this.Name = "SignIn";
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
    }
}

