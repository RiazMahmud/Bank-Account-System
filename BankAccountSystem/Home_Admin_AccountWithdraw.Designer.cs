namespace BankAccountSystemUI
{
    partial class Home_Admin_AccountWithdraw
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
            this.searchUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GoWithdrawAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // searchUserID
            // 
            this.searchUserID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUserID.Location = new System.Drawing.Point(280, 33);
            this.searchUserID.Name = "searchUserID";
            this.searchUserID.Size = new System.Drawing.Size(147, 26);
            this.searchUserID.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 117;
            this.label3.Text = "Enter User ID";
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
            this.button1.TabIndex = 140;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoWithdrawAccount
            // 
            this.GoWithdrawAccount.BackColor = System.Drawing.Color.Transparent;
            this.GoWithdrawAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoWithdrawAccount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoWithdrawAccount.ForeColor = System.Drawing.Color.White;
            this.GoWithdrawAccount.Location = new System.Drawing.Point(280, 103);
            this.GoWithdrawAccount.Name = "GoWithdrawAccount";
            this.GoWithdrawAccount.Size = new System.Drawing.Size(147, 30);
            this.GoWithdrawAccount.TabIndex = 120;
            this.GoWithdrawAccount.Text = "Ok";
            this.GoWithdrawAccount.UseVisualStyleBackColor = false;
            this.GoWithdrawAccount.Click += new System.EventHandler(this.GoWithdrawAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 141;
            this.label2.Text = "Enter Year";
            // 
            // stYear
            // 
            this.stYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stYear.FormattingEnabled = true;
            this.stYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.stYear.Location = new System.Drawing.Point(280, 72);
            this.stYear.Name = "stYear";
            this.stYear.Size = new System.Drawing.Size(147, 21);
            this.stYear.TabIndex = 142;
            this.stYear.SelectedIndexChanged += new System.EventHandler(this.stYear_SelectedIndexChanged);
            // 
            // Home_Admin_AccountWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 181);
            this.Controls.Add(this.stYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchUserID);
            this.Controls.Add(this.GoWithdrawAccount);
            this.Name = "Home_Admin_AccountWithdraw";
            this.Text = "Home_Admin_AccountWithdray";
            this.Load += new System.EventHandler(this.Home_Admin_AccountWithdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GoWithdrawAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stYear;
    }
}