using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioInterfaz
{
    public partial class IngresoAlumno : Form
    {
        public IngresoAlumno()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IngresoAlumno_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = DTPiker.Value;
            string estadocivil = comboBox1.Text;
            string sexo = "";
            foreach(Control item in groupBox1.Controls)//verificamos si el radiobutton esta checkeado
            {
                RadioButton radio= item as RadioButton;
                if(radio.Checked == true)
                {
                    sexo=radio.Text;
                }
            }
            bool extranjero = checkBox1.Checked;
            /*
             * aqui colocamos condicion de que si hay un campo string vacio salte un error mostrado en un label.
             * 
            if (nombre == String.Empty || estadocivil = String.Empty || sexo = String.Empty)
            {
                label6.Text = "Hay campos sin completar.";
            }
            else
            {

            }
            */
            //pasamos dato a datagrid
            DataGridViewRow fila = dataGridView1.Rows[0].Clone() as DataGridViewRow;
            fila.Cells[0].Value = nombre;
            fila.Cells[1].Value = estadocivil;
            fila.Cells[2].Value = fecha;
            fila.Cells[3].Value = sexo;
            fila.Cells[4].Value = (extranjero==true ?"si":"no");
            dataGridView1.Rows.Add(fila);





        }

    }
}
