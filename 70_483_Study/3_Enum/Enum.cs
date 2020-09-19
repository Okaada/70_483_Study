using System;
using System.Collections.Generic;
using System.Text;

namespace _70_483_Study._3_Enum
{
    public class Enum
    {
        public void Sample()
        {
            Days firstDay = Days.Sun;

            //------------//

            DaysWithBits newBit = DaysWithBits.A | DaysWithBits.B | DaysWithBits.F;
            Console.WriteLine(newBit);
        }

    }

    //It's possible to change the type
    enum Days : long
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }

    //FLAG ATTRIBUTE
    [Flags]
    enum DaysWithBits //ITS A BETTER WAY TO WORK WITH THE SUM OF VALUES INSIDE OF THE ENUM
    {
        A = 1,
        B = 2,
        C = 4,
        D = 8,
        E = 16,
        F = 32
    }
}
