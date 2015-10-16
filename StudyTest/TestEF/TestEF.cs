using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace TestEF
{
    public class TestEF
    {
        public IList<UserRoles> GetAllUer()
        {
            //Entities ef = new Entities();

            //IList<Users> userList = ef.Users.ToList<Users>();

            //return userList;

            using(Entities EFDB=new Entities())
            {
                IList<UserRoles> listuser = EFDB.UserRoles.Include("Users").ToList<UserRoles>();

                return listuser;
            }

        }
    }
}