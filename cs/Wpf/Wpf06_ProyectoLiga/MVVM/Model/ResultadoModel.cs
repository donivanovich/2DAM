using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Wpf06_ProyectoLiga.MVVM.Model
{
    public class ResultadoModel
    {
        public string id { get; set; }
        public string NOMBRE { get; set; }
        public string ESCUDO { get; set; }
        public string FECHA { get; set; }
        public string CAMPO { get; set; }
        public string G_LOCAL { get; set; }
        public string G_VISITANTE { get; set; }
        public string local { get; set; }
    }
}
