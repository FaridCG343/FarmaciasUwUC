using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciasUwU.App.Views
{
    public partial class FormAdminMenu : Form
    {
        public FormAdminMenu()
        {
            InitializeComponent();
        }

        private void brnUsuarios_Click(object sender, EventArgs e)
        {
            Program.formGestion = new FormUsuarios();
            Program.formGestion.Show();
            Hide();
        }

        private void FormAdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Hide();
            Program.formPOS?.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Program.formGestion = new FormProducto();
            Program.formGestion.Show();
            Hide();
        }
    }
}
