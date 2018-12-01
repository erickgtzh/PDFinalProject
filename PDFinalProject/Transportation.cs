using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFinalProject
{
    public partial class Transportation : Form
    {
        int bus_quantities;
        List<Order> orders = new List<Order>();
        List<int> greater_profit = new List<int>();
        List<Product> products_list = new List<Product>(); 
        public int Bus_quantities { get => bus_quantities; set => bus_quantities = value; }

        public Transportation()
        {
            InitializeComponent();
        }

        private void Transportation_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int vegetables_buses = 0;
            int sodas_buses = 0;
            int bread_buses = 0;
            int buses_capacity = 0;

            OrderGenerator generator = new OrderGenerator();
            orders = generator.getOrder();

            vegetables_buses = Convert.ToInt32(comboBox_frozen_veg_buses.Text);
            sodas_buses = Convert.ToInt32(comboBox_sodas_buses.Text);
            bread_buses = Convert.ToInt32(comboBox_bread_buses.Text);
            

            Bus_quantities = vegetables_buses + sodas_buses + bread_buses;

            if (Bus_quantities > 5)
                MessageBox.Show("You're exceeding the limit of the number of buses.");
            else if (Bus_quantities < 1)
                MessageBox.Show("It's needed one bus, at least.");
            else
            {

                vegetables_buses *= 120;
                sodas_buses *= 270;
                bread_buses *= 95;

                buses_capacity = vegetables_buses + sodas_buses + bread_buses;

                foreach (var i in orders)
                {
                    vegetables_buses -= i.Product1.Quantity;
                    i.Product1.Quantity *= 0;

                    sodas_buses -= i.Product2.Quantity;
                    i.Product2.Quantity *= 0;

                    bread_buses -= i.Product3.Quantity;
                    i.Product3.Quantity *= 0;
                }

                Console.WriteLine("Available vegetables on the bus:");
                Console.WriteLine(vegetables_buses);

                Console.WriteLine("Available sodas on the bus:");
                Console.WriteLine(sodas_buses);

                Console.WriteLine("Available bread on the bus:");
                Console.WriteLine(bread_buses);
            }

            //Cada camión contará con 120 refrescos por surtir.
            //Cada camión contará con 270 piezas de pan por surtir.
            //Cada camión cuenta con 95 bolsas de 1 Kg de verdura
        }

    }
}
