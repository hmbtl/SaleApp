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
    public partial class Currency : DevExpress.XtraEditors.XtraForm
    {
        public Currency()
        {
            InitializeComponent();
        }

        private void Currency_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Currencies' table. You can move, or remove it, as needed.
            this.currenciesTableAdapter.Fill(this.salesDatabaseDataSet.Currencies);

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private bool getCurrency()
        {

            bool hasValue = false;

            if (fromLookUp.SelectedValue != null && toLookUp.SelectedValue != null)
            {

                try
                {
                    SqlConnection cn = new SqlConnection(Properties.Settings.Default.SalesDatabaseConnectionString);
                    cn.Open();

                    DataTable dt = new DataTable();

                    string sqlquery = "SELECT * FROM Exchange WHERE currency_from_id = @currency_from AND currency_to_id = @currency_to";
                    SqlCommand command = new SqlCommand(sqlquery, cn);
                    command.Parameters.AddWithValue("@currency_from", Convert.ToInt32(fromLookUp.SelectedValue));
                    command.Parameters.AddWithValue("@currency_to", Convert.ToInt32(toLookUp.SelectedValue));
                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        dt.Load(reader);

                        foreach (DataRow dr in dt.Rows)
                        {

                            sellValueEdit.Text = dr["CONVERSION_VALUE"].ToString();
                            buyValueEdit.Text = dr["INVERSE_CONVERSION_VALUE"].ToString();
                        }


                        hasValue = true;
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Server Error");
                }
            }
            return hasValue;
        }

       

        private void saveCurrency()
        {

            if (fromLookUp.SelectedValue != null && toLookUp.SelectedValue != null)
            {

                try
                {
                    SqlConnection cn = new SqlConnection(Properties.Settings.Default.SalesDatabaseConnectionString);
                    cn.Open();


                    string sqlquery = "SELECT 1 FROM Exchange WHERE currency_from_id = @currency_from AND currency_to_id = @currency_to";
                    SqlCommand command = new SqlCommand(sqlquery, cn);
                    command.Parameters.AddWithValue("@currency_from", Convert.ToInt32(fromLookUp.SelectedValue));
                    command.Parameters.AddWithValue("@currency_to", Convert.ToInt32(toLookUp.SelectedValue));
                    SqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {

                        sqlquery = "UPDATE Exchange SET conversion_value = @conversion_value, inverse_conversion_value = @inverse_conversion_value" +
                            " WHERE currency_from_id = @currency_from AND currency_to_id = @currency_to";

                    }
                    else
                    {
                        sqlquery = "INSERT Exchange (conversion_value,  inverse_conversion_value, currency_from_id,currency_to_id)" +
                            "  VALUES(@conversion_value,  @inverse_conversion_value, @currency_from, @currency_to)";
                    }

                    reader.Close();
                    command = new SqlCommand(sqlquery, cn);
                    command.Parameters.AddWithValue("@currency_from", Convert.ToInt32(fromLookUp.SelectedValue));
                    command.Parameters.AddWithValue("@currency_to", Convert.ToInt32(toLookUp.SelectedValue));
                    command.Parameters.AddWithValue("@conversion_value", Convert.ToDouble(sellValueEdit.Text));
                    command.Parameters.AddWithValue("@inverse_conversion_value", Convert.ToDouble(buyValueEdit.Text));
                    command.ExecuteNonQuery();

                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Server Error");
                }
            }
        }


        private void fromLookUp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!getCurrency())
            {
                sellValueEdit.Text = "";
                buyValueEdit.Text = "";
            }
        }

        private void toLookUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!getCurrency())
            {
                sellValueEdit.Text = "";
                buyValueEdit.Text = "";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            saveCurrency();

        }
    }
}