namespace SaleApp
{
    partial class SalesForm
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
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new SaleApp.SalesDatabaseDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brandColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.discountColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.parfumeTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.parfumeSizeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sizeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amountColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sellPriceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.basePriceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sellDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.salesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.tableAdapterManager = new SaleApp.SalesDatabaseDataSetTableAdapters.TableAdapterManager();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.salesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemSearchLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1190, 760);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idColumn,
            this.brandColumn,
            this.discountColumn,
            this.parfumeTypeColumn,
            this.parfumeSizeColumn,
            this.sizeColumn,
            this.amountColumn,
            this.productColumn,
            this.sellPriceColumn,
            this.basePriceColumn,
            this.sellDateColumn,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // idColumn
            // 
            this.idColumn.Caption = "Id";
            this.idColumn.FieldName = "product_id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = true;
            this.idColumn.VisibleIndex = 0;
            this.idColumn.Width = 31;
            // 
            // brandColumn
            // 
            this.brandColumn.Caption = "Brand";
            this.brandColumn.FieldName = "brand";
            this.brandColumn.Name = "brandColumn";
            this.brandColumn.OptionsColumn.AllowEdit = false;
            this.brandColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.brandColumn.Visible = true;
            this.brandColumn.VisibleIndex = 2;
            this.brandColumn.Width = 92;
            // 
            // discountColumn
            // 
            this.discountColumn.Caption = "Discount";
            this.discountColumn.DisplayFormat.FormatString = "{0} %";
            this.discountColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.discountColumn.FieldName = "discount";
            this.discountColumn.Name = "discountColumn";
            this.discountColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.discountColumn.Visible = true;
            this.discountColumn.VisibleIndex = 6;
            this.discountColumn.Width = 82;
            // 
            // parfumeTypeColumn
            // 
            this.parfumeTypeColumn.Caption = "Pafume Type";
            this.parfumeTypeColumn.FieldName = "parfume_type";
            this.parfumeTypeColumn.Name = "parfumeTypeColumn";
            this.parfumeTypeColumn.OptionsColumn.AllowEdit = false;
            this.parfumeTypeColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.parfumeTypeColumn.Visible = true;
            this.parfumeTypeColumn.VisibleIndex = 5;
            this.parfumeTypeColumn.Width = 131;
            // 
            // parfumeSizeColumn
            // 
            this.parfumeSizeColumn.Caption = "Parfume Size";
            this.parfumeSizeColumn.FieldName = "parfume_size";
            this.parfumeSizeColumn.Name = "parfumeSizeColumn";
            this.parfumeSizeColumn.OptionsColumn.AllowEdit = false;
            this.parfumeSizeColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.parfumeSizeColumn.Visible = true;
            this.parfumeSizeColumn.VisibleIndex = 4;
            this.parfumeSizeColumn.Width = 106;
            // 
            // sizeColumn
            // 
            this.sizeColumn.Caption = "Size";
            this.sizeColumn.FieldName = "size";
            this.sizeColumn.Name = "sizeColumn";
            this.sizeColumn.OptionsColumn.AllowEdit = false;
            this.sizeColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.sizeColumn.Visible = true;
            this.sizeColumn.VisibleIndex = 3;
            this.sizeColumn.Width = 89;
            // 
            // amountColumn
            // 
            this.amountColumn.Caption = "Amount";
            this.amountColumn.FieldName = "amount";
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.amountColumn.Visible = true;
            this.amountColumn.VisibleIndex = 7;
            this.amountColumn.Width = 89;
            // 
            // productColumn
            // 
            this.productColumn.Caption = "Product";
            this.productColumn.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.productColumn.FieldName = "product_id";
            this.productColumn.Name = "productColumn";
            this.productColumn.OptionsColumn.AllowEdit = false;
            this.productColumn.Visible = true;
            this.productColumn.VisibleIndex = 1;
            this.productColumn.Width = 134;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.PopupFormMinSize = new System.Drawing.Size(500, 0);
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // sellPriceColumn
            // 
            this.sellPriceColumn.Caption = "Sell Price";
            this.sellPriceColumn.FieldName = "unit_price";
            this.sellPriceColumn.Name = "sellPriceColumn";
            this.sellPriceColumn.Visible = true;
            this.sellPriceColumn.VisibleIndex = 8;
            this.sellPriceColumn.Width = 116;
            // 
            // basePriceColumn
            // 
            this.basePriceColumn.Caption = "Base Price";
            this.basePriceColumn.FieldName = "base_price";
            this.basePriceColumn.Name = "basePriceColumn";
            this.basePriceColumn.OptionsColumn.AllowEdit = false;
            this.basePriceColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.basePriceColumn.Visible = true;
            this.basePriceColumn.VisibleIndex = 9;
            this.basePriceColumn.Width = 123;
            // 
            // sellDateColumn
            // 
            this.sellDateColumn.Caption = "Sell Date";
            this.sellDateColumn.FieldName = "date_added";
            this.sellDateColumn.Name = "sellDateColumn";
            this.sellDateColumn.Visible = true;
            this.sellDateColumn.VisibleIndex = 13;
            this.sellDateColumn.Width = 172;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupFormMinSize = new System.Drawing.Size(1000, 0);
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandsTableAdapter = null;
            this.tableAdapterManager.BuyersTableAdapter = null;
            this.tableAdapterManager.CountriesTableAdapter = null;
            this.tableAdapterManager.CurrenciesTableAdapter = null;
            this.tableAdapterManager.ExchangeTableAdapter = null;
            this.tableAdapterManager.Parfume_SizesTableAdapter = null;
            this.tableAdapterManager.Parfume_TypesTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.PurchasesTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SaleApp.SalesDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sell Price (Total)";
            this.gridColumn1.FieldName = "sellPriceTotal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundExpression = "[amount] * [unit_price]";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Width = 104;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sell Price (Discounted)";
            this.gridColumn2.FieldName = "sellPriceDiscounted";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.UnboundExpression = "[unit_price] * (1 - [discount] / 100)";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sell Price (Total Discounted)";
            this.gridColumn3.FieldName = "sellPriceDiscountedTotal";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.UnboundExpression = "[sellPriceDiscounted] * [amount]";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Income";
            this.gridColumn4.FieldName = "incomePrice";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.UnboundExpression = "[sellPriceDiscounted] - [base_price]";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Income (Total)";
            this.gridColumn5.FieldName = "incomeTotal";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.UnboundExpression = "[incomePrice] * [amount]";
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 760);
            this.Controls.Add(this.gridControl1);
            this.Name = "SalesForm";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn idColumn;
        private DevExpress.XtraGrid.Columns.GridColumn brandColumn;
        private DevExpress.XtraGrid.Columns.GridColumn discountColumn;
        private DevExpress.XtraGrid.Columns.GridColumn parfumeTypeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn parfumeSizeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn sizeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn amountColumn;
        private DevExpress.XtraGrid.Columns.GridColumn productColumn;
        private DevExpress.XtraGrid.Columns.GridColumn sellPriceColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn basePriceColumn;
        private DevExpress.XtraGrid.Columns.GridColumn sellDateColumn;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private SalesDatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private SalesDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}