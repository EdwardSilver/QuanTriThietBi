using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class BizNhaCungCap
    {
        #region Properties
        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        #endregion

        #region Initialization
        public BizNhaCungCap() { }
        public BizNhaCungCap(int MaNCC, string TenNCC, string DiaChi, string DienThoai)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.DiaChi = DiaChi;
            this.DienThoai = DienThoai;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
