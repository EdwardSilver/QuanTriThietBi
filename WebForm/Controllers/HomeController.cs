using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Biz;
using Core.Dal;

namespace Webform.Controllers
{
    public class HomeController : Controller
    {
        QuanTriThietBiEntities db = new QuanTriThietBiEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListThietBi()
        {
            return View(DalThietBi.LayDanhSachThietBi());
        }
        public ActionResult CreateThietBi()
        {
            ViewBag.MaNhom = new SelectList(db.NhomThietBis.ToList(), "MaNhomTB", "TenNhomTB");
            ViewBag.MaDonVi = new SelectList(db.DonVis.ToList(), "MaDV", "TenDonVi");
            return View();
        }
        [HttpPost]
        public ActionResult CreateThietBi(BizThietBi thietbi, int MaNhom, int MaDonVi)
        {

            ViewBag.MaNhom = new SelectList(db.NhomThietBis.ToList(), "MaNhomTB", "TenNhomTB");
            ViewBag.MaDonVi = new SelectList(db.DonVis.ToList(), "MaDV", "TenDonVi");
            thietbi.MaNhomTB = MaNhom;
            thietbi.MaDV = MaDonVi;
            if (ModelState.IsValid)
            {
                if (thietbi.Them())
                {
                    ViewBag.ThongBao = "Đăng ký thành công!";
                    return View();
                }
                else
                {
                    ViewBag.ThongBao = "Đăng ký không thành công!";
                    return View();
                }
            }
            return View();
        }

        public ActionResult Delete(int id, BizThietBi thietbi)
        {
            thietbi.MaTB = id;
            thietbi.Xoa();
            return Content("<script language='javascript' type='text/javascript'>alert('XóaThành Công!'); window.location.href = '../Home/Index';</script>");
        }
    }
}