using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCategoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SVC_Categorias.Service1Client svcCategoria = new SVC_Categorias.Service1Client();
            string returnString;

            returnString = svcCategoria.getCategoria(Int32.Parse(txtIDCategoria.Text));
            lblCategoria.Text = returnString;
        }

        private void lblIncluir_Click(object sender, EventArgs e)
        {
            SVC_Categorias.Service1Client svcCategoria = new SVC_Categorias.Service1Client();
            string returnString;

            returnString = svcCategoria.CriarCategoria(txtIncluir.Text);
            lblInclusao.Text = returnString;
            txtIDCategoria.Text = "";
            txtAlterar.Text = "";
        }

        private void txtIDCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            int num = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out num);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtIDCategoria.TextLength != 0)
            {
                SVC_Categorias.Service1Client svcCategoria = new SVC_Categorias.Service1Client();
                string returnString;

                returnString = svcCategoria.CriarCategoria(txtIncluir.Text);
                lblInclusao.Text = returnString;
            }
        }
    }
}
