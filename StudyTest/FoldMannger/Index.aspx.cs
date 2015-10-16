using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace FoldMannger
{
    public partial class Index : System.Web.UI.Page
    {
        Business bs = new Business();
        List<file> listfile = new List<file>();
        List<Fold> listfold = new List<Fold>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                listfile = bs.GetAllFile(1, 0);//获取第一级的文件列表
                listfold = bs.GetAllFold(Convert.ToInt32("1"),Convert.ToInt32("0"));//获取第一级的文件夹列表
                //如果第一级的文件夹为空,说明用户还没有创建新文件加
                //如果第一级的文件夹为空
                if (listfold.Count() == 0&&listfile.Count==0)
                {
                    this.empty.Visible = true;
                }
            }
        }

        protected void btnUP_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string savePath = "/UserFold/";
            if (this.fileUP.HasFile)
            {
                HttpPostedFile file = this.fileUP.PostedFile;
                fileName = file.FileName;
               string extension= Path.GetExtension(fileName).ToLower();
               if (extension == ".jpg" ||extension==".gif"|| extension == ".doc" || extension == ".docx")
               {
                   if(!Directory.Exists(Server.MapPath(savePath)))
                   {
                       Directory.CreateDirectory(Server.MapPath(savePath));
                   }
                   if (File.Exists(Server.MapPath(savePath + fileName)))
                   {
                       Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('已经存在相同的文件')</script>");
                       return;
                   }
                   this.fileUP.SaveAs(Server.MapPath(savePath+fileName));
               }

               try
               {///第一次插入数据
                   Fold modelFold = new Fold();
                   modelFold.Depth = 0;
                   //modelFold.FatherId //第一层fatherId没有值
                   modelFold.FoldName = savePath;
                   modelFold.UserId = 1;
                  int id= bs.addFold(modelFold);
                   if(id>0)
                   {
                   file modelfile = new file();
                   modelfile.fileName = fileName;
                   modelfile.filePath = savePath + fileName;
                   modelfile.FoldId = id;
                   bs.addFile(modelfile);
                   }
                
               } catch(Exception ex)
               {
               }


            }
        }
    }
}