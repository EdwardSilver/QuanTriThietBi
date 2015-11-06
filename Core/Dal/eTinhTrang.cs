using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dal
{
    public enum eTinhTrang : int
    {
        Damaged = 0, // Hư
        Using = 1,   // Đang được sử dụng
        Fixing = 2,  // Đang sửa chửa
        Sold = 3,    // Đã bán
        Liquidated = 4, // Đã thanh lý
        Out = 5,      // Đã được điều động ra khỏi trường
        Returned = 6 // Đã trả về phòng quản trị thiết bị
    }
}
