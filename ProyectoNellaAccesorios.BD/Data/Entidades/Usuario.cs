using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNellaAccesorios.BD.Data.Entidades
{
    [Index(nameof(NombreUsuario), Name = "UsuarioNombre_UQ", IsUnique = true)]
    public class Usuario : EntityBase
    {
        //public int Id { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "El Nombre de Usuario no debe superar los {1} caracteres")]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(6, ErrorMessage = "La Contraseña no debe superar los {1} caracteres")]
        public string ContraseñaUsuario { get; set; }
    }
}
