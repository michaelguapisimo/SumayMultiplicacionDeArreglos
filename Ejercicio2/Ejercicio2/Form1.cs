using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private bool[] asientos; // Declarar como arreglo de booleanos

        public Form1()
        {
            InitializeComponent();
            InicializarAsientos();
        }

        // Inicializa el arreglo de asientos a desocupados (false)
        private void InicializarAsientos()
        {
            asientos = new bool[10]; // Inicializar el arreglo con 10 elementos
            for (int i = 0; i < asientos.Length; i++)
            {
                asientos[i] = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbFumar.Checked)
            {
                AsignarAsiento(1, 5); // Asignar asiento en la sección de fumar (1-5)
            }
            else if (rbNoFumar.Checked)
            {
                AsignarAsiento(6, 10); // Asignar asiento en la sección de no fumar (6-10)
            }
            else
            {
                MessageBox.Show("Por favor seleccione una sección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para asignar un asiento en una sección específica
        private void AsignarAsiento(int inicio, int fin)
        {
            bool asignado = false;

            // Busca un asiento libre en la sección especificada
            for (int i = inicio - 1; i < fin; i++)
            {
                if (!asientos[i]) // Si el asiento no está ocupado
                {
                    asientos[i] = true;
                    ImprimirPaseDeAbordaje(i + 1);
                    asignado = true;
                    break;
                }
            }

            // Si no se asignó ningún asiento
            if (!asignado)
            {
                // Preguntar si desea cambiar de sección
                DialogResult resultado = MessageBox.Show("La sección está llena. ¿Desea cambiar de sección?",
                    "Sección llena", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Cambiar de sección: fumar a no fumar o viceversa
                    if (inicio == 1)
                    {
                        AsignarAsiento(6, 10); // Asignar en no fumar
                    }
                    else
                    {
                        AsignarAsiento(1, 5); // Asignar en fumar
                    }
                }
                else
                {
                    MessageBox.Show("Next flight leaves in 3 hours", "Vuelo lleno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Método para imprimir el pase de abordaje
        private void ImprimirPaseDeAbordaje(int numeroAsiento)
        {
            string seccion = (numeroAsiento <= 5) ? "Sección de Fumar" : "Sección de No Fumar";
            MessageBox.Show($"Asiento asignado: {numeroAsiento}\n{seccion}", "Pase de Abordaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
