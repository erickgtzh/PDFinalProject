using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFinalProject
{
    public partial class Simulation : Form
    {
        List<Order> ordered_list;
        public Simulation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RefreshList(List<Order> list)
        {
            DataConverter dc = new DataConverter();

            DataTable data = dc.ConvertToDataTable(list);
            dataGridView.DataSource = data;
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
            Color my_green = Color.FromArgb(212, 240, 186);
            Transportation transportation = new Transportation();
            ordered_list = transportation.OrderList();

            RefreshList(ordered_list);
            
            for (int i = 0; i < ordered_list.Count ; i++)
                dataGridView.Rows[i].DefaultCellStyle.BackColor = my_green;

            MessageBox.Show("Successful simulation. "+ Environment.NewLine +"Now, plase update your orders.");

            for (int i = 0; i < ordered_list.Count; i++)
                makeOrder(i);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void makeOrder(int i)
        {
            this.Hide();
            OrderGenerator orderGenerator = new OrderGenerator();
            MakeAnOrder makeAnOrder = new MakeAnOrder();
            makeAnOrder.setValues(ordered_list.ElementAt(i).Product1.Quantity, ordered_list.ElementAt(i).Product2.Quantity, ordered_list.ElementAt(i).Product3.Quantity);
            makeAnOrder.ShowDialog();

            int[] array = makeAnOrder.getValues();

            ordered_list.ElementAt(i).Product1.Quantity = array[0];
            ordered_list.ElementAt(i).Product2.Quantity = array[1];
            ordered_list.ElementAt(i).Product3.Quantity = array[2];

            String json = orderGenerator.createJson(ordered_list.ElementAt(i).IdStore, ordered_list.ElementAt(i).StoreName, array);
            Console.WriteLine(json);
            orderGenerator.Encoder(ordered_list.ElementAt(i).StoreName, json);
            
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderGenerator orderGenerator = new OrderGenerator();
            orderGenerator.setOrder(ordered_list);
            //orderGenerator.Show();
        }
    }
}
