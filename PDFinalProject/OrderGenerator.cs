using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoggerNamespace;
using QRCodeEncoderDecoderLibrary;

namespace PDFinalProject
{
    public partial class OrderGenerator : Form
    {

        public static List<Order> orders = new List<Order>();
        Product product1;
        Product product2;
        Product product3;
        Order order;
        Logger logger = Logger.Instance;

        public OrderGenerator()
        {
            InitializeComponent();
            //RefreshList(orders);
        }

        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }

        public List<Order> getOrder()
        {
            return orders;
        }

        public void setOrder(List<Order> _orders)
        {
            orders = _orders;
            AddButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //String json = createJson(0, "TestMarket", new int[] { 0, 0, 0 });
            //Encoder("TestMarket", json);
            Decoder();
        }

        public String createJson(int idStore, String storeName, int[] products)
        {
            List<Product> mylist = new List<Product>();
            mylist.Add(new Product(1,"Frozen Vegetables",products[0]));
            mylist.Add(new Product(2, "Sodas", products[1]));
            mylist.Add(new Product(3, "Bread", products[2]));
            Order a = new Order(idStore, storeName, mylist);
            String aux = Newtonsoft.Json.JsonConvert.SerializeObject(a);
            String json = "[\n" + aux +"\n]";
            return json;
        }

        public void Encoder(String name, String json)
        {
            //Console.WriteLine("Open");
            String path = @"Markets//" + name + ".png";
            QREncoder QRCodeEncoder = new QREncoder();
            QRCodeEncoder.Encode(ErrorCorrection.M, json);
            Bitmap QRCodeImage = new Bitmap(QRCodeToBitmap.CreateBitmap(QRCodeEncoder, 4, 8));
            //System.IO.File.Delete(path);

            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            //FileShare.Write(@"Markets//" + name + ".png",FileMode.Create);
            using (FileStream FS = new FileStream(path, FileMode.Create))
            {
                QRCodeImage.Save(FS, ImageFormat.Png);
            }

            //MessageBox.Show(name+".png"+" saved.");

            //Console.WriteLine("Close");
            logger.Log("Imagen creada");
        }

        public void Decoder()
        {
            QREncoder QRCodeEncoder = new QREncoder();
            Bitmap QRCodeImage = new Bitmap(QRCodeToBitmap.CreateBitmap(QRCodeEncoder, 4, 8));
            QRDecoder QRCodeDecoder = new QRDecoder();
            int[] q_products = new int[3];

            String searchFolder = @"Markets";
            var filters = new String[] { "png" };
            var files = GetFilesFrom(searchFolder, filters, false);

            foreach (var i in files)
            {
                byte[][] DataByteArray = QRCodeDecoder.ImageDecoder((Bitmap)Image.FromFile(i));
                String Result = QRCode.ByteArrayToStr(DataByteArray[0]);
                Result = Result.Substring(1, Result.Length - 2);
                order = Newtonsoft.Json.JsonConvert.DeserializeObject<Order>(Result);
                if(order.products.Count == 0)
                {
                    List<Product> auxproduct = new List<Product>();
                    auxproduct.Add(new Product(1, "Frozen vegetables",0));
                    auxproduct.Add(new Product(2, "Sodas", 0));
                    auxproduct.Add(new Product(3, "Bread", 0));
                    order.products = auxproduct;
                }
                orders.Add(order);
                RefreshList(orders);

            }
            AddButtons();
        }

        private void AddButtons()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Order";
            btn.Text = "Make an order";
            btn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(btn);
        }

        private void RefreshList(List<Order> list)
        {
            DataConverter dc = new DataConverter();

            DataTable data = dc.ConvertToDataTable(list);
            dataGridView.DataSource = data;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(Convert.ToString(e.ColumnIndex));
            if (e.ColumnIndex == 2 || e.ColumnIndex == 1 || e.ColumnIndex == 0)
            {
                //MessageBox.Show(Convert.ToString(e.RowIndex));
                this.Hide();

                MakeAnOrder makeAnOrder = new MakeAnOrder();
                makeAnOrder.setValues(orders.ElementAt(e.RowIndex).products[0].quantity, orders.ElementAt(e.RowIndex).products[1].quantity, orders.ElementAt(e.RowIndex).products[2].quantity);
                makeAnOrder.ShowDialog();

                int[] array = makeAnOrder.getValues();

                for(int i =0; i < orders.ElementAt(e.RowIndex).products.Count; i++)
                    orders.ElementAt(e.RowIndex).products[i].quantity = array[i];

                //product1 = new Product(1, "Frozen vegetables", array[0]);
                //product2 = new Product(2, "Sodas", array[1]);
                //product3 = new Product(3, "Bread", array[2]);

                //order = new Order(orders.ElementAt(e.RowIndex).IdStore, orders.ElementAt(e.RowIndex).StoreName, product1, product2, product3);

                String json = createJson(orders.ElementAt(e.RowIndex).idStore, orders.ElementAt(e.RowIndex).storeName, array );
                //Console.WriteLine(orders.ElementAt(e.RowIndex).StoreName);
                Encoder(orders.ElementAt(e.RowIndex).storeName, json);

                //RefreshList(orders);
                //for (int i = 0; i < array.Length; i++)
                //    Console.WriteLine(array[i]);
                //Console.WriteLine(Convert.ToString(orders.ElementAt(e.RowIndex).Product1.Quantity));
                //Console.WriteLine(Convert.ToString(orders.ElementAt(e.RowIndex).Product2.Quantity));
                //Console.WriteLine(Convert.ToString(orders.ElementAt(e.RowIndex).Product3.Quantity));

                //makeAnOrder.setValues();    
                this.Show();
            }
        }

        private void File_Click(object sender, EventArgs e)
        {
            logger.Contfile++;
        }

        private void DataGrid_Click(object sender, EventArgs e)
        {
            logger.Contable++;
        }

        private void Textbox_Click(object sender, EventArgs e)
        {
            logger.Contbox++;
        }

        private void button_simulation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transportation transportation = new Transportation();
            transportation.ShowDialog();
            //dataGridView.Clear();
            //dataGridView.Rows.Clear();
            //dataGridView.Refresh();
            RefreshList(orders);
            this.Show();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            textBox1.Text = logger.LoggingString;
            dataGridView_binnacle.DataSource = logger.loggingTable;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}