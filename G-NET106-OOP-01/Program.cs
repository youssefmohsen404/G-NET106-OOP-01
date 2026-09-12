using G_NET106_OOP_01.part_2;
using G_NET106_OOP_01.part1_Q1;
//using G_NET106_OOP_01.part1_Q2;

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

            #region part1 - Q2
            // struct shipment 
            #region A
            //A:Identify at least three problems with this design from an encapsulation perspective.
            // 1.any one can edit on the senstive data with any value whether it validated or not
            // 2.any one can print or get the value of any field whether it is a private data or not
            // 3. there is no easy maintainability and the encapsulation reduces bugs
            #endregion
            #region B
            //How can private fields and public properties improve this design?
            // i edited the struct with encapsulating fields
            #endregion
            #endregion

            #region part 2 smart delivery managment system 
            #region 1
            //1.	Create a DeliveryAddress struct with
            DeliveryAddress dA1 = new DeliveryAddress()
            {
                buildingNumber = 1,
                city = "cairo",
                street = "gamal abdelnaser"
            };
            DeliveryAddress dA2 = new DeliveryAddress()
            {
                buildingNumber = 2,
                city = "alexandria",
                street = "elgesh"
            };
            dA2 = dA1;
            dA2.street = "fawzy moaaz";
            dA2.city = "tanta";
            dA2.buildingNumber = 3;

            Console.WriteLine($"original address : {dA1.GetFullAddress()}");
            Console.WriteLine($"copied address : {dA2.GetFullAddress()}");
            #endregion
            


            Console.WriteLine("Enter Shipment 1 Data ");
            Console.WriteLine("tracking code:");
            string code;
            do
            {
                 code = Console.ReadLine();

            }while( string.IsNullOrEmpty( code ) );
      
            Console.WriteLine("please enter describtion:");


            string describtion;
            do {
                describtion = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(describtion));
            Console.WriteLine("Weight:");
            double weight;
            bool isWeight;
            do
            {
                isWeight = double.TryParse(Console.ReadLine(), out weight);
            } while (!isWeight);
            Console.WriteLine("Delivery Fee: ");
            decimal deliveryFee;
            bool isDeliveryFee;
            do
            {
                isDeliveryFee= decimal.TryParse(Console.ReadLine(), out deliveryFee);
            }while(!isDeliveryFee);

            Console.WriteLine("city:");
            string city;
            do
            {
                city = Console.ReadLine();
            }while(string.IsNullOrWhiteSpace(city));
            Console.WriteLine("street:");
            string street;
            do
            {
               street =  Console.ReadLine();
            }while(string.IsNullOrWhiteSpace(street));
            Console.WriteLine("building number:");
            int buildingNumber;
            bool isBuildingNumber;
            do
            {
                isBuildingNumber = int.TryParse(Console.ReadLine(), out buildingNumber);

            }while(!isBuildingNumber);
            Shipment shipment = new Shipment( code ,describtion , weight , deliveryFee  );
            DeliveryAddress deliveryAddress = new DeliveryAddress(city , street , buildingNumber);
            Console.WriteLine("Shipment added successfully.");

            Console.WriteLine("--- All Shipments ---");
            shipment.PrintShipment();
            Console.WriteLine(deliveryAddress.GetFullAddress());



            #endregion
        }
    }
}
