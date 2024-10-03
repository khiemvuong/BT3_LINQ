using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject.DTO
{
	internal class ProductDTO
	{
		public ProductDTO(string masp, string tensp, int sl, int dongia, string xuatxu, DateTime ngayhethan)
		{
			MASP = masp;
			TENSP = tensp;
			SL = sl;
			DONGIA = dongia;
			XUATXU = xuatxu;
			NGAY_HET_HAN = ngayhethan;
		}

		public ProductDTO() { }

		public string MASP { get; set; }
		public string TENSP { get; set; }
		public int SL { get; set; }
		public int DONGIA { get; set; }
		public string XUATXU {  get; set; }
		public DateTime NGAY_HET_HAN {  get; set; }
    }
}
