using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Smart
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Paintbrush pb = new Paintbrush();
            pb.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            
            Music mm = new Music();
            mm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            Game gg = new Game();
            gg.Show();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            Calculator cc = new Calculator();
            cc.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
            Notepad nn = new Notepad();
            nn.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
           Calender CC = new Calender();
            CC.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clock Cc = new Clock();
            Cc.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Secure",Text);
            Home.ActiveForm.Hide();
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Smart ll = new Smart();
            ll.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            CurrencyConverter CCC = new CurrencyConverter();
            CCC.Show();
        }
    }
}
