namespace Presentacion
{
    partial class ListadoArticulos
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
            this.dvgArticulos = new System.Windows.Forms.DataGridView();
            this.textTituloArticulos = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgArticulos
            // 
            this.dvgArticulos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dvgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgArticulos.Location = new System.Drawing.Point(30, 62);
            this.dvgArticulos.MultiSelect = false;
            this.dvgArticulos.Name = "dvgArticulos";
            this.dvgArticulos.Size = new System.Drawing.Size(729, 330);
            this.dvgArticulos.TabIndex = 0;
            // 
            // textTituloArticulos
            // 
            this.textTituloArticulos.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.textTituloArticulos.BackColor = System.Drawing.Color.Silver;
            this.textTituloArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTituloArticulos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTituloArticulos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTituloArticulos.Location = new System.Drawing.Point(30, 36);
            this.textTituloArticulos.Name = "textTituloArticulos";
            this.textTituloArticulos.Size = new System.Drawing.Size(729, 20);
            this.textTituloArticulos.TabIndex = 1;
            this.textTituloArticulos.Text = "ARTICULOS";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(30, 414);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(121, 414);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1275, 653);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.textTituloArticulos);
            this.Controls.Add(this.dvgArticulos);
            this.Name = "ListadoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgArticulos;
        private System.Windows.Forms.TextBox textTituloArticulos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnModificar;
    }
}