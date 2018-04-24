namespace BankAccountSystemUI
{
    partial class Home_Admin_Withdraw_New
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
            this.NoADD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.yesADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoADD
            // 
            this.NoADD.BackColor = System.Drawing.Color.Transparent;
            this.NoADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NoADD.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoADD.ForeColor = System.Drawing.Color.White;
            this.NoADD.Location = new System.Drawing.Point(288, 102);
            this.NoADD.Name = "NoADD";
            this.NoADD.Size = new System.Drawing.Size(147, 30);
            this.NoADD.TabIndex = 146;
            this.NoADD.Text = "No";
            this.NoADD.UseVisualStyleBackColor = false;
            this.NoADD.Click += new System.EventHandler(this.NoADD_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(101, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 29);
            this.label8.TabIndex = 144;
            this.label8.Text = "Are you start a new season?";
            // 
            // yesADD
            // 
            this.yesADD.BackColor = System.Drawing.Color.Transparent;
            this.yesADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yesADD.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesADD.ForeColor = System.Drawing.Color.White;
            this.yesADD.Location = new System.Drawing.Point(122, 102);
            this.yesADD.Name = "yesADD";
            this.yesADD.Size = new System.Drawing.Size(147, 30);
            this.yesADD.TabIndex = 145;
            this.yesADD.Text = "Yes";
            this.yesADD.UseVisualStyleBackColor = false;
            this.yesADD.Click += new System.EventHandler(this.yesADD_Click_1);
            // 
            // Home_Admin_Withdraw_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 181);
            this.Controls.Add(this.NoADD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yesADD);
            this.Name = "Home_Admin_Withdraw_New";
            this.Text = "New_Year_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoADD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button yesADD;
    }
}