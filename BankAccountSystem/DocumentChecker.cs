using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountSystemUI
{
    public partial class DocumentChecker : Form
    {
        public DocumentChecker()
        {
            InitializeComponent();
        }

        private void DocumentChecker_Load(object sender, EventArgs e)
        {

        }

        private void ShowAccountStatement_Click(object sender, EventArgs e)
        {
            Document d = new Document();
            d.giveDocData(stYear.Text, stMonth.Text);
            this.Hide();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin hm = new Home_Admin();
            hm.Show();
        }
    }
}
