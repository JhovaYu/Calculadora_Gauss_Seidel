using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Gauss_Seidel.Algoritmo_Gauss_Seidel
{
    public class GaussSeidel
    {
        // Función para verificar y ajustar la diagonal de la matriz
        public static bool VerificarYCorregirMatriz(List<List<double>> matriz, int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Si encontramos un 0 en la diagonal
                if (matriz[i][i] == 0)
                {
                    bool intercambioRealizado = false;

                    // Intentar intercambiar con una fila más abajo
                    for (int j = i + 1; j < n; j++)
                    {
                        if (matriz[j][i] != 0)
                        {
                            // Intercambiar filas i y j
                            IntercambiarFilas(matriz, i, j);
                            intercambioRealizado = true;
                            break;
                        }
                    }

                    if (!intercambioRealizado && i == n - 1)
                    {
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (matriz[j][i] != 0)
                            {
                                // Intercambiar la última fila con la fila anterior
                                IntercambiarFilas(matriz, i, j);
                                intercambioRealizado = true;
                                break;
                            }
                        }
                    }

                    // Si no fue posible intercambiar, la matriz es inválida
                    if (!intercambioRealizado)
                    {
                        MessageBox.Show("Matriz inválida: no es posible evitar un 0 en la diagonal.", "Error");
                        return false;
                    }
                }
            }
            // Si la función completa, significa que la matriz es válida para el método Gauss-Seidel
            return true;
        }

        // Función para intercambiar dos filas de la matriz
        private static void IntercambiarFilas(List<List<double>> matriz, int fila1, int fila2)
        {
            List<double> temp = matriz[fila1];
            matriz[fila1] = matriz[fila2];
            matriz[fila2] = temp;
        }

        public static bool VerificarDiagonalMayorQueSuma(List<List<double>> matriz, int n)
        {
            for (int i = 0; i < n; i++)
            {
                double sumaOtrosElementos = 0;

                // Sumar los coeficientes de las variables en la fila actual (excluyendo el término constante y el elemento de la diagonal)
                for (int j = 0; j < n; j++)
                {
                    if (i != j) // Excluir el elemento de la diagonal
                    {
                        sumaOtrosElementos += Math.Abs(matriz[i][j]); // Usamos valor absoluto para comparar correctamente
                    }
                }

                // El valor en la diagonal se toma de la misma fila pero en la columna de coeficientes
                if (Math.Abs(matriz[i][i]) <= sumaOtrosElementos)
                {
                    MessageBox.Show($"La fila {i + 1} no cumple con la condición de diagonal dominante.", "Matriz inválida");
                    return false;
                }
            }

            // Si se pasa por todas las filas sin problemas, la matriz es válida
            return true;
        }

        public static List<double> ResolverGS(List<List<double>> matriz, List<double> inicial, double tolerancia)
        {
            int n = matriz.Count;
            List<double> xViejo = new List<double>(inicial);
            List<double> xActual = new List<double>(new double[n]);
            double maxDif;

            do
            {
                maxDif = 0.0;

                for (int i = 0; i < n; i++)
                {
                    double sum = 0.0;

                    // Sumar los términos excepto el de la diagonal principal
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                        {
                            sum += matriz[i][j] * xActual[j]; // Usar los valores más recientes
                        }
                    }

                    // Actualizar el valor de la variable x[i]
                    xActual[i] = (matriz[i][n] - sum) / matriz[i][i];

                    // Calcular la diferencia para verificar la convergencia
                    double diff = Math.Abs(xActual[i] - xViejo[i]);
                    if (diff > maxDif)
                    {
                        maxDif = diff;
                    }

                    xViejo[i] = xActual[i]; // Actualizar el valor viejo
                }

            } while (maxDif > tolerancia);

            return xActual;
        }

        public static List<double> ObtenerConstantes(List<List<double>> matriz, int n)
        {
            List<double> Constantes = new List<double>();
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(j == n - 1)
                    {
                        Constantes.Add(matriz[i][j]);
                    }
                }
            }
            return Constantes;
        }
    }
}
