using DevExpress.XtraNavBar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaleApp
{
    public partial class SalesManagerForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private DataTable sellerDt, buyersDt;

        public SalesManagerForm()
        {
            InitializeComponent();
            populateNavSales();
            //fillSeller();
        }


        private void populateNavSales()
        {

            sellerDt = getSellers();
            buyersDt = getBuyers();

            foreach (DataRow dr in sellerDt.Rows)
            {
                NavBarItem item = new NavBarItem();
                item.Caption = dr["NAME"].ToString();
                productNavGroup.ItemLinks.Add(item);

            }

            foreach (DataRow dr in buyersDt.Rows)
            {
                NavBarItem item = new NavBarItem();
                item.Caption = dr["NAME"].ToString();
                buyerNavGroup.ItemLinks.Add(item);

            }
        }


        private DataTable getBuyers()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.SalesDatabaseConnectionString);
                cn.Open();

                string sqlquery = "SELECT name,buyer_id FROM Buyers";
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


        private DataTable getSellers()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.SalesDatabaseConnectionString);
                cn.Open();

                string sqlquery = "SELECT name,seller_id FROM Sellers";
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


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }




        private void navBarItem1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            if (e.Link.Group.Caption == "Purchases")
            {

                foreach (DataRow dr in sellerDt.Rows)
                {
                    int seller_id = Convert.ToInt32(dr["SELLER_ID"].ToString());
                    string name = dr["NAME"].ToString();

                    if (e.Link.Item.Caption == "Add Seller")
                    {
                        MessageBox.Show("Add Seller Box");
                        break;
                    }
                    else if (e.Link.Item.Caption == name)
                    {
                        PuchaseForm fm1 = new PuchaseForm(seller_id, name, 2);
                        fm1.MdiParent = this;
                        fm1.Show();
                    }
                }
            } else if (e.Link.Group.Caption == "Sales")
            {
                foreach (DataRow dr in buyersDt.Rows)
                {
                    int buyerId = Convert.ToInt32(dr["BUYER_ID"].ToString());
                    string name = dr["NAME"].ToString();


                    if (e.Link.Item.Caption == "Add Buyer")
                    {
                        MessageBox.Show("Add Buyer Box");
                        break;
                    }
                    else if (e.Link.Item.Caption == name)
                    {
                        SalesForm fm1 = new SalesForm(buyerId, name);
                        fm1.MdiParent = this;
                        fm1.Show();
                    }
                }
            }
            else if (e.Link.Group.Caption == "Advanced Options")
            {
                if (e.Link.Item.Caption == "Products")
                {
                    ProductsViewForm pdv = new ProductsViewForm();
                    pdv.MdiParent = this;
                    pdv.Show();
                }
            }
            else if (e.Link.Group.Caption == "Reports")
            {
                if (e.Link.Item.Caption == "Price List")
                {
                    PriceList pdv = new PriceList();
                    pdv.MdiParent = this;
                    pdv.Show();
                }
            }

        }


        private void printButtonClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).PrintPage();
            }
        }

        private void excelButtonClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).ExportExcel();
            }
        }

        private void mergeButtonClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).MergeCells();
            }
        }

        private void rowRemoveButtonClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).DeleteRow();
            }
        }

        private void rowAddButtonClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).AddNewRow();
            }
        }

        private void saveChangesClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).SaveRows();
            }
        }

        private void refreshRowsClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).RefreshRows();
            }
        }

        private void pdfExportClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).ExportPdf();
            }
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void showHideColumnClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).ShowHideColumns();
            }
        }

        private void barCheckItem3_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Checked");
        }

        private void currencyChecked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int currencyId = 1;
            bool isChecked = false;

            if (e.Link.Caption == "USD")
            {
                currencyId = 2;
                isChecked = usdCheck.Checked;
            }
            else if (e.Link.Caption == "AZN")
            {
                currencyId = 1;
                isChecked = aznCheck.Checked;
            }
            else if (e.Link.Caption == "EUR")
            {
                currencyId = 3;
                isChecked = eurCheck.Checked;
            }
            else if (e.Link.Caption == "AED")
            {
                currencyId = 4;
                isChecked = aedCheck.Checked;
            }
            else if (e.Link.Caption == "RUB")
            {
                currencyId = 5;
                isChecked = rurCheck.Checked;
            }

            if (ActiveMdiChild is GridControlInterface)
            {
                ((GridControlInterface)ActiveMdiChild).ShowCurrency(currencyId,isChecked);
            }

        }

        private void textColorChangeClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barEditItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void currencyButtonClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Currency currencyControl = new Currency();
            currencyControl.Show();
        }

    }
}
