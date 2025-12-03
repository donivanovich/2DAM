using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf03_AgendaPersonal.MVVM.Model
{
    public class Contacto
    {

        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Genero { get; set; }

    }
}
