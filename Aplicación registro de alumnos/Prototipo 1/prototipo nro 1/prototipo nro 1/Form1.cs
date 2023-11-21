namespace prototipo_nro_1
{
    public partial class Form1 : Form
    {
        ventanaRegistrar ventanaRegistrar = new ventanaRegistrar();
        ventanaBuscar ventanaBuscar = new ventanaBuscar();
        ventanaActualizar ventanaActualizar = new ventanaActualizar();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaRegistrar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaBuscar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventanaActualizar.ShowDialog();
        }
    }
}