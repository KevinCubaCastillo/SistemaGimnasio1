using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Ejercicio
    {
        public Ejercicio()
        {
            Detallerutinas = new HashSet<Detallerutina>();
        }

        public int Codejercicio { get; set; }
        public int? Codequipo { get; set; }
        public string? Nombreejercicio { get; set; }
        public string? Descripcion { get; set; }
        public string? Rutaimagen { get; set; }
        public string? Rutavideo { get; set; }
        public int? Estado { get; set; }

        public virtual Equipo? CodequipoNavigation { get; set; }
        public virtual Estado? EstadoNavigation { get; set; }
        public virtual ICollection<Detallerutina> Detallerutinas { get; set; }
    }
}
