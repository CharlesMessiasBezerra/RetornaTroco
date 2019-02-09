using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Troco.Controller;

namespace Troco
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }        

        private void btnTroco_Click(object sender, EventArgs e)
        {


            TrocoController trocoController = new TrocoController();
            trocoController.VlrPago = txtVlrPago.Text;
            trocoController.VlrTotal = txtVlrCompra.Text;

            if (!trocoController.Validacao())
            {
                MessageBox.Show("Favor entre com valor válido!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(trocoController.Calcula(),"Resultado", MessageBoxButtons.OK);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVlrPago.Text = "";
            txtVlrCompra.Text = "";

        }

    }
}
