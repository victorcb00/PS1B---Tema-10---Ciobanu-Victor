using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS1B___Tema_10___Ciobanu_Victor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number, error, x1 = 0; 
            int count = 0;
            bool val1 = false, val2 = false;
            if (!Double.TryParse(textNumber.Text, out number))
            {
                errorProvider1.SetError(textNumber, "NaN");
            }
            else
            {
                if (number < 0)
                {
                    errorProvider1.SetError(textNumber, "Negative number");
                }
                else
                {
                    errorProvider1.Clear();
                    val1 = true;
                }
            }
            if (!Double.TryParse(textError.Text, out error))
            {
                errorProvider2.SetError(textError, "NaN");
            }
            else
            {
                if (error < 0)
                {
                    errorProvider2.SetError(textError, "Negative number");
                }
                else
                {
                    errorProvider2.Clear();
                    val2 = true;
                }
            }
            if (val1 && val2)
            {
                Class1.Radical(number, error, ref x1, ref count);
                textSqrt.Text = Convert.ToString(x1);
                textSqrt2.Text = Convert.ToString(Math.Sqrt(number));
                textIterations.Text = Convert.ToString(count);
                textError2.Text = Convert.ToString(Math.Abs(x1 - Math.Sqrt(number)));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
