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
    
    public partial class NhomThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomThietBi()
        {
            this.ChiTietHopDongNhapHangs = new HashSet<ChiTietHopDongNhapHang>();
            this.ChiTietPhieuGiaos = new HashSet<ChiTietPhieuGiao>();
            this.ThietBis = new HashSet<ThietBi>();
        }
    
        public int MaNhomTB { get; set; }
        public string TenNhomTB { get; set; }
        public Nullable<int> MaLoai { get; set; }
        public Nullable<double> NguyenGia { get; set; }
        public string ThongSoKyThuat { get; set; }
        public Nullable<int> NamSX { get; set; }
        public string HinhAnh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHopDongNhapHang> ChiTietHopDongNhapHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuGiao> ChiTietPhieuGiaos { get; set; }
        public virtual LoaiThietBi LoaiThietBi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThietBi> ThietBis { get; set; }
    }
}
