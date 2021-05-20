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
            ((System.ComponentModel.ISupportInitialize)(this.tablaCafeteria)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCafeteria
            // 
            this.tablaCafeteria.AllowUserToAddRows = false;
            this.tablaCafeteria.AllowUserToDeleteRows = false;
            this.tablaCafeteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCafeteria.Location = new System.Drawing.Point(24, 128);
            this.tablaCafeteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaCafeteria.Name = "tablaCafeteria";
            this.tablaCafeteria.ReadOnly = true;
            this.tablaCafeteria.Size = new System.Drawing.Size(595, 478);
            this.tablaCafeteria.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 683);
            this.Controls.Add(this.tablaCafeteria);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP5";
            ((System.ComponentModel.ISupportInitialize)(this.tablaCafeteria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCafeteria;
    }
}