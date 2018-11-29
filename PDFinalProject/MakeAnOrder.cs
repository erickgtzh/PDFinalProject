using LoggerNamespace;
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
    public partial class MakeAnOrder : Form
    {
        private int quantity1;
        private int quantity2;
        private int quantity3;
        Logger logger = Logger.Instance;

        public MakeAnOrder(int quantity1, int quantity2, int quantity3)
        {
            this.quantity1 = quantity1;
            this.quantity2 = quantity2;
            this.quantity3 = quantity3;
        }

        public MakeAnOrder()
        {
            InitializeComponent();
        }

        public int Quantity1 { get => quantity1; set => quantity1 = value; }
        public int Quantity2 { get => quantity2; set => quantity2 = value; }
        public int Quantity3 { get => quantity3; set => quantity3 = value; }

        public void setValues(int quantity1, int quantity2, int quantity3)
        {
            textBox_frozen_veg.Text = Convert.ToString(quantity1);
            textBox_sodas.Text = Convert.ToString(quantity2);
            textBox_bread.Text = Convert.ToString(quantity3);
        }

        public int[] getValues()
        {
            int[] array = new int[3];
            array[0] = Quantity1;
            array[1] = Quantity2;
            array[2] = Quantity3;
            return array;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Quantity1 = Convert.ToInt32(textBox_frozen_veg.Text);
            Quantity2 = Convert.ToInt32(textBox_sodas.Text);
            Quantity3 = Convert.ToInt32(textBox_bread.Text);
            this.logger.Log("Se han creado productos");
            this.logger.Log("Pedido finalizado");
            this.Hide();
        }
    }
}
