using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        // Constantes para definir el tamaño de la matriz de ventas
        private const int NUMERO_DE_PRODUCTOS = 5;
        private const int NUMERO_DE_VENDEDORES = 4;

        // Matriz para almacenar las ventas (productos x vendedores)
        private decimal[,] ventas = new decimal[NUMERO_DE_PRODUCTOS, NUMERO_DE_VENDEDORES];

        public Form1()
        {
            InitializeComponent();
            InicializarMatrizVentas(); // Inicializamos en 0
        }

        // Inicializa la matriz de ventas en 0
        private void InicializarMatrizVentas()
        {
            for (int producto = 0; producto < NUMERO_DE_PRODUCTOS; producto++)
            {
                for (int vendedor = 0; vendedor < NUMERO_DE_VENDEDORES; vendedor++)
                {
                    ventas[producto, vendedor] = 0.0m;
                }
            }
        }

        private void btnAgregarEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                int vendedor = int.Parse(txtVendedor.Text) - 1; // Resta 1 porque el índice empieza en 0
                int producto = int.Parse(txtProducto.Text) - 1; // Resta 1 porque el índice empieza en 0
                decimal monto = decimal.Parse(txtMonto.Text);

                // Validamos que el número de vendedor y producto sean válidos
                if (vendedor < 0 || vendedor >= NUMERO_DE_VENDEDORES || producto < 0 || producto >= NUMERO_DE_PRODUCTOS)
                {
                    MessageBox.Show("Error: Vendedor o producto fuera de rango.");
                    return;
                }

                // Validamos que el monto sea un número positivo
                if (monto <= 0)
                {
                    MessageBox.Show("Error: El monto debe ser un número positivo.");
                    return;
                }

                // Agregamos el monto a la matriz de ventas
                ventas[producto, vendedor] += monto;
                MessageBox.Show("Venta agregada correctamente.");

                // Limpiamos los campos
                txtVendedor.Clear();
                txtProducto.Clear();
                txtMonto.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Evento del botón para mostrar el resumen de ventas
        private void btnMostrarResumen_Click(object sender, EventArgs e)
        {
            MostrarResumenVentas();
        }

        // Método para mostrar la tabla de ventas y los totales
        private void MostrarResumenVentas()
        {
            listBoxResumen.Items.Clear(); // Limpiamos el ListBox antes de mostrar los resultados

            // String donde guardamos el resumen de ventas
            listBoxResumen.Items.Add("Resumen de Ventas");
            listBoxResumen.Items.Add("Producto/Vendedor\tV1\tV2\tV3\tV4\tTotal Producto");

            decimal[] totalPorVendedor = new decimal[NUMERO_DE_VENDEDORES]; // Para almacenar el total de cada vendedor

            // Inicializamos los totales por vendedor en 0
            for (int i = 0; i < NUMERO_DE_VENDEDORES; i++)
            {
                totalPorVendedor[i] = 0.0m;
            }

            // Recorremos la matriz y mostramos los valores por producto y por vendedor
            for (int producto = 0; producto < NUMERO_DE_PRODUCTOS; producto++)
            {
                decimal totalPorProducto = 0.0m;
                string linea = $"Producto {producto + 1}\t\t";

                for (int vendedor = 0; vendedor < NUMERO_DE_VENDEDORES; vendedor++)
                {
                    linea += $"{ventas[producto, vendedor]:0.00}\t";
                    totalPorProducto += ventas[producto, vendedor];
                    totalPorVendedor[vendedor] += ventas[producto, vendedor];
                }

                linea += $"{totalPorProducto:0.00}";
                listBoxResumen.Items.Add(linea);
            }

            // Mostramos el total por vendedor
            string totalVendedores = "Total Vendedor\t\t";
            for (int vendedor = 0; vendedor < NUMERO_DE_VENDEDORES; vendedor++)
            {
                totalVendedores += $"{totalPorVendedor[vendedor]:0.00}\t";
            }

            listBoxResumen.Items.Add(totalVendedores);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBoxResumen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
