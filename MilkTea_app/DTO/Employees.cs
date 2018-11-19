using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MilkTea_app.DTO
{
    class Employees
    {
        public ObjectId _id { get; set; }
        public string MaNV { get; set; }
        public string Hoten { get; set; }
        public string Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string Chucvu { get; set; }
    }
}
