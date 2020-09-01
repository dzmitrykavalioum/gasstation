using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    class CafeItem
    {
        private string Name;

        public string NameP

        {
            get { return Name; }
            set { Name = value; }
        }

        private double Price;
        public double PriceP
        {
            get { return Price; }
            set { Price = value; }
        }

        private bool InOrder;
        public bool InOrderP
        {
            get { return InOrder; }
            set { InOrder = value; }
        }

        public CafeItem(string name,double price)
        {
            this.Name = name;
            this.Price = price;
            this.InOrder = false;

        }

    }
}
