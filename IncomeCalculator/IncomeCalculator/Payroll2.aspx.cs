using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using Oracle.Web;

namespace IncomeCalculator
{
    public partial class Payroll2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet grossSalaryDataSet = GetCommandOutput("SELECT SUM(GROSS_TOTAL)FROM EMPLOYEES");
            DataSet netSalaryDataSet = GetCommandOutput("SELECT SUM(NET_SALARY)FROM EMPLOYEES");
            tbTotalGross.Text = grossSalaryDataSet.Tables[0].Rows[0][0].ToString();
            tbTotalNet.Text = netSalaryDataSet.Tables[0].Rows[0][0].ToString();
        }

        protected DataSet GetCommandOutput(String command)
        {
            OracleConnection oracleConnection = new OracleConnection("TNS_ADMIN=C:/Users/user/Oracle/network/admin;" +
                                        "USER ID=CIPRI;" +
                                        "PASSWORD=password;" +
                                        "DATA SOURCE=localhost:1521/XEPDB1;" +
                                        "PERSIST SECURITY INFO=True");
            try
            {
                oracleConnection.Open();
                String cmdString = String.Format(command);
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmdString, oracleConnection);
                DataSet dataSet = new DataSet();
                oracleDataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
            finally
            {
                oracleConnection.Close();
            }
            return null;
        }
    }
}