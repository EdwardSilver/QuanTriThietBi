using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class BizChiTietPhieuXuLyThietBi
    {
        #region Properties
        public int MaPXLTB { get; set; }
        public int MaTB { get; set; }
        public double TienThuDuoc { get; set; }
        #endregion

        #region Initialization
        public BizChiTietPhieuXuLyThietBi() { }
        public BizChiTietPhieuXuLyThietBi(int MaPXLTB, int MaTB, double TienThuDuoc)
        {
            this.MaPXLTB = MaPXLTB;
            this.MaTB = MaTB;
            this.TienThuDuoc = TienThuDuoc;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
