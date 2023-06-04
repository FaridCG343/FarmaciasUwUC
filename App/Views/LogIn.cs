using FarmaciasUwU.App.Controllers;
using FarmaciasUwU.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciasUwU.Views
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario ?usuario = UsuarioController.LogIn(tbUsuario.Text, tbPassword.Text);
            if (usuario == null)
            {
                MessageBox.Show("Credenciales no validas");
                return;
            }
            MessageBox.Show("Has ingresado exitosamente");
            Program.user = usuario;
            Program.formPOS ??= new();
            Program.formPOS.Show();
            Hide();
        }
    }
}
