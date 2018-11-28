using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFinalProject
{
    class Product
    {
        private int idProduct;
        private String name;
        private int quantity;

        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Product()    {        }

        public Product(int idProduct, string name, int quantity)
        {
            this.idProduct = idProduct;
            this.name = name;
            this.quantity = quantity;
        }
    }
}
