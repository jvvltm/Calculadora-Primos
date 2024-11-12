using NumerosPrimos_Soporte;

namespace NumerosPrimos_Presentacion
{
    public partial class Form1 : Form
    {
        private readonly Soporte _soporte;
        public Form1()
        {
            InitializeComponent();
            _soporte = new Soporte();
            CargarRangos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarRangos()
        {
           
            comboBoxRango.Items.Add("1-99");
            comboBoxRango.Items.Add("100-999");
            comboBoxRango.Items.Add("1000-9999");
            comboBoxRango.Items.Add("10000-99999");
            comboBoxRango.Items.Add("100000-999999");
            comboBoxRango.Items.Add("1000000-9999999"); // rango extra para ver cuanto se demora
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxRango.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un rango.");
                return;
            }

            string rango = comboBoxRango.SelectedItem.ToString();
            var resultados = _soporte.ObtenerResultados(rango);

            txtResultados.Text = $"Rango: {resultados.rango}{Environment.NewLine}" +
                                  $"Número Primo Menor: {resultados.menor}{Environment.NewLine}" +
                                  $"Número Primo Mayor: {resultados.mayor}{Environment.NewLine}" +
                                  $"Cantidad de Números Primos: {resultados.cantidad}{Environment.NewLine}" +
                                  $"Tiempo: {resultados.tiempo:F3} segundos";

        }


    }
}
