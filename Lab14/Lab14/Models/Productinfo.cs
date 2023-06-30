using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14.Models
{
    public class Productinfo
    {
        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
