using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace SaleApp
{
    public partial class AddProduct : DevExpress.XtraEditors.XtraForm
    {
        public AddProduct()
        {
            InitializeComponent();
            initProductLookUp();


        }

        private void initProductLookUp()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.SalesDatabaseConnectionString);
                cn.Open();

                DataTable dt = new DataTable();

                string sqlquery = "SELECT a1.product_id as ID , a2.name as Brand, a1.name as  Product, a1.Size, a3.name as ST, a4.name as PT "+
                                    "FROM products a1 LEFT JOIN brands a2 ON a2.brand_id = a1.brand_id "+
                                    "LEFT JOIN Parfume_Sizes a3 ON a3.size_id = a1.size_id "+
                                    "LEFT JOIN Parfume_Types a4 ON a4.type_id = a1.type_id ";
                SqlCommand command = new SqlCommand(sqlquery, cn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                    lookUpEdit5.Properties.DataSource = dt.DefaultView;
                    lookUpEdit5.Properties.ValueMember = "ID";
                    lookUpEdit5.Properties.DisplayMember = "Product";


                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Server Error");
            }

        }


        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.salesDatabaseDataSet.Products);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Currencies' table. You can move, or remove it, as needed.
            this.currenciesTableAdapter.Fill(this.salesDatabaseDataSet.Currencies);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Parfume_Types' table. You can move, or remove it, as needed.
            this.parfume_TypesTableAdapter.Fill(this.salesDatabaseDataSet.Parfume_Types);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Parfume_Sizes' table. You can move, or remove it, as needed.
            this.parfume_SizesTableAdapter.Fill(this.salesDatabaseDataSet.Parfume_Sizes);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.salesDatabaseDataSet.Brands);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}