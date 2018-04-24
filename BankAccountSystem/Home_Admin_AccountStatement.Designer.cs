namespace BankAccountSystemUI
{
    partial class Home_Admin_AccountStatement
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
            this.label3 = new System.Windows.Forms.Label();
            this.ShowAccountStatement = new System.Windows.Forms.Button();
            this.AccountStatementSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "Enter User ID";
            // 
            // ShowAccountStatement
            // 
            this.ShowAccountStatement.BackColor = System.Drawing.Color.Transparent;
            this.ShowAccountStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowAccountStatement.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAccountStatement.ForeColor = System.Drawing.Color.White;
            this.ShowAccountStatement.Location = new System.Drawing.Point(281, 98);
            this.ShowAccountStatement.Name = "ShowAccountStatement";
            this.ShowAccountStatement.Size = new System.Drawing.Size(147, 30);
            this.ShowAccountStatement.TabIndex = 88;
            this.ShowAccountStatement.Text = "Ok";
            this.ShowAccountStatement.UseVisualStyleBackColor = false;
            this.ShowAccountStatement.Click += new System.EventHandler(this.ShowAccountStatement_Click);
            // 
            // AccountStatementSearch
            // 
            this.AccountStatementSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountStatementSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountStatementSearch.Location = new System.Drawing.Point(281, 34);
            this.AccountStatementSearch.Name = "AccountStatementSearch";
            this.AccountStatementSearch.Size = new System.Drawing.Size(147, 26);
            this.AccountStatementSearch.TabIndex = 89;
            this.AccountStatementSearch.TextChanged += new System.EventHandler(this.AccountStatementSearch_TextChanged);
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
            this.stYear.Location = new System.Drawing.Point(281, 67);
            this.stYear.Name = "stYear";
            this.stYear.Size = new System.Drawing.Size(147, 21);
            this.stYear.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 143;
            this.label2.Text = "Enter Year";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Home_Admin_AccountStatement
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
            this.Controls.Add(this.AccountStatementSearch);
            this.Controls.Add(this.ShowAccountStatement);
            this.Name = "Home_Admin_AccountStatement";
            this.Text = "Home_Admin_AccountStatement";
            this.Load += new System.EventHandler(this.Home_Admin_AccountStatement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowAccountStatement;
        private System.Windows.Forms.TextBox AccountStatementSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox stYear;
        private System.Windows.Forms.Label label2;
    }
}