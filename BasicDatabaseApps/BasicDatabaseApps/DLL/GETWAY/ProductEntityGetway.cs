using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicDatabaseApps.DLL.DAO;

namespace BasicDatabaseApps.DLL.GETWAY
{
    class ProductEntityGetway
    {
        private SqlConnection connection;
        private SqlCommand command;
       

        public ProductEntityGetway()
        {
            string conn = ConfigurationManager.ConnectionStrings["shop"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;
        }

        public string Save(ProductInfo productInfo)
        {
          
            connection.Open();
            string query = "INSERT INTO ProductEntity(Product_Code,Product_Name,Quantity) Values(@0,@1,@2)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0", productInfo.ProductCode);
            command.Parameters.AddWithValue("@1", productInfo.ProductName);
            command.Parameters.AddWithValue("@2", productInfo.Quantity);
            command.ExecuteNonQuery();
            connection.Close();
            return "Informatin has been save";
        }

        public List<int> GetTotalQuantity()
        {
           connection.Open();
            string query = "SELECT Quantity FROM ProductEntity";
            command=new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
            List<int> qunatitylist=new List<int>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int data =(int)reader[0];
                    qunatitylist.Add(data);
                }
            }
            connection.Close();
            return qunatitylist;
        }

      

        public List<ProductInfo> GetViewAll()
        {
            connection.Open();
            string query = "SELECT * FROM ProductEntity";
            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<ProductInfo> qunatitylist = new List<ProductInfo>();
            if (reader.HasRows)
            {
            
                while (reader.Read())
                {
                    ProductInfo productInfo = new ProductInfo();
                    productInfo.ProductId = Convert.ToInt32(reader[0]) ;
                    productInfo.ProductCode = reader[1].ToString();
                    productInfo.ProductName = reader[2].ToString();
                    productInfo.Quantity = Convert.ToInt32(reader[3]);
                    qunatitylist.Add(productInfo);

                }
            }
            connection.Close();
            return qunatitylist;
        }

        public List<ProductInfo> GetValidations()
        {
            connection.Open();
            string query = "SELECT * FROM ProductEntity";
            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<ProductInfo> qunatitylist = new List<ProductInfo>();
            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    ProductInfo productInfo = new ProductInfo();
                    productInfo.ProductId = Convert.ToInt32(reader[0]);
                    productInfo.ProductCode = reader[1].ToString();
                    productInfo.ProductName = reader[2].ToString();
                    productInfo.Quantity = Convert.ToInt32(reader[3]);
                    qunatitylist.Add(productInfo);

                }
            }
            connection.Close();
            return qunatitylist;
        }
    }
}
