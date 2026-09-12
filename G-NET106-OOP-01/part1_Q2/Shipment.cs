/*using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_01.part1_Q2
{
    internal struct Shipment
    {
        //without encapsulation
       *//* public string description;
        public double weight;
        public decimal deliveryFee;*//*

        //with encapsulation
        private string _describtion;

        public string? Describtion
        {
            get { return _describtion; }
            set
            {
                if (Describtion is null)
                    Console.WriteLine("invalid describtion");
                _describtion = value;
            }
        }
        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { if(value <= 0)
                    Console.WriteLine("invalid weight");
                _weight = value;
            
            }
        }
        private decimal _deliveryFee;

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            set { if(DeliveryFee<0)
                    Console.WriteLine("invalid fees");
            _deliveryFee = value;
            }
        }






    }
}
*/