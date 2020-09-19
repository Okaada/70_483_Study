using System;
using System.Collections.Generic;
using System.Text;

namespace _70_483_Study._1_ValueTypes
{
    public class ValueTypes
    {


        public void Sample()
        {
            //GOES TO STACK 
            int value;
            //OR
            System.Int32 systemInt;
            value = 30;

            int copyValue = value;

            Console.WriteLine($"Value: {value}");
            Console.WriteLine($"Copy Value: {copyValue}");

            value = 120;
            Console.WriteLine($"Value: {value}");
            Console.WriteLine($"CopyValue: {copyValue}");

            //OUTPUT 1:
            //VALUE: 30
            //COPYVALUE: 30
            //-------------
            //OUTPUT 2 (AFTER ASSIGN 120 TO VALUE):
            //VALUE: 120
            //COPYVALUE: 30
            //THIS HAPPENS BECAUSE VALUE TYPES DOESN'T MEDDLE IN A VARIABLE THAT WAS COPIED FROM ANOTHER VARIABLE 


            //INT is a STRUCT of INT32

            /*value = null;*/
            //NULL CANNOT BE ASSIGNED TO AN INTEGER TYPE
            //IT ONLY WORKS IF YOU LET THIS VARIABLE TO RECEIVE NULL VALUES WITH THE "?"
            int? nullableValue = null;
            //OR
            System.Nullable<int> nullableValue2 = null;

            //BOLLEANS ARE VALUE TYPES TOO
            bool boolVariable = true;
        }
    }
}
