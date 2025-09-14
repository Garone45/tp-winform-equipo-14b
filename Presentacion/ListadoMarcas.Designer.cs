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
            this.btnAgregarMarcas = new System.Windows.Forms.Button();
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.txtAgregarMarca = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoMarcas
            // 
            this.dgvListadoMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMarcas.Location = new System.Drawing.Point(53, 89);
            this.dgvListadoMarcas.Name = "dgvListadoMarcas";
            this.dgvListadoMarcas.Size = new System.Drawing.Size(338, 265);
            this.dgvListadoMarcas.TabIndex = 0;
            // 
            // lblListadoMarcas
            // 
            this.lblListadoMarcas.AutoSize = true;
            this.lblListadoMarcas.Location = new System.Drawing.Point(53, 70);
            this.lblListadoMarcas.Name = "lblListadoMarcas";
            this.lblListadoMarcas.Size = new System.Drawing.Size(52, 13);
            this.lblListadoMarcas.TabIndex = 1;
            this.lblListadoMarcas.Text = "MARCAS";
            // 
            // btnAgregarMarcas
            // 
            this.btnAgregarMarcas.Location = new System.Drawing.Point(316, 372);
            this.btnAgregarMarcas.Name = "btnAgregarMarcas";
            this.btnAgregarMarcas.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarcas.TabIndex = 2;
            this.btnAgregarMarcas.Text = "Agregar";
            this.btnAgregarMarcas.UseVisualStyleBackColor = true;
            this.btnAgregarMarcas.Click += new System.EventHandler(this.btnAgregarMarcas_Click);
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.Location = new System.Drawing.Point(50, 375);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(44, 13);
            this.lblNombreMarca.TabIndex = 3;
            this.lblNombreMarca.Text = "Nombre";
            // 
            // txtAgregarMarca
            // 
            this.txtAgregarMarca.Location = new System.Drawing.Point(103, 372);
            this.txtAgregarMarca.Name = "txtAgregarMarca";
            this.txtAgregarMarca.Size = new System.Drawing.Size(207, 20);
            this.txtAgregarMarca.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(419, 89);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ListadoMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtAgregarMarca);
            this.Controls.Add(this.lblNombreMarca);
            this.Controls.Add(this.btnAgregarMarcas);
            this.Controls.Add(this.lblListadoMarcas);
            this.Controls.Add(this.dgvListadoMarcas);
            this.Name = "ListadoMarcas";
            this.Text = "ListadoMarcas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListadoMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoMarcas;
        private System.Windows.Forms.Label lblListadoMarcas;
        private System.Windows.Forms.Button btnAgregarMarcas;
        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.TextBox txtAgregarMarca;
        private System.Windows.Forms.Button btnEliminar;
    }
}