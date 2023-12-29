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
    public partial class PercentagesLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPass_Click(object sender, EventArgs e)
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
                String dbPassword = dataSet.Tables[0].Rows[0][6].ToString();

                byte[] encodedPassword = new UTF8Encoding().GetBytes(tbPass.Text);
                byte[] passwordHash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
                String hashedPassword = BitConverter.ToString(passwordHash);

                if (dbPassword.Equals(hashedPassword))
                {
                    Server.Transfer("Percentages.aspx");
                }
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