using Taller_club_ligapro.Models;

namespace Taller_club_ligapro.Repositorios
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevulveListadoEquipos()
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
            equipos.Add(ldu);
            return equipos;
        }
    }
}
