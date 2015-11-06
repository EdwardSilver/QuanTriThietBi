using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class BizHopDongNhapHang
    {
        #region Properties
        public int MaHD { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaNCC { get; set; }
        public List<BizChiTietHopDongNhapHang> BizChiTiets { get; set; }
        #endregion

        #region Initialization
        public BizHopDongNhapHang() { }
        public BizHopDongNhapHang(int MaHD, string NoiDung, DateTime NgayLap, int MaNCC, List<BizChiTietHopDongNhapHang> BizChiTietHopDongNhapHangs)
        {
            this.MaHD = MaHD;
            this.NoiDung = NoiDung;
            this.NgayLap = NgayLap;
            this.MaNCC = MaNCC;
            BizChiTiets = BizChiTietHopDongNhapHangs;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
