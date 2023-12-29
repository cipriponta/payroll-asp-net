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
    public partial class AddNewEmployees : System.Web.UI.Page
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

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                oracleConnection.Open();
                String cmdString = String.Format("INSERT INTO EMPLOYEES(SURNAME, FIRST_NAME, OCCUPATION, GROSS_SALARY) VALUES(\'{0}\', \'{1}\', \'{2}\', {3})",
                                              tbSurname.Text,
                                              tbFirstName.Text,
                                              tbOccupation.Text,
                                              tbGrossSalary.Text);
                OracleCommand oracleCommand = new OracleCommand(cmdString, oracleConnection);
                oracleCommand.ExecuteNonQuery();
                lblError.Text = "";
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
                lblError.Text = "Invalid Data!";
            }
            finally
            {
                oracleConnection.Close();
            }
        }
    }
}