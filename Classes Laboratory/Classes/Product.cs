using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLaboratory.Classes
{
    class Product : Good
    {
        protected Nutrients nutrients;
        protected BaseInfoAboutGood bsInfo;

        public Product(ProductBuilder builder) : base(builder.GetName(), builder.GetPrice(), builder.GetManufacturerName())
        {
            this.nutrients = builder.GetNutrients();
            this.bsInfo = builder.GetBsInfo();
        }

        public Product(string name, double price, string manufacturerName, Nutrients nutrients, BaseInfoAboutGood bsInfo) : base(name, price, manufacturerName)
        {
            this.nutrients = nutrients;
            this.bsInfo = bsInfo;
        }

        public override object Clone()
        {
            return new Product(this.name, this.price, this.manufacturerName, this.nutrients, this.bsInfo);
        }

        public new string GetInfo()
        {
            string result = base.GetInfo();
            result += nutrients.GetInfo() + Environment.NewLine;
            result += bsInfo.GetInfo() + Environment.NewLine;
            return result;
        }
    }

    class DairyProduct : Product
    {

        public DairyProduct(DairyProductBuilder builder) 
            : base(builder.GetName(), builder.GetPrice(), builder.GetManufacturerName(), builder.GetNutrients(), builder.GetBsInfo()) { }

        public DairyProduct(string name, double price, string manufacturerName, Nutrients nutrients, BaseInfoAboutGood bsInfo)
            : base(name, price, manufacturerName, nutrients, bsInfo) { }

        public override object Clone()
        {
            return new DairyProduct(this.name, this.price, this.manufacturerName, this.nutrients, this.bsInfo);
        }
    }
}
