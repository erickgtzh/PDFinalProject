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
using QRCodeEncoderDecoderLibrary;

namespace PDFinalProject
{
    public partial class OrderGenerator : Form
    {
        List<Order> orders = new List<Order>();
        Product product1;
        Product product2;
        Product product3;
        Order order;

        public OrderGenerator()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //String json = createJson(0,"TestMarket",new int[]{ 0,0,0});
            //Encoder("TestMarket", json);
            Decoder();
        }

        private String createJson(int idStore,String storeName,int[] products)
        {
            String json = "";
            if(products[0] == 0 && products[1] == 0 && products[2] == 0)
                json = "[\n{\n\t\"idStore\": \""+idStore+ "\",\n\t\"storeName\": \"" + storeName+ "\",\n\t\"products\": []\n}\n]";
            else
                json = "[\n{\n\t\"idStore\": \"" + idStore + "\",\n\t\"storeName\": \"" + storeName + "\",\n\t\"products\": [" +
                    //Frozen vegetables
                    "\n\t\t{" +
                        "\n\t\t\t\"idProduct\": 1," +
                        "\n\t\t\t\"name\": \"Frozen vegetables\"," +
                        "\n\t\t\t\"quantity\": " + products[0] +
                    "\n\t\t}," +
                    //Sodas
                    "\n\t\t{" +
                        "\n\t\t\t\"idProduct\": 2," +
                        "\n\t\t\t\"name\": \"Sodas\"," +
                        "\n\t\t\t\"quantity\": " + products[1] +
                    "\n\t\t}," +
                    //Bread
                    "\n\t\t{" +
                        "\n\t\t\t\"idProduct\": 3," +
                        "\n\t\t\t\"name\": \"Bread\"," +
                        "\n\t\t\t\"quantity\": " + products[2] +
                    "\n\t\t}" +

                    "\n\t]" +

                    "\n}\n]";

            //Console.WriteLine(json);
            return json;
        }

        public void Encoder(String name,String json)
        {
            //Console.WriteLine("Open");
            String path = @"Markets//" + name + ".png";
            QREncoder QRCodeEncoder = new QREncoder();
            QRCodeEncoder.Encode(ErrorCorrection.M, json);
            Bitmap QRCodeImage = QRCodeToBitmap.CreateBitmap(QRCodeEncoder, 4, 8);

            //File.Delete(@"Markets//" + name + ".png");
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            //FileShare.Write(@"Markets//" + name + ".png",FileMode.Create);
            using(FileStream FS = new FileStream(@"Markets//"+name+".png", FileMode.Create))
            {
                QRCodeImage.Save(FS, ImageFormat.Png);
            }
            //FS.Dispose();
            

            //MessageBox.Show(name+".png"+" saved.");

            //Console.WriteLine("Close");
        }

        public void Decoder()
        {
            QREncoder QRCodeEncoder = new QREncoder();
            Bitmap QRCodeImage = QRCodeToBitmap.CreateBitmap(QRCodeEncoder, 4, 8);
            QRDecoder QRCodeDecoder = new QRDecoder();
            String quantities = "";
            int[] q_products = new int[3];
            //String auxiliar = "";
            //int cont = 0;
            String searchFolder = @"Markets";
            var filters = new String[] { "png" };
            var files = GetFilesFrom(searchFolder, filters, false);
            String quantity = "\"quantity\": ";

            foreach (var i in files)
            {
                byte[][] DataByteArray = QRCodeDecoder.ImageDecoder((Bitmap)Image.FromFile(i));
                
                String Result = QRCode.ByteArrayToStr(DataByteArray[0]);

                String aux = "";
                int charaux = 0;
                int chartcont = 0;
                int p_id = 0;
                string p_name = "";

                for (int chari = 0; chari < Result.Length; chari++)
                {

                    if (Result[chari] != ']')
                    {
                        if (Result[chari] == ':')
                        {
                            charaux = chari + 1;
                            while (Result[charaux] != ',' && Result[charaux] != '}')
                            {
                                if (Result[charaux] != '"' && Result[charaux] != ' ')
                                    aux += Result[charaux];

                                charaux++;
                            }
                            chari = charaux;

                            if (chartcont == 0)
                                p_id = Convert.ToInt32(aux);

                            else if (chartcont == 1)
                                p_name = aux;
                            else if (chartcont == 2)
                            {
                                while (Result[charaux] != ']')
                                {
                                    quantities += Result[charaux];
                                    charaux++;
                                }
                                if (quantities.IndexOf(quantity) == -1)
                                {
                                    q_products[0] = 0;
                                    q_products[1] = 0;
                                    q_products[2] = 0;
                                }
                                else
                                {
                                    int checar = 0;

                                    while (checar != 3)
                                    {
                                        int op = quantities.IndexOf(quantity);
                                        int com = quantities.IndexOf("}");
                                        q_products[checar] = Convert.ToInt32(quantities.Substring(op + quantity.Length, com - op - quantity.Length));

                                        quantities = quantities.Substring(com + 1);
                                        checar++;
                                    }
                                }



                            }


                            chartcont++;
                            aux = "";
                        }
                    }


                    //Console.WriteLine("2- " + quantities.Substring(quantities.IndexOf(quantity)));
                    //while ()
                    //{

                    //}
                }
                //Console.WriteLine(quantities);

                //if (op != -1)
                //{ 
                //auxiliar = quantities.Substring(op,com);
                //}

                //foreach (var x in q_products)
                //    Console.WriteLine(x);
                product1 = new Product(1, "Frozen vegetables", q_products[0]);
                product2 = new Product(2, "Sodas", q_products[1]);
                product3 = new Product(3, "Bread", q_products[2]);
                order = new Order(p_id, p_name, product1, product2, product3);
                //Console.WriteLine("\n" + order.IdStore + "\n" + order.StoreName + "\n" + product1.IdProduct + " " + product1.Name + " " + product1.Quantity + "\n" + product2.IdProduct + " " + product2.Name + " " + product2.Quantity + "\n" + product3.IdProduct + " " + product3.Name + " " + product3.Quantity);
                orders.Add(order);

                //RefreshList(orders);
                RefreshList(orders);
                
                //MessageBox.Show(Convert.ToString(id));
                //MessageBox.Show(Result);
                //MessageBox.Show(p_name);
                //cont++;
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
            if (e.ColumnIndex==2)
            {
                //MessageBox.Show(Convert.ToString(e.RowIndex));
                this.Hide();

                MakeAnOrder makeAnOrder = new MakeAnOrder();
                makeAnOrder.setValues(orders.ElementAt(e.RowIndex).Product1.Quantity, orders.ElementAt(e.RowIndex).Product2.Quantity, orders.ElementAt(e.RowIndex).Product3.Quantity);
                makeAnOrder.ShowDialog();

                int[] array = makeAnOrder.getValues();

                orders.ElementAt(e.RowIndex).Product1.Quantity = array[0];
                orders.ElementAt(e.RowIndex).Product2.Quantity = array[1];
                orders.ElementAt(e.RowIndex).Product3.Quantity = array[2];

                //product1 = new Product(1, "Frozen vegetables", array[0]);
                //product2 = new Product(2, "Sodas", array[1]);
                //product3 = new Product(3, "Bread", array[2]);

                //order = new Order(orders.ElementAt(e.RowIndex).IdStore, orders.ElementAt(e.RowIndex).StoreName, product1, product2, product3);

                String json = createJson(orders.ElementAt(e.RowIndex).IdStore, orders.ElementAt(e.RowIndex).StoreName, array );
                //Console.WriteLine(orders.ElementAt(e.RowIndex).StoreName);
                Encoder(orders.ElementAt(e.RowIndex).StoreName, json);

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
    }
}
