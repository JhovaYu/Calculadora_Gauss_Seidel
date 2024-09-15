using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Gauss_Seidel.Clases
{
    public class ModificarTablas
    {
        public static TableLayoutPanel CrearTablaResultados(TableLayoutPanel panel, List<double> resultados, int filas)
        {
            panel.Controls.Clear();
            panel.RowStyles.Clear();
            panel.ColumnStyles.Clear();

            panel.RowCount = filas;
            int columnas = 1;

            for (int i = 0; i < filas; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            }

            for (int i = 0; i < columnas; i++)
            {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));
            }

            int TextCounter = 1;

            for (int i = 0; i < filas; i++)
            {

                for (int j = 0; j < columnas; j++)
                {

                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox
                    {
                        Size = new Size(120, 20),
                        Text = "X" + TextCounter + "       =        " + resultados[i],
                        Dock = DockStyle.Fill
                    };
                    
                    panel.Controls.Add(textBox, j, i);

                    TextCounter++;
                }
            }
            return panel;
        }
    }
    
}
