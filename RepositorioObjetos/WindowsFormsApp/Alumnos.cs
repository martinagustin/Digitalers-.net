using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepositorioObjetos;

namespace WindowsFormsApp
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Alumno p = new Alumno();
            p.setCodigo(Convert.ToInt32(txtCod.Text));
            p.Nombre = txtName.Text;
            p.Apellido = txtLastname.Text;

            label4.Text = p.verDatos();

        }

        private void Alumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
