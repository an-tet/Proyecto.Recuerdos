using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuerdos.Modelo
{
    public class Recuerdo
    {
        private double id,id_usuario, padre;
        private String nombre;
        int tipo;
        public Recuerdo()
        {
        }

        public Recuerdo(double id, double id_usuario, double padre, string nombre, int tipo)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.padre = padre;
            this.nombre = nombre;
            this.Tipo = tipo;
        }

        public double Id { get => id; set => id = value; }
        public double Id_usuario { get => id_usuario; set => id_usuario = value; }
        public double Padre { get => padre; set => padre = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
