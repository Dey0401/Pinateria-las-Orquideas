using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPractica1
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();

        }

        #region Metodos propios
        private void Mensaje(string texto)
        {
            MessageBox.Show(texto);
        }
        private void   llenarCombo()
        {
            this.cmbProducto.Items.Add("Seleccione un producto"); //Index = 0
            this.cmbProducto.Items.Add("Producto 1"); //Index = 1 (cod : 110)
            this.cmbProducto.Items.Add("Producto 2"); //Index = 2 (cod : 215)
            this.cmbProducto.Items.Add("Otros productos"); //Index = 3
            this.cmbProducto.SelectedIndex = 0;
        }
        private void Limpiar()
        {
            this.cmbProducto.SelectedIndex = 0;
            this.txtVrDocena.Text = string.Empty;
            this.txtCant.Text = string.Empty;
            this.txtIVA.Text = string.Empty;
            this.grbAPagar.Visible = false;
            this.cmbProducto.Focus();


        }
        #endregion
        private void frmPedido_Load(object sender, EventArgs e)
        {
            llenarCombo();
        }
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Mensaje("Se limpiaron los campos correctamente");
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Mensaje("");
        }


    }
}
