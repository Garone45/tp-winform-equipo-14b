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
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgArticulos
            // 
            this.dvgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticulos.Location = new System.Drawing.Point(30, 65);
            this.dvgArticulos.Name = "dvgArticulos";
            this.dvgArticulos.Size = new System.Drawing.Size(237, 406);
            this.dvgArticulos.TabIndex = 0;
            // 
            // textTituloArticulos
            // 
            this.textTituloArticulos.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.textTituloArticulos.BackColor = System.Drawing.SystemColors.Info;
            this.textTituloArticulos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTituloArticulos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTituloArticulos.Location = new System.Drawing.Point(30, 39);
            this.textTituloArticulos.Name = "textTituloArticulos";
            this.textTituloArticulos.Size = new System.Drawing.Size(237, 27);
            this.textTituloArticulos.TabIndex = 1;
            this.textTituloArticulos.Text = "Listado articulos";
            // 
            // ListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 634);
            this.Controls.Add(this.textTituloArticulos);
            this.Controls.Add(this.dvgArticulos);
            this.Name = "ListadoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
    }
}