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
    public partial class ProductsViewForm : DevExpress.XtraEditors.XtraForm, GridControlInterface
    {
        public ProductsViewForm()
        {
            InitializeComponent();
        }

        private void ProductsViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Currencies' table. You can move, or remove it, as needed.
            this.currenciesTableAdapter.Fill(this.salesDatabaseDataSet.Currencies);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Parfume_Types' table. You can move, or remove it, as needed.
            this.parfume_TypesTableAdapter.Fill(this.salesDatabaseDataSet.Parfume_Types);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Parfume_Sizes' table. You can move, or remove it, as needed.
            this.parfume_SizesTableAdapter.Fill(this.salesDatabaseDataSet.Parfume_Sizes);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.salesDatabaseDataSet.Brands);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.salesDatabaseDataSet.Products);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        public void AddNewRow()
        {
            gridView1.AddNewRow();
        }

        public void DeleteRow()
        {
            gridView1.DeleteSelectedRows();
        }

        public void ExportExcel()
        {
            Utilities.Export(Utilities.EXPORT_EXCEL, "products", gridView1);
        }

        public void MergeCells()
        {
            gridView1.OptionsView.AllowCellMerge = !gridView1.OptionsView.AllowCellMerge;
        }

        public void ExportPdf()
        {

            Utilities.Export(Utilities.EXPORT_PDF, "products", gridView1);
        }

        public void PrintPage()
        {
            gridView1.Print();
        }

        public void ChangeCurrency()
        {
            throw new NotImplementedException();
        }

        public void SaveRows()
        {
            try
            {
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.productsTableAdapter.Update(this.salesDatabaseDataSet.Products);
                MessageBox.Show("Update successful");
            } catch (System.Exception)
            {
                MessageBox.Show("Update Failed.");
            }
        }


        private void UpdateDatabse()
        {

            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.SalesDatabaseConnectionString);
                cn.Open();

                DataTable dt = new DataTable();

                string sqlquery = "SELECT a1.product_id as ID , a2.name as Brand, a1.name as  Product, a1.Size, a3.name as ST, a4.name as PT " +
                                    "FROM products a1 LEFT JOIN brands a2 ON a2.brand_id = a1.brand_id " +
                                    "LEFT JOIN Parfume_Sizes a3 ON a3.size_id = a1.size_id " +
                                    "LEFT JOIN Parfume_Types a4 ON a4.type_id = a1.type_id ";
                SqlCommand command = new SqlCommand(sqlquery, cn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                 


                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Server Error");
            }
        }

        public void RefreshRows()
        {
            this.productsTableAdapter.Fill(this.salesDatabaseDataSet.Products);
        }

        public void ShowHideColumns()
        {
            gridView1.ShowCustomization();
            gridView1.CustomizationForm.Text = "Customize Box";
            gridView1.CustomizationForm.Opacity = 0.7;
            gridView1.CustomizationForm.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public void ShowCurrency(int currency_id, bool isVisible)
        {
            throw new NotImplementedException();
        }

        public void ChangeFontWeight(int type, bool isActive)
        {
            throw new NotImplementedException();
        }

        public void ChangeBackColor()
        {
            throw new NotImplementedException();
        }
    }
}