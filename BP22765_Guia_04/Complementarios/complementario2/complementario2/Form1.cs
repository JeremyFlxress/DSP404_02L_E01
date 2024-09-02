using System.Drawing.Drawing2D;

namespace complementario2
{
    public partial class Form1 : Form
    {
        // Declaraci�n de la matriz que se generar�.
        private int[,] matriz;

        public Form1()
        {
            InitializeComponent();
            matriz = new int[5, 5]; // Inicializa la matriz 5x5.
        }

        // M�todo para generar una matriz de 5x5 con n�meros aleatorios entre los l�mites dados.
        private int[,] GenerarMatriz(int limiteInferior, int limiteSuperior)
        {
            Random random = new Random();
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(limiteInferior, limiteSuperior + 1);
                }
            }

            return matriz;
        }

        // M�todo para mostrar la matriz en un DataGridView.
        private void MostrarMatriz(int[,] matriz, DataGridView dgv)
        {
            dgv.ColumnCount = 5;
            dgv.RowCount = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }
    

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int limiteInferior, limiteSuperior;

            // Verifica que los l�mites sean v�lidos.
            if (int.TryParse(txtLimiteInferior.Text, out limiteInferior) && int.TryParse(txtLimiteSuperior.Text, out limiteSuperior))
            {
                // Asegura que el l�mite inferior sea menor o igual al superior.
                if (limiteInferior <= limiteSuperior)
                {
                    matriz = GenerarMatriz(limiteInferior, limiteSuperior);
                    MessageBox.Show("Matriz generada.");
                }
                else
                {
                    MessageBox.Show("El l�mite inferior debe ser menor o igual al l�mite superior.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores num�ricos v�lidos para los l�mites.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            {
                MostrarMatriz(matriz, dgvMatriz);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
