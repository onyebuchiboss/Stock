using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Products : Form
    {

        
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0RU2PM09;Initial Catalog=Stock;Integrated Security=True");

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            statusValue.SelectedIndex = 0;
            LoadDataIntoGrid();
           // Delete();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //changing the value of the index combobox
            bool status;
            if (statusValue.SelectedIndex == 0)
            {
                status = true;
            }
            else { status = false; }
            var sqlQuery = "";

            con.Open();


            //checking if the record exist to update or otherwise just insert into the table 
            if (IfProductExist(con, productCodeValue.Text))
            {
                sqlQuery = @"UPDATE [dbo].[Product] SET [ProductName] = '" + productNameValue.Text + "',[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + productCodeValue.Text + "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO [dbo].[Product]([ProductName],[ProductCode],[ProductStatus]) VALUES
           ('" + productNameValue.Text + "', '" + productCodeValue.Text + "', '" + status + "')";
            }
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();

            con.Close();

            //reading data
            LoadDataIntoGrid();
           
        }

        public void LoadDataIntoGrid()
        {
            //reading data
            
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Stock].[dbo].[Product]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            productGridView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = productGridView.Rows.Add();
                productGridView.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                productGridView.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                //productGridView.Rows[n].Cells[2].Value = item["ProductStatus"].ToString();

                if ((bool)item["ProductStatus"])
                {
                    productGridView.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    productGridView.Rows[n].Cells[0].Value = "Deactive";
                }
            }
        }

        private void productGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            productCodeValue.Text = productGridView.SelectedRows[0].Cells[0].Value.ToString();
            productNameValue.Text = productGridView.SelectedRows[0].Cells[1].Value.ToString();

            if (productGridView.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                statusValue.SelectedIndex = 0;
            }
            else
            {
                statusValue.SelectedIndex = 1;
            }
            
        }


       //update method
       public bool IfProductExist(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Stock].[dbo].[Product] WHERE [ProductCode] = '" + productCodeValue.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        public void Delete()
        {
            var sqlQuery = "";
            if (IfProductExist(con, productCodeValue.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [Stock].[dbo].[Product] WHERE [ProductCode] = '" + productCodeValue.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            else
            {
                MessageBox.Show("No record of product found", "No Record found", MessageBoxButtons.OK);
            }
            
            //reading data
            LoadDataIntoGrid();
        }


        
    }
}
