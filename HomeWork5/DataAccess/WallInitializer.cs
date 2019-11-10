using HomeWork5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeWork5.DataAccess
{
    public class WallInitializer : CreateDatabaseIfNotExists<WallContext>
    {
        protected override void Seed(WallContext context)
        {
            context.Posts.AddRange(new List<Post>
            {
                new Post
                {
                    Name = "Шипа",
                    Text = "Здарова"
                },
                 new Post
                {
                    Name = "Вася",
                    Text = "Салам пацанам "
                }, 
                new Post
                {
                    Name = "Петя",
                    Text = "Как жизнь?"
                }, 
                new Post
                {
                    Name = "Оля",
                    Text = "Я Оля"
                }
            });
        }
    }
}