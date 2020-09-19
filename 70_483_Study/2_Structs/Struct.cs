using System;
using System.Collections.Generic;
using System.Text;

namespace _70_483_Study._2_Structs
{
    public class Struct
    {
        interface InterfaceSample
        {
            void SampleMethod();
        }

        struct SampleStruct: InterfaceSample
        {
            //CAN'T INITIALIZE VALUES HERE
            public double a;
            public double b;
            public double c;
            public double d;

            public void SampleMethod()
            {
                throw new NotImplementedException();
            }

        }

        struct OtherStruct
        {
            public double value;
            public double newValue;
            
            //THIS IS IMPOSSIBLE, I CAN'T HAVE A EMPTY CTOR IN A STRUCT
            //public OtherStruct() { }

            public OtherStruct(double value, double newValue)
            {
                this.value = value;
                this.newValue = newValue;
            }


            //PRINT VALUES USING THE TOSTRING METHOD
            //OVERRIDE LET US ACCESS INTERNAL METHODS
            public override string ToString()
            {
                return $"Value: {value}, NewValue: {newValue}"; 
            }
        }

        public void Sample()
        {
            //It is impossible to inherit a struct in other struct
            //but we can implement interfaces

            //STRUCTS ARE VALUE TYPES
            //CLASSES ARE REFERENCE TYPES


            SampleStruct firstStruct; //This is a "group" of variables. All the variables contained on SampleStruct may be accessed 
            //IMPORTANT: AUTOMATICALLY INITIALIZES THE DEFAULT VALUES FOR THE DECLARED TYPES

            firstStruct.a = 1;
            firstStruct.b = 1;
            firstStruct.c = 1;
            firstStruct.d = 1;


            //ANOTHER WAY TO USE
            SampleStruct secondStruct;
            secondStruct = new SampleStruct() { a = 1, b = 2, c = 3, d = 4 };

            //THIRD WAY 
            var otherStruct = new OtherStruct(1,2);
        }
    }
}
