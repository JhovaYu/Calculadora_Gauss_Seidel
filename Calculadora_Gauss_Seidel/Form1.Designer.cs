﻿namespace Calculadora_Gauss_Seidel
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
            this.tablayout_MainForm = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel_Ecuations = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel_InsertEcuations = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel_InsertValues = new System.Windows.Forms.TableLayoutPanel();
            this.lb_SubTitle = new System.Windows.Forms.Label();
            this.lb_NoVariables = new System.Windows.Forms.Label();
            this.lb_aviso = new System.Windows.Forms.Label();
            this.tablayout_Ecuaciones = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel_OutPutEcuations = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel_Resultados = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_NumInicial = new System.Windows.Forms.Label();
            this.lb_NumTolerancia = new System.Windows.Forms.Label();
            this.tb_NumIniciales = new System.Windows.Forms.TextBox();
            this.tb_Tolerancia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel_Resultado = new System.Windows.Forms.TableLayoutPanel();
            this.panelStyler1 = new Calculadora_Gauss_Seidel.Clases.PanelStyler();
            this.tb_NoVariables = new System.Windows.Forms.TextBox();
            this.panelConBordeInferior1 = new Calculadora_Gauss_Seidel.Clases.PanelConBordeInferior();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel_Iconos = new System.Windows.Forms.TableLayoutPanel();
            this.picBox_Close = new System.Windows.Forms.PictureBox();
            this.picBox_Maximizar = new System.Windows.Forms.PictureBox();
            this.picBox_Hide = new System.Windows.Forms.PictureBox();
            this.tablePanel_Title = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.tablayout_MainForm.SuspendLayout();
            this.tablePanel_Ecuations.SuspendLayout();
            this.tablePanel_InsertEcuations.SuspendLayout();
            this.tablePanel_InsertValues.SuspendLayout();
            this.tablePanel_OutPutEcuations.SuspendLayout();
            this.tablePanel_Resultados.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelStyler1.SuspendLayout();
            this.panelConBordeInferior1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tablePanel_Iconos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hide)).BeginInit();
            this.tablePanel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tablayout_MainForm
            // 
            this.tablayout_MainForm.AutoScroll = true;
            this.tablayout_MainForm.BackColor = System.Drawing.Color.White;
            this.tablayout_MainForm.ColumnCount = 1;
            this.tablayout_MainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablayout_MainForm.Controls.Add(this.tablePanel_Ecuations, 0, 1);
            this.tablayout_MainForm.Controls.Add(this.panel_header, 0, 0);
            this.tablayout_MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablayout_MainForm.Location = new System.Drawing.Point(0, 0);
            this.tablayout_MainForm.Name = "tablayout_MainForm";
            this.tablayout_MainForm.RowCount = 2;
            this.tablayout_MainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.1315F));
            this.tablayout_MainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.8685F));
            this.tablayout_MainForm.Size = new System.Drawing.Size(1106, 685);
            this.tablayout_MainForm.TabIndex = 8;
            this.tablayout_MainForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tablayout_MainForm_Paint);
            // 
            // tablePanel_Ecuations
            // 
            this.tablePanel_Ecuations.ColumnCount = 2;
            this.tablePanel_Ecuations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_Ecuations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_Ecuations.Controls.Add(this.tablePanel_InsertEcuations, 0, 0);
            this.tablePanel_Ecuations.Controls.Add(this.tablePanel_OutPutEcuations, 1, 0);
            this.tablePanel_Ecuations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_Ecuations.Location = new System.Drawing.Point(3, 99);
            this.tablePanel_Ecuations.Name = "tablePanel_Ecuations";
            this.tablePanel_Ecuations.RowCount = 1;
            this.tablePanel_Ecuations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_Ecuations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 583F));
            this.tablePanel_Ecuations.Size = new System.Drawing.Size(1100, 583);
            this.tablePanel_Ecuations.TabIndex = 8;
            // 
            // tablePanel_InsertEcuations
            // 
            this.tablePanel_InsertEcuations.BackColor = System.Drawing.Color.White;
            this.tablePanel_InsertEcuations.ColumnCount = 1;
            this.tablePanel_InsertEcuations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_InsertEcuations.Controls.Add(this.tablePanel_InsertValues, 0, 0);
            this.tablePanel_InsertEcuations.Controls.Add(this.tablayout_Ecuaciones, 0, 1);
            this.tablePanel_InsertEcuations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_InsertEcuations.Location = new System.Drawing.Point(3, 3);
            this.tablePanel_InsertEcuations.Name = "tablePanel_InsertEcuations";
            this.tablePanel_InsertEcuations.RowCount = 2;
            this.tablePanel_InsertEcuations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tablePanel_InsertEcuations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tablePanel_InsertEcuations.Size = new System.Drawing.Size(544, 577);
            this.tablePanel_InsertEcuations.TabIndex = 0;
            // 
            // tablePanel_InsertValues
            // 
            this.tablePanel_InsertValues.BackColor = System.Drawing.Color.RoyalBlue;
            this.tablePanel_InsertValues.ColumnCount = 3;
            this.tablePanel_InsertValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablePanel_InsertValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablePanel_InsertValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel_InsertValues.Controls.Add(this.lb_SubTitle, 1, 0);
            this.tablePanel_InsertValues.Controls.Add(this.lb_NoVariables, 1, 1);
            this.tablePanel_InsertValues.Controls.Add(this.lb_aviso, 1, 3);
            this.tablePanel_InsertValues.Controls.Add(this.panelStyler1, 1, 2);
            this.tablePanel_InsertValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_InsertValues.Location = new System.Drawing.Point(3, 3);
            this.tablePanel_InsertValues.Name = "tablePanel_InsertValues";
            this.tablePanel_InsertValues.RowCount = 4;
            this.tablePanel_InsertValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tablePanel_InsertValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel_InsertValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel_InsertValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablePanel_InsertValues.Size = new System.Drawing.Size(538, 190);
            this.tablePanel_InsertValues.TabIndex = 0;
            // 
            // lb_SubTitle
            // 
            this.lb_SubTitle.AutoSize = true;
            this.lb_SubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SubTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SubTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_SubTitle.Location = new System.Drawing.Point(56, 0);
            this.lb_SubTitle.Name = "lb_SubTitle";
            this.lb_SubTitle.Size = new System.Drawing.Size(370, 76);
            this.lb_SubTitle.TabIndex = 0;
            this.lb_SubTitle.Text = "Calculadora de Gauss-Seidel";
            this.lb_SubTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lb_NoVariables
            // 
            this.lb_NoVariables.AutoSize = true;
            this.lb_NoVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_NoVariables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoVariables.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_NoVariables.Location = new System.Drawing.Point(56, 76);
            this.lb_NoVariables.Name = "lb_NoVariables";
            this.lb_NoVariables.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lb_NoVariables.Size = new System.Drawing.Size(370, 38);
            this.lb_NoVariables.TabIndex = 1;
            this.lb_NoVariables.Text = "Ingrese el número de variables";
            // 
            // lb_aviso
            // 
            this.lb_aviso.AutoSize = true;
            this.lb_aviso.BackColor = System.Drawing.Color.White;
            this.lb_aviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_aviso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_aviso.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_aviso.Location = new System.Drawing.Point(56, 161);
            this.lb_aviso.Name = "lb_aviso";
            this.lb_aviso.Size = new System.Drawing.Size(370, 29);
            this.lb_aviso.TabIndex = 3;
            this.lb_aviso.Text = "Ingrese dos variables o mas";
            this.lb_aviso.Visible = false;
            // 
            // tablayout_Ecuaciones
            // 
            this.tablayout_Ecuaciones.ColumnCount = 1;
            this.tablayout_Ecuaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablayout_Ecuaciones.Location = new System.Drawing.Point(3, 199);
            this.tablayout_Ecuaciones.Name = "tablayout_Ecuaciones";
            this.tablayout_Ecuaciones.RowCount = 1;
            this.tablayout_Ecuaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout_Ecuaciones.Size = new System.Drawing.Size(538, 375);
            this.tablayout_Ecuaciones.TabIndex = 1;
            // 
            // tablePanel_OutPutEcuations
            // 
            this.tablePanel_OutPutEcuations.ColumnCount = 1;
            this.tablePanel_OutPutEcuations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_OutPutEcuations.Controls.Add(this.tablePanel_Resultados, 0, 1);
            this.tablePanel_OutPutEcuations.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tablePanel_OutPutEcuations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_OutPutEcuations.Location = new System.Drawing.Point(553, 3);
            this.tablePanel_OutPutEcuations.Name = "tablePanel_OutPutEcuations";
            this.tablePanel_OutPutEcuations.RowCount = 2;
            this.tablePanel_OutPutEcuations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tablePanel_OutPutEcuations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tablePanel_OutPutEcuations.Size = new System.Drawing.Size(544, 577);
            this.tablePanel_OutPutEcuations.TabIndex = 1;
            // 
            // tablePanel_Resultados
            // 
            this.tablePanel_Resultados.ColumnCount = 1;
            this.tablePanel_Resultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_Resultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel_Resultados.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tablePanel_Resultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_Resultados.Location = new System.Drawing.Point(3, 199);
            this.tablePanel_Resultados.Name = "tablePanel_Resultados";
            this.tablePanel_Resultados.RowCount = 1;
            this.tablePanel_Resultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_Resultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tablePanel_Resultados.Size = new System.Drawing.Size(538, 375);
            this.tablePanel_Resultados.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Controls.Add(this.lb_NumInicial, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_NumTolerancia, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_NumIniciales, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Tolerancia, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(538, 190);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lb_NumInicial
            // 
            this.lb_NumInicial.AutoSize = true;
            this.lb_NumInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumInicial.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_NumInicial.Location = new System.Drawing.Point(3, 38);
            this.lb_NumInicial.Name = "lb_NumInicial";
            this.lb_NumInicial.Size = new System.Drawing.Size(210, 21);
            this.lb_NumInicial.TabIndex = 0;
            this.lb_NumInicial.Text = "Ingrese los números iniciales";
            // 
            // lb_NumTolerancia
            // 
            this.lb_NumTolerancia.AutoSize = true;
            this.lb_NumTolerancia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumTolerancia.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_NumTolerancia.Location = new System.Drawing.Point(298, 38);
            this.lb_NumTolerancia.Name = "lb_NumTolerancia";
            this.lb_NumTolerancia.Size = new System.Drawing.Size(209, 21);
            this.lb_NumTolerancia.TabIndex = 1;
            this.lb_NumTolerancia.Text = "Ingrese el valor de tolerancia";
            // 
            // tb_NumIniciales
            // 
            this.tb_NumIniciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_NumIniciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NumIniciales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NumIniciales.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_NumIniciales.Location = new System.Drawing.Point(3, 79);
            this.tb_NumIniciales.Multiline = true;
            this.tb_NumIniciales.Name = "tb_NumIniciales";
            this.tb_NumIniciales.Size = new System.Drawing.Size(236, 32);
            this.tb_NumIniciales.TabIndex = 2;
            this.tb_NumIniciales.TabStop = false;
            this.tb_NumIniciales.Text = "1,1,1,1";
            this.tb_NumIniciales.Enter += new System.EventHandler(this.tb_NumIniciales_Enter);
            this.tb_NumIniciales.Leave += new System.EventHandler(this.tb_NumIniciales_Leave);
            // 
            // tb_Tolerancia
            // 
            this.tb_Tolerancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Tolerancia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Tolerancia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Tolerancia.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_Tolerancia.Location = new System.Drawing.Point(298, 79);
            this.tb_Tolerancia.Multiline = true;
            this.tb_Tolerancia.Name = "tb_Tolerancia";
            this.tb_Tolerancia.Size = new System.Drawing.Size(237, 32);
            this.tb_Tolerancia.TabIndex = 3;
            this.tb_Tolerancia.TabStop = false;
            this.tb_Tolerancia.Text = "0.001";
            this.tb_Tolerancia.Enter += new System.EventHandler(this.tb_Tolerancia_Enter);
            this.tb_Tolerancia.Leave += new System.EventHandler(this.tb_Tolerancia_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(136, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_header
            // 
            this.panel_header.AutoSize = true;
            this.panel_header.Controls.Add(this.panelConBordeInferior1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_header.Location = new System.Drawing.Point(15, 3);
            this.panel_header.Margin = new System.Windows.Forms.Padding(15, 3, 13, 3);
            this.panel_header.Name = "panel_header";
            this.panel_header.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel_header.Size = new System.Drawing.Size(1078, 90);
            this.panel_header.TabIndex = 9;
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Controls.Add(this.tablayout_MainForm);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1106, 685);
            this.panel_main.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tablePanel_Resultado, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(532, 369);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tablePanel_Resultado
            // 
            this.tablePanel_Resultado.ColumnCount = 1;
            this.tablePanel_Resultado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_Resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_Resultado.Location = new System.Drawing.Point(136, 3);
            this.tablePanel_Resultado.Name = "tablePanel_Resultado";
            this.tablePanel_Resultado.RowCount = 1;
            this.tablePanel_Resultado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_Resultado.Size = new System.Drawing.Size(260, 363);
            this.tablePanel_Resultado.TabIndex = 0;
            // 
            // panelStyler1
            // 
            this.panelStyler1.BorderColor = System.Drawing.Color.Black;
            this.panelStyler1.BorderWidth = 3;
            this.panelStyler1.Controls.Add(this.tb_NoVariables);
            this.panelStyler1.CornerRadius = 10;
            this.panelStyler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStyler1.Location = new System.Drawing.Point(63, 114);
            this.panelStyler1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelStyler1.Name = "panelStyler1";
            this.panelStyler1.Size = new System.Drawing.Size(366, 47);
            this.panelStyler1.TabIndex = 5;
            // 
            // tb_NoVariables
            // 
            this.tb_NoVariables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_NoVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NoVariables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoVariables.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_NoVariables.Location = new System.Drawing.Point(0, 0);
            this.tb_NoVariables.Margin = new System.Windows.Forms.Padding(16, 6, 6, 6);
            this.tb_NoVariables.Multiline = true;
            this.tb_NoVariables.Name = "tb_NoVariables";
            this.tb_NoVariables.Size = new System.Drawing.Size(366, 47);
            this.tb_NoVariables.TabIndex = 2;
            this.tb_NoVariables.TabStop = false;
            this.tb_NoVariables.Text = "Ingresar número de variables";
            this.tb_NoVariables.TextChanged += new System.EventHandler(this.tb_NoVariables_TextChanged_1);
            this.tb_NoVariables.Enter += new System.EventHandler(this.tb_NoVariables_Enter);
            this.tb_NoVariables.Leave += new System.EventHandler(this.tb_NoVariables_Leave);
            // 
            // panelConBordeInferior1
            // 
            this.panelConBordeInferior1.Controls.Add(this.tableLayoutPanel1);
            this.panelConBordeInferior1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConBordeInferior1.Location = new System.Drawing.Point(0, 0);
            this.panelConBordeInferior1.Name = "panelConBordeInferior1";
            this.panelConBordeInferior1.Size = new System.Drawing.Size(1078, 80);
            this.panelConBordeInferior1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tablePanel_Iconos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tablePanel_Title, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tablePanel_Iconos
            // 
            this.tablePanel_Iconos.AutoSize = true;
            this.tablePanel_Iconos.ColumnCount = 4;
            this.tablePanel_Iconos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_Iconos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tablePanel_Iconos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tablePanel_Iconos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tablePanel_Iconos.Controls.Add(this.picBox_Close, 3, 0);
            this.tablePanel_Iconos.Controls.Add(this.picBox_Maximizar, 2, 0);
            this.tablePanel_Iconos.Controls.Add(this.picBox_Hide, 1, 0);
            this.tablePanel_Iconos.Dock = System.Windows.Forms.DockStyle.Right;
            this.tablePanel_Iconos.Location = new System.Drawing.Point(948, 3);
            this.tablePanel_Iconos.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.tablePanel_Iconos.Name = "tablePanel_Iconos";
            this.tablePanel_Iconos.RowCount = 2;
            this.tablePanel_Iconos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_Iconos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_Iconos.Size = new System.Drawing.Size(120, 71);
            this.tablePanel_Iconos.TabIndex = 7;
            // 
            // picBox_Close
            // 
            this.picBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Close.Image")));
            this.picBox_Close.Location = new System.Drawing.Point(83, 3);
            this.picBox_Close.Name = "picBox_Close";
            this.picBox_Close.Size = new System.Drawing.Size(34, 29);
            this.picBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Close.TabIndex = 1;
            this.picBox_Close.TabStop = false;
            this.picBox_Close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBox_Maximizar
            // 
            this.picBox_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Maximizar.Image")));
            this.picBox_Maximizar.Location = new System.Drawing.Point(43, 3);
            this.picBox_Maximizar.Name = "picBox_Maximizar";
            this.picBox_Maximizar.Size = new System.Drawing.Size(33, 29);
            this.picBox_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Maximizar.TabIndex = 7;
            this.picBox_Maximizar.TabStop = false;
            this.picBox_Maximizar.Click += new System.EventHandler(this.picBox_Maximizar_Click);
            // 
            // picBox_Hide
            // 
            this.picBox_Hide.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Hide.Image")));
            this.picBox_Hide.Location = new System.Drawing.Point(7, 7);
            this.picBox_Hide.Margin = new System.Windows.Forms.Padding(7, 7, 7, 0);
            this.picBox_Hide.Name = "picBox_Hide";
            this.picBox_Hide.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.picBox_Hide.Size = new System.Drawing.Size(26, 25);
            this.picBox_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Hide.TabIndex = 8;
            this.picBox_Hide.TabStop = false;
            this.picBox_Hide.Click += new System.EventHandler(this.picBox_Hide_Click);
            // 
            // tablePanel_Title
            // 
            this.tablePanel_Title.ColumnCount = 2;
            this.tablePanel_Title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tablePanel_Title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablePanel_Title.Controls.Add(this.lb_Titulo, 1, 0);
            this.tablePanel_Title.Controls.Add(this.picBox_logo, 0, 0);
            this.tablePanel_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_Title.Location = new System.Drawing.Point(3, 3);
            this.tablePanel_Title.Name = "tablePanel_Title";
            this.tablePanel_Title.RowCount = 1;
            this.tablePanel_Title.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_Title.Size = new System.Drawing.Size(533, 71);
            this.tablePanel_Title.TabIndex = 8;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_Titulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(162, 0);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(255, 71);
            this.lb_Titulo.TabIndex = 1;
            this.lb_Titulo.Text = "SmartCalculator";
            this.lb_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBox_logo
            // 
            this.picBox_logo.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_logo.Image")));
            this.picBox_logo.Location = new System.Drawing.Point(56, 3);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(100, 65);
            this.picBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_logo.TabIndex = 0;
            this.picBox_logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1106, 685);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tablayout_MainForm.ResumeLayout(false);
            this.tablayout_MainForm.PerformLayout();
            this.tablePanel_Ecuations.ResumeLayout(false);
            this.tablePanel_InsertEcuations.ResumeLayout(false);
            this.tablePanel_InsertValues.ResumeLayout(false);
            this.tablePanel_InsertValues.PerformLayout();
            this.tablePanel_OutPutEcuations.ResumeLayout(false);
            this.tablePanel_Resultados.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelStyler1.ResumeLayout(false);
            this.panelStyler1.PerformLayout();
            this.panelConBordeInferior1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tablePanel_Iconos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hide)).EndInit();
            this.tablePanel_Title.ResumeLayout(false);
            this.tablePanel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBox_Close;
        private System.Windows.Forms.PictureBox picBox_Maximizar;
        private System.Windows.Forms.TableLayoutPanel tablayout_MainForm;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Iconos;
        private System.Windows.Forms.PictureBox picBox_Hide;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Ecuations;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Title;
        private System.Windows.Forms.PictureBox picBox_logo;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.TableLayoutPanel tablePanel_InsertEcuations;
        private System.Windows.Forms.TableLayoutPanel tablePanel_OutPutEcuations;
        private System.Windows.Forms.TableLayoutPanel tablePanel_InsertValues;
        private System.Windows.Forms.Label lb_SubTitle;
        private System.Windows.Forms.Label lb_NoVariables;
        private System.Windows.Forms.TextBox tb_NoVariables;
        private System.Windows.Forms.Label lb_aviso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tablayout_Ecuaciones;
        private Clases.PanelConBordeInferior panelConBordeInferior1;
        private Clases.PanelStyler panelStyler1;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Resultados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_NumInicial;
        private System.Windows.Forms.Label lb_NumTolerancia;
        private System.Windows.Forms.TextBox tb_NumIniciales;
        private System.Windows.Forms.TextBox tb_Tolerancia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Resultado;
    }
}

