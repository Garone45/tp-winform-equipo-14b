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

        private void Eliminar_Click(object sender, EventArgs e)
        {
                ArticulosNegocio negocio = new ArticulosNegocio();
                Articulos seleccionado;
            try
            {
                //Opciones de si o no, se guarda respuesta en el dialogResult
                DialogResult respuesta = MessageBox.Show("Desea eliminar un articulo?","Eliminando..",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dvgArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IDArticulo);
                    MessageBox.Show("Eliminado Correctamente!");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
