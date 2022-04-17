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
            if (!Double.TryParse(textNumber.Text, out number))
                errorProvider1.SetError(textNumber, "Nu e numar");
            else
                errorProvider1.Clear();
            if (!Double.TryParse(textError.Text, out error))
                errorProvider2.SetError(textError, "Nu e numar");
            else
                errorProvider2.Clear();
            Class1.Radical(number, error, ref x1, ref count);
            textSqrt.Text = Convert.ToString(x1);
            textSqrt2.Text = Convert.ToString(Math.Sqrt(number));
            textIterations.Text = Convert.ToString(count);
            textDifference.Text = Convert.ToString(x1 - Math.Sqrt(number));
        }
    }
}
