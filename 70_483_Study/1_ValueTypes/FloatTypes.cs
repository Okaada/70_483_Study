using System;
using System.Collections.Generic;
using System.Text;

namespace _70_483_Study._1_ValueTypes
{
    public class FloatTypes
    {
        public void Sample()
        {
            float floatValue = 15; //System.Single
            floatValue = 16.7f; //Without the letter F, the compiler doesn't know that value is float

            float floatValue2 = 4.1231e12f;

            //If your float variable needs to acceept a bigger value, you can use double

            double bigFloat = 6e100; //System.Double 
        }
    }
}
