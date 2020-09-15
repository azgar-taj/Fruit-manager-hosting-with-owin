using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitManager.Models
{
    public class Apple
    {
        public Apple()
        {
            Type = "Apple";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
    }
}