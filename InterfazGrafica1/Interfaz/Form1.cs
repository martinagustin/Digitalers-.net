namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = TxtInput.Text;
            Alumno a = new Alumno();
            a.Name = texto;
            LblOutput.Text = a.Name;
        }
    }
}