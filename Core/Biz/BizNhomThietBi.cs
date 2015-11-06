using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Dal;
namespace Core.Biz
{
    public class BizNhomThietBi
    {
        #region Properties
        public int MaNhomTB { get; set; }
        public string TenNhomTB { get; set; }
        public int MaLoai { get; set; }
        public double NguyenGia { get; set; }
        public string ThongSoKyThuat { get; set; }
        public int NamSX { get; set; }
        public string HinhAnh { get; set; }
        #endregion

        #region Initialization
        public BizNhomThietBi() { }
        public BizNhomThietBi(int MaNhomTB, string TenNhomTB, int MaLoai, double NguyenGia, string ThongSoKyThuat, int NamSX, string HinhAnh)
        {
            this.MaNhomTB = MaNhomTB;
            this.TenNhomTB = TenNhomTB;
            this.MaLoai = MaLoai;
            this.NguyenGia = NguyenGia;
            this.ThongSoKyThuat = ThongSoKyThuat;
            this.NamSX = NamSX;
            this.HinhAnh = HinhAnh;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
