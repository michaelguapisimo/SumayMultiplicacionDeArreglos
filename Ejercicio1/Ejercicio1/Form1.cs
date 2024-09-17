using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private int [] sumCounts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] sumas = new int[13]; // Arreglo para contar las frecuencias de las sumas (2 a 12)

            for (int i = 0; i < 36000; i++)
            {
                int dado1 = rand.Next(1, 7); // Genera un número entre 1 y 6
                int dado2 = rand.Next(1, 7); // Genera un número entre 1 y 6
                int suma = dado1 + dado2;
                sumas[suma]++;
            }

            Limpiar ListBox;
            lstResultados.Items.Clear();

            // Añadir resultados al ListBox
            for (int i = 2; i < sumas.Length; i++)
            {
                lstResultados.Items.Add($"Suma: {i}, Frecuencia: {sumas[i]}");
            }

            // Verificar si los totales son razonables
            double frecuenciaEsperada = 36000 / 6.0;
            MessageBox.Show($"Frecuencia esperada para la suma 7: {frecuenciaEsperada}\nFrecuencia real para la suma 7: {sumas[7]}");
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
