﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Taller_club_ligapro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Ingrese nombre: ")]

        public string Nombre { get; set; }
        [Range(0,20)]

        public int PartidosJugados{ get; set; }
        [Range(0, 20)]

        public int PartidosGanados { get; set; }
        [Range(0, 20)]

        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]


        public int ParitdosPerdidos { get; set; }

        public int TotalPuentos { get; set; }




    }
}
