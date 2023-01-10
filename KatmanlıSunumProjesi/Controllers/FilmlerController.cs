using KatmanlıData.Data;
using KatmanlıModel.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatmanlıSunumProjesi.Controllers
{
    public class FilmlerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FilmlerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objList = _db.Filmler.ToList();
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(Filmler obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var ob = await _db.Filmler.FindAsync(id);
            return View(ob);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Filmler ob)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ob);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ob);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var obj = await _db.Filmler.FindAsync(id);
            _db.Filmler.Remove(obj);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
