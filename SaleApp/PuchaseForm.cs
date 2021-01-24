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
using System.IO;

namespace SaleApp
{
    public partial class PuchaseForm : DevExpress.XtraEditors.XtraForm, GridControlInterface
    {

        private int sellerId, currencyId;
        public PuchaseForm(int sellerId, string name, int currencyId)
        {
            InitializeComponent();
            this.Text = name;
            this.sellerId = sellerId;
            this.currencyId = currencyId;
            getPurchasesTableAdapter.Fill(salesDatabaseDataSet.getPurchases, this.sellerId, this.currencyId);

        }

      

        private void XtraForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Currencies' table. You can move, or remove it, as needed.
            this.currenciesTableAdapter.Fill(this.salesDatabaseDataSet.Currencies);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.salesDatabaseDataSet.Products);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Currencies' table. You can move, or remove it, as needed.
            this.currenciesTableAdapter.Fill(this.salesDatabaseDataSet.Currencies);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.salesDatabaseDataSet.Products);

        }

        public void exportPdf()
        {
            
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "export.xlsx";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(saveFile.FileName);
            }
            
        }

        public void printFile()
        {
            gridView1.Print();
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

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "products_export_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(saveFile.FileName);
            }
        }

        public void MergeCells()
        {
            gridView1.OptionsView.AllowCellMerge = !gridView1.OptionsView.AllowCellMerge;
        }

        public void ExportPdf()
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "products_export_" + DateTime.Now.ToString("dd_MM_yyyy") + ".pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(saveFile.FileName);
            }
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
            throw new NotImplementedException();
        }

        public void RefreshRows()
        {
            this.getPurchasesTableAdapter.Fill(this.salesDatabaseDataSet.getPurchases,this.sellerId,this.currencyId);
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