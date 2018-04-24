namespace BankAccountSystemUI
{
    partial class DocumentChecker
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
            this.stYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowAccountStatement = new System.Windows.Forms.Button();
            this.stMonth = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stYear
            // 
            this.stYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.stYear.Location = new System.Drawing.Point(236, 43);
            this.stYear.Name = "stYear";
            this.stYear.Size = new System.Drawing.Size(147, 21);
            this.stYear.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 147;
            this.label2.Text = "Enter Year";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(446, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 146;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowAccountStatement
            // 
            this.ShowAccountStatement.BackColor = System.Drawing.Color.Transparent;
            this.ShowAccountStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowAccountStatement.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAccountStatement.ForeColor = System.Drawing.Color.White;
            this.ShowAccountStatement.Location = new System.Drawing.Point(236, 99);
            this.ShowAccountStatement.Name = "ShowAccountStatement";
            this.ShowAccountStatement.Size = new System.Drawing.Size(147, 30);
            this.ShowAccountStatement.TabIndex = 145;
            this.ShowAccountStatement.Text = "Ok";
            this.ShowAccountStatement.UseVisualStyleBackColor = false;
            this.ShowAccountStatement.Click += new System.EventHandler(this.ShowAccountStatement_Click);
            // 
            // stMonth
            // 
            this.stMonth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stMonth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.stMonth.FormattingEnabled = true;
            this.stMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.stMonth.Location = new System.Drawing.Point(236, 72);
            this.stMonth.Name = "stMonth";
            this.stMonth.Size = new System.Drawing.Size(147, 21);
            this.stMonth.TabIndex = 150;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(87, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 24);
            this.label13.TabIndex = 149;
            this.label13.Text = "Enter Month";
            // 
            // DocumentChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(564, 181);
            this.Controls.Add(this.stMonth);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.stYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowAccountStatement);
            this.Name = "DocumentChecker";
            this.Text = "DocumentChecker";
            this.Load += new System.EventHandler(this.DocumentChecker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowAccountStatement;
        private System.Windows.Forms.ComboBox stMonth;
        private System.Windows.Forms.Label label13;
    }
}