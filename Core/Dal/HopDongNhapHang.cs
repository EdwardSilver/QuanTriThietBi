//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class HopDongNhapHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HopDongNhapHang()
        {
            this.ChiTietHopDongNhapHangs = new HashSet<ChiTietHopDongNhapHang>();
        }
    
        public int MaHD { get; set; }
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<int> MaNCC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHopDongNhapHang> ChiTietHopDongNhapHangs { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}