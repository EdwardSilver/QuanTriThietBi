using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class BizChiTietHopDongNhapHang
    {
        #region Properties
        public int MaHD { get; set; }
        public int MaNhomTB { get; set; }
        public int SoLuong { get; set; }
        #endregion

        #region Initialization
        public BizChiTietHopDongNhapHang() { }
        public BizChiTietHopDongNhapHang(int MaHD, int MaNhomTB, int SoLuong)
        {
            this.MaHD = MaHD;
            this.MaNhomTB = MaNhomTB;
            this.SoLuong = SoLuong;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}