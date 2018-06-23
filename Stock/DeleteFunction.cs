using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public class DeleteFunction
    {
       // public void DeleteButton()
        //{
        //    var sqlQuery = "";
        //    SqlConnection con = new SqlConnection("Data Source=LAPTOP-0RU2PM09;Initial Catalog=Stock;Integrated Security=True");
        //    if (IfProductExist(con, productCodeValue.Text))
        //    {
        //        sqlQuery = @"UPDATE [dbo].[Product] SET [ProductName] = '" + productNameValue.Text + "',[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + productCodeValue.Text + "'";
        //    }
        //    else
        //    {
        //        sqlQuery = @"INSERT INTO [dbo].[Product]([ProductName],[ProductCode],[ProductStatus]) VALUES
        //   ('" + productNameValue.Text + "', '" + productCodeValue.Text + "', '" + status + "')";
        //    }
        //    SqlCommand cmd = new SqlCommand(sqlQuery, con);
        //    cmd.ExecuteNonQuery();

        //    con.Close();
       // }
    }
}
