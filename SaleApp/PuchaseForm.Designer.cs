namespace SaleApp
{
    partial class PuchaseForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getPurchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new SaleApp.SalesDatabaseDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colsize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbasePriceExchanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparfumeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparfumeSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCurrencyExchange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colunitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunitPriceExchanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbuyAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscountedTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscountedTotalPriceExchanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscountedUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscountedUnitPriceExchanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalPriceExchanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalBuyAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.getPurchasesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.getPurchasesTableAdapter();
            this.productsTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.currenciesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.CurrenciesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPurchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 668);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1231, 150);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.getPurchasesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(1231, 668);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // getPurchasesBindingSource
            // 
            this.getPurchasesBindingSource.DataMember = "getPurchases";
            this.getPurchasesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colbarcode,
            this.colbrand,
            this.colproductName,
            this.colsize,
            this.colbasePrice,
            this.colbasePriceExchanged,
            this.coltotalAmount,
            this.colparfumeType,
            this.colparfumeSize,
            this.colCurrency,
            this.colCurrencyExchange,
            this.colunitPrice,
            this.colunitPriceExchanged,
            this.colDiscount,
            this.colbuyAmount,
            this.colSeller,
            this.coldiscountedTotalPrice,
            this.coldiscountedTotalPriceExchanged,
            this.coldiscountedUnitPrice,
            this.coldiscountedUnitPriceExchanged,
            this.coltotalPrice,
            this.coltotalPriceExchanged,
            this.coltotalBuyAmount,
            this.colBuyDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colbarcode
            // 
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 1;
            // 
            // colbrand
            // 
            this.colbrand.FieldName = "brand";
            this.colbrand.Name = "colbrand";
            this.colbrand.Visible = true;
            this.colbrand.VisibleIndex = 2;
            // 
            // colproductName
            // 
            this.colproductName.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colproductName.FieldName = "productName";
            this.colproductName.Name = "colproductName";
            this.colproductName.Visible = true;
            this.colproductName.VisibleIndex = 3;
            this.colproductName.Width = 193;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.CascadingMember = "product_id";
            this.repositoryItemLookUpEdit1.DataSource = this.productsBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "product_id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // colsize
            // 
            this.colsize.FieldName = "size";
            this.colsize.Name = "colsize";
            this.colsize.Visible = true;
            this.colsize.VisibleIndex = 4;
            // 
            // colbasePrice
            // 
            this.colbasePrice.FieldName = "basePrice";
            this.colbasePrice.Name = "colbasePrice";
            this.colbasePrice.Visible = true;
            this.colbasePrice.VisibleIndex = 5;
            // 
            // colbasePriceExchanged
            // 
            this.colbasePriceExchanged.FieldName = "basePriceExchanged";
            this.colbasePriceExchanged.Name = "colbasePriceExchanged";
            this.colbasePriceExchanged.Visible = true;
            this.colbasePriceExchanged.VisibleIndex = 6;
            // 
            // coltotalAmount
            // 
            this.coltotalAmount.FieldName = "totalAmount";
            this.coltotalAmount.Name = "coltotalAmount";
            this.coltotalAmount.Visible = true;
            this.coltotalAmount.VisibleIndex = 7;
            // 
            // colparfumeType
            // 
            this.colparfumeType.FieldName = "parfumeType";
            this.colparfumeType.Name = "colparfumeType";
            this.colparfumeType.Visible = true;
            this.colparfumeType.VisibleIndex = 9;
            this.colparfumeType.Width = 129;
            // 
            // colparfumeSize
            // 
            this.colparfumeSize.FieldName = "parfumeSize";
            this.colparfumeSize.Name = "colparfumeSize";
            this.colparfumeSize.Visible = true;
            this.colparfumeSize.VisibleIndex = 8;
            this.colparfumeSize.Width = 103;
            // 
            // colCurrency
            // 
            this.colCurrency.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 10;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.CascadingMember = "currency_id";
            this.repositoryItemLookUpEdit2.DataSource = this.currenciesBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "currency_id";
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // colCurrencyExchange
            // 
            this.colCurrencyExchange.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colCurrencyExchange.FieldName = "CurrencyExchange";
            this.colCurrencyExchange.Name = "colCurrencyExchange";
            this.colCurrencyExchange.Visible = true;
            this.colCurrencyExchange.VisibleIndex = 11;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.CascadingMember = "currency_id";
            this.repositoryItemLookUpEdit3.DataSource = this.currenciesBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "name";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "currency_id";
            // 
            // colunitPrice
            // 
            this.colunitPrice.FieldName = "unitPrice";
            this.colunitPrice.Name = "colunitPrice";
            this.colunitPrice.Visible = true;
            this.colunitPrice.VisibleIndex = 12;
            // 
            // colunitPriceExchanged
            // 
            this.colunitPriceExchanged.FieldName = "unitPriceExchanged";
            this.colunitPriceExchanged.Name = "colunitPriceExchanged";
            this.colunitPriceExchanged.Visible = true;
            this.colunitPriceExchanged.VisibleIndex = 13;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 14;
            // 
            // colbuyAmount
            // 
            this.colbuyAmount.FieldName = "buyAmount";
            this.colbuyAmount.Name = "colbuyAmount";
            this.colbuyAmount.Visible = true;
            this.colbuyAmount.VisibleIndex = 15;
            // 
            // colSeller
            // 
            this.colSeller.FieldName = "Seller";
            this.colSeller.Name = "colSeller";
            this.colSeller.Visible = true;
            this.colSeller.VisibleIndex = 16;
            // 
            // coldiscountedTotalPrice
            // 
            this.coldiscountedTotalPrice.FieldName = "discountedTotalPrice";
            this.coldiscountedTotalPrice.Name = "coldiscountedTotalPrice";
            this.coldiscountedTotalPrice.Visible = true;
            this.coldiscountedTotalPrice.VisibleIndex = 17;
            // 
            // coldiscountedTotalPriceExchanged
            // 
            this.coldiscountedTotalPriceExchanged.FieldName = "discountedTotalPriceExchanged";
            this.coldiscountedTotalPriceExchanged.Name = "coldiscountedTotalPriceExchanged";
            this.coldiscountedTotalPriceExchanged.Visible = true;
            this.coldiscountedTotalPriceExchanged.VisibleIndex = 18;
            // 
            // coldiscountedUnitPrice
            // 
            this.coldiscountedUnitPrice.FieldName = "discountedUnitPrice";
            this.coldiscountedUnitPrice.Name = "coldiscountedUnitPrice";
            this.coldiscountedUnitPrice.Visible = true;
            this.coldiscountedUnitPrice.VisibleIndex = 19;
            // 
            // coldiscountedUnitPriceExchanged
            // 
            this.coldiscountedUnitPriceExchanged.FieldName = "discountedUnitPriceExchanged";
            this.coldiscountedUnitPriceExchanged.Name = "coldiscountedUnitPriceExchanged";
            this.coldiscountedUnitPriceExchanged.Visible = true;
            this.coldiscountedUnitPriceExchanged.VisibleIndex = 20;
            // 
            // coltotalPrice
            // 
            this.coltotalPrice.FieldName = "totalPrice";
            this.coltotalPrice.Name = "coltotalPrice";
            this.coltotalPrice.Visible = true;
            this.coltotalPrice.VisibleIndex = 21;
            // 
            // coltotalPriceExchanged
            // 
            this.coltotalPriceExchanged.FieldName = "totalPriceExchanged";
            this.coltotalPriceExchanged.Name = "coltotalPriceExchanged";
            this.coltotalPriceExchanged.Visible = true;
            this.coltotalPriceExchanged.VisibleIndex = 22;
            // 
            // coltotalBuyAmount
            // 
            this.coltotalBuyAmount.FieldName = "totalBuyAmount";
            this.coltotalBuyAmount.Name = "coltotalBuyAmount";
            this.coltotalBuyAmount.Visible = true;
            this.coltotalBuyAmount.VisibleIndex = 23;
            // 
            // colBuyDate
            // 
            this.colBuyDate.FieldName = "BuyDate";
            this.colBuyDate.Name = "colBuyDate";
            this.colBuyDate.Visible = true;
            this.colBuyDate.VisibleIndex = 24;
            // 
            // getPurchasesTableAdapter
            // 
            this.getPurchasesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // PuchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 818);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "PuchaseForm";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.XtraForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPurchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource getPurchasesBindingSource;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colbrand;
        private DevExpress.XtraGrid.Columns.GridColumn colproductName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colsize;
        private DevExpress.XtraGrid.Columns.GridColumn colbasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colbasePriceExchanged;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colparfumeType;
        private DevExpress.XtraGrid.Columns.GridColumn colparfumeSize;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyExchange;
        private DevExpress.XtraGrid.Columns.GridColumn colunitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colunitPriceExchanged;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colbuyAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSeller;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscountedTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscountedTotalPriceExchanged;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscountedUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscountedUnitPriceExchanged;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalPriceExchanged;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalBuyAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyDate;
        private SalesDatabaseDataSetTableAdapters.getPurchasesTableAdapter getPurchasesTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private SalesDatabaseDataSetTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
    }
}