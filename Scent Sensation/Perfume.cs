using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scent_Sensation
{
    public class Perfume
    {
        public String Name { get; set; }
        public int Mililiters { get; set; }
        public String ScentGroup { get; set; }
        public String Availability { get; set; }
        public int Price { get; set; }

        public Perfume(string name, int mililiters, string scentGroup, string availability, int price)
        {
            Name = name;
            Mililiters = mililiters;
            ScentGroup = scentGroup;
            Availability = availability;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name + " " + Mililiters + "мл \n");
            stringBuilder.Append("Availability: " + Availability + "\n");
            stringBuilder.Append(Price + " ден. \n");
            stringBuilder.Append("\n");

            return stringBuilder.ToString();
        }
    }
}
