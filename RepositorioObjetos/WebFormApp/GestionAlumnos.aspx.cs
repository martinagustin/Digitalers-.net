using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepositorioObjetos;
namespace WebFormApp
{
    public partial class GestionAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.Nombre = txtnom.Text;
            a.Apellido = txtape.Text;
            lblDatosAlumnos.Text = a.verDatos();
        }

        protected void btnviajar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.html");
        }
    }
}