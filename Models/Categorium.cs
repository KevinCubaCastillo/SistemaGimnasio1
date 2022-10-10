using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Equipos = new HashSet<Equipo>();
        }

        public int Codcategoria { get; set; }
        public string Nombrecategoria { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Rutaimagen { get; set; }
        public int? Estado { get; set; }

        public virtual Estado? EstadoNavigation { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
