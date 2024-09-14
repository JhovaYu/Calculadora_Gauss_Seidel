using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Gauss_Seidel.Clases
{
    public class PanelConBordeInferior : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Definir el color y grosor del borde
            Color borderColor = Color.Gray;
            int borderWidth = 5;

            // Crear un objeto Pen para dibujar el borde
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                // Dibujar solo el borde inferior
                e.Graphics.DrawLine(pen, 0, this.Height - borderWidth / 2, this.Width, this.Height - borderWidth / 2);
            }
        }
    }
}
