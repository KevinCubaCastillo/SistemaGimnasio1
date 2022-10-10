using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Equipo
    {
        public Equipo()
        {
            Ejercicios = new HashSet<Ejercicio>();
        }

        public int Codequipo { get; set; }
        public int? Codcategoria { get; set; }
        public string Nombreequipo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Rutaimagen { get; set; }
        public int? Estado { get; set; }

        public virtual Categorium? CodcategoriaNavigation { get; set; }
        public virtual Estado? EstadoNavigation { get; set; }
        public virtual ICollection<Ejercicio> Ejercicios { get; set; }
    }
}
