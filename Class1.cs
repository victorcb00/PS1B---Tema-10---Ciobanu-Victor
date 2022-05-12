using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1B___Tema_10___Ciobanu_Victor
{
    public class Class1
    {
        public static void Radical(double number, double error, ref double x1, ref int count)
        {
			double x0;
			x1 = number / 2;
			count = 0;
			do
			{
				x0 = x1;
				x1 = (x0 + number / x0) / 2;
				count++;
			} while (Math.Abs(x1 - x0) > error);
		}

		public static double GetRandomNumber(double minimum, double maximum)
		{
			Random random = new Random(Guid.NewGuid().GetHashCode());
			return random.NextDouble() * (maximum - minimum) + minimum;
		}
	}
}
