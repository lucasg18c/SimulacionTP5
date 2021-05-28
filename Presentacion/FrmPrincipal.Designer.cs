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
            this.tablaCafeteria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOcioso = new System.Windows.Forms.Label();
            this.lblOcioso2 = new System.Windows.Forms.Label();
            this.lblTiempOciosoEmp1 = new System.Windows.Forms.Label();
            this.lblTiempoOciosoEmp2 = new System.Windows.Forms.Label();
            this.lblPermCola = new System.Windows.Forms.Label();
            this.lblValorPromedioPermCola = new System.Windows.Forms.Label();
            this.lblOciosoDueño = new System.Windows.Forms.Label();
            this.lblTimepoOciosoDueño = new System.Windows.Forms.Label();
            this.lblColaEmp = new System.Windows.Forms.Label();
            this.lblCantidadColaMaxEmp = new System.Windows.Forms.Label();
            this.lblColaDuenio = new System.Windows.Forms.Label();
            this.lblCantidadColaMaxDuenio = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCantidadMostra = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtMostrarDesde = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtIteraciones = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtHastaFinConsumo = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDesdeFinConsumo = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtHastaFinMesa = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDesdeFinMesa = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtSegFinEntrega = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtSegFinCompra = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDesviacionLlegada = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtMediaLlegada = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCafeteria)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCafeteria
            // 
            this.tablaCafeteria.AllowUserToAddRows = false;
            this.tablaCafeteria.AllowUserToDeleteRows = false;
            this.tablaCafeteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCafeteria.Location = new System.Drawing.Point(23, 176);
            this.tablaCafeteria.Margin = new System.Windows.Forms.Padding(4);
            this.tablaCafeteria.Name = "tablaCafeteria";
            this.tablaCafeteria.ReadOnly = true;
            this.tablaCafeteria.Size = new System.Drawing.Size(578, 347);
            this.tablaCafeteria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(635, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Evento Llegada Persona Disrtibucion Normal\r\n(En minutos):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(634, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Evento Fin de Compra Cte (En segundos):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(634, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Evento Fin de Entregas Pedidos Exp Negativa\r\n(Segundos)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(634, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Evento Fin Uso Mesa Uniforme Entre\r\n(Minutos):\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(635, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Evento Fin Consumo en mesa \r\nUniforme Entre (Minutos):\r\n";
            // 
            // lblOcioso
            // 
            this.lblOcioso.AutoSize = true;
            this.lblOcioso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOcioso.Location = new System.Drawing.Point(29, 21);
            this.lblOcioso.Name = "lblOcioso";
            this.lblOcioso.Size = new System.Drawing.Size(182, 19);
            this.lblOcioso.TabIndex = 14;
            this.lblOcioso.Text = "Timepo Ocioso Empleado 1:\r\n";
            // 
            // lblOcioso2
            // 
            this.lblOcioso2.AutoSize = true;
            this.lblOcioso2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOcioso2.Location = new System.Drawing.Point(29, 40);
            this.lblOcioso2.Name = "lblOcioso2";
            this.lblOcioso2.Size = new System.Drawing.Size(188, 19);
            this.lblOcioso2.TabIndex = 15;
            this.lblOcioso2.Text = "Timepo Ocioso Empleado 2 :\r\n";
            // 
            // lblTiempOciosoEmp1
            // 
            this.lblTiempOciosoEmp1.AutoSize = true;
            this.lblTiempOciosoEmp1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTiempOciosoEmp1.Location = new System.Drawing.Point(317, 21);
            this.lblTiempOciosoEmp1.Name = "lblTiempOciosoEmp1";
            this.lblTiempOciosoEmp1.Size = new System.Drawing.Size(71, 19);
            this.lblTiempOciosoEmp1.TabIndex = 16;
            this.lblTiempOciosoEmp1.Text = "valor ocio";
            // 
            // lblTiempoOciosoEmp2
            // 
            this.lblTiempoOciosoEmp2.AutoSize = true;
            this.lblTiempoOciosoEmp2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTiempoOciosoEmp2.Location = new System.Drawing.Point(317, 40);
            this.lblTiempoOciosoEmp2.Name = "lblTiempoOciosoEmp2";
            this.lblTiempoOciosoEmp2.Size = new System.Drawing.Size(71, 19);
            this.lblTiempoOciosoEmp2.TabIndex = 17;
            this.lblTiempoOciosoEmp2.Text = "valor ocio";
            // 
            // lblPermCola
            // 
            this.lblPermCola.AutoSize = true;
            this.lblPermCola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPermCola.Location = new System.Drawing.Point(29, 89);
            this.lblPermCola.Name = "lblPermCola";
            this.lblPermCola.Size = new System.Drawing.Size(231, 19);
            this.lblPermCola.TabIndex = 18;
            this.lblPermCola.Text = "Tiempo Prom Permanencia en Cola:";
            // 
            // lblValorPromedioPermCola
            // 
            this.lblValorPromedioPermCola.AutoSize = true;
            this.lblValorPromedioPermCola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValorPromedioPermCola.Location = new System.Drawing.Point(317, 89);
            this.lblValorPromedioPermCola.Name = "lblValorPromedioPermCola";
            this.lblValorPromedioPermCola.Size = new System.Drawing.Size(104, 19);
            this.lblValorPromedioPermCola.TabIndex = 19;
            this.lblValorPromedioPermCola.Text = "valor promedio";
            // 
            // lblOciosoDueño
            // 
            this.lblOciosoDueño.AutoSize = true;
            this.lblOciosoDueño.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOciosoDueño.Location = new System.Drawing.Point(29, 59);
            this.lblOciosoDueño.Name = "lblOciosoDueño";
            this.lblOciosoDueño.Size = new System.Drawing.Size(152, 19);
            this.lblOciosoDueño.TabIndex = 20;
            this.lblOciosoDueño.Text = "Timepo Ocioso Dueño:";
            // 
            // lblTimepoOciosoDueño
            // 
            this.lblTimepoOciosoDueño.AutoSize = true;
            this.lblTimepoOciosoDueño.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimepoOciosoDueño.Location = new System.Drawing.Point(317, 59);
            this.lblTimepoOciosoDueño.Name = "lblTimepoOciosoDueño";
            this.lblTimepoOciosoDueño.Size = new System.Drawing.Size(71, 19);
            this.lblTimepoOciosoDueño.TabIndex = 21;
            this.lblTimepoOciosoDueño.Text = "valor ocio";
            // 
            // lblColaEmp
            // 
            this.lblColaEmp.AutoSize = true;
            this.lblColaEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColaEmp.Location = new System.Drawing.Point(29, 119);
            this.lblColaEmp.Name = "lblColaEmp";
            this.lblColaEmp.Size = new System.Drawing.Size(165, 19);
            this.lblColaEmp.TabIndex = 22;
            this.lblColaEmp.Text = "Cola Maxima Empleados:";
            // 
            // lblCantidadColaMaxEmp
            // 
            this.lblCantidadColaMaxEmp.AutoSize = true;
            this.lblCantidadColaMaxEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidadColaMaxEmp.Location = new System.Drawing.Point(317, 119);
            this.lblCantidadColaMaxEmp.Name = "lblCantidadColaMaxEmp";
            this.lblCantidadColaMaxEmp.Size = new System.Drawing.Size(143, 19);
            this.lblCantidadColaMaxEmp.TabIndex = 23;
            this.lblCantidadColaMaxEmp.Text = "Cantidad de Personas";
            // 
            // lblColaDuenio
            // 
            this.lblColaDuenio.AutoSize = true;
            this.lblColaDuenio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColaDuenio.Location = new System.Drawing.Point(29, 138);
            this.lblColaDuenio.Name = "lblColaDuenio";
            this.lblColaDuenio.Size = new System.Drawing.Size(139, 19);
            this.lblColaDuenio.TabIndex = 24;
            this.lblColaDuenio.Text = "Cola Maxima Dueño:";
            // 
            // lblCantidadColaMaxDuenio
            // 
            this.lblCantidadColaMaxDuenio.AutoSize = true;
            this.lblCantidadColaMaxDuenio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidadColaMaxDuenio.Location = new System.Drawing.Point(317, 138);
            this.lblCantidadColaMaxDuenio.Name = "lblCantidadColaMaxDuenio";
            this.lblCantidadColaMaxDuenio.Size = new System.Drawing.Size(143, 19);
            this.lblCantidadColaMaxDuenio.TabIndex = 25;
            this.lblCantidadColaMaxDuenio.Text = "Cantidad de Personas";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(321, 655);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(289, 50);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCantidadMostra
            // 
            this.txtCantidadMostra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtCantidadMostra.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtCantidadMostra.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtCantidadMostra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCantidadMostra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadMostra.ForeColor = System.Drawing.Color.White;
            this.txtCantidadMostra.Location = new System.Drawing.Point(33, 649);
            this.txtCantidadMostra.LongitudMaxima = 6;
            this.txtCantidadMostra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadMostra.Name = "txtCantidadMostra";
            this.txtCantidadMostra.Size = new System.Drawing.Size(259, 53);
            this.txtCantidadMostra.TabIndex = 28;
            this.txtCantidadMostra.Texto = "Cantidad a Mostrar:";
            this.txtCantidadMostra.TextoAyuda = "";
            this.txtCantidadMostra.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtCantidadMostra.Valor = 0D;
            // 
            // txtMostrarDesde
            // 
            this.txtMostrarDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMostrarDesde.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMostrarDesde.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtMostrarDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMostrarDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarDesde.ForeColor = System.Drawing.Color.White;
            this.txtMostrarDesde.Location = new System.Drawing.Point(33, 598);
            this.txtMostrarDesde.LongitudMaxima = 6;
            this.txtMostrarDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMostrarDesde.Name = "txtMostrarDesde";
            this.txtMostrarDesde.Size = new System.Drawing.Size(259, 53);
            this.txtMostrarDesde.TabIndex = 27;
            this.txtMostrarDesde.Texto = "Mostrar Desde:";
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
            this.txtIteraciones.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteraciones.ForeColor = System.Drawing.Color.White;
            this.txtIteraciones.Location = new System.Drawing.Point(33, 546);
            this.txtIteraciones.LongitudMaxima = 6;
            this.txtIteraciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(259, 53);
            this.txtIteraciones.TabIndex = 26;
            this.txtIteraciones.Texto = "Iteraciones:";
            this.txtIteraciones.TextoAyuda = "";
            this.txtIteraciones.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtIteraciones.Valor = 0D;
            // 
            // txtHastaFinConsumo
            // 
            this.txtHastaFinConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtHastaFinConsumo.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtHastaFinConsumo.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtHastaFinConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtHastaFinConsumo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaFinConsumo.ForeColor = System.Drawing.Color.White;
            this.txtHastaFinConsumo.Location = new System.Drawing.Point(632, 652);
            this.txtHastaFinConsumo.LongitudMaxima = 6;
            this.txtHastaFinConsumo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHastaFinConsumo.Name = "txtHastaFinConsumo";
            this.txtHastaFinConsumo.Size = new System.Drawing.Size(259, 53);
            this.txtHastaFinConsumo.TabIndex = 13;
            this.txtHastaFinConsumo.Texto = "Hasta:";
            this.txtHastaFinConsumo.TextoAyuda = "";
            this.txtHastaFinConsumo.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.RealesNegativos;
            this.txtHastaFinConsumo.Valor = 0D;
            // 
            // txtDesdeFinConsumo
            // 
            this.txtDesdeFinConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesdeFinConsumo.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesdeFinConsumo.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDesdeFinConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDesdeFinConsumo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesdeFinConsumo.ForeColor = System.Drawing.Color.White;
            this.txtDesdeFinConsumo.Location = new System.Drawing.Point(632, 598);
            this.txtDesdeFinConsumo.LongitudMaxima = 6;
            this.txtDesdeFinConsumo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesdeFinConsumo.Name = "txtDesdeFinConsumo";
            this.txtDesdeFinConsumo.Size = new System.Drawing.Size(259, 53);
            this.txtDesdeFinConsumo.TabIndex = 12;
            this.txtDesdeFinConsumo.Texto = "Desde:";
            this.txtDesdeFinConsumo.TextoAyuda = "";
            this.txtDesdeFinConsumo.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.RealesNegativos;
            this.txtDesdeFinConsumo.Valor = 0D;
            // 
            // txtHastaFinMesa
            // 
            this.txtHastaFinMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtHastaFinMesa.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtHastaFinMesa.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtHastaFinMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtHastaFinMesa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaFinMesa.ForeColor = System.Drawing.Color.White;
            this.txtHastaFinMesa.Location = new System.Drawing.Point(635, 488);
            this.txtHastaFinMesa.LongitudMaxima = 6;
            this.txtHastaFinMesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHastaFinMesa.Name = "txtHastaFinMesa";
            this.txtHastaFinMesa.Size = new System.Drawing.Size(259, 53);
            this.txtHastaFinMesa.TabIndex = 10;
            this.txtHastaFinMesa.Texto = "Hasta:";
            this.txtHastaFinMesa.TextoAyuda = "";
            this.txtHastaFinMesa.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.RealesNegativos;
            this.txtHastaFinMesa.Valor = 0D;
            // 
            // txtDesdeFinMesa
            // 
            this.txtDesdeFinMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesdeFinMesa.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesdeFinMesa.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDesdeFinMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDesdeFinMesa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesdeFinMesa.ForeColor = System.Drawing.Color.White;
            this.txtDesdeFinMesa.Location = new System.Drawing.Point(635, 434);
            this.txtDesdeFinMesa.LongitudMaxima = 6;
            this.txtDesdeFinMesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesdeFinMesa.Name = "txtDesdeFinMesa";
            this.txtDesdeFinMesa.Size = new System.Drawing.Size(259, 53);
            this.txtDesdeFinMesa.TabIndex = 9;
            this.txtDesdeFinMesa.Texto = "Desde:";
            this.txtDesdeFinMesa.TextoAyuda = "";
            this.txtDesdeFinMesa.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.RealesNegativos;
            this.txtDesdeFinMesa.Valor = 0D;
            // 
            // txtSegFinEntrega
            // 
            this.txtSegFinEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtSegFinEntrega.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtSegFinEntrega.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtSegFinEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSegFinEntrega.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegFinEntrega.ForeColor = System.Drawing.Color.White;
            this.txtSegFinEntrega.Location = new System.Drawing.Point(638, 322);
            this.txtSegFinEntrega.LongitudMaxima = 6;
            this.txtSegFinEntrega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSegFinEntrega.Name = "txtSegFinEntrega";
            this.txtSegFinEntrega.Size = new System.Drawing.Size(259, 53);
            this.txtSegFinEntrega.TabIndex = 7;
            this.txtSegFinEntrega.Texto = "Segundos:";
            this.txtSegFinEntrega.TextoAyuda = "";
            this.txtSegFinEntrega.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Enteros;
            this.txtSegFinEntrega.Valor = 0D;
            // 
            // txtSegFinCompra
            // 
            this.txtSegFinCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtSegFinCompra.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtSegFinCompra.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtSegFinCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSegFinCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegFinCompra.ForeColor = System.Drawing.Color.White;
            this.txtSegFinCompra.Location = new System.Drawing.Point(638, 222);
            this.txtSegFinCompra.LongitudMaxima = 6;
            this.txtSegFinCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSegFinCompra.Name = "txtSegFinCompra";
            this.txtSegFinCompra.Size = new System.Drawing.Size(259, 53);
            this.txtSegFinCompra.TabIndex = 5;
            this.txtSegFinCompra.Texto = "Segundos:";
            this.txtSegFinCompra.TextoAyuda = "";
            this.txtSegFinCompra.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Enteros;
            this.txtSegFinCompra.Valor = 0D;
            // 
            // txtDesviacionLlegada
            // 
            this.txtDesviacionLlegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesviacionLlegada.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDesviacionLlegada.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDesviacionLlegada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDesviacionLlegada.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesviacionLlegada.ForeColor = System.Drawing.Color.White;
            this.txtDesviacionLlegada.Location = new System.Drawing.Point(638, 128);
            this.txtDesviacionLlegada.LongitudMaxima = 6;
            this.txtDesviacionLlegada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesviacionLlegada.Name = "txtDesviacionLlegada";
            this.txtDesviacionLlegada.Size = new System.Drawing.Size(259, 53);
            this.txtDesviacionLlegada.TabIndex = 2;
            this.txtDesviacionLlegada.Texto = "Desviacion:";
            this.txtDesviacionLlegada.TextoAyuda = "";
            this.txtDesviacionLlegada.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtDesviacionLlegada.Valor = 0D;
            // 
            // txtMediaLlegada
            // 
            this.txtMediaLlegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMediaLlegada.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtMediaLlegada.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtMediaLlegada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMediaLlegada.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaLlegada.ForeColor = System.Drawing.Color.White;
            this.txtMediaLlegada.Location = new System.Drawing.Point(638, 74);
            this.txtMediaLlegada.LongitudMaxima = 6;
            this.txtMediaLlegada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMediaLlegada.Name = "txtMediaLlegada";
            this.txtMediaLlegada.Size = new System.Drawing.Size(259, 53);
            this.txtMediaLlegada.TabIndex = 1;
            this.txtMediaLlegada.Texto = "Media:";
            this.txtMediaLlegada.TextoAyuda = "";
            this.txtMediaLlegada.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtMediaLlegada.Valor = 0D;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(945, 716);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidadMostra);
            this.Controls.Add(this.txtMostrarDesde);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.lblCantidadColaMaxDuenio);
            this.Controls.Add(this.lblColaDuenio);
            this.Controls.Add(this.lblCantidadColaMaxEmp);
            this.Controls.Add(this.lblColaEmp);
            this.Controls.Add(this.lblTimepoOciosoDueño);
            this.Controls.Add(this.lblOciosoDueño);
            this.Controls.Add(this.lblValorPromedioPermCola);
            this.Controls.Add(this.lblPermCola);
            this.Controls.Add(this.lblTiempoOciosoEmp2);
            this.Controls.Add(this.lblTiempOciosoEmp1);
            this.Controls.Add(this.lblOcioso2);
            this.Controls.Add(this.lblOcioso);
            this.Controls.Add(this.txtHastaFinConsumo);
            this.Controls.Add(this.txtDesdeFinConsumo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHastaFinMesa);
            this.Controls.Add(this.txtDesdeFinMesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSegFinEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSegFinCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesviacionLlegada);
            this.Controls.Add(this.txtMediaLlegada);
            this.Controls.Add(this.tablaCafeteria);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP5 Simulación | Cosci - Folli - Lerda - Lozada - Reartes - Slavik";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCafeteria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCafeteria;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtMediaLlegada;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtDesviacionLlegada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtSegFinCompra;
        private System.Windows.Forms.Label label3;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtSegFinEntrega;
        private System.Windows.Forms.Label label4;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtHastaFinMesa;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtDesdeFinMesa;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtHastaFinConsumo;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtDesdeFinConsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOcioso;
        private System.Windows.Forms.Label lblOcioso2;
        private System.Windows.Forms.Label lblTiempOciosoEmp1;
        private System.Windows.Forms.Label lblTiempoOciosoEmp2;
        private System.Windows.Forms.Label lblPermCola;
        private System.Windows.Forms.Label lblValorPromedioPermCola;
        private System.Windows.Forms.Label lblOciosoDueño;
        private System.Windows.Forms.Label lblTimepoOciosoDueño;
        private System.Windows.Forms.Label lblColaEmp;
        private System.Windows.Forms.Label lblCantidadColaMaxEmp;
        private System.Windows.Forms.Label lblColaDuenio;
        private System.Windows.Forms.Label lblCantidadColaMaxDuenio;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtIteraciones;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtMostrarDesde;
        private SimulacionTP4.Presentacion.Controles.DatoTxtNum txtCantidadMostra;
        private System.Windows.Forms.Button btnCalcular;
    }
}