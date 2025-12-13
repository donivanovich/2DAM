using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf04_MiniBiblioteca.MVVM.Model
{
    public class Libro
    {
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public DateTime Publicacion { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
}
