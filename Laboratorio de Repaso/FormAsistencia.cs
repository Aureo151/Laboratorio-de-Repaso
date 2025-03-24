using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_de_Repaso
{
    public partial class FormAsistencia : Form
    {
        List<Asistencia> asistencias = new List<Asistencia>();
        public FormAsistencia()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarAsistencia_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia();
            asistencia.NoEmpleado = Convert.ToInt16(txtNoEmpleado.Text);
            asistencia.mes = Convert.ToInt16(txtMes.Text);
            asistencia.horasMes = Convert.ToInt16(txtHorasMes.Text);

            asistencias.Add(asistencia);
            txtNoEmpleado.Clear();
            txtMes.Clear();
            txtHorasMes.Clear();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {

        }


    }
}
