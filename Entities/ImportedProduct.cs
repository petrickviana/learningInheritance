using System;
using System.Globalization;

namespace Herançapolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsfee) : base(name, price)
        {
            customsFee = customsfee;
        }


        public double totalPrice()
        { 
            return Price + customsFee;
        }

        public override string priceTag()
        {
            return base.priceTag() + " (Customs fee: $ " + customsFee.ToString("F2", CultureInfo.InvariantCulture)+ ")";

        }


    }
}
