namespace Presentacion
{
    partial class ListadoMarcas
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
            this.dgvListadoMarcas = new System.Windows.Forms.DataGridView();
            this.lblListadoMarcas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoMarcas
            // 
            this.dgvListadoMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMarcas.Location = new System.Drawing.Point(53, 89);
            this.dgvListadoMarcas.Name = "dgvListadoMarcas";
            this.dgvListadoMarcas.Size = new System.Drawing.Size(338, 150);
            this.dgvListadoMarcas.TabIndex = 0;
            // 
            // lblListadoMarcas
            // 
            this.lblListadoMarcas.AutoSize = true;
            this.lblListadoMarcas.Location = new System.Drawing.Point(53, 70);
            this.lblListadoMarcas.Name = "lblListadoMarcas";
            this.lblListadoMarcas.Size = new System.Drawing.Size(94, 13);
            this.lblListadoMarcas.TabIndex = 1;
            this.lblListadoMarcas.Text = "Listado de Marcas";
            // 
            // ListadoMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListadoMarcas);
            this.Controls.Add(this.dgvListadoMarcas);
            this.Name = "ListadoMarcas";
            this.Text = "ListadoMarcas";
            this.Load += new System.EventHandler(this.ListadoMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoMarcas;
        private System.Windows.Forms.Label lblListadoMarcas;
    }
}