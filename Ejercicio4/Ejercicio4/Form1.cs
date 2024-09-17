using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
        public partial class Form1 : Form
        {
            // Arreglo para almacenar la cantidad de vendedores en cada rango
            private int[] rangoSalarios = new int[9]; // 9 rangos de salarios

            public Form1()
            {
                InitializeComponent();
            }

            // Evento del botón para agregar una venta y calcular el salario
            private void btnAgregarVenta_Click(object sender, EventArgs e)
            {
                try
                {
                    // Obtenemos las ventas brutas del vendedor
                    double ventasBrutas = double.Parse(txtVentasBrutas.Text);

                    // Calculamos el salario
                    double salario = 200 + (0.09 * ventasBrutas);

                    // Convertimos el salario a un entero (truncado)
                    int salarioEntero = (int)salario;

                    // Clasificamos el salario en uno de los 9 rangos
                    ClasificarSalario(salarioEntero);

                    MessageBox.Show($"Salario calculado: ${salarioEntero}");

                    // Limpiamos el campo de entrada
                    txtVentasBrutas.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            // Método para clasificar el salario en uno de los rangos y actualizar el contador
            private void ClasificarSalario(int salario)
            {
                if (salario >= 200 && salario <= 299)
                {
                    rangoSalarios[0]++;
                }
                else if (salario >= 300 && salario <= 399)
                {
                    rangoSalarios[1]++;
                }
                else if (salario >= 400 && salario <= 499)
                {
                    rangoSalarios[2]++;
                }
                else if (salario >= 500 && salario <= 599)
                {
                    rangoSalarios[3]++;
                }
                else if (salario >= 600 && salario <= 699)
                {
                    rangoSalarios[4]++;
                }
                else if (salario >= 700 && salario <= 799)
                {
                    rangoSalarios[5]++;
                }
                else if (salario >= 800 && salario <= 899)
                {
                    rangoSalarios[6]++;
                }
                else if (salario >= 900 && salario <= 999)
                {
                    rangoSalarios[7]++;
                }
                else if (salario >= 1000)
                {
                    rangoSalarios[8]++;
                }
            }

            // Evento del botón para mostrar el resumen de salarios en el ListBox
            private void btnMostrarResumen_Click(object sender, EventArgs e)
            {
                listBoxResumen.Items.Clear(); // Limpiamos el ListBox antes de mostrar los resultados

                // Mostramos los vendedores por rango de salario
                listBoxResumen.Items.Add("Rango de Salarios\tCantidad de Vendedores");
                listBoxResumen.Items.Add($"$200-$299\t\t{rangoSalarios[0]}");
                listBoxResumen.Items.Add($"$300-$399\t\t{rangoSalarios[1]}");
                listBoxResumen.Items.Add($"$400-$499\t\t{rangoSalarios[2]}");
                listBoxResumen.Items.Add($"$500-$599\t\t{rangoSalarios[3]}");
                listBoxResumen.Items.Add($"$600-$699\t\t{rangoSalarios[4]}");
                listBoxResumen.Items.Add($"$700-$799\t\t{rangoSalarios[5]}");
                listBoxResumen.Items.Add($"$800-$899\t\t{rangoSalarios[6]}");
                listBoxResumen.Items.Add($"$900-$999\t\t{rangoSalarios[7]}");
                listBoxResumen.Items.Add($"$1000 o superior\t{rangoSalarios[8]}");
            }
        }
    }