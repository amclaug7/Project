using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dealership
{
    public partial class FactoryOrder : Form
    {
        public FactoryOrder()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrew\Desktop\ToyotaDealer.mdf;Integrated Security=True;Connect Timeout=30");

        string vin;
        int basecarID;
        int trimID;

        private void FactoryOrder_Load(object sender, EventArgs e)
        {
            string query = "select basecarmodel " +
                           "from basecar;";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            foreach (DataRow row in dtbl.Rows)
            {
                cbxModel.Items.Add($"{row["basecarmodel"].ToString().Trim()}");
            }
            
            fillInventoryDataTable();
        }

        private void fillInventoryDataTable()
        {
            string query = "select vin, basecarmodel, trimtype " +
                            "from inventory, basecar, trim " +
                            "where inventory.basecarID = basecar.basecarID " +
                            "and inventory.trimID = trim.trimID " +
                            "and sold = 0";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            foreach (DataRow row in dtbl.Rows)
            {
                listBox1.Items.Add($"{row["vin"].ToString().Trim()}\t" +
                    $"{row["basecarmodel"].ToString().Trim()}\t{row["trimtype"].ToString().Trim()}");
            }
        }

        private void cbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            basecarID = cbxModel.SelectedIndex + 1;

            string query2 = $"select trimtype " +
                            $"from trim " +
                            $"where trim.basecarID = {basecarID};";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon);
            DataTable dtbl2 = new DataTable();
            sda2.Fill(dtbl2);

            foreach (DataRow row in dtbl2.Rows)
            {
                cbxTrim.Items.Add($"{row["trimtype"].ToString().Trim()}");
            }
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            trimID = cbxTrim.SelectedIndex + 1;
            vin = "AAAAAAAAAAAAAAAA";

            string queryMakeOrder = $"insert into inventory values('{vin}',{basecarID},{trimID},0);";
            SqlDataAdapter MakeOrdersda = new SqlDataAdapter(queryMakeOrder, sqlcon);
            DataTable Orderdtbl = new DataTable();
            MakeOrdersda.Fill(Orderdtbl);

            listBox1.Items.Clear();
            fillInventoryDataTable();

            basecarID = 0;
            trimID = 0;

            cbxModel.SelectedIndex = -1;
            cbxTrim.SelectedIndex = -1;
            cbxTrim.Items.Clear();

            MessageBox.Show("Car Ordered");
        }        
    }
}
