namespace BankAccountSystemUI
{
    partial class Home_Admin_AccountUpdate
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
            this.accountUpdateSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GoUpdateAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountUpdateSearch
            // 
            this.accountUpdateSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountUpdateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountUpdateSearch.Location = new System.Drawing.Point(273, 45);
            this.accountUpdateSearch.Name = "accountUpdateSearch";
            this.accountUpdateSearch.Size = new System.Drawing.Size(147, 26);
            this.accountUpdateSearch.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Enter User ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GoUpdateAccount
            // 
            this.GoUpdateAccount.BackColor = System.Drawing.Color.Transparent;
            this.GoUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoUpdateAccount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.GoUpdateAccount.Location = new System.Drawing.Point(273, 77);
            this.GoUpdateAccount.Name = "GoUpdateAccount";
            this.GoUpdateAccount.Size = new System.Drawing.Size(147, 30);
            this.GoUpdateAccount.TabIndex = 104;
            this.GoUpdateAccount.Text = "Ok";
            this.GoUpdateAccount.UseVisualStyleBackColor = false;
            this.GoUpdateAccount.Click += new System.EventHandler(this.GoUpdateAccount_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(447, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 140;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home_Admin_AccountUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoUpdateAccount);
            this.Controls.Add(this.accountUpdateSearch);
            this.Name = "Home_Admin_AccountUpdate";
            this.Text = "Home_Admin_AccountUpdate";
            this.Load += new System.EventHandler(this.Home_Admin_AccountUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountUpdateSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoUpdateAccount;
        private System.Windows.Forms.Button button1;
    }
}