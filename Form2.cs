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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            double min_value, max_value, error;
            int nr_values;
            bool val1 = false, val2 = false, val3 = false, val4 = false;

            if (!Double.TryParse(textMin_value.Text, out min_value))
            {
                errorProvider1.SetError(textMin_value, "NaN");
            }
            else
            {
                if (min_value < 0)
                {
                    errorProvider1.SetError(textMin_value, "Negative number");
                }
                else
                {
                    errorProvider1.Clear();
                    val1 = true;
                }
            }
            if (!Double.TryParse(textMax_value.Text, out max_value))
            {
                errorProvider2.SetError(textMax_value, "NaN");
            }
            else
            {
                if (max_value < 0)
                {
                    errorProvider2.SetError(textMax_value, "Negative number");
                }
                else
                {
                    errorProvider2.Clear();
                    if (max_value < min_value)
                    {
                        errorProvider2.SetError(textMax_value, "Number less than min_value");
                    }
                    else
                    {
                        errorProvider2.Clear();
                        val2 = true;
                    }
                }
            }
            if (!int.TryParse(textNr_values.Text, out nr_values))
            {
                errorProvider3.SetError(textNr_values, "Not an integer");
            }
            else
            {
                if (nr_values < 0)
                {
                    errorProvider3.SetError(textNr_values, "Negative number");
                }
                else
                {
                    errorProvider3.Clear();
                    val3 = true;
                }
            }
            if (!Double.TryParse(textError.Text, out error))
            {
                errorProvider4.SetError(textError, "NaN");
            }
            else
            {
                if (error < 0)
                {
                    errorProvider4.SetError(textError, "Negative number");
                }
                else
                {
                    errorProvider4.Clear();
                    val4 = true;
                }
            }

            double x1 = 0, number, error_sum = 0, sum = 0;
            int count = 0;
            Dictionary<int, int> hash = new Dictionary<int, int>();

            progressBar.Minimum = 0;
            progressBar.Maximum = nr_values;
            progressBar.Value = 0;
            progressBar.Step = 1;
            if (val1 && val2 && val3 && val4)
            {
                for (int i = 0; i < nr_values; i++)
                {
                    number = Class1.GetRandomNumber(min_value, max_value);
                    Class1.Radical(number, error, ref x1, ref count);
                    if (hash.ContainsKey(count))
                    {
                        hash[count]++;
                    }
                    else
                    {
                        hash.Add(count, 1);
                    }
                    error_sum += Math.Abs(x1 - Math.Sqrt(number));
                    progressBar.PerformStep();
                }
                foreach (var series in chart.Series)
                {
                    series.Points.Clear();
                }
                foreach (KeyValuePair<int, int> pair in hash)
                {
                    chart.Series["Iterations"].Points.AddXY(pair.Key, pair.Value);
                    sum += pair.Key * pair.Value;
                }
                textAvg_error.Text = Convert.ToString(error_sum / nr_values);
                textAvg_iterations.Text = Convert.ToString(sum / nr_values);
            }
        }
    }
}
