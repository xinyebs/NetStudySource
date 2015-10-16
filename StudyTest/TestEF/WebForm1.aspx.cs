using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.EntityClient;

namespace TestEF
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            using (EntityConnection entityConn = new EntityConnection("name=Entities"))
             {
                 entityConn.Open();
                 using (EntityCommand cmd = entityConn.CreateCommand())
                 {
                     cmd.CommandText = "select value c from Entities.UserRoles as c where c.id>0 ";
                   EntityDataReader read= cmd.ExecuteReader();
                     while(read.Read())
                     {
                         txtbox.Text=read[0].ToString();
                     }
                 }
             }
          //TestEF ef = new TestEF();
          // repTest.DataSource= ef.GetAllUer();
          // repTest.DataBind();
            
        }
    }
}