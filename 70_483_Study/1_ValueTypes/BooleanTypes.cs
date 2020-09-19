using System;
using System.Collections.Generic;
using System.Text;

namespace _70_483_Study._1_ValueTypes 
{ 
    public class BooleanTypes
    {
        public void Sample()
        {
            //bool isActive = 1; //CANNOT RECEIVE NUMBERS BY DEFAULT
            bool isActive = true;

            //But, accepts if expressions were true or false
            bool isTrue = 20 + 20 == 40;

            //we can use for validate something
            if (isTrue)
            {
                //DO SOMETHING
            }
            else
            {
                //DO SOMETHING
            }
        }
    }
}
