using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPostres.Models
{
    public class Receta
    {
        public int Id { get; set; }
        public string Nombre_Postre { get; set; }
        public string Ingredientes { get; set; }
        public string Receta_Postre { get; set; }

    }
}