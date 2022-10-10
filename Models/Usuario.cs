using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Inscripciones = new HashSet<Inscripcione>();
            Publicaciones = new HashSet<Publicacione>();
            Rutinas = new HashSet<Rutina>();
        }

        public string Ci { get; set; } = null!;
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Nombreusuario { get; set; }
        public string? Contrasenia { get; set; }
        public string? Tipo { get; set; }
        public int? Estado { get; set; }

        public virtual Estado? EstadoNavigation { get; set; }
        public virtual ICollection<Inscripcione> Inscripciones { get; set; }
        public virtual ICollection<Publicacione> Publicaciones { get; set; }
        public virtual ICollection<Rutina> Rutinas { get; set; }
    }
}
