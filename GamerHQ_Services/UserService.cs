﻿using GamerHQ.Data;
using GamerHQ_Data;
using GamerHQ_Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerHQ_Services
{
    public class UserService
    {
        public bool CreateUser(UserCreate model)
        {
            var entity =
                new User()
                {
                    Name = model.Name,
                    GamerTag = model.GamerTag,
                    Email = model.Email,
                    Age = model.Age,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.UsersInfo.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<UserListItem> GetUsers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .UsersInfo
                    .Select(
                        e =>
                        new UserListItem
                        {
                            Name = e.Name,
                            GamerTag = e.GamerTag,
                            Email = e.Email,
                            Age = e.Age,
                        }
                        );
                return query.ToArray();
            }
        }
        public UserDetail GetUserById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                User entity =
                    ctx
                    .UsersInfo
                    .Single(e => e.UserID == id);
                return
                new UserDetail
                {
                    UserID = entity.UserID,
                    Name = entity.Name,
                    GamerTag = entity.GamerTag,
                    Email = entity.Email,
                    Age = entity.Age
                };
            }
        }
        public bool UpdateUser(UserEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .UsersInfo
                    .Single(e => e.UserID == model.UserID);

                entity.Name = model.Name;
                entity.GamerTag = model.GamerTag;
                entity.Email = model.Email;
                entity.Age = model.Age;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteUser(int userID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                 ctx
                 .UsersInfo
                 .Single(e => e.UserID == userID);
                ctx.UsersInfo.Remove(entity);

                return ctx.SaveChanges() == 1;

            }
        }
    }
}
