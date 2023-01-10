using KatmanlıData.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatmanlıSunumProjesi.Controllers
{
    public class FilmIzlemeListesiController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FilmIzlemeListesiController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objList = _db.FilmIzlemeListesi.ToList();
            return View(objList);
        }




        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var obj = await _db.FilmIzlemeListesi.FindAsync(id);
            _db.FilmIzlemeListesi.Remove(obj);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
