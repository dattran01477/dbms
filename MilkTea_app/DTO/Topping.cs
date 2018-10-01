using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea_app.DTO
{
    class Topping
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string type { get; set; }
    }
}
