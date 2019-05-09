using AspNetDocker.DAL;
using AspNetDocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetDocker.BLL
{
    public class UserService
    {
        public IEnumerable<UserModel> GetUsers()
        {
            using (var db = new DemoContext())
            {
                return db
                    .Users
                    .Select(x => new UserModel()
                    {
                        Id = x.Id,
                        Email = x.Email,
                        FullName = x.FullName
                    })
                    .ToList();
            }
        }
    }
}