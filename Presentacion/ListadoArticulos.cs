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
using System.Security.Policy;


namespace Presentacion
{
   
    public partial class ListadoArticulos : Form
    {
        private List<Articulos> listaArticulos;
        
        public ListadoArticulos()
        {
            InitializeComponent();
        }


        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
          
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dvgArticulos.DataSource = listaArticulos;
                pbxArticulos.Load(listaArticulos[0].Imagen.UrlImagen);
                
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
                listaArticulos = negocio.listar();
                dvgArticulos.DataSource = listaArticulos;
                //dvgArticulos.Columns["ImagenUrl"].Visible = false;
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

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            ArticulosNegocio negocio = new ArticulosNegocio();
            this.listaArticulos = negocio.listar(); 

            string filtro = txtFiltroRapido.Text;
                
            if(filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(buscar => buscar.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            

            dvgArticulos.DataSource = null;
            dvgArticulos.DataSource = listaFiltrada;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo ventana = new AgregarArticulo();
            ventana.ShowDialog();
        }

       /* private void dvgArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e) // Va cambiando de foto
        {
            Articulos seleccionado = (Articulos)dvgArticulos.CurrentRow.DataBoundItem;
            pbxArticulos.Load(seleccionado.Imagen.UrlImagen);
        }*/
    }
}
