using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem3Cloud.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string description { get; set; }
        public Category category { get; set; }
    }
}
