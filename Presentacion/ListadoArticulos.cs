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
    public partial class ListadoArticulos : Form
    {
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.FormBorderStyle = FormBorderStyle.None; // sin bordes
            this.Dock = DockStyle.Fill; // ocupa todo el contenedor padre
=======
           
>>>>>>> f0565038410d7eb892a35ee6043ee179ade8f14e
            ArticulosNegocio negocio = new ArticulosNegocio();
            dvgArticulos.DataSource = negocio.listar();

        }

        
    }
}
