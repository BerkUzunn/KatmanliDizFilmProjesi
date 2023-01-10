using KatmanlıData.Data;
using KatmanlıModel.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatmanlıSunumProjesi.Controllers
{
    public class DiziYorumController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiziYorumController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objList = _db.DiziYorumlar.ToList();
            return View(objList);
        }
        public async Task<IActionResult> Create(DiziYorumlar obj)
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

            var ob = await _db.DiziYorumlar.FindAsync(id);
            return View(ob);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(DiziYorumlar ob)
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
            var obj = await _db.DiziYorumlar.FindAsync(id);
            _db.DiziYorumlar.Remove(obj);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
