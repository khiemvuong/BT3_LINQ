using LinqToObject.DAO;
using LinqToObject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToObject
{
	public partial class Form1 : Form
	{	
		ProductDAO productDAO = new ProductDAO();

		List<ProductDTO> productsList = new List<ProductDTO>();

		DataTable table1 = new DataTable();
		
		DataTable table2 = new DataTable();

		public Form1()
		{
			InitializeComponent();
		}

		private void Reload()
		{
			table1.Rows.Clear();
			productsList = productDAO.GetProducts();

			foreach (var product in productsList)
			{
				table1.Rows.Add(product.MASP, product.TENSP, product.SL, product.DONGIA, product.XUATXU, product.NGAY_HET_HAN);
			}

			allProduct.DataSource = table1;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			productsList = productDAO.GetProducts();
			
			table1.Columns.Add("MASP", typeof(string));
			table1.Columns.Add("TENSP", typeof(string));
			table1.Columns.Add("SL", typeof(int));
			table1.Columns.Add("DONGIA", typeof(int));
			table1.Columns.Add("XUATXU", typeof(string));
			table1.Columns.Add("NGAY_HET_HAN", typeof(DateTime));

			table2.Columns.Add("MASP", typeof(string));
			table2.Columns.Add("TENSP", typeof(string));
			table2.Columns.Add("SL", typeof(int));
			table2.Columns.Add("DONGIA", typeof(int));
			table2.Columns.Add("XUATXU", typeof(string));
			table2.Columns.Add("NGAY_HET_HAN", typeof(DateTime));

			foreach (var product in productsList)
			{
				table1.Rows.Add(product.MASP,product.TENSP,product.SL,product.DONGIA,product.XUATXU,product.NGAY_HET_HAN);
			}

			allProduct.DataSource = table1;
			filteredProduct.DataSource = table2;
		}

		private void luuSP_Click(object sender, EventArgs e)
		{
			try
			{
				ProductDTO product = new ProductDTO(maSP.Text, tenSP.Text, (int)sl.Value, (int)donGia.Value, xuatXu.Text, ngayHetHan.Value);

				productDAO.AddProducts(product);

				Reload();

				MessageBox.Show("Add product successfully!");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			table2.Rows.Clear();

			ProductDTO product = productsList
			.OrderByDescending(p => p.DONGIA)
			.FirstOrDefault();


			table2.Rows.Add(product.MASP, product.TENSP, product.SL, product.DONGIA, product.XUATXU, product.NGAY_HET_HAN);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			table2.Rows.Clear();

			ProductDTO product = productsList
			.Where(obj => obj.XUATXU == "Nhật Bản")
			.FirstOrDefault();

			if (product != null) {
				table2.Rows.Add(product.MASP, product.TENSP, product.SL, product.DONGIA, product.XUATXU, product.NGAY_HET_HAN);
			}

		}

		private void button5_Click(object sender, EventArgs e)
		{
			table2.Rows.Clear();

			List<ProductDTO> filteredProductList = new List<ProductDTO>();

			filteredProductList = productsList.Where(x => x.NGAY_HET_HAN < DateTime.Today).ToList();

			foreach (var product in filteredProductList)
			{
				table2.Rows.Add(product.MASP, product.TENSP, product.SL, product.DONGIA, product.XUATXU, product.NGAY_HET_HAN);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			table2.Rows.Clear();

			List<ProductDTO> filteredProductList = new List<ProductDTO>();

			filteredProductList = productsList.Where(x => (x.DONGIA >= gtria.Value && x.DONGIA <= gtrib.Value)).ToList();

			foreach (var product in filteredProductList)
			{
				table2.Rows.Add(product.MASP, product.TENSP, product.SL, product.DONGIA, product.XUATXU, product.NGAY_HET_HAN);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				productDAO.DeleteProductsByXuatXu(deleteByXuatXu.Text);

				Reload();

				MessageBox.Show("Xoa thanh cong");
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		
		}

		private void button8_Click(object sender, EventArgs e)
		{
			List<ProductDTO> filteredProductList = new List<ProductDTO>();

			filteredProductList = productsList.Where(x => x.NGAY_HET_HAN < DateTime.Today).ToList();

			if(filteredProductList.Count >= 1)
			{
				MessageBox.Show("Co ton tai sp qua han trong kho!");
			} else
			{
				MessageBox.Show("Trong kho khong ton tai san pham qua han!");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			try
			{
				productDAO.DeleteAllProducts();
				Reload();

				MessageBox.Show("Xoa thanh cong");
			} catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			try
			{
				List<ProductDTO> filteredProductList = new List<ProductDTO>();

				filteredProductList = productsList.Where(x => x.NGAY_HET_HAN < DateTime.Today).ToList();

				foreach (ProductDTO productDTO in filteredProductList)
				{
					productDAO.DeleteProductsByMaSP(productDTO.MASP);
				}

				Reload();

				MessageBox.Show("Xoa thanh cong!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				productDAO.DeleteProductsByMaSP(maSP.Text);
				Reload();

				MessageBox.Show("Xoa thanh cong");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);	
			}
		}
	}
}
