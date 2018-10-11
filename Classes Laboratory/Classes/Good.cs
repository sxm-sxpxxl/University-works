using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLaboratory.Classes
{
    class Good : ICloneable
    {
        protected string name;
        protected double price;
        protected string manufacturerName;

        public Good(GoodBuilder builder)
        {
            this.name = builder.GetName();
            this.price = builder.GetPrice();
            this.manufacturerName = builder.GetManufacturerName();
        }

        public Good(string name, double price, string manufacturerName)
        {
            this.name = name;
            this.price = price;
            this.manufacturerName = manufacturerName;
        }

        public virtual object Clone() { return new Good(name, price, manufacturerName); }
        public string GetName() { return name; }
        public double GetPrice() { return price; }
        public string GetManufacturer() { return manufacturerName; }

        public virtual string GetInfo()
        {
            string result = String.Empty;
            result += "Name: " + name + Environment.NewLine;
            result += "Price: " + price + "$" + Environment.NewLine;
            result += "Manufacturer name: " + manufacturerName + Environment.NewLine;
            return result;
        }
    }
}
