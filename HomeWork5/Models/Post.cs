using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork5.Models
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Text { get; set; }
    }
}