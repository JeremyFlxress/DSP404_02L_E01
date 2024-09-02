namespace Complementario1
{
    public partial class Form1 : Form
    {
        // Declaraci�n de la lista 
        private List<int> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<int>(); 
        }

        // M�todo para crear la lista vac�a.
        private void CrearListaVacia()
        {
            lista = new List<int>();
            MostrarLista(lista, listBoxElementos); 
        }

        // M�todo para mostrar los elementos en un ListBox.
        private void MostrarLista(List<int> lista, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var item in lista)
            {
                listBox.Items.Add(item);
            }
        }

       
        private void InsertarElemento(List<int> lista, int valor)
        {
            lista.Add(valor);
            MostrarLista(lista, listBoxElementos); 
        }

        // M�todo para remover el primer elemento de la lista.
        private void RemoverElemento(List<int> lista)
        {
            if (lista.Count > 0)
            {
                lista.RemoveAt(0);
                MostrarLista(lista, listBoxElementos); 
            }
            else
            {
                MessageBox.Show("La lista est� vac�a.");
            }
        }

        // Evento del bot�n Salir.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento del bot�n Crear Lista Vac�a.
        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearListaVacia();
            MessageBox.Show("Lista creada.");
        }

        // Evento del bot�n Remover Elemento.
        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverElemento(lista);
            MessageBox.Show("Elemento removido.");
        }

        
        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtValor.Text, out valor)) 
            {
                InsertarElemento(lista, valor);
                MessageBox.Show("Elemento insertado.");
                txtValor.Clear(); 
            }
            else
            {
                MessageBox.Show("Ingrese un valor num�rico v�lido.");
            }
        }

        // Evento del bot�n Mostrar Lista.
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarLista(lista, listBoxElementos);
        }
    }
}