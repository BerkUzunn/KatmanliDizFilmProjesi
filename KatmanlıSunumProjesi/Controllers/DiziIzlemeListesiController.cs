using KatmanlıData.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatmanlıSunumProjesi.Controllers
{
    public class DiziIzlemeListesiController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiziIzlemeListesiController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objList = _db.DiziIzlemeListesi.ToList();
            return View(objList);
        }

    
      

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var obj = await _db.DiziIzlemeListesi.FindAsync(id);
            _db.DiziIzlemeListesi.Remove(obj);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
