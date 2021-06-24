using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    public class Islemci
    {
        public double toplama(double x, double y)
        {
            return x + y;
        }
        public double cikarma(double x, double y)
        {
            return x - y;
        }
        public double carpma(double x, double y)
        {
            return x * y;
        }
        public double bölme(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
    }
}
