using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IncomeCalculator
{
    public partial class SiteMaster : MasterPage
    {
        private static int swTimerCounter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            swTimerCounter++;
            if(swTimerCounter == 10)
            {
                String swapUrl = imageAd1.ImageUrl;
                imageAd1.ImageUrl = imageAd2.ImageUrl;
                imageAd2.ImageUrl = swapUrl;
                swTimerCounter = 0;
            }

            lblTime.Text = DateTime.Now.ToString();
        }
    }
}