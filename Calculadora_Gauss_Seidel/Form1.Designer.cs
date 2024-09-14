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
            this.picBox_Close = new System.Windows.Forms.PictureBox();
            this.lb_NoVariables = new System.Windows.Forms.Label();
            this.tb_NoVariables = new System.Windows.Forms.TextBox();
            this.tablayout_Ecuaciones = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_aviso = new System.Windows.Forms.Label();
            this.picBox_Maximizar = new System.Windows.Forms.PictureBox();
            this.tablayout_MainForm = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel_Instruction = new System.Windows.Forms.TableLayoutPanel();
            this.tablayout_IconOptions = new System.Windows.Forms.TableLayoutPanel();
            this.picBox_Hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Maximizar)).BeginInit();
            this.tablayout_MainForm.SuspendLayout();
            this.tablePanel_Instruction.SuspendLayout();
            this.tablayout_IconOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hide)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Titulo.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(3, 0);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(651, 45);
            this.lb_Titulo.TabIndex = 0;
            this.lb_Titulo.Text = "Calculadora de Gauss-Seidel";
            this.lb_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_Close
            // 
            this.picBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Close.Image")));
            this.picBox_Close.Location = new System.Drawing.Point(177, 3);
            this.picBox_Close.Name = "picBox_Close";
            this.picBox_Close.Size = new System.Drawing.Size(34, 37);
            this.picBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Close.TabIndex = 1;
            this.picBox_Close.TabStop = false;
            this.picBox_Close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_NoVariables
            // 
            this.lb_NoVariables.AutoSize = true;
            this.lb_NoVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_NoVariables.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoVariables.Location = new System.Drawing.Point(3, 45);
            this.lb_NoVariables.Name = "lb_NoVariables";
            this.lb_NoVariables.Size = new System.Drawing.Size(651, 32);
            this.lb_NoVariables.TabIndex = 2;
            this.lb_NoVariables.Text = "Ingrese el numero de variables";
            this.lb_NoVariables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_NoVariables
            // 
            this.tb_NoVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NoVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NoVariables.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoVariables.Location = new System.Drawing.Point(3, 80);
            this.tb_NoVariables.Multiline = true;
            this.tb_NoVariables.Name = "tb_NoVariables";
            this.tb_NoVariables.Size = new System.Drawing.Size(651, 26);
            this.tb_NoVariables.TabIndex = 3;
            this.tb_NoVariables.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_NoVariables.TextChanged += new System.EventHandler(this.tb_NoVariables_TextChanged);
            // 
            // tablayout_Ecuaciones
            // 
            this.tablayout_Ecuaciones.AutoScroll = true;
            this.tablayout_Ecuaciones.AutoSize = true;
            this.tablayout_Ecuaciones.ColumnCount = 2;
            this.tablayout_Ecuaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablayout_Ecuaciones.Location = new System.Drawing.Point(224, 140);
            this.tablayout_Ecuaciones.Name = "tablayout_Ecuaciones";
            this.tablayout_Ecuaciones.RowCount = 2;
            this.tablayout_Ecuaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.Size = new System.Drawing.Size(657, 473);
            this.tablayout_Ecuaciones.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(224, 619);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 32);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "hola";
            // 
            // lb_aviso
            // 
            this.lb_aviso.AutoSize = true;
            this.lb_aviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_aviso.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_aviso.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_aviso.Location = new System.Drawing.Point(3, 109);
            this.lb_aviso.Name = "lb_aviso";
            this.lb_aviso.Size = new System.Drawing.Size(651, 22);
            this.lb_aviso.TabIndex = 6;
            this.lb_aviso.Text = "Debe de haber minimo 2 variables";
            this.lb_aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_aviso.Visible = false;
            // 
            // picBox_Maximizar
            // 
            this.picBox_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Maximizar.Image")));
            this.picBox_Maximizar.Location = new System.Drawing.Point(137, 3);
            this.picBox_Maximizar.Name = "picBox_Maximizar";
            this.picBox_Maximizar.Size = new System.Drawing.Size(33, 37);
            this.picBox_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Maximizar.TabIndex = 7;
            this.picBox_Maximizar.TabStop = false;
            this.picBox_Maximizar.Click += new System.EventHandler(this.picBox_Maximizar_Click);
            // 
            // tablayout_MainForm
            // 
            this.tablayout_MainForm.AutoScroll = true;
            this.tablayout_MainForm.AutoSize = true;
            this.tablayout_MainForm.ColumnCount = 3;
            this.tablayout_MainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablayout_MainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tablayout_MainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablayout_MainForm.Controls.Add(this.textBox1, 1, 2);
            this.tablayout_MainForm.Controls.Add(this.tablePanel_Instruction, 1, 0);
            this.tablayout_MainForm.Controls.Add(this.tablayout_Ecuaciones, 1, 1);
            this.tablayout_MainForm.Controls.Add(this.tablayout_IconOptions, 2, 0);
            this.tablayout_MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablayout_MainForm.Location = new System.Drawing.Point(0, 0);
            this.tablayout_MainForm.Name = "tablayout_MainForm";
            this.tablayout_MainForm.RowCount = 3;
            this.tablayout_MainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablayout_MainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablayout_MainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablayout_MainForm.Size = new System.Drawing.Size(1106, 685);
            this.tablayout_MainForm.TabIndex = 8;
            this.tablayout_MainForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tablayout_MainForm_Paint);
            // 
            // tablePanel_Instruction
            // 
            this.tablePanel_Instruction.ColumnCount = 1;
            this.tablePanel_Instruction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_Instruction.Controls.Add(this.lb_aviso, 0, 3);
            this.tablePanel_Instruction.Controls.Add(this.tb_NoVariables, 0, 2);
            this.tablePanel_Instruction.Controls.Add(this.lb_Titulo, 0, 0);
            this.tablePanel_Instruction.Controls.Add(this.lb_NoVariables, 0, 1);
            this.tablePanel_Instruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_Instruction.Location = new System.Drawing.Point(224, 3);
            this.tablePanel_Instruction.Name = "tablePanel_Instruction";
            this.tablePanel_Instruction.RowCount = 4;
            this.tablePanel_Instruction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tablePanel_Instruction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel_Instruction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel_Instruction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablePanel_Instruction.Size = new System.Drawing.Size(657, 131);
            this.tablePanel_Instruction.TabIndex = 6;
            // 
            // tablayout_IconOptions
            // 
            this.tablayout_IconOptions.ColumnCount = 4;
            this.tablayout_IconOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablayout_IconOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tablayout_IconOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tablayout_IconOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tablayout_IconOptions.Controls.Add(this.picBox_Close, 3, 0);
            this.tablayout_IconOptions.Controls.Add(this.picBox_Maximizar, 2, 0);
            this.tablayout_IconOptions.Controls.Add(this.picBox_Hide, 1, 0);
            this.tablayout_IconOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.tablayout_IconOptions.Location = new System.Drawing.Point(889, 3);
            this.tablayout_IconOptions.Name = "tablayout_IconOptions";
            this.tablayout_IconOptions.RowCount = 2;
            this.tablayout_IconOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_IconOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_IconOptions.Size = new System.Drawing.Size(214, 131);
            this.tablayout_IconOptions.TabIndex = 7;
            // 
            // picBox_Hide
            // 
            this.picBox_Hide.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Hide.Image")));
            this.picBox_Hide.Location = new System.Drawing.Point(101, 7);
            this.picBox_Hide.Margin = new System.Windows.Forms.Padding(7, 7, 7, 0);
            this.picBox_Hide.Name = "picBox_Hide";
            this.picBox_Hide.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.picBox_Hide.Size = new System.Drawing.Size(26, 33);
            this.picBox_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Hide.TabIndex = 8;
            this.picBox_Hide.TabStop = false;
            this.picBox_Hide.Click += new System.EventHandler(this.picBox_Hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 685);
            this.Controls.Add(this.tablayout_MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Maximizar)).EndInit();
            this.tablayout_MainForm.ResumeLayout(false);
            this.tablayout_MainForm.PerformLayout();
            this.tablePanel_Instruction.ResumeLayout(false);
            this.tablePanel_Instruction.PerformLayout();
            this.tablayout_IconOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.PictureBox picBox_Close;
        private System.Windows.Forms.Label lb_NoVariables;
        private System.Windows.Forms.TextBox tb_NoVariables;
        private System.Windows.Forms.TableLayoutPanel tablayout_Ecuaciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_aviso;
        private System.Windows.Forms.PictureBox picBox_Maximizar;
        private System.Windows.Forms.TableLayoutPanel tablayout_MainForm;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Instruction;
        private System.Windows.Forms.TableLayoutPanel tablayout_IconOptions;
        private System.Windows.Forms.PictureBox picBox_Hide;
    }
}

