using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class BizPhieuChuyenThietBi
    {
        #region Properties
        public int MaPCTB { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaDV_Giao { get; set; }
        public int MaDV_Nhan { get; set; }
        public string GhiChu { get; set; }
        public IList<BizThietBi> ThietBis { get; set; }
        #endregion

        #region Initialization
        public BizPhieuChuyenThietBi() { }
        public BizPhieuChuyenThietBi(int MaPCTB, DateTime NgayLap, int MaDV_Giao, int MaDV_Nhan, string GhiChu, IList<BizThietBi> ThietBis)
        {
            this.MaPCTB = MaPCTB;
            this.NgayLap = NgayLap;
            this.MaDV_Giao = MaDV_Giao;
            this.MaDV_Nhan = MaDV_Nhan;
            this.GhiChu = GhiChu;
            this.ThietBis = ThietBis;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
