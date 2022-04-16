using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1B___Tema_10___Ciobanu_Victor
{
    public class Class1
    {
        public static void Radical(float numar, float eroare, ref float x1, ref int count)
        {
			float x0 = 0;
			x1 = numar / 2;
			count = 0;
			do
			{
				x0 = x1;
				x1 = (x0 + numar / x0) / 2;
				count++;
			} while (Math.Abs(x1 - x0) > eroare);
		}
    }
}
