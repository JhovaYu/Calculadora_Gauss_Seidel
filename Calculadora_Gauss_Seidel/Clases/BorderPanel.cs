using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Gauss_Seidel.Clases
{
    public class BorderPanel : Panel
    {
        public int BorderThickness { get; set; } = 5;  // Grosor del borde inferior
        public Color BorderColor { get; set; } = Color.Gray;  // Color del borde inferior

        public BorderPanel()
        {
            // Habilita el estilo de doble búfer para reducir parpadeo
            this.DoubleBuffered = true;
            this.Dock = DockStyle.Fill;
            this.Margin = new Padding(0,0,0,0);
        }

        // Sobrescribe el evento OnPaint para dibujar el borde inferior
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crea el lápiz con el color y grosor deseados
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                // Dibuja el borde inferior
                e.Graphics.DrawLine(pen, 0, BorderThickness / 2, this.Width, BorderThickness / 2);
            }
        }
    }
}
