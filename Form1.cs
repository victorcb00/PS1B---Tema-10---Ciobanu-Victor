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
            float numar = 1657;
            float eroare = 0.001f;
            float x1 = 0;
            int count = 0;
            Class1.Radical(numar, eroare, ref x1, ref count);
            Console.WriteLine("{0} {1}", x1, count);
        }
    }
}
