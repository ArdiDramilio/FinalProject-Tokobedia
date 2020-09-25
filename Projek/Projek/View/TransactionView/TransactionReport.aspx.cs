using Projek.Controller;
using Projek.Controller.TransactionController;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek.View.TransactionView
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("../HomeView/Home.aspx");
            }
            else
            {
                String ID = Session["LoginSession"].ToString();
                MsUser user = HomeController.FetchDataForHome(ID);
                if (user.RoleID == "RL1")
                {
                    CrystalReport1 report = new CrystalReport1();
                    DataSet1 dataset = ReportingController.GetDataSet();
                    report.SetDataSource(dataset);
                    CrystalReportViewer1.ReportSource = report;
                }
                else
                {
                    Response.Redirect("../HomeView/Home.aspx");
                }
            }
            
        }
    }
}