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

            this.Resize += MainForm_Resize;

            Clases.BorderPanel[] borderPanels = new Clases.BorderPanel[6];
            int n = borderPanels.Length;

            for (int i=0; i<n; i++)
            {
                borderPanels[i] = new Clases.BorderPanel();

                
            }

            

            tablePanel_00.Controls.Add(borderPanels[4], 2, 1);
            tablePanel_01.Controls.Add(borderPanels[5], 2, 1);

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
                if(filas == 1)
                {
                    lb_aviso.Visible = true;
                }else if (filas > 10)
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
                    lb_aviso.Visible = false;

                }
                else
                {
                    AjustarFilasColumnas(filas, columnas);
                    lb_aviso.Visible = false;
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
                tablayout_Ecuaciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            }

            for (int i = 0; i < columnas; i++) 
            {
                tablayout_Ecuaciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));
            }

            
            for (int i = 0; i < filas; i++)
            {
                int TextCounter = 1; 

                for (int j = 0; j < columnas; j++)
                {

                    TextBox texBox = new TextBox
                    {
                        //Multiline = true,
                        Size = new Size(120, 20),
                        Text = "X" + TextCounter,
                        Dock = DockStyle.Fill
                    };
                    texBox.Click += new EventHandler(TextBox_Click);
                    tablayout_Ecuaciones.Controls.Add(texBox, j, i);
                    if(TextCounter < columnas)
                    {
                        TextCounter++; 
                    }
                    else if (TextCounter == columnas)
                    {
                        texBox.Text = "";
                    }
                    
                }
            }
        }

        String valorInicial;

        private void MainForm_Resize(object sender, EventArgs e)
        {
            
            panel_main.Width = this.ClientSize.Width;
            panel_main.Height = this.ClientSize.Height;
            
        }

        private void RemoveRoundPanel(Panel panel)
        {
            panel.Region = null; 
        }

        bool maximizar = false;
        private void picBox_Maximizar_Click(object sender, EventArgs e)
        {
            if (maximizar == false)
            {
                this.WindowState = FormWindowState.Maximized;

                lb_Titulo.Font = new Font(lb_Titulo.Font.FontFamily, 28);
                lb_NoVariables.Font = new Font(lb_NoVariables.Font.FontFamily, 20);
                tb_NoVariables.Font = new Font(tb_NoVariables.Font.FontFamily, 16);
                lb_aviso.Font = new Font(lb_aviso.Font.FontFamily, 16);
                tablayout_MainForm.RowStyles[0].Height = 12;
                tablayout_MainForm.RowStyles[1].Height = 76;
                tablayout_MainForm.RowStyles[2].Height = 12;

                RedondearPanel.RoundPanel(panel_main, 60);

                maximizar = true;

            }
            else
            {
                this.WindowState= FormWindowState.Normal;

                lb_Titulo.Font = new Font(lb_Titulo.Font.FontFamily, 16);
                lb_NoVariables.Font = new Font(lb_NoVariables.Font.FontFamily, 14);
                tb_NoVariables.Font = new Font(tb_NoVariables.Font.FontFamily, 14);
                lb_aviso.Font = new Font(lb_aviso.Font.FontFamily, 9);
                tablayout_MainForm.RowStyles[0].Height = 20;
                tablayout_MainForm.RowStyles[1].Height = 60;
                tablayout_MainForm.RowStyles[2].Height = 20;

                RemoveRoundPanel(panel_main);

               maximizar = false;
            }
            

        }

        private void tablayout_MainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBox_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lb_NoVariables_Click(object sender, EventArgs e)
        {

        }

        private void lb_aviso_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox clickedTextBox = sender as TextBox; // Obtener el TextBox que fue clicado
            valorInicial = clickedTextBox.Text;
            clickedTextBox.Clear();
            clickedTextBox.LostFocus += new EventHandler(TextBox_FocusLeave);
            
        }

        private void TextBox_FocusLeave(object sender, EventArgs e)
        {
            TextBox focusTextBox = sender as TextBox;
            if (focusTextBox.Text == "")
            {
                focusTextBox.Text = valorInicial;
            }
        }
    }
}