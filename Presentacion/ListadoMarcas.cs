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

        private void btnAgregarMarcas_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            try
            {
                Marcas marcas = new Marcas();
                marcas.Descripcion = txtAgregarMarca.Text;
                negocio.agregar(marcas);

                MessageBox.Show("Marca agregada correctamente");
                dgvListadoMarcas.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            Marcas seleccionado;
            try
            {
                //Opciones de si o no, se guarda respuesta en el dialogResult
                DialogResult respuesta = MessageBox.Show("Desea eliminar una Marca?", "Eliminando..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marcas)dgvListadoMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IDMarca);
                    MessageBox.Show("Eliminado Correctamente!");
                    dgvListadoMarcas.DataSource = negocio.listar();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
