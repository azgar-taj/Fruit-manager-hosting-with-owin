using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitManager.Models
{
    public interface IFruit 
    {
        int Id { get; set; }
        string Name { get; set; }
        string Color { get; set; }
        int Price { get; set; }
        string Type { get; set; }
    }
}