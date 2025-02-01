using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
  public class  Car
    {
              
        public void Wheel()
        {
            Console.WriteLine("Wheel is Running");
        }

        public void engine()
        {
            Console.WriteLine("Enigine is start");
        }


        public Car( int car_number)
        {
            Console.WriteLine(car_number);
        }

        public Car()
        {
            Console.WriteLine("");
        }
    }
}
