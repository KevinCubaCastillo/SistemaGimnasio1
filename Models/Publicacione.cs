using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Publicacione
    {
        public int Codpublicacion { get; set; }
        public string Ciusuario { get; set; } = null!;
        public string Titulo { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public string? Rutaimagen { get; set; }
        public int? Estado { get; set; }

        public virtual Usuario CiusuarioNavigation { get; set; } = null!;
        public virtual Estado? EstadoNavigation { get; set; }
    }
}
