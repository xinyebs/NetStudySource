using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEBSericesTest.com._10628106.client;

namespace WEBSericesTest
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            CaluteSevices p = new CaluteSevices();
            this.labShow.Text = p.Add(Convert.ToInt32(this.txtNum1.Text),Convert.ToInt32(this.txtNum2.Text)).ToString();
        }

        protected void btnTrafic_Click(object sender, EventArgs e)
        {
            WEBSericesTest.com._10628106.client.Service d = new com._10628106.client.Service();
           StandardData standaData= d.GetAllBusLine("1003","5a12243cb30d4315bc2ee238dfda1f79");
           //this.labShow.Text = standaData.result;
          StandardDataListOfLineModel q= d.getTodayLineInfo("501", "1003", "5a12243cb30d4315bc2ee238dfda1f79");
          this.labShow.Text = q.list.ToString();
           
        }
    }
}