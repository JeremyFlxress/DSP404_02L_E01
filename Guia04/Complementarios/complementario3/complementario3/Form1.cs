namespace complementario3
{
    public partial class Form1 : Form
    {
        // Declaraci�n de la lista de notas.
        private List<double> notas;

        public Form1()
        {
            InitializeComponent();
            notas = new List<double>(); 
        }

        // M�todo que calcula y muestra los resultados estad�sticos en un ListBox.
        private void CalcularEstadisticas(List<double> notas, ListBox listBox)
        {
            listBox.Items.Clear();

            if (notas.Count == 0)
            {
                listBox.Items.Add("No hay notas registradas.");
                return;
            }

            // a) Porcentaje de estudiantes deficientes (con notas menores de 5.0)
            int numDeficientes = notas.Count(nota => nota < 5.0);
            double porcentajeDeficientes = (double)numDeficientes / notas.Count * 100;

            // b) N�mero de aprobados (con notas mayores o iguales a 6.0)
            int numAprobados = notas.Count(nota => nota >= 6.0);

            // c) Nota m�s baja, nota m�s alta y nota media
            double notaMinima = notas.Min();
            double notaMaxima = notas.Max();
            double notaMedia = notas.Average();

            // Mostrar los resultados en el ListBox
            listBox.Items.Add($"Porcentaje de Deficientes: {porcentajeDeficientes:F2}%");
            listBox.Items.Add($"N�mero de Aprobados: {numAprobados}");
            listBox.Items.Add($"Nota m�s baja: {notaMinima}");
            listBox.Items.Add($"Nota m�s alta: {notaMaxima}");
            listBox.Items.Add($"Nota media: {notaMedia:F2}");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularEstadisticas(notas, listBoxResultados);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double nota;

            // Verifica que se ingrese un valor num�rico v�lido entre 0.0 y 10.0.
            if (double.TryParse(txtNota.Text, out nota) && nota >= 0.0 && nota <= 10.0)
            {
                notas.Add(nota);
                MessageBox.Show("Nota agregada.");
                txtNota.Clear(); 
            }
            else
            {
                MessageBox.Show("Ingrese una nota v�lida entre 0.0 y 10.0.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
