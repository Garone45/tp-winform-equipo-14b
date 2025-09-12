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
using Dominio;


namespace Presentacion
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void listadoDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListadoArticulos))
                    return;
            }*/
            
            ListadoArticulos ventana = new ListadoArticulos();
            ventana.MdiParent = this;
            ventana.Show();
          
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AgregarArticulo))
                    return;
            }
            AgregarArticulo ventana = new AgregarArticulo();
            ventana.Show();

           
            //ventana.MdiParent = this;
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            /*foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListadoMarcas))
                    return;
            }*/

            ListadoMarcas ventana = new ListadoMarcas();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
