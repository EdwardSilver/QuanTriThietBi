using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Biz
{
    public class BizLoaiThietBi
    {
        #region Properties
        public int MaLoai { get; set; }
        public string  TenLoai { get; set; }
        #endregion

        #region Initialization
        public BizLoaiThietBi() { }
        public BizLoaiThietBi(int MaLoai, string TenLoai)
        {
            this.MaLoai = MaLoai;
            this.TenLoai = TenLoai;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
