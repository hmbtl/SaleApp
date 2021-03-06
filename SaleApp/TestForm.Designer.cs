﻿namespace SaleApp
{
    partial class TestForm
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.salesDatabaseDataSet = new SaleApp.SalesDatabaseDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.idColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brandColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.discountColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.parfumeTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.parfumeSizeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sizeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amountColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sellPriceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.basePriceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sellDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.salesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1045, 573);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1045, 573);
            this.gridSplitContainer1.TabIndex = 0;
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
            this.productColumn.FieldName = "product_id";
            this.productColumn.Name = "productColumn";
            this.productColumn.OptionsColumn.AllowEdit = false;
            this.productColumn.Visible = true;
            this.productColumn.VisibleIndex = 1;
            this.productColumn.Width = 134;
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
            this.sellDateColumn.VisibleIndex = 10;
            this.sellDateColumn.Width = 172;
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
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 573);
            this.Controls.Add(this.gridSplitContainer1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private SalesDatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn idColumn;
        private DevExpress.XtraGrid.Columns.GridColumn brandColumn;
        private DevExpress.XtraGrid.Columns.GridColumn discountColumn;
        private DevExpress.XtraGrid.Columns.GridColumn parfumeTypeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn parfumeSizeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn sizeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn amountColumn;
        private DevExpress.XtraGrid.Columns.GridColumn productColumn;
        private DevExpress.XtraGrid.Columns.GridColumn sellPriceColumn;
        private DevExpress.XtraGrid.Columns.GridColumn basePriceColumn;
        private DevExpress.XtraGrid.Columns.GridColumn sellDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}