using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuerdos.Modelo
{
    public class Archivo
    {
        private double id, id_directorio;
        private String nombre, contenido;
        private Boolean pendiente;

        public Archivo()
        {
        }

        public Archivo(double id, double id_directorio, string nombre, string contenido, bool pendiente)
        {
            this.id = id;
            this.id_directorio = id_directorio;
            this.nombre = nombre;
            this.contenido = contenido;
            this.Pendiente = pendiente;
        }

        public double Id { get => id; set => id = value; }
        public double Id_directorio { get => id_directorio; set => id_directorio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public bool Pendiente { get => pendiente; set => pendiente = value; }
    }
}
