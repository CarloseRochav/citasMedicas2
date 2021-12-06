using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoEquipo3_1.DAO;
using ProyectoEquipo3_1.Controllers;

namespace ProyectoEquipo3_1
{
    public partial class ADM_RClientes : Form
    {
        PacienteController controller = new PacienteController();

        
        public ADM_RClientes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string aPaterno = textBox2.Text;
            string aMaterno = textBox3.Text;
            string nombre = textBox4.Text;
            string genero = comboBox1.Text;
            string fecha = textBox6.Text;
            string correo = textBox7.Text;
            string contrasenia = textBox8.Text;

            //PacienteController controller = new PacienteController();
            try
            {
                string mensaje = controller.Inserccion(aPaterno, aMaterno, nombre, genero, fecha, correo, contrasenia);
                MessageBox.Show(mensaje);
            }
            catch
            {
                string mensaje = controller.Inserccion(aPaterno, aMaterno, nombre, genero, fecha, correo, contrasenia);
                MessageBox.Show(mensaje);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
