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
using Stock;

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Focus();

            UserNameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //connect to SQL database
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0RU2PM09;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                                                   FROM [dbo].[Login] where UserName = '"+UserNameTextBox.Text+"' and Password = '"+passwordTextBox.Text+"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //if the username and password is wrong, the dt has a value of null

            //TO-DO: ckecklogin detail
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                StockMain main = new StockMain();
                main.Show();
            }
            else {
                UserNameTextBox.Clear();
                passwordTextBox.Clear();
                MessageBox.Show("Incorrect username and password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
        }
    }
}
