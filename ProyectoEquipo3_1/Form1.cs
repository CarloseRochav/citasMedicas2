using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoEquipo3_1.Models;

namespace ProyectoEquipo3_1
{
    public partial class Form1 : Form
    {
        ADM_RClientes registrarPaciente = new ADM_RClientes();
        ADM_RMedico registrarMedico = new ADM_RMedico();
        ADM_REspecialidad registrarEspecialidad = new ADM_REspecialidad();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            registrarPaciente.Show();
        }
    }
}
