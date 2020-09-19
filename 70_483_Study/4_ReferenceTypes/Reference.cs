using System;
using System.Collections.Generic;
using System.Text;

namespace _70_483_Study._4_ReferenceTypes
{
    public abstract class Reference
    {
        //A CLASS, IS A REFERENCE TYPE
        public static void Sample()
        {
            //HEAP
            //A CLASS NEED TO BE INSTANCIATED BEFORE WE START TO USE IT, LIKE THE FOLLOWING EXAMPLE
            //FIRST WE HAVE CUSTOMER1 RECEIVING JOHN NAME
            Customer customer1 = new Customer("John", 32);
            Customer customer2;

            //HERE WE ARE ASSIGNING THE REFERENCE
            customer2 = customer1;

            //WHEN WE CHANGE THE COSTUMER 2 NAME, THE CUSTUMER 1 NAME WILL CHANGE TOO, BECAUSE CLASSES ARE REFERENCE TYPES
            //IF YOU WANT TO SEE, JUST EXECUTE IT ON PROGRAM.CS
            customer2.Name = "Joana";

            Console.WriteLine($"C1 ||| Name: {customer1.Name}, Age: {customer1.Age}");
            Console.WriteLine($"C2 ||| Name: {customer2.Name}, Age: {customer2.Age}");
        }

    }

    class Customer
    {
        //A CLASS CAN HAVE A EMPTY CTOR
        //CLASS CAN INHERIT ANOTHER CLASS

        private Customer() { }

        public string Name { get; set; }
        public int Age { get; set; }
        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
