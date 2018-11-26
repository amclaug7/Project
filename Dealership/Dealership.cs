using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dealership
{
    public partial class Dealership : Form
    {
        public Dealership()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrew\Desktop\ToyotaDealer.mdf;Integrated Security=True;Connect Timeout=30");

        int customerID;
        int inventoryID;

        private void Dealership_Load(object sender, EventArgs e)
        {
           
            string query = "select * from customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);            

            foreach (DataRow row in dtbl.Rows)
            {
                lbxCustomers.Items.Add($"{row["firstname"].ToString()}{row["lastname"].ToString()}");
            }

            fillInventoryDataTable();
            fillSalesDataTable();
        }

        private void fillInventoryDataTable()
        {
            string query2 = "select basecarmodel, trimtype from inventory " +
                "where sold = 0";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon);
            DataTable dtbl2 = new DataTable();
            sda2.Fill(dtbl2);

            foreach (DataRow row in dtbl2.Rows)
            {
                lbxInventory.Items.Add($"{row["basecarmodel"].ToString()} {row["trimtype"].ToString()}");
            }
        }

        private void fillSalesDataTable()
        {
            string querySalesData = "select basecarmodel, trimtype, firstname " +
                                    "from inventory, customer, sales " +
                                    "where sales.customerID = customer.customerID " +
                                    "and sales.inventoryID = inventory.inventoryID";
            SqlDataAdapter salesData = new SqlDataAdapter(querySalesData, sqlcon);
            DataTable salesdtbl = new DataTable();
            salesData.Fill(salesdtbl);

            foreach (DataRow row in salesdtbl.Rows)
            {
                lbxSales.Items.Add($"{row["basecarmodel"].ToString()}{row["trimtype"].ToString()}{row["firstname"].ToString()}");
            }
        }

        private void lbxCustomers_DoubleClick(object sender, EventArgs e)
        {
            string queryCustomer = $"select customerID from customer where customerID = '" +
                $"{lbxCustomers.SelectedIndex + 1}'";
            SqlDataAdapter sda3 = new SqlDataAdapter(queryCustomer, sqlcon);
            DataTable dtbl3 = new DataTable();
            sda3.Fill(dtbl3);
            foreach (DataRow row in dtbl3.Rows)
            {
                customerID = int.Parse(row["customerID"].ToString());
            }

            MessageBox.Show(customerID.ToString());
        }

        private void lbxInventory_DoubleClick(object sender, EventArgs e)
        {
            string queryInventory = $"select inventoryID from inventory where inventoryID = '" +
                $"{lbxInventory.SelectedIndex + 1}'";
            SqlDataAdapter sda4 = new SqlDataAdapter(queryInventory, sqlcon);
            DataTable dtbl4 = new DataTable();
            sda4.Fill(dtbl4);
            foreach (DataRow row in dtbl4.Rows)
            {
                inventoryID = int.Parse(row["inventoryID"].ToString());
            }

            MessageBox.Show(inventoryID.ToString());
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string queryMakeSale = $"insert into sales values({inventoryID},{customerID});" +
                                   $"update inventory set sold = 1 where inventoryID = {inventoryID}";
            SqlDataAdapter MakeSalesda = new SqlDataAdapter(queryMakeSale, sqlcon);
            DataTable Solddtbl = new DataTable();
            MakeSalesda.Fill(Solddtbl);

            lbxSales.Items.Clear();
            fillSalesDataTable();
            lbxInventory.Items.Clear();
            fillInventoryDataTable();
        }
    }
}
