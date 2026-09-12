using G_NET106_OOP_01.part1_Q1;

namespace G_NET106_OOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1 - Q1
            #region A
            //struct DeliveryAddress 
            //A:What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?

           /* DeliveryAddress dA1 = new DeliveryAddress()
            {
                city = "alexandria",
                street = "street1"
            };
            DeliveryAddress dA2 = new DeliveryAddress()
            {
                city = "cairo",
                street = "street2"
            };
            dA2 = dA1;
            Console.WriteLine(dA1.street);
            Console.WriteLine(dA2.street);

            string city = "tanta";
            dA2.city = city;
            Console.WriteLine("after modifing the second object");
            Console.WriteLine(dA1.city);
            Console.WriteLine(dA2.city);*/


            // the only object i modified it's value changed and th other object value stays 
            // cause the struct is a value type so the data is stored in the stack

            #endregion
            #region B
            //  class Customer 
            //B: What happens when a Customer variable is copied into another variable and one variable modifies the object
/*
            Customer c1 = new Customer() {
                name  = "youssef"
            };
            Customer c2 = new Customer() {
                name  = "mohamed"
            };
            c2 = c1;
            Console.WriteLine(c1.name);
            Console.WriteLine(c2.name);

            string name = "ahmed";
            c2.name = name;
            Console.WriteLine("After modifing c2 name");
            Console.WriteLine(c1.name);
            Console.WriteLine(c2.name);*/


            // so when object 2 value is modified the value of the 2 objects takes this modified value 
            // cause the class is a reference type so the data is stored in the heap pointing to the same object in the heap


            #endregion
            #endregion
        }
    }
}
