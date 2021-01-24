namespace SaleApp
{
    partial class Currency
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new SaleApp.SalesDatabaseDataSet();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.currenciesTableAdapter = new SaleApp.SalesDatabaseDataSetTableAdapters.CurrenciesTableAdapter();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.fromLookUp = new System.Windows.Forms.ComboBox();
            this.toLookUp = new System.Windows.Forms.ComboBox();
            this.currenciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buyValueEdit = new DevExpress.XtraEditors.TextEdit();
            this.sellValueEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyValueEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellValueEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton1.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(232, 166);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 33);
            this.simpleButton1.TabIndex = 39;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 16);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "From Currency:";
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(191, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "To Currency:";
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 16);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "Buy:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(191, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 16);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "Sell:";
            // 
            // fromLookUp
            // 
            this.fromLookUp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currenciesBindingSource, "currency_id", true));
            this.fromLookUp.DataSource = this.currenciesBindingSource;
            this.fromLookUp.DisplayMember = "name";
            this.fromLookUp.FormattingEnabled = true;
            this.fromLookUp.Location = new System.Drawing.Point(21, 54);
            this.fromLookUp.Name = "fromLookUp";
            this.fromLookUp.Size = new System.Drawing.Size(149, 24);
            this.fromLookUp.TabIndex = 49;
            this.fromLookUp.ValueMember = "currency_id";
            this.fromLookUp.SelectedIndexChanged += new System.EventHandler(this.fromLookUp_SelectedIndexChanged);
            // 
            // toLookUp
            // 
            this.toLookUp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.currenciesBindingSource1, "currency_id", true));
            this.toLookUp.DataSource = this.currenciesBindingSource1;
            this.toLookUp.DisplayMember = "name";
            this.toLookUp.FormattingEnabled = true;
            this.toLookUp.Location = new System.Drawing.Point(191, 54);
            this.toLookUp.Name = "toLookUp";
            this.toLookUp.Size = new System.Drawing.Size(149, 24);
            this.toLookUp.TabIndex = 50;
            this.toLookUp.ValueMember = "currency_id";
            this.toLookUp.SelectedIndexChanged += new System.EventHandler(this.toLookUp_SelectedIndexChanged);
            // 
            // currenciesBindingSource1
            // 
            this.currenciesBindingSource1.DataMember = "Currencies";
            this.currenciesBindingSource1.DataSource = this.salesDatabaseDataSet;
            // 
            // buyValueEdit
            // 
            this.buyValueEdit.Location = new System.Drawing.Point(21, 115);
            this.buyValueEdit.Name = "buyValueEdit";
            this.buyValueEdit.Size = new System.Drawing.Size(149, 22);
            this.buyValueEdit.TabIndex = 51;
            // 
            // sellValueEdit
            // 
            this.sellValueEdit.Location = new System.Drawing.Point(191, 115);
            this.sellValueEdit.Name = "sellValueEdit";
            this.sellValueEdit.Size = new System.Drawing.Size(149, 22);
            this.sellValueEdit.TabIndex = 52;
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 211);
            this.Controls.Add(this.sellValueEdit);
            this.Controls.Add(this.buyValueEdit);
            this.Controls.Add(this.toLookUp);
            this.Controls.Add(this.fromLookUp);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Currency";
            this.Text = "CurrencyForm";
            this.Load += new System.EventHandler(this.Currency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyValueEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellValueEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private SalesDatabaseDataSetTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox fromLookUp;
        private System.Windows.Forms.ComboBox toLookUp;
        private System.Windows.Forms.BindingSource currenciesBindingSource1;
        private DevExpress.XtraEditors.TextEdit buyValueEdit;
        private DevExpress.XtraEditors.TextEdit sellValueEdit;
    }
}