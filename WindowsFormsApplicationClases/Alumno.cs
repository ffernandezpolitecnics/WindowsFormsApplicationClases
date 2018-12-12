using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationClases
{
    class Alumno
    {
        public Alumno()
        {

        }

        public Alumno(int id, string nombre, DateTime fechaNac)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechaNac = fechaNac;
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNac { get; set; }
        public int MyProperty { get; set; }

        public int edad()
        {
            DateTime hoy = DateTime.Now;

            return hoy.Year - fechaNac.Year;
        }
    }
}
