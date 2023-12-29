using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using Oracle.Web;

namespace IncomeCalculator
{
    public partial class SalarySlips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbSearch.Text))
            {
                UpdateUI();
            }
            else
            {
                UpdateUI(tbSearch.Text);
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
                String cmdString = String.Format("SELECT * FROM EMPLOYEES");
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmdString, oracleConnection);
                DataSet dataSet = new DataSet();
                oracleDataAdapter.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    AddSalarySlip(row);
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

        protected void UpdateUI(string name)
        {
            OracleConnection oracleConnection = new OracleConnection("TNS_ADMIN=C:/Users/user/Oracle/network/admin;" +
                                        "USER ID=CIPRI;" +
                                        "PASSWORD=password;" +
                                        "DATA SOURCE=localhost:1521/XEPDB1;" +
                                        "PERSIST SECURITY INFO=True");

            try
            {
                oracleConnection.Open();
                String cmdString = String.Format(String.Format("SELECT * FROM EMPLOYEES WHERE SURNAME LIKE \'{0}%\'", name));
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmdString, oracleConnection);
                DataSet dataSet = new DataSet();
                oracleDataAdapter.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    AddSalarySlip(row);
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

        protected void AddSalarySlip(DataRow tableRow)
        {
            Panel panel = new Panel();
            CreateEntry(panel, "ID", tableRow["ID"].ToString());
            AddSpace(panel);
            CreateEntry(panel, "TAX_INCOME", tableRow["TAX_INCOME"].ToString());
            AddNewLine(panel);

            CreateEntry(panel, "SURNAME", tableRow["SURNAME"].ToString());
            AddSpace(panel);
            CreateEntry(panel, "TAX_PENSION", tableRow["TAX_PENSION"].ToString());
            AddNewLine(panel);

            CreateEntry(panel, "FIRST_NAME", tableRow["FIRST_NAME"].ToString());
            AddSpace(panel);
            CreateEntry(panel, "TAX_HEALTH", tableRow["TAX_HEALTH"].ToString());
            AddNewLine(panel);

            CreateEntry(panel, "OCCUPATION", tableRow["OCCUPATION"].ToString());
            AddSpace(panel);
            CreateEntry(panel, "DEDUCTIONS", tableRow["DEDUCTIONS"].ToString());
            AddNewLine(panel);

            CreateEntry(panel, "GROSS_SALARY", tableRow["GROSS_SALARY"].ToString());
            AddSpace(panel);
            CreateEntry(panel, "NET_SALARY", tableRow["NET_SALARY"].ToString());
            AddNewLine(panel);

            CreateEntry(panel, "GROSS_INCREASE", tableRow["GROSS_INCREASE"].ToString());
            AddNewLine(panel);
            CreateEntry(panel, "GROSS_PRIZES", tableRow["GROSS_PRIZES"].ToString());
            AddNewLine(panel);
            CreateEntry(panel, "GROSS_TOTAL", tableRow["GROSS_TOTAL"].ToString());
            AddNewLine(panel);
            CreateEntry(panel, "GROSS_TAXABLE", tableRow["GROSS_TAXABLE"].ToString());
            AddNewLine(panel);

            AddNewLine(panel);
            AddNewLine(panel);

            MainPanel.Controls.Add(panel);
        }

        protected void CreateEntry(Panel panel, String lblText, String tbText)
        {
            Label lbl = new Label();
            lbl.Text = lblText;
            lbl.Width = 150;
            panel.Controls.Add(lbl);

            TextBox tb = new TextBox();
            tb.Text = tbText;
            tb.Width = 150;
            tb.ReadOnly = true;
            panel.Controls.Add(tb);
        }

        protected void AddSpace(Panel panel)
        {
            panel.Controls.Add(new LiteralControl("&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp"));
            panel.Controls.Add(new LiteralControl("&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp"));
        }

        protected void AddNewLine(Panel panel)
        {
            panel.Controls.Add(new LiteralControl("<br />"));
        }
    }
}