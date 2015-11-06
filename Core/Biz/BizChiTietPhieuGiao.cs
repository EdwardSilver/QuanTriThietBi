using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class BizChiTietPhieuGiao
    {
        #region Properties
        public int MaPG { get; set; }
        public int MaNhomTB { get; set; }
        public int SoLuong { get; set; }
        #endregion

        #region Initialization
        public BizChiTietPhieuGiao() { }
        public BizChiTietPhieuGiao(int MaPG, int MaNhomTB, int SoLuong)
        {
            this.MaPG = MaPG;
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
