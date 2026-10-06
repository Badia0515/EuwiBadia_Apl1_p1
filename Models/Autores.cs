using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Euwinbadia_P1_Apl1.Models;
    public class Autores 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debes de LLenar el campo Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="Debes de llenar el campo Nacionalidades")]
        public string Nacionalidad { get; set; }

        [Required(ErrorMessage = "Debes de llenar el campo Nacionalidades")]
        public string FechaDeNacimiento { get; set; }

        [Range(1,int.MaxValue, ErrorMessage ="No debe ser menor que 1")]
        public int Sueldo { get; set; }
    }

