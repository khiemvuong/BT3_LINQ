using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using LinqToObject.DTO;
using System.Xml.Linq;

namespace LinqToObject.DAO
{
	
	internal class ProductDAO
	{
		private string connectionString;

		public ProductDAO()
		{
			connectionString = ConfigurationManager.ConnectionStrings["ProductManagementDbConnectionString"].ConnectionString;
		}

		public List<ProductDTO> GetProducts()
		{
			List<ProductDTO> productModelList = new List<ProductDTO>();

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "SELECT * FROM SANPHAM";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					SqlDataReader reader = cmd.ExecuteReader();


					while (reader.Read())
					{
						ProductDTO product = new ProductDTO()
						{
							MASP = reader["MASP"].ToString(),
							TENSP = reader["TENSP"].ToString(),
							SL = (int)reader["SL"],
							DONGIA = (int)reader["DONGIA"],
							XUATXU = reader["XUATXU"].ToString(),
							NGAY_HET_HAN = (DateTime) reader["NGAY_HET_HAN"]
						};

						productModelList.Add(product);
					}
				}
			}

			return productModelList;
		}

		public void AddProducts(ProductDTO product)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "INSERT INTO SANPHAM (MASP, TENSP, SL, DONGIA, XUATXU, NGAY_HET_HAN) VALUES (@masp, @tensp, @sl, @dongia, @xuatxu, @ngay_het_han)";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@masp", product.MASP);
					cmd.Parameters.AddWithValue("@tensp", product.TENSP);
					cmd.Parameters.AddWithValue("@sl", product.SL);
					cmd.Parameters.AddWithValue("@dongia", product.DONGIA);
					cmd.Parameters.AddWithValue("@xuatxu", product.XUATXU);
					cmd.Parameters.AddWithValue("@ngay_het_han", product.NGAY_HET_HAN);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public void DeleteProductsByXuatXu(string xuatxu)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "DELETE FROM SANPHAM WHERE XUATXU = @xuatxu";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@xuatxu", xuatxu);
	
					cmd.ExecuteNonQuery();
				}
			}
		}

		public void DeleteProductsByMaSP(string masp)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "DELETE FROM SANPHAM WHERE MASP = @masp";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@masp", masp);

					cmd.ExecuteNonQuery();
				}
			}
		}

		public void DeleteAllProducts()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "DELETE FROM SANPHAM WHERE 1 = 1";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}
