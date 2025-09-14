using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class AgregarArticulo : Form
    {
        private Articulos articulo = null; 
        public AgregarArticulo()
        {
            InitializeComponent();
        }
        public AgregarArticulo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if(articulo == null)
                {
                    articulo = new Articulos();
                }
                
                articulo.CodigoArticulo = txtCodigoArticulo.Text;              //capturamos lo que se agrega en el textBox 
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca =(Marcas) cboMarca.SelectedItem; //el selected item lo casteamos como marca
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem ; //el selected item lo casteamos como categoria

                if(articulo.IDArticulo != 0)
                {
                    //articulo.IDArticulo = articulo.IDArticulo;
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Correctamente");
                   
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado Correctamente");

                }
                
               
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
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = CategoriasNegocio.listar();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "Descripcion";
                
                if(articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboMarca.SelectedValue = articulo.Marca.IDMarca;
                    cboCategoria.SelectedValue = articulo.Categoria.IDCategoria;
                    btnAgregar.Text = "Modificar";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
