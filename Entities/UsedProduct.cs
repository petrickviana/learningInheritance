using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herançapolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manudate) : base(name, price)
        {
            manufactureDate = manudate;
        }

        public override string priceTag()
        {
            return Name+ " (Used) $ " + Price + " (Manufacture date: " + manufactureDate.ToString("dd/MM/yyyy") + ")";
        }


    }
}
