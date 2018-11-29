using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFinalProject
{
    public class Order
    {
        private int idStore;
        private String storeName;
        private Product product1;
        private Product product2;
        private Product product3;

        public int IdStore { get => idStore; set => idStore = value; }
        public string StoreName { get => storeName; set => storeName = value; }
        internal Product Product1 { get => product1; set => product1 = value; }
        internal Product Product2 { get => product2; set => product2 = value; }
        internal Product Product3 { get => product3; set => product3 = value; }

        public Order(int idStore, string storeName, Product product1, Product product2, Product product3)
        {
            this.idStore = idStore;
            this.storeName = storeName;
            this.product1 = product1;
            this.product2 = product2;
            this.product3 = product3;
        }
    }
}
