using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Dealership
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrew\source\repos\Final Project\DealerDatabase\ToyotaDealer.mdf;Integrated Security=True;Connect Timeout=30");


        private void LogInPage_Load(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = true;
        }

        private void btnCheckCredentials_Click(object sender, EventArgs e)
        {
            var f = new SalesRecords();
            var g = new FactoryOrder();			

			string username = tbxUsername.Text;
            string password = tbxPassword.Text;

			string sha256(string randomString)
			{
				var crypt = new SHA256Managed();
				var hash = new StringBuilder();
				byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
				foreach (byte theByte in crypto)
				{
					hash.Append(theByte.ToString("x2"));
				}
				return hash.ToString();
			}

			string query = $"select username, password, employeetype from employee " +
                           $"where username = '{username}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    if (row["password"].ToString().Trim() != sha256(password))
                    {
                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.Parse(row["employeetype"].ToString()) == 1)
                        {
                            this.Hide();
                            f.ShowDialog();
                            this.Close();
                        }
                        else if(int.Parse(row["employeetype"].ToString()) == 2)
                        {
                            this.Hide();
                            g.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }            
        }
    }
}
