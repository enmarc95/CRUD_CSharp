using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11.BLL
{
    public class EmpleadosBLL
    {
        private int id;
        private string nombres;
        private string apellidos;
        private string email;
        private string telefono;
        private string dui;

        public EmpleadosBLL(int id, string nombres, string apellidos, string email, string telefono, string dui)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
            this.dui = dui;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Dui { get => dui; set => dui = value; }
    }
}
