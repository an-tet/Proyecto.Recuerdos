using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuerdos.Modelo
{
    public class Directorio
    {
        private double id, padre;
        private String nombre;
        public Directorio()
        {
        }
        public Directorio(double id, double padre, string nombre)
        {
            this.id = id;
            this.padre = padre;
            this.nombre = nombre;
        }

        public double Id { get => id; set => id = value; }
        public double Padre { get => padre; set => padre = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
