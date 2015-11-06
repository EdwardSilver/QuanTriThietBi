using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class BizPhieuGiao
    {
        #region Properties
        public int MaPG { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaDV { get; set; }
        public string GhiChu { get; set; }

        public IList<BizChiTietPhieuGiao> BizChiTietPhieuGiaos { get; set; }
        #endregion

        #region Initialization
        public BizPhieuGiao() { }
        public BizPhieuGiao(int MaPG, DateTime NgayLap, int MaDV, string GhiChu, IList<BizChiTietPhieuGiao> BizChiTietPhieuGiaos)
        {
            this.MaPG = MaPG;
            this.NgayLap = NgayLap;
            this.MaDV = MaDV;
            this.GhiChu = GhiChu;
            this.BizChiTietPhieuGiaos = BizChiTietPhieuGiaos;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
