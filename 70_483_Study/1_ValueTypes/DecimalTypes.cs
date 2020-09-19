using System;
using System.Collections.Generic;
using System.Text;

namespace _70_483_Study._1_ValueTypes
{
    public class DecimalTypes
    {

        public void Sample()
        {
            //Internally float and double stores the number like a binary representation, and after, rounds up the value
            double a;
            double b;
            double c;

            a = 3.10;
            b = 3.20;
            c = 3.30;

            //that's why, we can use the decimal type, because stores the real decimal number
            decimal decimalValue = 10.1m; //System.Decimal //We just need to use the suffix m
        }

    }
}
