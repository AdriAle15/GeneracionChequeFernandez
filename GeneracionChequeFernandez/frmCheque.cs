using Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneracionChequeFernandez
{
    public partial class frmCheque : Form
    {
        public frmCheque()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (this.txtPagueseA.TextLength == 0)
            {
                MessageBox.Show("Por favor ingrese un nombre");
                this.txtPagueseA.Focus();
                return;
            }

            if (this.txtCantidad.TextLength == 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad");
                this.txtCantidad.Focus();
                return;
            }

            if (this.txtNumCheque.TextLength == 0)
            {
                MessageBox.Show("Por favor ingrese el número");
                this.txtNumCheque.Focus();
                return;
            }

            int num = 0;

            if (!Int32.TryParse(this.txtCantidad.Text, out num))
            {
                MessageBox.Show("Debes ingresar una cantidad válida");
                this.txtCantidad.Focus();
                return;
            }

            string res = NumLetras.obtenerNombre(num);
            txtLetras.Text = res;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
