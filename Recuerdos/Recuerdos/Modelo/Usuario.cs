using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuerdos.Modelo
{
    class Usuario
    {
        private double id;
        private String usuario, contracena, nombre, apellidos, correo_electronico;

        public Usuario()
        {
        }

        public Usuario(double id, string usuario, string contracena, string nombre, string apellidos, string correo_electronico)
        {
            this.id = id;
            this.usuario = usuario;
            this.contracena = contracena;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo_electronico = correo_electronico;
        }

        public double Id { get => id; set => id = value; }
        public string Usuarios { get => usuario; set => usuario = value; }
        public string Contracena { get => contracena; set => contracena = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }        
    }
}
