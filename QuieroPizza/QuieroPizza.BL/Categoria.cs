﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la categoria")]  // Validación
        public string Descripcion { get; set; }
    }
}
