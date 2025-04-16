using Microsoft.AspNetCore.Mvc;
using Taller_club_ligapro.Models;
using Taller_club_ligapro.Repositorios;

namespace Taller_club_ligapro.Controllers

{
    public class EquipoController : Controller
    {

        public IActionResult List()
        {
            EquiposRepository repository = new EquiposRepository();
            var equipos = repository.DevuleveListEquipos();
            return View(equipos);
        }
        public IActionResult EditarEquipo()
        {
            Equipo bsc = new Equipo { Id = 1 };
            return View(bsc);
        }

    }
}