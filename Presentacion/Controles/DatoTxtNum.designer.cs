namespace SimulacionTP4.Presentacion.Controles
{
    partial class DatoTxtNum
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
            this.components = new System.ComponentModel.Container();
            this.lblNombreCampo = new System.Windows.Forms.Label();
            this.pnlLineaBase = new System.Windows.Forms.Panel();
            this.txtValor = new SimulacionTP4.Presentacion.Controles.NumTextBox();
            this.toolTipBtn = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblNombreCampo
            // 
            this.lblNombreCampo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombreCampo.Location = new System.Drawing.Point(0, 0);
            this.lblNombreCampo.Name = "lblNombreCampo";
            this.lblNombreCampo.Size = new System.Drawing.Size(163, 51);
            this.lblNombreCampo.TabIndex = 0;
            this.lblNombreCampo.Text = "Nombre Campo";
            this.lblNombreCampo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombreCampo.Click += new System.EventHandler(this.ClickValor);
            this.lblNombreCampo.MouseLeave += new System.EventHandler(this.MouseSale);
            this.lblNombreCampo.MouseHover += new System.EventHandler(this.Hover);
            // 
            // pnlLineaBase
            // 
            this.pnlLineaBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.pnlLineaBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaBase.Location = new System.Drawing.Point(0, 51);
            this.pnlLineaBase.Name = "pnlLineaBase";
            this.pnlLineaBase.Size = new System.Drawing.Size(259, 2);
            this.pnlLineaBase.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(169, 14);
            this.txtValor.MaxLength = 6;
            this.txtValor.Name = "txtValor";
            this.txtValor.ShortcutsEnabled = false;
            this.txtValor.Size = new System.Drawing.Size(77, 24);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.Tipo = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtValor.MouseLeave += new System.EventHandler(this.MouseSale);
            this.txtValor.MouseHover += new System.EventHandler(this.Hover);
            // 
            // toolTipBtn
            // 
            this.toolTipBtn.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // DatoTxtNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblNombreCampo);
            this.Controls.Add(this.pnlLineaBase);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DatoTxtNum";
            this.Size = new System.Drawing.Size(259, 53);
            this.Click += new System.EventHandler(this.ClickValor);
            this.MouseLeave += new System.EventHandler(this.MouseSale);
            this.MouseHover += new System.EventHandler(this.Hover);
            this.Resize += new System.EventHandler(this.CambioDimensiones);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCampo;
        private Controles.NumTextBox txtValor;
        private System.Windows.Forms.Panel pnlLineaBase;
        private System.Windows.Forms.ToolTip toolTipBtn;
    }
}
