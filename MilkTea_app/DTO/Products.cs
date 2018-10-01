using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea_app.DTO
{
    class Products
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public ObjectId categoryId { get; set; }
    }
}
