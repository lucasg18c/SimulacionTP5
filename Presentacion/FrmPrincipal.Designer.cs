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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCantidadMostrar = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtMostrarDesde = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtIteraciones = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtHastaUsoMesa = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDesdeUsoMesa = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtMediaEntrega = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDuracionCompra = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDesviacionLlegada = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtMediaLlegada = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtHastaConsumo = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDesdeConsumo = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlMg1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOcioEmpleado1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOcioEmpleado2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblOcioDuenio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTiempoCola = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTiempoCafe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblColaEmpleados = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblColaDuenio = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tablaCafeteria = new System.Windows.Forms.DataGridView();
            this.pnlLateral.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCafeteria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(0, 701);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(279, 50);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.ClickBtnCalcular);
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
            this.txtCantidadMostrar.LongitudMaxima = 6;
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
            this.txtMostrarDesde.LongitudMaxima = 6;
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
            this.txtIteraciones.LongitudMaxima = 6;
            this.txtIteraciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(262, 53);
            this.txtIteraciones.TabIndex = 26;
            this.txtIteraciones.Texto = "Iteraciones";
            this.txtIteraciones.TextoAyuda = "";
            this.txtIteraciones.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Enteros;
            this.txtIteraciones.Valor = 100000D;
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
            // pnlTopBar
            // 
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1229, 60);
            this.pnlTopBar.TabIndex = 30;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.pnlLateral.Controls.Add(this.pnlDatos);
            this.pnlLateral.Controls.Add(this.panel1);
            this.pnlLateral.Controls.Add(this.btnExportar);
            this.pnlLateral.Controls.Add(this.pnlMg1);
            this.pnlLateral.Controls.Add(this.btnCalcular);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLateral.Location = new System.Drawing.Point(950, 60);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(279, 751);
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
            this.pnlDatos.Size = new System.Drawing.Size(279, 641);
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
            this.label11.Padding = new System.Windows.Forms.Padding(10, 8, 0, 5);
            this.label11.Size = new System.Drawing.Size(262, 35);
            this.label11.TabIndex = 33;
            this.label11.Text = "Consumo en mesas";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 511);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10, 8, 0, 5);
            this.label10.Size = new System.Drawing.Size(262, 35);
            this.label10.TabIndex = 32;
            this.label10.Text = "Uso de mesas";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 423);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 8, 0, 5);
            this.label9.Size = new System.Drawing.Size(262, 35);
            this.label9.TabIndex = 31;
            this.label9.Text = "Entrega de pedidos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 335);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 8, 0, 5);
            this.label8.Size = new System.Drawing.Size(262, 35);
            this.label8.TabIndex = 30;
            this.label8.Text = "Compras";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 194);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 8, 0, 5);
            this.label7.Size = new System.Drawing.Size(262, 35);
            this.label7.TabIndex = 29;
            this.label7.Text = "Llegada de personas";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 8, 0, 5);
            this.label6.Size = new System.Drawing.Size(262, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Presentación";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 641);
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
            this.btnExportar.Location = new System.Drawing.Point(0, 646);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(279, 50);
            this.btnExportar.TabIndex = 31;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.ClickBtnExportar);
            // 
            // pnlMg1
            // 
            this.pnlMg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMg1.Location = new System.Drawing.Point(0, 696);
            this.pnlMg1.Name = "pnlMg1";
            this.pnlMg1.Size = new System.Drawing.Size(279, 5);
            this.pnlMg1.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 149);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOcioEmpleado1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 40);
            this.panel2.TabIndex = 33;
            // 
            // lblOcioEmpleado1
            // 
            this.lblOcioEmpleado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOcioEmpleado1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOcioEmpleado1.Location = new System.Drawing.Point(179, 0);
            this.lblOcioEmpleado1.Name = "lblOcioEmpleado1";
            this.lblOcioEmpleado1.Size = new System.Drawing.Size(101, 40);
            this.lblOcioEmpleado1.TabIndex = 20;
            this.lblOcioEmpleado1.Text = "valor ocio";
            this.lblOcioEmpleado1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tiempo Ocioso Empleado 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblOcioEmpleado2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(289, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 40);
            this.panel4.TabIndex = 34;
            // 
            // lblOcioEmpleado2
            // 
            this.lblOcioEmpleado2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOcioEmpleado2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOcioEmpleado2.Location = new System.Drawing.Point(188, 0);
            this.lblOcioEmpleado2.Name = "lblOcioEmpleado2";
            this.lblOcioEmpleado2.Size = new System.Drawing.Size(92, 40);
            this.lblOcioEmpleado2.TabIndex = 20;
            this.lblOcioEmpleado2.Text = "valor ocio";
            this.lblOcioEmpleado2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tiempo Ocioso Empleado 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblOcioDuenio);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(575, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 40);
            this.panel3.TabIndex = 35;
            // 
            // lblOcioDuenio
            // 
            this.lblOcioDuenio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOcioDuenio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOcioDuenio.Location = new System.Drawing.Point(179, 0);
            this.lblOcioDuenio.Name = "lblOcioDuenio";
            this.lblOcioDuenio.Size = new System.Drawing.Size(101, 40);
            this.lblOcioDuenio.TabIndex = 22;
            this.lblOcioDuenio.Text = "valor ocio";
            this.lblOcioDuenio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 40);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tiempo Ocioso Dueño";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTiempoCola);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 40);
            this.panel5.TabIndex = 36;
            // 
            // lblTiempoCola
            // 
            this.lblTiempoCola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTiempoCola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTiempoCola.Location = new System.Drawing.Point(179, 0);
            this.lblTiempoCola.Name = "lblTiempoCola";
            this.lblTiempoCola.Size = new System.Drawing.Size(101, 40);
            this.lblTiempoCola.TabIndex = 20;
            this.lblTiempoCola.Text = "valor promedio";
            this.lblTiempoCola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 40);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tiempo Prom. Perm. Cola";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblTiempoCafe);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(289, 49);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 40);
            this.panel8.TabIndex = 39;
            // 
            // lblTiempoCafe
            // 
            this.lblTiempoCafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTiempoCafe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTiempoCafe.Location = new System.Drawing.Point(179, 0);
            this.lblTiempoCafe.Name = "lblTiempoCafe";
            this.lblTiempoCafe.Size = new System.Drawing.Size(101, 40);
            this.lblTiempoCafe.TabIndex = 20;
            this.lblTiempoCafe.Text = "valor promedio";
            this.lblTiempoCafe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 40);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tiempo Prom. Perm. Cafetería";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblColaEmpleados);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(575, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 40);
            this.panel6.TabIndex = 37;
            // 
            // lblColaEmpleados
            // 
            this.lblColaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColaEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColaEmpleados.Location = new System.Drawing.Point(179, 0);
            this.lblColaEmpleados.Name = "lblColaEmpleados";
            this.lblColaEmpleados.Size = new System.Drawing.Size(101, 40);
            this.lblColaEmpleados.TabIndex = 24;
            this.lblColaEmpleados.Text = "Cantidad de Personas";
            this.lblColaEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 40);
            this.label12.TabIndex = 19;
            this.label12.Text = "Mayor Cola Empleados";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblColaDuenio);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(3, 95);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 40);
            this.panel7.TabIndex = 38;
            // 
            // lblColaDuenio
            // 
            this.lblColaDuenio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColaDuenio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColaDuenio.Location = new System.Drawing.Point(179, 0);
            this.lblColaDuenio.Name = "lblColaDuenio";
            this.lblColaDuenio.Size = new System.Drawing.Size(101, 40);
            this.lblColaDuenio.TabIndex = 26;
            this.lblColaDuenio.Text = "Cantidad de Personas";
            this.lblColaDuenio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 40);
            this.label14.TabIndex = 19;
            this.label14.Text = "Mayor Cola Dueño";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 209);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(950, 15);
            this.splitter1.TabIndex = 33;
            this.splitter1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 224);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 587);
            this.panel9.TabIndex = 34;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(940, 224);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 587);
            this.panel10.TabIndex = 35;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(10, 801);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(930, 10);
            this.panel11.TabIndex = 36;
            // 
            // tablaCafeteria
            // 
            this.tablaCafeteria.AllowUserToAddRows = false;
            this.tablaCafeteria.AllowUserToDeleteRows = false;
            this.tablaCafeteria.AllowUserToResizeRows = false;
            this.tablaCafeteria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaCafeteria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaCafeteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCafeteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaCafeteria.Location = new System.Drawing.Point(10, 224);
            this.tablaCafeteria.Margin = new System.Windows.Forms.Padding(4);
            this.tablaCafeteria.MultiSelect = false;
            this.tablaCafeteria.Name = "tablaCafeteria";
            this.tablaCafeteria.ReadOnly = true;
            this.tablaCafeteria.RowHeadersVisible = false;
            this.tablaCafeteria.Size = new System.Drawing.Size(930, 577);
            this.tablaCafeteria.TabIndex = 37;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1229, 811);
            this.Controls.Add(this.tablaCafeteria);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP5 Simulación | Cosci - Folli - Lerda - Lozada - Reartes - Slavik";
            this.pnlLateral.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCafeteria)).EndInit();
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
        private System.Windows.Forms.Button btnCalcular;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOcioEmpleado1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblOcioEmpleado2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOcioDuenio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTiempoCola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTiempoCafe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblColaEmpleados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblColaDuenio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView tablaCafeteria;
    }
}