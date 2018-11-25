using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MilkTea_app.DTO
{
    class Userclass
    {
        public string usersname { get; set; }
        public string pass { get; set; }
        public string role { get; set; }
    }
}
