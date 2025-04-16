using Taller_club_ligapro.Models;

namespace Taller_club_ligapro.Repositories
{
    public class EquiposRepository
    {
        public IEnumerable<Equipo> DevuleveListEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo bsc = new Equipo
            {
                Id = 1,
                Nombre = "BSC",
                PartidosJugados = 4,
                PartidosGanados = 3,
                PartidosPerdidos = 3,
                PartidosEmpatados = 5,
                ToatalPuntos = 0,
            };
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosGanados = 3,
                PartidosPerdidos = 3,
                PartidosJugados = 4,
                PartidosEmpatados = 5,
                ToatalPuntos = 0,
            };
            Equipo eml = new Equipo
            {
                Id = 1,
                Nombre = "Emelec",
                PartidosGanados = 3,
                PartidosPerdidos = 3,
                PartidosJugados = 4,
                PartidosEmpatados = 5,
                ToatalPuntos = 0,
            };
            Equipo auc = new Equipo
            {
                Id = 1,
                Nombre = "Emelec",
                PartidosGanados = 3,
                PartidosPerdidos = 3,
                PartidosJugados = 4,
                PartidosEmpatados = 5,
                ToatalPuntos = 0,
            };
            equipos.Add(auc);
            equipos.Add(bsc);
            equipos.Add(ldu);
            equipos.Add(eml);
            return equipos;
        }
    }
}