using System;
using System.Collections.Generic;
using System.Text;

namespace _70_483_Study._1_ValueTypes
{
    public class IntegerTypes
    {
        public void Sample()
        {
            int integerValue = 15; //System.Int32 || 4bytes => -2,147,483,648 to 2,147,483,647

            char charValue = 'A' ; //System.Char || Store 2bytes => 16bits (UNICODEChar)

            byte byteValue = 0xFF; //1byte => 8bits, Values from 0 to 255 

            short shortValue = 230; //System.Int16 || Just a short integer, stores 2 bytes => -32,768 to 32,767

            long longValue = 3074534534123123; //System.Int64 || 8bytes

            sbyte sbyteValue = -123; //System.sbyte || byte type, but accepts negative values

            ushort ushortValue = 230; //System.UInt16 || doesn't accept values less than 0 (cannot use - ... but stores high values) => 0 to 65,535

            uint uintValue = 65555; //System.UInt32 || doesn't accept values less than 0 (cannot use - ... but stores high value) => 0 to 4,294,967,295
        }
    }
}
