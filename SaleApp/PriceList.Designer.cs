namespace SaleApp
{
    partial class PriceList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.salesDatabaseDataSet1 = new SaleApp.SalesDatabaseDataSet();
            this.productsTableAdapter1 = new SaleApp.SalesDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new SaleApp.SalesDatabaseDataSet();
            this.parfumeTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parfumeSizesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandsTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.BrandsTableAdapter();
            this.parfume_TypesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.Parfume_TypesTableAdapter();
            this.parfume_SizesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.Parfume_SizesTableAdapter();
            this.currenciesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.CurrenciesTableAdapter();
            this.tableAdapterManager = new SaleApp.SalesDatabaseDataSetTableAdapters.TableAdapterManager();
            this.exchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exchangeTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.ExchangeTableAdapter();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.priceListGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbrand_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsize_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parfumeTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parfumeSizesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // salesDatabaseDataSet1
            // 
            this.salesDatabaseDataSet1.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parfumeTypesBindingSource
            // 
            this.parfumeTypesBindingSource.DataMember = "Parfume_Types";
            this.parfumeTypesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // parfumeSizesBindingSource
            // 
            this.parfumeSizesBindingSource.DataMember = "Parfume_Sizes";
            this.parfumeSizesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.salesDatabaseDataSet1;
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // parfume_TypesTableAdapter
            // 
            this.parfume_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // parfume_SizesTableAdapter
            // 
            this.parfume_SizesTableAdapter.ClearBeforeFill = true;
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandsTableAdapter = this.brandsTableAdapter;
            this.tableAdapterManager.BuyersTableAdapter = null;
            this.tableAdapterManager.CountriesTableAdapter = null;
            this.tableAdapterManager.CurrenciesTableAdapter = this.currenciesTableAdapter;
            this.tableAdapterManager.ExchangeTableAdapter = null;
            this.tableAdapterManager.Parfume_SizesTableAdapter = this.parfume_SizesTableAdapter;
            this.tableAdapterManager.Parfume_TypesTableAdapter = this.parfume_TypesTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter1;
            this.tableAdapterManager.PurchasesTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SaleApp.SalesDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // exchangeBindingSource
            // 
            this.exchangeBindingSource.DataMember = "Exchange";
            this.exchangeBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // exchangeTableAdapter
            // 
            this.exchangeTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.CascadingMember = "brand_id";
            this.repositoryItemLookUpEdit1.DataSource = this.brandsBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "brand_id";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.CascadingMember = "type_id";
            this.repositoryItemLookUpEdit2.DataSource = this.parfumeTypesBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "type_id";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.CascadingMember = "size_id";
            this.repositoryItemLookUpEdit3.DataSource = this.parfumeSizesBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "name";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "size_id";
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.CascadingMember = "currency_id";
            this.repositoryItemLookUpEdit4.DataSource = this.currenciesBindingSource;
            this.repositoryItemLookUpEdit4.DisplayMember = "name";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.ValueMember = "currency_id";
            // 
            // priceListGrid
            // 
            this.priceListGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colbrand_id,
            this.colprice,
            this.colsize,
            this.colquantity,
            this.coltype_id,
            this.colsize_id,
            this.gridColumn1});
            this.priceListGrid.GridControl = this.gridControl1;
            this.priceListGrid.Name = "priceListGrid";
            this.priceListGrid.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.priceListGrid.OptionsView.ColumnAutoWidth = false;
            this.priceListGrid.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData_1);
            this.priceListGrid.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colname
            // 
            this.colname.Caption = "Product Name";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 103;
            // 
            // colbrand_id
            // 
            this.colbrand_id.Caption = "Brand";
            this.colbrand_id.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colbrand_id.FieldName = "brand_id";
            this.colbrand_id.Name = "colbrand_id";
            this.colbrand_id.Visible = true;
            this.colbrand_id.VisibleIndex = 0;
            this.colbrand_id.Width = 103;
            // 
            // colprice
            // 
            this.colprice.Caption = "Price";
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 6;
            this.colprice.Width = 69;
            // 
            // colsize
            // 
            this.colsize.Caption = "Size ML";
            this.colsize.FieldName = "size";
            this.colsize.Name = "colsize";
            this.colsize.Visible = true;
            this.colsize.VisibleIndex = 2;
            this.colsize.Width = 103;
            // 
            // colquantity
            // 
            this.colquantity.Caption = "Amount";
            this.colquantity.FieldName = "quantity";
            this.colquantity.Name = "colquantity";
            this.colquantity.Visible = true;
            this.colquantity.VisibleIndex = 5;
            this.colquantity.Width = 103;
            // 
            // coltype_id
            // 
            this.coltype_id.Caption = "Parfume Type";
            this.coltype_id.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.coltype_id.FieldName = "type_id";
            this.coltype_id.Name = "coltype_id";
            this.coltype_id.Visible = true;
            this.coltype_id.VisibleIndex = 4;
            this.coltype_id.Width = 103;
            // 
            // colsize_id
            // 
            this.colsize_id.Caption = "Size Type";
            this.colsize_id.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colsize_id.FieldName = "size_id";
            this.colsize_id.Name = "colsize_id";
            this.colsize_id.Visible = true;
            this.colsize_id.VisibleIndex = 3;
            this.colsize_id.Width = 103;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.priceListGrid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4});
            this.gridControl1.Size = new System.Drawing.Size(959, 537);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.priceListGrid});
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Total";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundExpression = "[price] * [quantity]";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 145;
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 537);
            this.Controls.Add(this.gridControl1);
            this.Name = "PriceList";
            this.Text = "PriceList";
            this.Load += new System.EventHandler(this.PriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parfumeTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parfumeSizesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SalesDatabaseDataSet salesDatabaseDataSet1;
        private SalesDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private SalesDatabaseDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private System.Windows.Forms.BindingSource parfumeTypesBindingSource;
        private SalesDatabaseDataSetTableAdapters.Parfume_TypesTableAdapter parfume_TypesTableAdapter;
        private System.Windows.Forms.BindingSource parfumeSizesBindingSource;
        private SalesDatabaseDataSetTableAdapters.Parfume_SizesTableAdapter parfume_SizesTableAdapter;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private SalesDatabaseDataSetTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
        private SalesDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource exchangeBindingSource;
        private SalesDatabaseDataSetTableAdapters.ExchangeTableAdapter exchangeTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView priceListGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colbrand_id;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colsize;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn coltype_id;
        private DevExpress.XtraGrid.Columns.GridColumn colsize_id;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}