using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Gauss_Seidel
{
    public partial class Form1 : Form
    {
        int NumVariables = 0, filas = 0, columnas = 0;
        public Form1()
        {
            InitializeComponent();
            lb_Titulo.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_NoVariables_TextChanged(object sender, EventArgs e)
        {
            if (tb_NoVariables.Text != "")
            {
                filas = int.Parse(tb_NoVariables.Text);
                columnas = filas + 1;
                if (filas > 10)
                {
                    DialogResult result = MessageBox.Show("Estas seguro que deseas colocar " + filas + " variables?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //MessageBox.Show(filas.ToString());
                    if (result == DialogResult.Yes)
                    {
                        AjustarFilasColumnas(filas, columnas);
                    }
                    else
                    {
                        filas = 0;
                    }
                }
                else
                {
                    AjustarFilasColumnas(filas, columnas);
                }


            }
        }

        private void AjustarFilasColumnas(int filas, int columnas)
        {
            tablayout_Ecuaciones.Controls.Clear();
            tablayout_Ecuaciones.RowStyles.Clear();
            tablayout_Ecuaciones.ColumnStyles.Clear();

            tablayout_Ecuaciones.RowCount = filas;
            tablayout_Ecuaciones.ColumnCount = columnas; 

            for (int i = 0; i < filas; i++)
            {
                tablayout_Ecuaciones.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / filas));
            }

            for (int i = 0; i < columnas * 2; i++) 
            {
                tablayout_Ecuaciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / (columnas * 2)));
            }

            
            for (int i = 0; i < filas; i++)
            {
                int TextCounter = 1; 

                for (int j = 0; j < columnas; j++)
                {
                    
                    TextBox texBox = new TextBox
                    {
                        Dock = DockStyle.Fill
                    };
                    tablayout_Ecuaciones.Controls.Add(texBox, j * 2, i);
                    TextCounter++; 
                }
            }
        }
    }
}