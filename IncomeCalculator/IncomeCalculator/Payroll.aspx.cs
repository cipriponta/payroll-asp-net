using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Payroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OracleConnection oracleConnection = new OracleConnection("TNS_ADMIN=C:/Users/user/Oracle/network/admin;" +
                                        "USER ID=CIPRI;" +
                                        "PASSWORD=password;" +
                                        "DATA SOURCE=localhost:1521/XEPDB1;" +
                                        "PERSIST SECURITY INFO=True");
            oracleConnection.Open();
            String cmdString = String.Format("SELECT * FROM EMPLOYEES");
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmdString, oracleConnection);
            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load(Server.MapPath("PayrollCrystalReport.rpt"));
            reportDocument.SetDataSource(dataSet.Tables[0]);
            CrystalReportViewer1.ReportSource = reportDocument;
        }
    }
}