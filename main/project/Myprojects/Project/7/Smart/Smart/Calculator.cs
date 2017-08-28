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
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textbox_result.Text == "0") || (isOperationPerformed))
                textbox_result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!textbox_result.Text.Contains("."))
                    textbox_result.Text = textbox_result.Text + button.Text;
            }else
            textbox_result.Text = textbox_result.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button18.PerformClick();
                operationPerformed = button.Text;
                labelcurrentoperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textbox_result.Text);
                labelcurrentoperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "0";
            resultValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textbox_result.Text = (resultValue + Double.Parse(textbox_result.Text)).ToString();
                    break;
                case "-":
                    textbox_result.Text = (resultValue - Double.Parse(textbox_result.Text)).ToString();
                    break;
                case "*":
                    textbox_result.Text = (resultValue * Double.Parse(textbox_result.Text)).ToString();
                    break;
                case "/":
                    textbox_result.Text = (resultValue / Double.Parse(textbox_result.Text)).ToString();
                    break;
            }
            resultValue = Double.Parse(textbox_result.Text);
            labelcurrentoperation.Text = "";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void a(object sender, EventArgs e)
        {

        }
    }
}
