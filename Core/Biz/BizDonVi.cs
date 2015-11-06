using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class BizDonVi
    {
        #region Properties
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        #endregion

        #region Initialization
        public BizDonVi() { }
        public BizDonVi(int MaDV, string TenDV)
        {
            this.MaDV = MaDV;
            this.TenDV = TenDV;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
