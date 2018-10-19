﻿using System;
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
       private MongoClient client;
       private IMongoDatabase database;
        public DataStore(string hostName,string dataName)
        {
            try
            {
                client = new MongoClient(hostName+":27017");
                database = client.GetDatabase(dataName);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataStore()
        {
            try
            {
                client = new MongoClient();
                database = client.GetDatabase("QuanLyTraSua");
<<<<<<< HEAD
                
=======


                //var resul=database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getCategory()" } });
                //Cursor stats = database.RunCommand<Cursor>(new Cursor{ { "eval", "getCategory()" } });
                //stats.foreach (MessageBox.Show("a")) ;
               // MessageBox.Show(stats.ToString());

                //MessageBox.Show();
                //foreach (var a in resul)
                //{
                //    MessageBox.Show(a["retval"].AsString);
                //}
>>>>>>> phuc
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
<<<<<<< HEAD
        public void get()
        {
            var reult = database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "GetCategoryDrink()" } });

            var array = reult["retval"].AsBsonArray;
            foreach (var b in array)
            {
                MessageBox.Show(b["name"].AsString);
            }
           
        }
        
=======
        public void postProducts(string name, string price,string categoryId)
        {
            try
                {
                string str = "addPoducts('" + name + "'," + price + "," + "ObjectId('" + categoryId + "'));";
                MessageBox.Show(str);
                database.RunCommand<BsonDocument>(new BsonDocument { { "eval",str } });
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
                MessageBox.Show(str);
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
                string str = "insertCategory('" + name + "'," +type + "));";
                MessageBox.Show(str);
                database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                MessageBox.Show("Đã thêm thành công");
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
                string str = "updateCategory('" + name + "'," + type + "));";
                MessageBox.Show(str);
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
                    database.RunCommand<BsonDocument>(new BsonDocument { { "eval", str } });
                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi! Không xóa được dữ liệu!");
            }
        }

>>>>>>> phuc
    }
}
