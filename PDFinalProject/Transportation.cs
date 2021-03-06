﻿
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
        List<int> greater_profit = new List<int>();
        List<Product> products_list = new List<Product>();
        double vegetables_price = 18.5;
        double sodas_price = 7.0;
        double bread_price = 22.0;

        public int Bus_quantities { get => bus_quantities; set => bus_quantities = value; }
        public double Vegetables_price { get => vegetables_price; set => vegetables_price = value; }
        public double Sodas_price { get => sodas_price; set => sodas_price = value; }
        public double Bread_price { get => bread_price; set => bread_price = value; }

        public Transportation()
        {
            InitializeComponent();
        }

        private void Transportation_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            List<int> aux = new List<int>();
            int sum = Convert.ToInt32(comboBox_frozen_veg_buses.Text) + Convert.ToInt32(comboBox_sodas_buses.Text) + Convert.ToInt32(comboBox_bread_buses.Text);

            int sum_tot = Convert.ToInt32(comboBox_frozen_veg_buses.Text) * 120 + Convert.ToInt32(comboBox_sodas_buses.Text) * 270 + Convert.ToInt32(comboBox_bread_buses.Text) * 95;
            aux.Add(sum);
            aux.Add(sum_tot);

            aux.Add(Convert.ToInt32(comboBox_frozen_veg_buses.Text) * 120);
            aux.Add(Convert.ToInt32(comboBox_sodas_buses.Text) * 270);
            aux.Add(Convert.ToInt32(comboBox_bread_buses.Text) * 95);

            ValidatorDirector validatorDirector = new ValidatorDirector();

            validatorDirector.startSimulation(aux.ToArray());

            if (validatorDirector.getErrorMessage() != "")
            {
                MessageBox.Show(validatorDirector.getErrorMessage());
            }
            else
            {
                MessageBox.Show("Please create a new Order for your Market.");
                Simulate();
            }
        }

        public void Simulate()
        {
            this.Hide();

            Simulation simulation = new Simulation();
            simulation.ShowDialog();
        }

        public List<Order> OrderList()
        {
            OrderGenerator orderGenerator = new OrderGenerator();
            List<Order> orders = orderGenerator.getOrder();

            for (int i = 0; i < orders.Count; i++)
            {
                for (int j = 0; j < orders.Count - 1; j++)
                {
                    double profit_j = orders.ElementAt(j).Product1.Quantity * vegetables_price +
                                    orders.ElementAt(j).Product2.Quantity * sodas_price +
                                    orders.ElementAt(j).Product3.Quantity * bread_price;

                    double profit_j_toCompare = orders.ElementAt(j + 1).Product1.Quantity * vegetables_price +
                                                orders.ElementAt(j + 1).Product2.Quantity * sodas_price +
                                                orders.ElementAt(j + 1).Product3.Quantity * bread_price;

                    if (profit_j < profit_j_toCompare)
                    {
                        int temp1 = orders.ElementAt(j).Product1.Quantity;
                        int temp2 = orders.ElementAt(j).Product2.Quantity;
                        int temp3 = orders.ElementAt(j).Product3.Quantity;
                        string temp4 = orders.ElementAt(j).StoreName;
                        //int id = orders.ElementAt(j).IdStore;

                        orders.ElementAt(j).Product1.Quantity = orders.ElementAt(j + 1).Product1.Quantity;
                        orders.ElementAt(j).Product2.Quantity = orders.ElementAt(j + 1).Product2.Quantity;
                        orders.ElementAt(j).Product3.Quantity = orders.ElementAt(j + 1).Product3.Quantity;
                        orders.ElementAt(j).StoreName = orders.ElementAt(j + 1).StoreName;
                        //orders.ElementAt(j).IdStore = orders.ElementAt(j + 1).IdStore;

                        orders.ElementAt(j + 1).Product1.Quantity = temp1;
                        orders.ElementAt(j + 1).Product2.Quantity = temp2;
                        orders.ElementAt(j + 1).Product3.Quantity = temp3;
                        orders.ElementAt(j + 1).StoreName = temp4;
                        //orders.ElementAt(j + 1).IdStore = id;
                    }
                }
                orders.ElementAt(i).IdStore = i;
            }
            //foreach (var i in orders)
            //{
            //    Console.WriteLine(i.StoreName);
            //    Console.WriteLine(i.IdStore);
            //    Console.WriteLine(i.Product1.Quantity);
            //    Console.WriteLine(i.Product2.Quantity);
            //    Console.WriteLine(i.Product3.Quantity);
            //}
            return orders;
        }
    }
}
