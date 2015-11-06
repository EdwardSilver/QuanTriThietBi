using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Dal;
using System.ComponentModel.DataAnnotations;

namespace Core.Biz
{
    public class BizThietBi
    {
        #region Properties + Annotations
        [Display(Name ="Mã thiết bị")]
        public int MaTB { get; set; }

        [Display(Name ="Năm sử dụng")]
        public DateTime NamSD { get; set; }

        [Display(Name ="Tỉ lệ khấu hao", Description ="Nhập số từ 0 đến 100. Tỉ lệ khấu khao - đơn vị %")]
        [Range(0, 100)]
        public double TiLeKhauHao { get; set; }

        [Display(Name ="Giá trị sử dụng", Description ="Nhập số từ 0 đến 100. Giá trị sử dụng - đơn vị %")]
        [Range(0, 100)]
        public double GiaTriSuDung { get; set; }

        [Display(Name ="Tình trạng")]
        public int TinhTrang { get; set; }

        public int MaNhomTB { get; set; }

        public int MaDV { get; set; }
        #endregion

        #region Initialization
        public BizThietBi()
        {
            TiLeKhauHao = 1; // Giá trị mặc định ban đầu cho tỉ lệ khấu hao của thiết bị 1%
            GiaTriSuDung = 100; // Giá trị mặc định ban đầu cho giá trị sử dụng của thiết bị 100%
            TinhTrang = (int)eTinhTrang.Using; // Giá trị mặc định ban đầu cho tình trạng của thiết bị là Using - Đang sử dụng
        }    
        public BizThietBi(int MaTB, DateTime NamSD, double TiLeKhauHao, double GiaTriSuDung, int TinhTrang, int MaNhomTB, int MaDV)
        {
            this.MaTB = MaTB;
            this.NamSD = NamSD;
            this.TiLeKhauHao = TiLeKhauHao;
            this.GiaTriSuDung = GiaTriSuDung;
            this.TinhTrang = TinhTrang;
            this.MaNhomTB = MaNhomTB;
            this.MaDV = MaDV;
        }
        #endregion

        #region Public Methods
        public bool Them()
        {
            return DalThietBi.ThemThietBi(this);
        }
        public bool CapNhat()
        {
            return DalThietBi.CapNhat(this);
        }
        public bool Xoa()
        {
            return DalThietBi.XoaThietBi(this);
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
