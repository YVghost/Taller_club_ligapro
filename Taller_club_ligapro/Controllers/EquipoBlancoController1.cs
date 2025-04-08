using Microsoft.AspNetCore.Mvc;
using Taller_club_ligapro.Models;
//este controlador no tiene referencia por lo que es de prueba y entendimiento de controladores 
namespace Taller_club_ligapro.Controllers
{
    public class EquipoBlancoController1 : Controller
    {
        public IActionResult List()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                ParitdosPerdidos = 0
            };




            return View();
        }
    }
}
