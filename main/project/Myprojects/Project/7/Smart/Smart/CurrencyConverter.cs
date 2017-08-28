using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void conv_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(amount_txt.Text);
            if (fromcombo1.SelectedItem=="Rupees" && tocombo2.SelectedItem=="Dollar")
            {
                int conver = i / 103;
                display_amount.Text = "Converted Amount : " + conver + "\t $";
            }

            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Euro")
            {
                int conver = i / 115;
                display_amount.Text = "Converted Amount : " + conver + "\t Euro";
            }

            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Rupees")
            {
                int conver = i * 103;
                display_amount.Text = "Converted Amount : " + conver + "\t RS/=";
            }

            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Rupees")
            {
                int conver = i * 115;
                display_amount.Text = "Converted Amount : " + conver + "\t RS/=";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
