namespace TestLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArithmeticImpl
    {
        public int Add(int leftnum, int rightnum)
        {
            return leftnum + rightnum;
        }

        public int Divide(int leftnum, int rightnum)
        {
            if (rightnum == 0)
            {
                throw new DivideByZeroException();
            }

            return leftnum / rightnum;
        }

        public int Multiply(int leftnum, int rightnum)
        {
            return leftnum * rightnum;
        }

        public int Subtract(int leftnum, int rightnum)
        {
            return leftnum - rightnum;
        }
    }
}
