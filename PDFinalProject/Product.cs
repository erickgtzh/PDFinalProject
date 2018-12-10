using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFinalProject
{
    public class Product
    {
        public int idProduct;
        public String name;
        public int quantity;
        public Product(int idProduct,String name, int quantity)
        {
            this.idProduct = idProduct;
            this.name = name;
            this.quantity = quantity;
        }

    }
}
