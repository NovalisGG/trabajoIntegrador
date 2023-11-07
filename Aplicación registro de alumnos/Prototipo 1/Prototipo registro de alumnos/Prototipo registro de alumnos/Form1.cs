namespace Prototipo_registro_de_alumnos
{
    public partial class Form1 : Form
    {
        pantallaRegistrar ventanaRegistrar = new pantallaRegistrar();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaRegistrar.ShowDialog();
        }
    }
}