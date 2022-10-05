using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRegistro.Entidades
{
    public class Articulo
    {
         [Key]

        public int ProductoId { get; set; }
        public string? Descripcion { get; set; }
        public string? Marca { get; set; }
        public decimal Existencia { get; set; }
    }
}