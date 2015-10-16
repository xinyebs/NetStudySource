using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace CodeFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BlogDbContext();
            
                //向数据库添加记录
                var blogUser = new BlogUser() { BlogUserId = 1, BlogName = "燕赤霞" };
                db.BlogUsers.Add(blogUser);
                var post = new Post()
                {
                    PostId = 1,
                    PostTitle = "一切皆有可能--我与小倩不得不说的事",
                    BlogUserId = 1
                };
                db.Posts.Add(post);

                //保存记录，返回受影响的行数
                int recordsAffected = db.SaveChanges();
                Console.WriteLine("追加{0}记录成功", recordsAffected);
           
        }
    }


    public partial class BlogUser
    {
        /// <summary>
        /// 默认情况下属性被命名为ID、id或者[ClassName]Id，将映射为数据表中的主键
        /// </summary>
        public int BlogUserId { get; set; }  
        public string BlogName { get; set; }

        /// <summary>
        /// virtual 表示延迟加载
        /// </summary>
        public virtual ICollection<Post> Posts { get; set; }
    }

    public partial class Post
    {
        public int PostId { get; set; }   
        public string PostTitle { get; set; } 
        public int BlogUserId { get; set; }
        /// <summary>   
        ///  延迟加载博客用户     
        ///  </summary>      
       public virtual BlogUser BlogUser { get; set; }   
    }

    public class BlogDbContext
    {
        public IDbSet<BlogUser> BlogUsers { get; set; }   
        public IDbSet<Post> Posts { get; set; }
    }
}
