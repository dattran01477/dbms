using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;
using MilkTea_app.DTO;
using MilkTea_app.DAL;
using MongoDB.Bson.Serialization;

namespace MilkTea_app.BLL
{
    class DataStore
    {
       private  MongoClient client;
       private  IMongoDatabase database;
        public static List<String> roles;
        public static String hostName;
        public bool isConnect = false;
        private string userName, pass;
        public DataStore(string userName,string pass)
        {
            this.userName = userName;
            this.pass = pass;
            try
            {
                client = new MongoClient("mongodb://"+ userName+":"+pass+ "@"+hostName+":27017/QuanLyTraSua");
                database = client.GetDatabase("QuanLyTraSua");
                bool isMongoLive = database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

                if (isMongoLive)
                {
                    isConnect = true;
                }
                else
                {
                    isConnect = false;
                }

            }
            catch (MongoException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataStore()
        {
            string stringConn = "mongodb://QuanLy:123@"+hostName+":27017";
            try
            {
                client = new MongoClient(stringConn);
                database = client.GetDatabase("QuanLyTraSua");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<Employees> GetEmployees()
        {
            //var doc = new BsonDocument(new Dictionary<string, string> { { "GetEmployees()", "" } });
            //var command = new BsonDocumentCommand<int>(doc);
            //var result = database.RunCommand(command);
            //MessageBox.Show(result.ToString());
            List<Employees> employeesList = new List<Employees>();
            //return employeesList;
            Employees employees;
            try
            {
                var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "GetEmployees()" } });

                var array = reult["retval"].AsBsonArray;
                foreach (var b in array)
                {
                    employees = new Employees();
                    employees._id = b["_id"].AsObjectId;
                    employees.MaNV = b["MaNV"].AsString;
                    employees.Hoten = b["Hoten"].AsString;
                    employees.Ngaysinh = b["Ngaysinh"].AsString;
                    employees.Diachi = b["Diachi"].AsString;
                    employees.Chucvu = b["Chucvu"].AsString;
                    employeesList.Add(employees);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return employeesList;

        }
        public List<Userclass> getUsers()
        {
            Userclass us;
            List<Userclass> ls = new List<Userclass>();
            try
            {
                string str = "getUsers()";
                var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                var array = reult["retval"].AsBsonArray;
                foreach (var b in array)
                {
                    us = new Userclass();
                    us.usersname = b["user"].AsString;
                    us.pass = "********";
                    us.role = b["roles"][0]["role"].ToString();
                    if(us.role== "executeEval")
                    {
                        us.role = b["roles"][1]["role"].ToString();
                    }
                    ls.Add(us);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return ls;
        }
        public void addUser(string username,string pass,string role)
        {
            try
            {
                string str = "CreateUser('" + username + "','" + pass + "','" + role + "');";
                var a = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                if (a.GetElement("retval").ToString() == "retval=0") MessageBox.Show("Đã tồn tại user, kiểm tra lại!");
                else MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không thêm được dữ liệu!");
            }
        }
        public void deleteUser(string username)
        {
            try
            {
                string str = "dropUsers('" + username + "');";
                var a = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                if (a.GetElement("retval").ToString() == "retval=0") MessageBox.Show("Lỗi xóa user, kiểm tra lại!");
                else MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không thêm được dữ liệu!");
            }
        }
        public void updateUser(string username,string password,string role)
        {
            try
            {
                string str = "dropUsers('" + username + "');";
                var a = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                if (a.GetElement("retval").ToString() == "retval=0") MessageBox.Show("Lỗi rồi, kiểm tra lại!");
                else
                {
                    addUser(username, password, role);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không thêm được dữ liệu!");
            }
        }
        public void addEmployees(string MaNV,string TenNV,string Ngaysinh,string Diachi,string Chucvu)
        {
            try
            {
                string str = "addEmployees('" + MaNV + "','" + TenNV + "','" +Ngaysinh+ "','"+Diachi+"','"+Chucvu+"');";
                var a=database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                if (a.GetElement("retval").ToString() == "retval=0") MessageBox.Show("Đã tồn tại nhân viên, kiểm tra lại!");
                else MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không thêm được dữ liệu!");
            }
        }
        public void deleteEmployees(string Manv)
        {
            try
            {
                string str = "deleteEmployees('" + Manv + "');";
                database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                MessageBox.Show("Đã xóa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không xóa được dữ liệu!");
            }
        }
        public void updateEmployees(string MaNV,string TenNV,String Ngaysinh,string Diachi,String Chucvu)
        {
            try
            {
                string str = "updateEmployees('" + MaNV + "','" + TenNV + "','" + Ngaysinh + "','" + Diachi + "','" + Chucvu + "');";
                var a = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                if (a.GetElement("retval").ToString() == "retval=0") MessageBox.Show("Không thể cập nhật thông tin!");
                else MessageBox.Show("Đã cập nhật thông tin thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không thêm được dữ liệu!");
            }
        }


        public List<Category> getCategoryDrink()
        {
            List<Category> categoriesList = new List<Category>();
            Category category;
            try
            {
                // IMongoCollection<Category> categories = database.GetCollection<Category>("Category");
                // var c = categories.Find(x => true).ToList();


                //// lọc ra các danh mục loại nước bằng linq
                //var a = from b in categories.AsQueryable<Category>()
                //        where b.type == "Drink"
                //        select b;


                // //var result = database.EvalAsync("GetCategory()").Result;
                // foreach (var temp in a)
                // {
                //     categoriesList.Add(temp);
                // }
                var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "GetCategory('Drink')" } });

                var array = reult["retval"].AsBsonArray;
                foreach (var b in array)
                {
                    category = new Category();
                    category._id= b["_id"].AsObjectId;
                    category.type = b["type"].AsString;
                    category.name= b["name"].AsString;
                    categoriesList.Add(category);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return categoriesList;
        }

        private void getRoles()
        {
            var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getRoles('"+userName+"')" } });

            var array = reult["retval"].AsBsonArray;
            //foreach (var b in array)
            //{
            //    category = new Category();
            //    category._id = b["_id"].AsObjectId;
            //    category.type = b["type"].AsString;
            //    category.name = b["name"].AsString;
            //    categoriesList.Add(category);
            //}
           
        }
        public List<Category> getCategoryFood()
        {
            List<Category> categoriesList = new List<Category>();
            Category category;
            try
            {
                var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "GetCategory('Food')" } });

                var array = reult["retval"].AsBsonArray;
                foreach (var b in array)
                {
                    category = new Category();
                    category._id = b["_id"].AsObjectId;
                    category.type = b["type"].AsString;
                    category.name = b["name"].AsString;
                    categoriesList.Add(category);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return categoriesList;
        }


        public List<Category> getCategory()
        {
            List<Category> categoriesList = new List<Category>();
            Category category;
            try
            {
                var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "GetCategory()" } });

                var array = reult["retval"].AsBsonArray;
                foreach (var b in array)
                {
                    category = new Category();
                    category._id = b["_id"].AsObjectId;
                    category.type = b["type"].AsString;
                    category.name = b["name"].AsString;
                    categoriesList.Add(category);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return categoriesList;
        }

        //public List<Topping> getCategoryTopping()
        //{
        //    List<Topping> categoriesList = new List<Topping>();
        //    try
        //    {
        //        IMongoCollection<Topping> categories = database.GetCollection<Topping>("Topping");
        //        var c = categories.Find(x => true).ToList();

             

        //        // lọc ra các danh mục loại nước bằng linq
        //        var a = from b in categories.AsQueryable<Topping>()                      
        //                select b;


        //        //var result = database.EvalAsync("GetCategory()").Result;
        //        foreach (var temp in a)
        //        {
        //            categoriesList.Add(temp);
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    return categoriesList;
        //}

        public List<Products> getAllProduct(string categoryName)
        {
            List<Products> productsList = new List<Products>();
            Products product = new Products();
            if (categoryName == null)
                return productsList;
            try
            {
                //IMongoCollection<Products> products = database.GetCollection<Products>("Products");
                //IMongoCollection<Category> categories = database.GetCollection<Category>("Category");

                //// lọc ra mã danh mục
                //var idCategory = (from b in categories.AsQueryable<Category>()
                //                  where b.name == categoryName
                //                  select b._id).FirstOrDefault(); ;


                //// lọc ra các danh mục loại nước bằng linq
                //var d = from b in products.AsQueryable<Products>()
                //        where b.categoryId == idCategory
                //        select b;

                ////Thêm vào list
                //foreach (var temp in d)
                //{
                //    productsList.Add(temp);
                //}

                //Lấy mã _id của sản phẩm
                var reult1 = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "GetIdCategory('" + categoryName + "')" } });
                var temp = reult1["retval"].AsBsonDocument;
                var idCategory = temp["_id"].AsObjectId;

                //Lấy sản phẩm
                var reult2 = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "GetProduct('" + idCategory + "')" } });
                var array = reult2["retval"].AsBsonArray;
                foreach (var b in array)
                {
                    product = new Products();
                    product._id = b["_id"].AsObjectId;
                    product.categoryId = b["categoryId"].AsObjectId;
                    product.name = b["name"].AsString;
                    product.price = b["price"].AsDouble;
                    productsList.Add(product);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return productsList;
        }
        public Products getInfoProduct(string productName)
        {
            Products product = new Products();
            try
            {
                var reult2 = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "GetInfoProduct('" + productName + "')" } });
                var b = reult2["retval"].AsBsonDocument;
               
                    product = new Products();
                    product._id = b["_id"].AsObjectId;
                    product.categoryId = b["categoryId"].AsObjectId;
                    product.name = b["name"].AsString;
                    product.price = b["price"].AsDouble;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return product;
        }

        public void addCategory(Category category)
        {
            try
            {
                IMongoCollection<Category> categories = database.GetCollection<Category>("Category");
                categories.InsertOne(category);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }
        public void addProduct(Products product)
        {
            try
            {
                IMongoCollection<Products> products = database.GetCollection<Products>("Products");
                products.InsertOne(product);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void addOrder(BsonArray bsonArray,double sumPrice,int disCount,String _idNV)
        {
            string function = "addorder(" + sumPrice + "," + disCount + "," + bsonArray + ")";
            try
            {
                var reult2 = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", function } });
                MessageBox.Show(reult2["retval"].AsString);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public ObjectId getIdCategory(string nameCategory)
        {
            ObjectId _id = new ObjectId();
            try
            {
                var categories = database.GetCollection<Category>("Category");
                _id = (from a in categories.AsQueryable<Category>()
                           where a.name == nameCategory
                           select a._id).FirstOrDefault();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return _id;
           
        }

        public void get()
        {
            
            var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "GetCategoryDrink()" } });

            var array = reult["retval"].AsBsonArray;
            foreach (var b in array)
            {
                MessageBox.Show(b["name"].AsString);
            }
           
        }
        

        public void postProducts(string name, string price,string categoryId)
        {
            try
            {
                string str = "addPoducts('" + name + "'," + price + ",'" + categoryId + "');";
                var a=database.RunCommand<BsonDocument>(new BsonDocument { { "eval",str } });
                if (a["retval"].ToString() == "1") MessageBox.Show("Đã thêm thành công");
                else MessageBox.Show("Dữ liệu thêm vào bị lỗi rồi!");
            MessageBox.Show("Đã thêm thành công");
        }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không thêm được dữ liệu!");
            }
}
        public void updateProducts(string name, string price, string categoryId)
        {
            try
            {
                string str = "updateProducts('" + name + "'," + price + "," + "ObjectId('" + categoryId + "'));";
                database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                MessageBox.Show("Đã thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không cập nhật được dữ liệu!");
            }
        }

        public void deleteProducts(string name)
        {
            try
            {
                var result=MessageBox.Show("Bạn có chắc chắn muốn xóa ?","Delete Products",MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    string str = "deleteProducts('" + name + "');";
                    MessageBox.Show(str);
                    database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không xóa được dữ liệu!");
            }
        }

        public void postCategory(string name, string type)
        {
            try
            {
                string str = "insertCategory('" + name + "','" +type + "');";
                var a=database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                if (a["retval"].ToString() == "1") MessageBox.Show("Đã thêm thành công");
                else MessageBox.Show("Dữ liệu thêm vào bị lỗi rồi!");
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không thêm được dữ liệu!");
            }
        }
        public void updateCategory(string name, string type)
        {
            try
            {
                string str = "updateCategory('" + name + "'," + type + ");";
                database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                MessageBox.Show("Đã thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không cập nhật được dữ liệu!");
            }
        }
        public void deleteCategory(string name)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Delete Category", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string str = "deleteCategory('" + name + "');";
                    MessageBox.Show(str);
                    var a=database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                    if (a["retval"].ToString() == "1") MessageBox.Show("Đã xóa thành công");
                    else MessageBox.Show("Còn tồn tại các Products thuộc "+ name +" !");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không xóa được dữ liệu!");
            }
        }

        //report
        public int getHoaDonNgay()
        {
            int soHoaDon = 0;
            try
            {
                var reult2 = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getSoHoaDonTheNgay()" } });
                 soHoaDon =(int) reult2["retval"].AsDouble;

              
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return soHoaDon;
        }
        public int getTongChiecKhau()
        {
            int tongChiecKhau = 0;
            try
            {
                var reult2 = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getTongChiecKhau()" } });
                tongChiecKhau = (int)reult2["retval"].AsDouble;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return tongChiecKhau;
        }
        public int getDoanhThuTheoNgay()
        {
            int soDoanhThuNgay = 0;
            try
            {
                var reult2 = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getDoanhThuTheoNgay()" } });
                soDoanhThuNgay = (int)reult2["retval"].AsDouble;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return soDoanhThuNgay;
        }
        public List<String> getRoles(String name)
        {
            List<String> roles2 = new List<String>();
          
           
            try
            {
                var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getRoles('"+name+"')" } });

                var array = reult["retval"].AsBsonArray;
                foreach (var b in array)
                {
                    
                    roles2.Add(b.AsString);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            roles = roles2;
            return roles2;
        }
        public void Changpassword(string user,string pass)
        {
            string str = "changpassword('" + user + "','" + pass + "')";
            try
            {
                var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                if (reult["retval"].ToString() == "1") MessageBox.Show("Đã đổi mật khẩu thành công!");
                else MessageBox.Show("Không thể đổi mật khẩu !");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        

    }
}
