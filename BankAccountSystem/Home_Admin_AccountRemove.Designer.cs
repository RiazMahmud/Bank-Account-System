﻿namespace BankAccountSystemUI
{
    partial class Home_Admin_AccountRemove
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
            this.searchRemoveAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GoRemoveAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchRemoveAccount
            // 
            this.searchRemoveAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchRemoveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRemoveAccount.Location = new System.Drawing.Point(282, 42);
            this.searchRemoveAccount.Name = "searchRemoveAccount";
            this.searchRemoveAccount.Size = new System.Drawing.Size(147, 26);
            this.searchRemoveAccount.TabIndex = 102;
            this.searchRemoveAccount.TextChanged += new System.EventHandler(this.searchRemoveAccount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Enter Account NO";
            // 
            // GoRemoveAccount
            // 
            this.GoRemoveAccount.BackColor = System.Drawing.Color.Transparent;
            this.GoRemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoRemoveAccount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoRemoveAccount.ForeColor = System.Drawing.Color.White;
            this.GoRemoveAccount.Location = new System.Drawing.Point(282, 74);
            this.GoRemoveAccount.Name = "GoRemoveAccount";
            this.GoRemoveAccount.Size = new System.Drawing.Size(147, 30);
            this.GoRemoveAccount.TabIndex = 104;
            this.GoRemoveAccount.Text = "Ok";
            this.GoRemoveAccount.UseVisualStyleBackColor = false;
            this.GoRemoveAccount.Click += new System.EventHandler(this.GoRemoveAccount_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(459, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 139;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home_Admin_AccountRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoRemoveAccount);
            this.Controls.Add(this.searchRemoveAccount);
            this.Name = "Home_Admin_AccountRemove";
            this.Text = "Home_Admin_AccountRemove";
            this.Load += new System.EventHandler(this.Home_Admin_AccountRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchRemoveAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoRemoveAccount;
        private System.Windows.Forms.Button button1;
    }
}