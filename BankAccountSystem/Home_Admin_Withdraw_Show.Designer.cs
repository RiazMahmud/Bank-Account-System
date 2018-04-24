namespace BankAccountSystemUI
{
    partial class Home_Admin_Withdraw_Show
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
            this.label8 = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(183, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 29);
            this.label8.TabIndex = 140;
            this.label8.Text = "Enter Password";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.Transparent;
            this.yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.ForeColor = System.Drawing.Color.White;
            this.yes.Location = new System.Drawing.Point(124, 115);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(147, 30);
            this.yes.TabIndex = 142;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.Transparent;
            this.No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.No.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.ForeColor = System.Drawing.Color.White;
            this.No.Location = new System.Drawing.Point(293, 115);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(147, 30);
            this.No.TabIndex = 143;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(211, 64);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(147, 26);
            this.password.TabIndex = 144;
            // 
            // Home_Admin_Withdraw_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 181);
            this.Controls.Add(this.password);
            this.Controls.Add(this.No);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yes);
            this.Name = "Home_Admin_Withdraw_Show";
            this.Text = "Home_Admin_Withdraw_Show";
            this.Load += new System.EventHandler(this.Home_Admin_Withdraw_Show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.TextBox password;
    }
}