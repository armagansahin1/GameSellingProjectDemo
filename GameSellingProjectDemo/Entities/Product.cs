using GameSellingProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingProjectDemo.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
    }
}
