using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Garcia.Models
{
    public class Articulos
    {
        [Key]
        [Required(ErrorMessage = "El campo ID no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo ID no puede ser menor que cero o mayor a 1000000.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "El campo Descripcion no puede estar vacío.")]
        [MinLength(3, ErrorMessage = "El Descripcion debe tener por lo menos 3 caracteres.")]
        [RegularExpression(@"\S(.*)\S", ErrorMessage = "Debe ser un texto.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "")]
        [Range(0, 1000000, ErrorMessage = "El campo Existencia no puede ser menor que cero o mayor a 1000000.")]
        public decimal Existencia { get; set; }

        [Required(ErrorMessage = "")]
        [Range(0, 1000000, ErrorMessage = "El campo Costo no puede ser menor que cero o mayor a 1000000.")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "")]
        [Range(0, 1000000, ErrorMessage = "El campo Inventario no puede ser menor que cero o mayor a 1000000.")]
        public decimal Inventario { get; set; }

        public Articulos()
        {
            ID = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            Inventario = 0;
        }

        public Articulos(int ID, string descripcion, decimal existencia, decimal costo, decimal inventario)
        {
            ID = ID;
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            Existencia = existencia;
            Costo = costo;
            Inventario = inventario;
        }
    }
}
