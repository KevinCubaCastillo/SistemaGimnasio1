using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Rutina
    {
        public Rutina()
        {
            Detallerutinas = new HashSet<Detallerutina>();
        }

        public int Codrutina { get; set; }
        public string Ciusuario { get; set; } = null!;
        public string? Cicliente { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public int? Estado { get; set; }

        public virtual Cliente? CiclienteNavigation { get; set; }
        public virtual Usuario CiusuarioNavigation { get; set; } = null!;
        public virtual Estado? EstadoNavigation { get; set; }
        public virtual ICollection<Detallerutina> Detallerutinas { get; set; }
    }
}
