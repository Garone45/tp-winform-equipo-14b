using Dominio;
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
    public partial class ListaCategorias : Form
    {
        public ListaCategorias()
        {
            InitializeComponent();
        }

        private void ListaCategorias_Load(object sender, EventArgs e)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            dvgListaCategoria.DataSource = negocio.listar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();

            try
            {
                Categoria categoria = new Categoria();
                categoria.Descripcion = txtNombreCategoria.Text;
                negocio.agregar(categoria);
                MessageBox.Show("Agregado Correctamente ");

                dvgListaCategoria.DataSource=negocio.listar();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dvgListaCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgListaCategoria.CurrentRow == null) return;

            Categoria seleccionado = dvgListaCategoria.CurrentRow.DataBoundItem as Categoria;
            if (seleccionado == null) return;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar esta categoria?", "Eliminando..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dvgListaCategoria.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Descripcion);
                    MessageBox.Show("Eliminado Correctamente...");
                    dvgListaCategoria.DataSource = negocio.listar();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
