using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuerdos.Modelo
{
    public class Sueno
    {
        private double id, id_recuerdo, id_usuario;
        private String nombre, contenido;
        private Boolean pendiente;

        public Sueno()
        {
        }

        public Sueno(double id, double id_recuerdo, double id_usuario, string nombre, string contenido, bool pendiente)
        {
            this.Id = id;
            this.Id_recuerdo = id_recuerdo;
            this.Id_usuario = id_usuario;
            this.Nombre = nombre;
            this.Contenido = contenido;
            this.Pendiente = pendiente;
        }

        public double Id { get => id; set => id = value; }
        public double Id_recuerdo { get => id_recuerdo; set => id_recuerdo = value; }
        public double Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public bool Pendiente { get => pendiente; set => pendiente = value; }
    }
}
