namespace AplicacionWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = TxtUser.Text;
            string password = TxtPassword.Text;
            if(user.ToLower()=="pepito" && password.ToLower() == "educacion")
            {
                LblOutput.Text = $"BIENVENIDO\n {user}";
            }
            else
            {
                LblOutput.Text = "Error";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LblOutput.Text = "";
            TxtUser.Text = "";
            TxtPassword.Text = "";
        }
    }
}