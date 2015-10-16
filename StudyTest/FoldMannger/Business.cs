using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoldMannger
{
    public class Business
    {
        #region File
        /// <summary>
        /// 增加一个文件实体
        /// </summary>
        /// <param name="fold"></param>
        /// <returns></returns>
        public bool addFile(file fold)
        {
            using (FoldDBEntities ef=new FoldDBEntities())
            {
                ef.file.AddObject(fold);
                int resuit = ef.SaveChanges();
                if (resuit > 0) return true;
                else return false;
            }
        }

        /// <summary>
        /// 通过用户ID和文件夹Id获得所有的文件
        /// </summary>
        /// <returns></returns>
        public List<file> GetAllFile(int userId,int foldId)
        {
            using(FoldDBEntities ef=new FoldDBEntities())
            {
                var p = ef.file.Where(r => r.UserId == userId && r.FoldId==foldId);
                //return p != null ? p.ToList() : null;
                return p.ToList();
            }
        }
        #endregion

        #region fold
        /// <summary>
        /// 增加一个fold
        /// </summary>
        /// <param name="fold"></param>
        /// <returns></returns>
        public int addFold(Fold fold)
        {
            using (FoldDBEntities ef = new FoldDBEntities())
            {
                ef.Fold.AddObject(fold);
                int resuit= ef.SaveChanges();
                if (resuit > 0) return fold.Id;
                else return 0;

            }
        }
        /// <summary>
        /// 通过用户id获取该文件,fatherId获取文件夹列表
        /// fatherId=0表示获取第一级的目录
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<Fold> GetAllFold(int UserId,int fatherId)
        {
            using (FoldDBEntities ef = new FoldDBEntities())
            {
                var p = ef.Fold.Where(r => r.UserId==UserId&&r.FatherId==fatherId);

                //return p!=null?p.ToList():null;

                return p.ToList();
            }
        }
        #endregion

    }
}