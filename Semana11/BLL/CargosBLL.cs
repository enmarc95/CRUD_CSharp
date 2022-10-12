using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11.BLL
{
    public class CargosBLL
    {
        private int id;
        private string cargo;
        private double salario;

        public CargosBLL(int id)
        {
            this.id = id;
        }

        public CargosBLL(int id, string cargo, double salario)
        {
            this.id = id;
            this.cargo = cargo;
            this.salario = salario;
        }

        public int Id { get => id; set => id = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}
