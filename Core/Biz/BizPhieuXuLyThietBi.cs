using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class BizPhieuXuLyThietBi
    {
        #region Properties + Annotations
        public int MaPXLTB { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaDV_Giao { get; set; }
        public int MaDV_Nhan { get; set; }
        public string GhiChu { get; set; }
        public List<BizChiTietPhieuXuLyThietBi> lstBizChiTiets { get; set; }
        #endregion

        #region Initialization
        public BizPhieuXuLyThietBi() { }
        public BizPhieuXuLyThietBi(int MaPXLTB, DateTime NgayLap, int MaDV_Giao, int MaDV_Nhan, string GhiChu, List<BizChiTietPhieuXuLyThietBi> lstBizChiTiets)
        {
            this.MaPXLTB = MaPXLTB;
            this.NgayLap = NgayLap;
            this.MaDV_Giao = MaDV_Giao;
            this.MaDV_Nhan = MaDV_Nhan;
            this.GhiChu = GhiChu;
            this.lstBizChiTiets = lstBizChiTiets;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
