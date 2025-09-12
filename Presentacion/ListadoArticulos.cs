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
    public partial class ListadoArticulos : Form
    {
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
          
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                dvgArticulos.DataSource = negocio.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                dvgArticulos.DataSource = negocio.listar();
               // dvgArticulos.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dvgArticulos.CurrentRow.DataBoundItem; //capturamos el articulo seleccionado en la grilla
           
            AgregarArticulo ventanaModificar = new AgregarArticulo(seleccionado);
            ventanaModificar.ShowDialog();
        }
    }
}
