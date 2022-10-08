using Semana11.BLL;
using Semana11.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana11.PL
{
    public partial class frmEmpleados : Form
    {
        SedesDAL sedes;
        EmpleadosDAL empleados;
        public frmEmpleados()
        {
            InitializeComponent();
            this.sedes = new SedesDAL();
            this.empleados = new EmpleadosDAL();
        }

        private void listSedes()
        {
            List<SedesBLL> listSedes = sedes.getAllSedess();
            cmbSedes.DataSource = listSedes;
            cmbSedes.DisplayMember = "nombre";
            cmbSedes.ValueMember = "id";
        }

        private void fillDvgEmpleados()
        {
            dgvEmpleados.DataSource = empleados.getAllEmpleados();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            listSedes();
            fillDvgEmpleados();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
