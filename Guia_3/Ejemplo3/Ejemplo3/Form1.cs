using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Drawing;

namespace Ejemplo3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> palabras = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //agregamos datos al diccionario
            palabras.Add("Manzana", "Fruta pom�cea comestible, fruto del manzano dom�stico (Malus domestica), otros manzanos (especies del g�nero Malus).");
            palabras.Add("Pera", "Fruta comestible que procede del Pyrus communis, un �rbol que se conoce coloquialmente como peral com�n. Existen, de todas maneras, muchas clases de peras, que son producidas por otros �rboles del g�nero Pyrus.");
            palabras.Add("Melocot�n", "Fruto del melocotonero. Es una drupa de olor agradable, esf�rica, de seis a ocho cent�metros de di�metro, con un surco profundo que ocupa media circunferencia, epicarpio delgado, velloso, de color amarillo con manchas encarnadas, mesocarpio amarillento, de sabor agradable y adherido a un hueso pardo, duro y rugoso, que encierra una almendra muy amarga.");

            //recorre el diccionario para llenar la lista con la llave
            foreach (var item in palabras.Keys)
            {
                lstPalabras.Items.Add(item);
            }

        }

        private void lstPalabras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstPalabras.Text;
            //buscamos dato de la lista dentro del diccionario
            for (int i = 0; i < palabras.Count; i++)
            {
                var item = palabras.ElementAt(i);
                if (buscar == item.Key)
                {
                    lblpalabra.Text = item.Key;
                    txtsignificado.Text = item.Value;
                    break;
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
