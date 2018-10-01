using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea_app.DTO
{
    class Category
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public object[] product { get; set; }
        public string type { get; set; }
    }
}
