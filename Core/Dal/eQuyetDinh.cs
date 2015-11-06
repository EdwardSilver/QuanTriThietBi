using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dal
{
    public enum eQuyetDinh : int
    {
        Sell = 3,   // Bán
        Liquidate = 4, // Thanh lý
        Out = 5 // Điều động ra khỏi trường
    }
}
