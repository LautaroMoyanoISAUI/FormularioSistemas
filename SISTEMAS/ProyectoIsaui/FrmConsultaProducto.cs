using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIsaui.Clases;

namespace ProyectoIsaui
{
    public partial class FrmConsultaProducto : FrmBase
    {
        public FrmConsultaProducto()
        {
            InitializeComponent();
        }

        private void FrmConsultaProducto_Load(object sender, EventArgs e)
        {
            string sql = "select * from producto";
            DataTable tbproducto = Db.Select(sql);
            grdproducto.DataSource = tbproducto;
        }

        private void grdproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            Producto producto = new Producto();
            DataTable tbproducto = producto.Buscar(nombre);
            grdproducto.DataSource = tbproducto;
            grdproducto.Columns[0].Visible = false;
            grdproducto.Columns[3].Width = 100;
            grdproducto.Columns[5].Width = 100;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPrincipal.CodProducto = ""; //sirve para limpiar la variable
            FrmProducto frm = new FrmProducto();
            frm.Show();
        }

        private void txtCodBarra_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtCodBarra.Text;
            Producto pro = new Producto();
            DataTable tabla = pro.BuscarCodBarra(codigo);
            grdproducto.DataSource = tabla;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string codigo = grdproducto.CurrentRow.Cells[0].Value.ToString();
            FrmPrincipal.CodProducto = codigo;
            FrmProducto frm = new FrmProducto();
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(grdproducto.CurrentRow.Cells[0].Value.ToString());
            Producto pro = new Producto();
            pro.Borrar(codigo);
            string nombre = txtNombre.Text;
            Producto producto = new Producto();
            DataTable tbproducto = producto.Buscar(nombre);
            grdproducto.DataSource = tbproducto;
            MessageBox.Show("El producto se ha borrado correctamente");
       }
    }
}
