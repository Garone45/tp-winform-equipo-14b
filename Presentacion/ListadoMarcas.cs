using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ListadoMarcas : Form
    {
        public ListadoMarcas()
        {
            InitializeComponent();
        }

        private void ListadoMarcas_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None; // sin bordes
            //this.Dock = DockStyle.Fill; // ocupa todo el contenedor padre


            MarcasNegocio negocio = new MarcasNegocio();
            dgvListadoMarcas.DataSource = negocio.listar();
        }
    }
}
