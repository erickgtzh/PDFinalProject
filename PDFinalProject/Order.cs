using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFinalProject
{
    public class Order
    {
        public int idStore;
        public String storeName;
        public List<Product> products;

        public Order(int idStore, string storeName, List<Product> list)
        {
            this.idStore = idStore;
            this.storeName = storeName;
            this.products = list;
        }
    }
}
