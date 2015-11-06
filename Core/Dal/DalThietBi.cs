using Core.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dal
{
    public class DalThietBi
    {
        private static QuanTriThietBiEntities db;

        #region Thêm thiết bị
        public static bool ThemThietBi(BizThietBi thietBi)
        {
            db = new QuanTriThietBiEntities();

            ThietBi newThietBi = new ThietBi();
            newThietBi.MaNhomTB = thietBi.MaNhomTB;
            newThietBi.NamSD = thietBi.NamSD;
            newThietBi.MaDV = thietBi.MaDV;
            newThietBi.TiLeKhauHao = thietBi.TiLeKhauHao;
            newThietBi.GiaTriSuDung = thietBi.GiaTriSuDung;
            newThietBi.TinhTrang = thietBi.TinhTrang;           

            try
            {
                db.ThietBis.Add(newThietBi);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Sửa thông tin thiết bị
        public static bool CapNhat(BizThietBi bizThietBi)
        {
            db = new QuanTriThietBiEntities();
            ThietBi thietBi = db.ThietBis.SingleOrDefault(n => n.MaTB == bizThietBi.MaTB);
            if(thietBi != null)
            {
                thietBi.NamSD = thietBi.NamSD;
                thietBi.TiLeKhauHao = thietBi.TiLeKhauHao;
                thietBi.GiaTriSuDung = thietBi.GiaTriSuDung;
                thietBi.TinhTrang = thietBi.TinhTrang;
                thietBi.MaNhomTB = thietBi.MaNhomTB;
                thietBi.MaDV = thietBi.MaDV;

                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Xóa thiết bị
        public static bool XoaThietBi(BizThietBi bizThietBi)
        {
            db = new QuanTriThietBiEntities();
            ThietBi thietBi = db.ThietBis.SingleOrDefault(n => n.MaTB == bizThietBi.MaTB);
            if(thietBi == null)
            {
                return false;
            }
            try
            {
                db.ThietBis.Remove(thietBi);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Lấy danh sách thiết bị
        public static List<BizThietBi> LayDanhSachThietBi()
        {
            db = new QuanTriThietBiEntities();
            List<ThietBi> lstThietBis = db.ThietBis.ToList();
            List<BizThietBi> lstBizThietBis = new List<BizThietBi>();

            foreach (var thietBi in lstThietBis)
            {
                BizThietBi bizThietBi = new BizThietBi(
                        thietBi.MaTB,
                        (DateTime)thietBi.NamSD,
                        (double)thietBi.TiLeKhauHao,
                        (int)thietBi.GiaTriSuDung,
                        (int)thietBi.TinhTrang,
                        (int)thietBi.MaNhomTB,
                        (int)thietBi.MaDV
                    );
                lstBizThietBis.Add(bizThietBi);
            }
            return lstBizThietBis;
        }
        #endregion

    }
}
