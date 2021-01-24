namespace SaleApp
{
    partial class ProductsViewForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new SaleApp.SalesDatabaseDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbrand_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.parfumeTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colsize_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.parfumeSizesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coldate_added = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrency_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productsTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.brandsTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.BrandsTableAdapter();
            this.parfume_SizesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.Parfume_SizesTableAdapter();
            this.parfume_TypesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.Parfume_TypesTableAdapter();
            this.currenciesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.CurrenciesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parfumeTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parfumeSizesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4,
            this.repositoryItemLookUpEdit5});
            this.gridControl1.Size = new System.Drawing.Size(1086, 522);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colbrand_id,
            this.colprice,
            this.colsize,
            this.colquantity,
            this.type_id,
            this.colsize_id,
            this.coldate_added,
            this.colcurrency_id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 163;
            // 
            // colbrand_id
            // 
            this.colbrand_id.Caption = "brand";
            this.colbrand_id.ColumnEdit = this.repositoryItemLookUpEdit5;
            this.colbrand_id.FieldName = "brand_id";
            this.colbrand_id.Name = "colbrand_id";
            this.colbrand_id.Visible = true;
            this.colbrand_id.VisibleIndex = 0;
            this.colbrand_id.Width = 133;
            // 
            // repositoryItemLookUpEdit5
            // 
            this.repositoryItemLookUpEdit5.AutoHeight = false;
            this.repositoryItemLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit5.CascadingMember = "brand_id";
            this.repositoryItemLookUpEdit5.DataSource = this.brandsBindingSource;
            this.repositoryItemLookUpEdit5.DisplayMember = "name";
            this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
            this.repositoryItemLookUpEdit5.ValueMember = "brand_id";
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // colprice
            // 
            this.colprice.DisplayFormat.FormatString = "{0} AZN";
            this.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 2;
            this.colprice.Width = 76;
            // 
            // colsize
            // 
            this.colsize.FieldName = "size";
            this.colsize.Name = "colsize";
            this.colsize.Visible = true;
            this.colsize.VisibleIndex = 3;
            this.colsize.Width = 63;
            // 
            // colquantity
            // 
            this.colquantity.FieldName = "quantity";
            this.colquantity.Name = "colquantity";
            this.colquantity.Visible = true;
            this.colquantity.VisibleIndex = 6;
            this.colquantity.Width = 121;
            // 
            // type_id
            // 
            this.type_id.Caption = "parfume type";
            this.type_id.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.type_id.FieldName = "type_id";
            this.type_id.Name = "type_id";
            this.type_id.Visible = true;
            this.type_id.VisibleIndex = 5;
            this.type_id.Width = 141;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.CascadingMember = "type_id";
            this.repositoryItemLookUpEdit3.DataSource = this.parfumeTypesBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "name";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "type_id";
            // 
            // parfumeTypesBindingSource
            // 
            this.parfumeTypesBindingSource.DataMember = "Parfume_Types";
            this.parfumeTypesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // colsize_id
            // 
            this.colsize_id.Caption = "size type";
            this.colsize_id.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colsize_id.FieldName = "size_id";
            this.colsize_id.Name = "colsize_id";
            this.colsize_id.Visible = true;
            this.colsize_id.VisibleIndex = 4;
            this.colsize_id.Width = 101;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.CascadingMember = "size_id";
            this.repositoryItemLookUpEdit2.DataSource = this.parfumeSizesBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "size_id";
            // 
            // parfumeSizesBindingSource
            // 
            this.parfumeSizesBindingSource.DataMember = "Parfume_Sizes";
            this.parfumeSizesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // coldate_added
            // 
            this.coldate_added.FieldName = "date_added";
            this.coldate_added.Name = "coldate_added";
            this.coldate_added.Visible = true;
            this.coldate_added.VisibleIndex = 8;
            this.coldate_added.Width = 141;
            // 
            // colcurrency_id
            // 
            this.colcurrency_id.Caption = "currency";
            this.colcurrency_id.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colcurrency_id.FieldName = "currency_id";
            this.colcurrency_id.Name = "colcurrency_id";
            this.colcurrency_id.Visible = true;
            this.colcurrency_id.VisibleIndex = 7;
            this.colcurrency_id.Width = 122;
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
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // parfume_SizesTableAdapter
            // 
            this.parfume_SizesTableAdapter.ClearBeforeFill = true;
            // 
            // parfume_TypesTableAdapter
            // 
            this.parfume_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // ProductsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 522);
            this.Controls.Add(this.gridControl1);
            this.Name = "ProductsViewForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parfumeTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parfumeSizesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colbrand_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colsize;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn type_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colsize_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_added;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrency_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private SalesDatabaseDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private System.Windows.Forms.BindingSource parfumeSizesBindingSource;
        private SalesDatabaseDataSetTableAdapters.Parfume_SizesTableAdapter parfume_SizesTableAdapter;
        private System.Windows.Forms.BindingSource parfumeTypesBindingSource;
        private SalesDatabaseDataSetTableAdapters.Parfume_TypesTableAdapter parfume_TypesTableAdapter;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private SalesDatabaseDataSetTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
    }
}