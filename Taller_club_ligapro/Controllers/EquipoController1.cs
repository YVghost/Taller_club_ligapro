using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller_club_ligapro.Models;
using Taller_club_ligapro.Repositorios;

namespace Taller_club_ligapro.Controllers
{
    public class EquipoController1 : Controller
    {
        // GET: EquipoController1
        public ActionResult List()
        {
            EquipoRepository repo = new EquipoRepository();
            var equipo = repo.DevulveListadoEquipos;
            
            return View(equipo);
        }

        // GET: EquipoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EquipoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EquipoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EquipoController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EquipoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EquipoController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
