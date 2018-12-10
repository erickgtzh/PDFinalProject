using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PDFinalProject
{
    class DataConverter
    {
        public DataConverter()
        {

        }

        public DataTable ConvertToDataTable(List<Order> data)
        {
            DataTable orders = new DataTable();
            orders.Columns.Add(new DataColumn("idStore", typeof(string)));
            orders.Columns.Add(new DataColumn("storeName", typeof(string)));
            foreach (Order element in data)
            {
                DataRow row = orders.NewRow();
                row[0] = element.idStore;
                row[1] = element.storeName;
                orders.Rows.Add(row);
            }
            return orders;
        }
    }
}
