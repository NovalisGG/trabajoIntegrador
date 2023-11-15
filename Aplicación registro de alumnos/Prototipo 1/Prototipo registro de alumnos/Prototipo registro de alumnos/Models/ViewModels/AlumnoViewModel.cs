using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_registro_de_alumnos.Models.ViewModels
{
    public class AlumnoViewModel
    {
        public int id { get; set; }

        [DisplayName("Nombre")]
        public string nombre { get; set; }
        public int edad { get; set; }

    }
}
