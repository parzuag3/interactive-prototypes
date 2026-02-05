using System;
using System.Collections.Generic;
using System.Text;

namespace class10242022
{
    
    
        public class Car
        {

            public string make;
            public string model;
            public string color;
            public string year;
            public string mileage;

        public Car()
        {
            make = "Honda";
            model = "Sedan";
            color = "Silver";
            year = "2022";
            mileage = "1570";
        }

            public void GetCarDetails()
            {
            Console.WriteLine(color);
            Console.WriteLine(make);
            Console.WriteLine(mileage);
            Console.WriteLine(model);
            Console.WriteLine(year);
        }
        }
        
        
    
} 

