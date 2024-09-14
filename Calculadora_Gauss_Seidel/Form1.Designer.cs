namespace Calculadora_Gauss_Seidel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_NoVariables = new System.Windows.Forms.Label();
            this.tb_NoVariables = new System.Windows.Forms.TextBox();
            this.tablayout_Ecuaciones = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(370, 22);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(382, 33);
            this.lb_Titulo.TabIndex = 0;
            this.lb_Titulo.Text = "Calculadora de Gauss-Seidel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1041, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_NoVariables
            // 
            this.lb_NoVariables.AutoSize = true;
            this.lb_NoVariables.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoVariables.Location = new System.Drawing.Point(399, 64);
            this.lb_NoVariables.Name = "lb_NoVariables";
            this.lb_NoVariables.Size = new System.Drawing.Size(310, 22);
            this.lb_NoVariables.TabIndex = 2;
            this.lb_NoVariables.Text = "Ingrese el numero de variables";
            // 
            // tb_NoVariables
            // 
            this.tb_NoVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NoVariables.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoVariables.Location = new System.Drawing.Point(439, 98);
            this.tb_NoVariables.Multiline = true;
            this.tb_NoVariables.Name = "tb_NoVariables";
            this.tb_NoVariables.Size = new System.Drawing.Size(238, 24);
            this.tb_NoVariables.TabIndex = 3;
            this.tb_NoVariables.TextChanged += new System.EventHandler(this.tb_NoVariables_TextChanged);
            // 
            // tablayout_Ecuaciones
            // 
            this.tablayout_Ecuaciones.AutoScroll = true;
            this.tablayout_Ecuaciones.AutoSize = true;
            this.tablayout_Ecuaciones.ColumnCount = 2;
            this.tablayout_Ecuaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.Location = new System.Drawing.Point(57, 198);
            this.tablayout_Ecuaciones.Name = "tablayout_Ecuaciones";
            this.tablayout_Ecuaciones.RowCount = 2;
            this.tablayout_Ecuaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.Size = new System.Drawing.Size(932, 162);
            this.tablayout_Ecuaciones.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(405, 470);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "hola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 685);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tablayout_Ecuaciones);
            this.Controls.Add(this.tb_NoVariables);
            this.Controls.Add(this.lb_NoVariables);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_NoVariables;
        private System.Windows.Forms.TextBox tb_NoVariables;
        private System.Windows.Forms.TableLayoutPanel tablayout_Ecuaciones;
        private System.Windows.Forms.TextBox textBox1;
    }
}

