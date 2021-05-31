namespace SimulacionTP5.Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnSimular = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtHastaConsumo = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDesdeConsumo = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHastaUsoMesa = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDesdeUsoMesa = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMediaEntrega = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDuracionCompra = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesviacionLlegada = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtMediaLlegada = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadMostrar = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtMostrarDesde = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtIteraciones = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlMg1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.inicioControl = new SimulacionTP5.Presentacion.Pantallas.InicioControl();
            this.resultadoControl = new SimulacionTP5.Presentacion.Pantallas.ResultadoControl();
            this.errorControl = new SimulacionTP5.Presentacion.Pantallas.ErrorControl();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlLateral.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnSimular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSimular.FlatAppearance.BorderSize = 0;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSimular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimular.Location = new System.Drawing.Point(0, 643);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(279, 50);
            this.btnSimular.TabIndex = 29;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.ClickBtnSimular);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.pnlTopBar.Controls.Add(this.pbMenu);
            this.pnlTopBar.Controls.Add(this.label1);
            this.pnlTopBar.Controls.Add(this.pbLogo);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(944, 60);
            this.pnlTopBar.TabIndex = 30;
            // 
            // pbMenu
            // 
            this.pbMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbMenu.Image = global::SimulacionTP5.Properties.Resources.MenuCeleste;
            this.pbMenu.Location = new System.Drawing.Point(892, 12);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(35, 35);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 2;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.ClickBtnMenu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "TP5 - Grupo 14";
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::SimulacionTP5.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(60, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.pnlLateral.Controls.Add(this.pnlDatos);
            this.pnlLateral.Controls.Add(this.panel1);
            this.pnlLateral.Controls.Add(this.btnExportar);
            this.pnlLateral.Controls.Add(this.pnlMg1);
            this.pnlLateral.Controls.Add(this.btnSimular);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLateral.Location = new System.Drawing.Point(665, 60);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(279, 693);
            this.pnlLateral.TabIndex = 31;
            // 
            // pnlDatos
            // 
            this.pnlDatos.AutoScroll = true;
            this.pnlDatos.Controls.Add(this.txtHastaConsumo);
            this.pnlDatos.Controls.Add(this.txtDesdeConsumo);
            this.pnlDatos.Controls.Add(this.label11);
            this.pnlDatos.Controls.Add(this.txtHastaUsoMesa);
            this.pnlDatos.Controls.Add(this.txtDesdeUsoMesa);
            this.pnlDatos.Controls.Add(this.label10);
            this.pnlDatos.Controls.Add(this.txtMediaEntrega);
            this.pnlDatos.Controls.Add(this.label9);
            this.pnlDatos.Controls.Add(this.txtDuracionCompra);
            this.pnlDatos.Controls.Add(this.label8);
            this.pnlDatos.Controls.Add(this.txtDesviacionLlegada);
            this.pnlDatos.Controls.Add(this.txtMediaLlegada);
            this.pnlDatos.Controls.Add(this.label7);
            this.pnlDatos.Controls.Add(this.txtCantidadMostrar);
            this.pnlDatos.Controls.Add(this.txtMostrarDesde);
            this.pnlDatos.Controls.Add(this.txtIteraciones);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(279, 583);
            this.pnlDatos.TabIndex = 33;
            // 
            // txtHastaConsumo
            // 
            this.txtHastaConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtHastaConsumo.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtHastaConsumo.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtHastaConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtHastaConsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHastaConsumo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaConsumo.ForeColor = System.Drawing.Color.White;
            this.txtHastaConsumo.Location = new System.Drawing.Point(0, 740);
            this.txtHastaConsumo.LongitudMaxima = 6;
            this.txtHastaConsumo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHastaConsumo.Name = "txtHastaConsumo";
            this.txtHastaConsumo.Size = new System.Drawing.Size(262, 53);
            this.txtHastaConsumo.TabIndex = 35;
            this.txtHastaConsumo.Texto = "Hasta";
            this.txtHastaConsumo.TextoAyuda = "";
            this.txtHastaConsumo.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtHastaConsumo.Valor = 6D;
            // 
            // txtDesdeConsumo
            // 
            this.txtDesdeConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesdeConsumo.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesdeConsumo.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDesdeConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDesdeConsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDesdeConsumo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesdeConsumo.ForeColor = System.Drawing.Color.White;
            this.txtDesdeConsumo.Location = new System.Drawing.Point(0, 687);
            this.txtDesdeConsumo.LongitudMaxima = 6;
            this.txtDesdeConsumo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesdeConsumo.Name = "txtDesdeConsumo";
            this.txtDesdeConsumo.Size = new System.Drawing.Size(262, 53);
            this.txtDesdeConsumo.TabIndex = 34;
            this.txtDesdeConsumo.Texto = "Desde";
            this.txtDesdeConsumo.TextoAyuda = "";
            this.txtDesdeConsumo.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtDesdeConsumo.Valor = 4D;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 652);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 8, 0, 8);
            this.label11.Size = new System.Drawing.Size(262, 35);
            this.label11.TabIndex = 33;
            this.label11.Text = "Consumo en mesas (minutos)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtHastaUsoMesa
            // 
            this.txtHastaUsoMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtHastaUsoMesa.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtHastaUsoMesa.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtHastaUsoMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtHastaUsoMesa.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHastaUsoMesa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaUsoMesa.ForeColor = System.Drawing.Color.White;
            this.txtHastaUsoMesa.Location = new System.Drawing.Point(0, 599);
            this.txtHastaUsoMesa.LongitudMaxima = 6;
            this.txtHastaUsoMesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHastaUsoMesa.Name = "txtHastaUsoMesa";
            this.txtHastaUsoMesa.Size = new System.Drawing.Size(262, 53);
            this.txtHastaUsoMesa.TabIndex = 10;
            this.txtHastaUsoMesa.Texto = "Hasta";
            this.txtHastaUsoMesa.TextoAyuda = "";
            this.txtHastaUsoMesa.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtHastaUsoMesa.Valor = 19D;
            // 
            // txtDesdeUsoMesa
            // 
            this.txtDesdeUsoMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesdeUsoMesa.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesdeUsoMesa.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDesdeUsoMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDesdeUsoMesa.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDesdeUsoMesa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesdeUsoMesa.ForeColor = System.Drawing.Color.White;
            this.txtDesdeUsoMesa.Location = new System.Drawing.Point(0, 546);
            this.txtDesdeUsoMesa.LongitudMaxima = 6;
            this.txtDesdeUsoMesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesdeUsoMesa.Name = "txtDesdeUsoMesa";
            this.txtDesdeUsoMesa.Size = new System.Drawing.Size(262, 53);
            this.txtDesdeUsoMesa.TabIndex = 9;
            this.txtDesdeUsoMesa.Texto = "Desde";
            this.txtDesdeUsoMesa.TextoAyuda = "";
            this.txtDesdeUsoMesa.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtDesdeUsoMesa.Valor = 11D;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 511);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10, 8, 0, 8);
            this.label10.Size = new System.Drawing.Size(262, 35);
            this.label10.TabIndex = 32;
            this.label10.Text = "Uso de mesas (minutos)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtMediaEntrega
            // 
            this.txtMediaEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMediaEntrega.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMediaEntrega.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtMediaEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMediaEntrega.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMediaEntrega.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaEntrega.ForeColor = System.Drawing.Color.White;
            this.txtMediaEntrega.Location = new System.Drawing.Point(0, 458);
            this.txtMediaEntrega.LongitudMaxima = 6;
            this.txtMediaEntrega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMediaEntrega.Name = "txtMediaEntrega";
            this.txtMediaEntrega.Size = new System.Drawing.Size(262, 53);
            this.txtMediaEntrega.TabIndex = 7;
            this.txtMediaEntrega.Texto = "Media";
            this.txtMediaEntrega.TextoAyuda = "";
            this.txtMediaEntrega.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtMediaEntrega.Valor = 50D;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 423);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 8, 0, 8);
            this.label9.Size = new System.Drawing.Size(262, 35);
            this.label9.TabIndex = 31;
            this.label9.Text = "Entrega de pedidos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDuracionCompra
            // 
            this.txtDuracionCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDuracionCompra.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDuracionCompra.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDuracionCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDuracionCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDuracionCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracionCompra.ForeColor = System.Drawing.Color.White;
            this.txtDuracionCompra.Location = new System.Drawing.Point(0, 370);
            this.txtDuracionCompra.LongitudMaxima = 6;
            this.txtDuracionCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuracionCompra.Name = "txtDuracionCompra";
            this.txtDuracionCompra.Size = new System.Drawing.Size(262, 53);
            this.txtDuracionCompra.TabIndex = 5;
            this.txtDuracionCompra.Texto = "Duración";
            this.txtDuracionCompra.TextoAyuda = "";
            this.txtDuracionCompra.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtDuracionCompra.Valor = 20D;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 335);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 8, 0, 8);
            this.label8.Size = new System.Drawing.Size(262, 35);
            this.label8.TabIndex = 30;
            this.label8.Text = "Compras";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDesviacionLlegada
            // 
            this.txtDesviacionLlegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesviacionLlegada.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesviacionLlegada.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDesviacionLlegada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDesviacionLlegada.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDesviacionLlegada.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesviacionLlegada.ForeColor = System.Drawing.Color.White;
            this.txtDesviacionLlegada.Location = new System.Drawing.Point(0, 282);
            this.txtDesviacionLlegada.LongitudMaxima = 6;
            this.txtDesviacionLlegada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesviacionLlegada.Name = "txtDesviacionLlegada";
            this.txtDesviacionLlegada.Size = new System.Drawing.Size(262, 53);
            this.txtDesviacionLlegada.TabIndex = 2;
            this.txtDesviacionLlegada.Texto = "Desviación";
            this.txtDesviacionLlegada.TextoAyuda = "";
            this.txtDesviacionLlegada.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtDesviacionLlegada.Valor = 2D;
            // 
            // txtMediaLlegada
            // 
            this.txtMediaLlegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMediaLlegada.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMediaLlegada.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtMediaLlegada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMediaLlegada.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMediaLlegada.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaLlegada.ForeColor = System.Drawing.Color.White;
            this.txtMediaLlegada.Location = new System.Drawing.Point(0, 229);
            this.txtMediaLlegada.LongitudMaxima = 6;
            this.txtMediaLlegada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMediaLlegada.Name = "txtMediaLlegada";
            this.txtMediaLlegada.Size = new System.Drawing.Size(262, 53);
            this.txtMediaLlegada.TabIndex = 1;
            this.txtMediaLlegada.Texto = "Media";
            this.txtMediaLlegada.TextoAyuda = "";
            this.txtMediaLlegada.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtMediaLlegada.Valor = 10D;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 194);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 8, 0, 8);
            this.label7.Size = new System.Drawing.Size(262, 35);
            this.label7.TabIndex = 29;
            this.label7.Text = "Llegada de personas";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCantidadMostrar
            // 
            this.txtCantidadMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtCantidadMostrar.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtCantidadMostrar.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtCantidadMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCantidadMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCantidadMostrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadMostrar.ForeColor = System.Drawing.Color.White;
            this.txtCantidadMostrar.Location = new System.Drawing.Point(0, 141);
            this.txtCantidadMostrar.LongitudMaxima = 7;
            this.txtCantidadMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadMostrar.Name = "txtCantidadMostrar";
            this.txtCantidadMostrar.Size = new System.Drawing.Size(262, 53);
            this.txtCantidadMostrar.TabIndex = 28;
            this.txtCantidadMostrar.Texto = "Cantidad a Mostrar";
            this.txtCantidadMostrar.TextoAyuda = "";
            this.txtCantidadMostrar.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtCantidadMostrar.Valor = 100D;
            // 
            // txtMostrarDesde
            // 
            this.txtMostrarDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMostrarDesde.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMostrarDesde.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtMostrarDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMostrarDesde.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMostrarDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarDesde.ForeColor = System.Drawing.Color.White;
            this.txtMostrarDesde.Location = new System.Drawing.Point(0, 88);
            this.txtMostrarDesde.LongitudMaxima = 7;
            this.txtMostrarDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMostrarDesde.Name = "txtMostrarDesde";
            this.txtMostrarDesde.Size = new System.Drawing.Size(262, 53);
            this.txtMostrarDesde.TabIndex = 27;
            this.txtMostrarDesde.Texto = "Mostrar Desde";
            this.txtMostrarDesde.TextoAyuda = "";
            this.txtMostrarDesde.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtMostrarDesde.Valor = 0D;
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtIteraciones.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtIteraciones.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtIteraciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIteraciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIteraciones.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteraciones.ForeColor = System.Drawing.Color.White;
            this.txtIteraciones.Location = new System.Drawing.Point(0, 35);
            this.txtIteraciones.LongitudMaxima = 7;
            this.txtIteraciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(262, 53);
            this.txtIteraciones.TabIndex = 26;
            this.txtIteraciones.Texto = "Iteraciones";
            this.txtIteraciones.TextoAyuda = "";
            this.txtIteraciones.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Enteros;
            this.txtIteraciones.Valor = 100000D;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 8, 0, 8);
            this.label6.Size = new System.Drawing.Size(262, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Simulación";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 5);
            this.panel1.TabIndex = 32;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Location = new System.Drawing.Point(0, 588);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(279, 50);
            this.btnExportar.TabIndex = 31;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.ClickBtnExportar);
            // 
            // pnlMg1
            // 
            this.pnlMg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMg1.Location = new System.Drawing.Point(0, 638);
            this.pnlMg1.Name = "pnlMg1";
            this.pnlMg1.Size = new System.Drawing.Size(279, 5);
            this.pnlMg1.TabIndex = 30;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 693);
            this.panel9.TabIndex = 34;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(655, 60);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 693);
            this.panel10.TabIndex = 35;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(10, 743);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(645, 10);
            this.panel11.TabIndex = 36;
            // 
            // inicioControl
            // 
            this.inicioControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.inicioControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicioControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.inicioControl.ForeColor = System.Drawing.Color.White;
            this.inicioControl.Location = new System.Drawing.Point(10, 60);
            this.inicioControl.Margin = new System.Windows.Forms.Padding(5);
            this.inicioControl.Name = "inicioControl";
            this.inicioControl.Size = new System.Drawing.Size(645, 683);
            this.inicioControl.TabIndex = 37;
            // 
            // resultadoControl
            // 
            this.resultadoControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.resultadoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.resultadoControl.ForeColor = System.Drawing.Color.White;
            this.resultadoControl.Location = new System.Drawing.Point(10, 60);
            this.resultadoControl.Margin = new System.Windows.Forms.Padding(4);
            this.resultadoControl.Name = "resultadoControl";
            this.resultadoControl.Size = new System.Drawing.Size(645, 683);
            this.resultadoControl.TabIndex = 38;
            this.resultadoControl.Visible = false;
            // 
            // errorControl
            // 
            this.errorControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.errorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.errorControl.ForeColor = System.Drawing.Color.White;
            this.errorControl.Location = new System.Drawing.Point(10, 60);
            this.errorControl.Margin = new System.Windows.Forms.Padding(4);
            this.errorControl.Name = "errorControl";
            this.errorControl.Size = new System.Drawing.Size(645, 683);
            this.errorControl.TabIndex = 39;
            this.errorControl.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(944, 753);
            this.Controls.Add(this.inicioControl);
            this.Controls.Add(this.resultadoControl);
            this.Controls.Add(this.errorControl);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP5 Simulación | Cosci - Folli - Lerda - Lozada - Reartes - Slavik";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtMediaLlegada;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtDesviacionLlegada;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtDuracionCompra;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtMediaEntrega;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtHastaUsoMesa;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtDesdeUsoMesa;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtIteraciones;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtMostrarDesde;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtCantidadMostrar;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel pnlMg1;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtHastaConsumo;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtDesdeConsumo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private Pantallas.InicioControl inicioControl;
        private Pantallas.ResultadoControl resultadoControl;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private Pantallas.ErrorControl errorControl;
        private System.Windows.Forms.PictureBox pbMenu;
    }
}