using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaGimansio2.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Inscripciones = new HashSet<Inscripcione>();
            Publicaciones = new HashSet<Publicacione>();
            Rutinas = new HashSet<Rutina>();
        }
        [Required]
        [Column("ci", TypeName = "varchar(100)")]
        [StringLength(100)]
        [Display(Name = "Ingrese su CI:")]
        public string Ci { get; set; } = null!;
        [Required]
        [Column("nombre", TypeName = "varchar(100)")]
        [StringLength(100)]
        [Display(Name = "Ingrese su nombre:")]
        public string? Nombres { get; set; }
        [Required]
        [Column("apellido", TypeName = "varchar(100)")]
        [StringLength(100)]
        [Display(Name = "Ingrese su apellido:")]
        public string? Apellidos { get; set; }
        [Required(ErrorMessage = "Ingrese su nombre de usuario")]
        [Column("nombreUsuario", TypeName = "varchar(100)")]
        [StringLength(100)]
        [Display(Name = "Ingrese su nombre de usuario:")]
        public string? Nombreusuario { get; set; }
        [Required(ErrorMessage = "Ingrese su contraseña")]
        [Column("clave", TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Password)]
        [Display(Name = "Ingrese su contraseña:")]
        public string? Contrasenia { get; set; }
        public string? Tipo { get; set; }
        [ScaffoldColumn(false)]
        public int? Estado { get; set; }
        
        public virtual Estado? EstadoNavigation { get; set; }
        
        public virtual ICollection<Inscripcione> Inscripciones { get; set; }
        public virtual ICollection<Publicacione> Publicaciones { get; set; }
        public virtual ICollection<Rutina> Rutinas { get; set; }
    }
}
