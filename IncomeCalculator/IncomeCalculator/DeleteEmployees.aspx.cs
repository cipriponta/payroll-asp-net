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
    public partial class DeleteEmployees : System.Web.UI.Page
    {
        private OracleConnection oracleConnection;

        protected void Page_Load(object sender, EventArgs e)
        {
            oracleConnection = new OracleConnection("TNS_ADMIN=C:/Users/user/Oracle/network/admin;" +
                                        "USER ID=CIPRI;" +
                                        "PASSWORD=password;" +
                                        "DATA SOURCE=localhost:1521/XEPDB1;" +
                                        "PERSIST SECURITY INFO=True");
        }

        protected void btnDelEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                oracleConnection.Open();
                String cmdString = String.Format("DELETE FROM EMPLOYEES WHERE SURNAME = \'{0}\' and FIRST_NAME = \'{1}\'",
                                              tbSurname.Text,
                                              tbFirstName.Text);
                OracleCommand oracleCommand = new OracleCommand(cmdString, oracleConnection);
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
    }
}