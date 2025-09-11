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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                articulos.CodigoArticulo = txtCodigoArticulo.Text;              //capturamos lo que se agrega en el textBox 
                articulos.Nombre = txtNombre.Text;
                articulos.Descripcion = txtDescripcion.Text;
                articulos.Marca =(Marcas) cboMarca.SelectedItem; //el selected item lo casteamos como marca
                articulos.Categoria = (Categoria)cboCategoria.SelectedItem ; //el selected item lo casteamos como categoria

                negocio.agregar(articulos);
                
                
                MessageBox.Show("Agregado Correctamente");
                
                
                Close();//volvemos a la ventana principal...

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }



        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio CategoriasNegocio = new CategoriasNegocio();
            try
            {
                cboMarca.DataSource = marcasNegocio.listar();
                cboCategoria.DataSource = CategoriasNegocio.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
