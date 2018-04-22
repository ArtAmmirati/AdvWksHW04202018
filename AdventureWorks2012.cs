using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace salesOrderIDLookUp
{
    public partial class MasterForm : Form
    {//establishing connection to sql server
        const string ConnString = @"Server=DTPLAPTOP02;Database=AdventureWorks2012;Trusted_Connection=True;User ID=AdvWorks2012;Password=1234 ";
        SqlConnection sqlConnection = new SqlConnection(ConnString);

        public MasterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//assignining the Customer list to the data adapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("dbo.sp_CustomerList", ConnString);
            DataTable dtCBCust = new DataTable();

            int CustomerID;
            string Customer;

            try
            {
                sqlDataAdapter.Fill(dtCBCust);

                foreach (DataRow drCustomer in dtCBCust.Rows)
                {
                    CustomerID = int.Parse(drCustomer.ItemArray[0].ToString());
                    Customer = drCustomer.ItemArray[1].ToString();
                    CustomerCB.Items.Add(new cboObject(CustomerID, Customer));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CustomerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboObject current = (cboObject)CustomerCB.SelectedItem;
            int CustomerID = current.CustomerID;
            DataTable dtCustomerOrders = new DataTable();

            try
            {// passing the stored procedure 'sales' to sql
                SqlCommand sqlCom = new SqlCommand("dbo.sp_SalesBS1", sqlConnection);
                sqlCom.CommandType = CommandType.StoredProcedure;
                //establishing the parameter to the customer id
                SqlParameter prmCustID = new SqlParameter("@CustomerID", CustomerID);
                sqlCom.Parameters.Add(prmCustID);

                SqlDataAdapter dataFeed = new SqlDataAdapter(sqlCom);

                dataFeed.Fill(dtCustomerOrders);

                dataGrid.DataSource = dtCustomerOrders;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //setting up the object class for the insertion into the data grid
        public class cboObject
        {
            int customerID;
            string customerName;


            public cboObject(int CustomerID, string CustomName)
            {
                customerID = CustomerID;
                customerName = CustomName;
            }


            public cboObject(string CustomerName)
            {
                customerName = CustomerName;
            }


            public int CustomerID
            {
                get { return customerID; }
                set { customerID = value; }
            }


            public string CustomName
            {
                get { return customerName; }
                set { customerName = value; }
            }


            public override string ToString()
            {
                return CustomName;
            }

        }

        private void salesOrderIDTB_TextChanged(object sender, EventArgs e)
        {

        }
        // Trying to fill the sale order id into the text box...not working

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                salesOrderIDTB.Text = row.Cells[0].Value.ToString();

            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


