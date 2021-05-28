namespace SimulacionTP1.Presentacion.ControlesUsuario
{
    partial class DatoCombo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreCampo = new System.Windows.Forms.Label();
            this.cmbValor = new System.Windows.Forms.ComboBox();
            this.pnlLineaBase = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNombreCampo
            // 
            this.lblNombreCampo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombreCampo.Location = new System.Drawing.Point(0, 0);
            this.lblNombreCampo.Name = "lblNombreCampo";
            this.lblNombreCampo.Size = new System.Drawing.Size(129, 68);
            this.lblNombreCampo.TabIndex = 1;
            this.lblNombreCampo.Text = "Nombre Campo";
            this.lblNombreCampo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombreCampo.MouseLeave += new System.EventHandler(this.MouseSale);
            this.lblNombreCampo.MouseHover += new System.EventHandler(this.Hover);
            // 
            // cmbValor
            // 
            this.cmbValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.cmbValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValor.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.cmbValor.ForeColor = System.Drawing.Color.White;
            this.cmbValor.FormattingEnabled = true;
            this.cmbValor.Location = new System.Drawing.Point(201, 21);
            this.cmbValor.Name = "cmbValor";
            this.cmbValor.Size = new System.Drawing.Size(82, 31);
            this.cmbValor.TabIndex = 2;
            this.cmbValor.MouseLeave += new System.EventHandler(this.MouseSale);
            this.cmbValor.MouseHover += new System.EventHandler(this.Hover);
            // 
            // pnlLineaBase
            // 
            this.pnlLineaBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.pnlLineaBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaBase.Location = new System.Drawing.Point(129, 66);
            this.pnlLineaBase.Name = "pnlLineaBase";
            this.pnlLineaBase.Size = new System.Drawing.Size(167, 2);
            this.pnlLineaBase.TabIndex = 3;
            // 
            // DatoCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.cmbValor);
            this.Controls.Add(this.lblNombreCampo);
            this.Controls.Add(this.pnlLineaBase);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DatoCombo";
            this.Size = new System.Drawing.Size(296, 68);
            this.SizeChanged += new System.EventHandler(this.CambioDimensiones);
            this.MouseLeave += new System.EventHandler(this.MouseSale);
            this.MouseHover += new System.EventHandler(this.Hover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCampo;
        private System.Windows.Forms.ComboBox cmbValor;
        private System.Windows.Forms.Panel pnlLineaBase;
    }
}
