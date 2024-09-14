using Calculadora_Gauss_Seidel.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            PanelConBordeInferior borderPanel = new PanelConBordeInferior();
            panel_header.Controls.Add(borderPanel);


        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    System.Windows.Forms.TextBox texBox = new System.Windows.Forms.TextBox
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
                tablayout_MainForm.RowStyles[0].Height = 10;
                tablayout_MainForm.RowStyles[1].Height = 90;

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
                tablayout_MainForm.RowStyles[0].Height = 14;
                tablayout_MainForm.RowStyles[1].Height = 86;

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

        private void tb_NoVariables_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_NoVariables.Text != "")
            {
                filas = int.Parse(tb_NoVariables.Text);
                columnas = filas + 1;
                if (filas == 1)
                {
                    lb_aviso.Visible = true;
                }
                else if (filas > 10)
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

        private void tb_NoVariables_Enter(object sender, EventArgs e)
        {
            tb_NoVariables.Clear();
            tb_NoVariables.ForeColor = Color.Black;
            tb_NoVariables.Font = new Font(tb_NoVariables.Font.FontFamily, 20);
                
        }

        private void tb_NoVariables_Leave(object sender, EventArgs e)
        {
            if(tb_NoVariables.Text == "")
            {
                tb_NoVariables.Text = "Ingresar numero de variables";
                tb_NoVariables.ForeColor = SystemColors.InactiveCaption;
                tb_NoVariables.Font = new Font(tb_NoVariables.Font.FontFamily, 9);
            }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox clickedTextBox = sender as System.Windows.Forms.TextBox; // Obtener el TextBox que fue clicado
            valorInicial = clickedTextBox.Text;
            clickedTextBox.Clear();
            clickedTextBox.LostFocus += new EventHandler(TextBox_FocusLeave);
            
        }

        private void TextBox_FocusLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox focusTextBox = sender as System.Windows.Forms.TextBox;
            if (focusTextBox.Text == "")
            {
                focusTextBox.Text = valorInicial;
            }
        }
    }
}