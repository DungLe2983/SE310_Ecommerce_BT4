using Ecommerce_21520739.Data;
using Ecommerce_21520739.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_21520739.ViewComponents
{
    public class MenuLoaiViewComponent:ViewComponent
    {
        private readonly Hshop2024Context db;

        public MenuLoaiViewComponent(Hshop2024Context context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVM
            {
                MaLoai =lo.MaLoai,
                TenLoai = lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            }); 
            return View(data);
        }
    }
}
