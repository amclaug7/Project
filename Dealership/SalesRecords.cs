using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dealership
{
    public partial class SalesRecords : Form
    {
        public SalesRecords()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrew\source\repos\Final Project\DealerDatabase\ToyotaDealer.mdf;Integrated Security=True;Connect Timeout=30");

        int customerID = 0;
        int inventoryID = 0;

        private void Dealership_Load(object sender, EventArgs e)
        {
            fillCustomerDataTable();
            fillInventoryDataTable();
            fillSalesDataTable();
        }

        private void fillCustomerDataTable()
        {
            string query = "select * from customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);            

            foreach (DataRow row in dtbl.Rows)
            {
                lbxCustomers.Items.Add($"{row["name"].ToString()}");
            }
        }

        private void lbxCustomers_DoubleClick(object sender, EventArgs e)
        {
            string queryCustomer = $"select customerID, name from customer where customerID = '" +
                $"{lbxCustomers.SelectedIndex + 1}'";
            SqlDataAdapter sda3 = new SqlDataAdapter(queryCustomer, sqlcon);
            DataTable dtbl3 = new DataTable();
            sda3.Fill(dtbl3);
            foreach (DataRow row in dtbl3.Rows)
            {
                customerID = int.Parse(row["customerID"].ToString());
                lblCustomerName.Text = row["name"].ToString();
                lblCustomerNameReview.Text = row["name"].ToString();
            }           
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            string queryEnterCustomer = $"insert into customer values('{tbxCustomerName.Text}');";
            SqlDataAdapter EnterCustomersda = new SqlDataAdapter(queryEnterCustomer, sqlcon);
            DataTable EnterCustomerdtbl = new DataTable();
            EnterCustomersda.Fill(EnterCustomerdtbl);

            lbxCustomers.Items.Clear();
            fillCustomerDataTable();

            string queryCustomer = $"select customerID, name from customer where name = " +
                $"'{tbxCustomerName.Text}';";
            SqlDataAdapter sda3 = new SqlDataAdapter(queryCustomer, sqlcon);
            DataTable dtbl3 = new DataTable();
            sda3.Fill(dtbl3);
            foreach (DataRow row in dtbl3.Rows)
            {
                customerID = int.Parse(row["customerID"].ToString());
                lblCustomerName.Text = row["name"].ToString();
                lblCustomerNameReview.Text = row["name"].ToString();
            }
        }

        private void fillInventoryDataTable()
        {
            string sold;

            string query2 = "select basecarmodel, trimtype, sold " +
                            "from inventory, basecar, trim " +
                            "where inventory.basecarID = basecar.basecarID " +
                            "and inventory.trimID = trim.trimID;";// +
                            //"and sold = 0;";
            SqlDataAdapter sda = new SqlDataAdapter(query2, sqlcon);
            DataTable dtbl2 = new DataTable();
            sda.Fill(dtbl2);

            foreach (DataRow row in dtbl2.Rows)
            {
                if (row["sold"].ToString().Trim() == "True")
                {
                    sold = "Sold";
                }
                else
                {
                    sold = "Unsold";
                }

                lbxInventory.Items.Add($"{row["basecarmodel"].ToString().Trim()}\t" +
                    $"{row["trimtype"].ToString().Trim()} \t{sold}");
            }
        }

        private void lbxInventory_DoubleClick(object sender, EventArgs e)
        {
            string queryInventory = $"select inventoryID, basecarmodel, trimtype, sold " +
                                    $"from inventory, basecar, trim " +
                                    $"where inventory.basecarID = basecar.basecarID " +
                                    $"and inventory.trimID = trim.trimID " +
                                    $"and inventoryID = {lbxInventory.SelectedIndex + 1};";
            SqlDataAdapter sda4 = new SqlDataAdapter(queryInventory, sqlcon);
            DataTable dtbl4 = new DataTable();
            sda4.Fill(dtbl4);
            foreach (DataRow row in dtbl4.Rows)
            {
                if (row["sold"].ToString().Trim() == "False")
                {
                    inventoryID = int.Parse(row["inventoryID"].ToString());
                    lblCarSelection.Text = $"{row["basecarmodel"].ToString().Trim()} " +
                        $"{row["trimtype"].ToString().Trim()}";
                    lblCarSelection2.Text = $"{row["basecarmodel"].ToString().Trim()}\n" +
                        $"{row["trimtype"].ToString().Trim()}";
                }
                else
                {
                    MessageBox.Show("Car Already Sold", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }        
        
        private void btnSellIt_Click(object sender, EventArgs e)
        {
            if (inventoryID == 0 || customerID == 0)
            {
                MessageBox.Show("Select a Customer and a Car", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else
            {
                string queryMakeSale = $"insert into sales values({inventoryID},{customerID});" +
                                       $"update inventory set sold = 1 where inventoryID = {inventoryID};";
                SqlDataAdapter MakeSalesda = new SqlDataAdapter(queryMakeSale, sqlcon);
                DataTable Solddtbl = new DataTable();
                MakeSalesda.Fill(Solddtbl);

                lbxSales.Items.Clear();
                fillSalesDataTable();
                lbxInventory.Items.Clear();
                fillInventoryDataTable();

                customerID = 0;
                inventoryID = 0;

                lblCarSelection.Text = "";
                lblCarSelection2.Text = "";
                lblCustomerName.Text = "";
                lblCustomerNameReview.Text = "";
                
                MessageBox.Show("Car Sold", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void fillSalesDataTable()
        {
            string querySalesData = "select basecarmodel, trimtype, name " +
                                    "from inventory, customer, sales, basecar, trim " +
                                    "where sales.customerID = customer.customerID " +
                                    "and sales.inventoryID = inventory.inventoryID " +
                                    "and inventory.basecarID = basecar.basecarID " +
                                    "and inventory.trimID = trim.trimID";
            SqlDataAdapter salesData = new SqlDataAdapter(querySalesData, sqlcon);
            DataTable salesdtbl = new DataTable();
            salesData.Fill(salesdtbl);

            foreach (DataRow row in salesdtbl.Rows)
            {
                lbxSales.Items.Add($"{row["basecarmodel"].ToString().Trim()}\t" +
                    $"{row["trimtype"].ToString().Trim()} \t{row["name"].ToString().Trim()}");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var f = new LogInPage();

            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
