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
using DevExpress.XtraGrid.Views.Base;

namespace SaleApp
{
    public partial class SalesForm : DevExpress.XtraEditors.XtraForm, GridControlInterface
    {
        private int buyerId = 0;
        private string name = "";

        private DataTable productsDT;

        public SalesForm(int buyerId, string name)
        {
            this.buyerId = buyerId;
            this.name = name;

            InitializeComponent();
            initForm();


        }

        private void initForm()
        {
            this.productsDT = initProductLookUp();
            this.Text = "Sales (" + this.name + ")";
            BindingSource src = new BindingSource();
            src.DataSource = this.productsDT;
            repositoryItemSearchLookUpEdit1.DataSource = src;
            repositoryItemSearchLookUpEdit1.ValueMember = "ProductId";
            repositoryItemSearchLookUpEdit1.CascadingMember = "ProductId";
            repositoryItemSearchLookUpEdit1.DisplayMember = "Product";
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.salesDatabaseDataSet.Sales);
            applyFilters();
        }

        private void applyFilters()
        {
        }

        private DataRow getProductRow(int productId)
        {
            DataRow[] dr = this.productsDT.Select("ProductId = " + productId);

            DataRow cd = null;

            if (dr.Length > 0)
            {
                cd = dr[0];
            }

            return cd;
        }




        private DataTable initProductLookUp()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.SalesDatabaseConnectionString);
                cn.Open();


                string sqlquery = "SELECT a1.product_id as ProductId , a2.name as Brand, a1.name as  Product, a1.Size, a3.name as ParfumeSize, a4.name as ParfumeType " +
                                    ", a1.price as BasePrice FROM products a1 LEFT JOIN brands a2 ON a2.brand_id = a1.brand_id " +
                                    "LEFT JOIN Parfume_Sizes a3 ON a3.size_id = a1.size_id " +
                                    "LEFT JOIN Parfume_Types a4 ON a4.type_id = a1.type_id ";
                SqlCommand command = new SqlCommand(sqlquery, cn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);

                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Server Error");
            }

            return dt;
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (view.GetListSourceRowCellValue(e.ListSourceRowIndex, "product_id") != DBNull.Value)
            {
                int productId = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "product_id");
                DataRow dr = getProductRow(productId);

                if (e.Column.FieldName == "brand" && e.IsGetData)
                {
                    e.Value = dr["Brand"].ToString();

                }
                else if (e.Column.FieldName == "parfume_size" && e.IsGetData)
                {
                    e.Value = dr["ParfumeSize"].ToString();
                }
                else if (e.Column.FieldName == "parfume_type" && e.IsGetData)
                {
                    e.Value = dr["ParfumeType"].ToString();
                }
                else if (e.Column.FieldName == "base_price" && e.IsGetData)
                {
                    e.Value = Convert.ToDouble(dr["BasePrice"].ToString());
                }
                else if (e.Column.FieldName == "size" && e.IsGetData)
                {
                    e.Value = Convert.ToDouble(dr["Size"].ToString());
                }
            } else
            {
                e.Value = ""; 
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }

        public void AddNewRow()
        {
            gridView1.AddNewRow();
        }

        public void DeleteRow()
        {
            throw new NotImplementedException();
        }

        public void ExportExcel()
        {
            Utilities.Export(Utilities.EXPORT_EXCEL, "sales", gridView1);
        }

        public void ExportPdf()
        {
            Utilities.Export(Utilities.EXPORT_PDF, "sales", gridView1);
        }

        public void PrintPage()
        {
            gridView1.Print();
        }

        public void ChangeCurrency()
        {
            throw new NotImplementedException();
        }

        public void MergeCells()
        {
            gridView1.OptionsView.AllowCellMerge = !gridView1.OptionsView.AllowCellMerge;
        }

        public void SaveRows()
        {
            throw new NotImplementedException();
        }

        public void RefreshRows()
        {
            productsDT = initProductLookUp();
            this.salesTableAdapter.Fill(this.salesDatabaseDataSet.Sales);
            gridView1.RefreshData();
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