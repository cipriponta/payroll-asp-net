using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using Oracle.Web;
using System.Text;
using System.Security.Cryptography;

namespace IncomeCalculator
{
    public partial class Percentages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                UpdateUI();
            }
        }

        protected void btnChangePercentages_Click(object sender, EventArgs e)
        {
            bool updateUI = false;

            if(!Session["TaxPension"].Equals(tbTaxPension.Text))
            {
                ExecuteUpdateCommand("UPDATE PERCENTAGES SET DEFAULT_PERCENTAGE_TAX_PENSION = " + tbTaxPension.Text);
                updateUI = true;
            }
            if (!Session["TaxHealth"].Equals(tbTaxHealth.Text))
            {
                ExecuteUpdateCommand("UPDATE PERCENTAGES SET DEFAULT_PERCENTAGE_TAX_HEALTH = " + tbTaxHealth.Text);
                updateUI = true;
            }
            if (!Session["TaxIncome"].Equals(tbTaxIncome.Text))
            {
                ExecuteUpdateCommand("UPDATE PERCENTAGES SET DEFAULT_PERCENTAGE_TAX_INCOME = " + tbTaxIncome.Text);
                updateUI = true;
            }
            if (!Session["GrossIncrease"].Equals(tbGrossIncrease.Text))
            {
                ExecuteUpdateCommand("UPDATE PERCENTAGES SET DEFAULT_PERCENTAGE_GROSS_INCREASE = " + tbGrossIncrease.Text);
                updateUI = true;
            }
            if (!Session["Deductions"].Equals(tbDeductions.Text))
            {
                ExecuteUpdateCommand("UPDATE PERCENTAGES SET DEFAULT_VALUE_DEDUCTIONS = " + tbDeductions.Text);
                updateUI = true;
            }
            if (!Session["GrossPrizes"].Equals(tbGrossPrizes.Text))
            {
                ExecuteUpdateCommand("UPDATE PERCENTAGES SET DEFAULT_VALUE_GROSS_PRIZES = " + tbGrossPrizes.Text);
                updateUI = true;
            }
            if (!string.IsNullOrEmpty(tbPassword.Text))
            {

                byte[] encodedPassword = new UTF8Encoding().GetBytes(tbPassword.Text);
                byte[] passwordHash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
                String HashedPassword = BitConverter.ToString(passwordHash);
                ExecuteUpdateCommand("UPDATE PERCENTAGES SET ENCRYPTED_TABLE_PASSWORD = '" + HashedPassword + "'");
                updateUI = true;
            }

            if(updateUI)
            {
                UpdateUI();
            }
        }

        protected void ExecuteUpdateCommand(String command)
        {
            OracleConnection oracleConnection = new OracleConnection("TNS_ADMIN=C:/Users/user/Oracle/network/admin;" +
                                        "USER ID=CIPRI;" +
                                        "PASSWORD=password;" +
                                        "DATA SOURCE=localhost:1521/XEPDB1;" +
                                        "PERSIST SECURITY INFO=True");
            try
            {
                oracleConnection.Open();
                OracleCommand oracleCommand = new OracleCommand(command, oracleConnection);
                oracleCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
            finally
            {
                oracleConnection.Close();
            }
        }

        protected void UpdateUI()
        {
            OracleConnection oracleConnection = new OracleConnection("TNS_ADMIN=C:/Users/user/Oracle/network/admin;" +
                                        "USER ID=CIPRI;" +
                                        "PASSWORD=password;" +
                                        "DATA SOURCE=localhost:1521/XEPDB1;" +
                                        "PERSIST SECURITY INFO=True");

            try
            {
                oracleConnection.Open();
                String cmdString = String.Format("SELECT * FROM PERCENTAGES");
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmdString, oracleConnection);
                DataSet dataSet = new DataSet();
                oracleDataAdapter.Fill(dataSet);

                Session["TaxPension"] = tbTaxPension.Text = dataSet.Tables[0].Rows[0][0].ToString();
                Session["TaxHealth"] = tbTaxHealth.Text = dataSet.Tables[0].Rows[0][1].ToString();
                Session["TaxIncome"] = tbTaxIncome.Text = dataSet.Tables[0].Rows[0][2].ToString();
                Session["GrossIncrease"] = tbGrossIncrease.Text = dataSet.Tables[0].Rows[0][3].ToString();
                Session["Deductions"] = tbDeductions.Text = dataSet.Tables[0].Rows[0][4].ToString();
                Session["GrossPrizes"] = tbGrossPrizes.Text = dataSet.Tables[0].Rows[0][5].ToString();
                tbPassword.Text = "";
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
            finally
            {
                oracleConnection.Close();
            }
        }
    }
}