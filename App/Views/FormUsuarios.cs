using FarmaciasUwU.App.Controllers;
using FarmaciasUwU.App.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciasUwU.App.Views
{
    public partial class FormUsuarios : Form
    {
        private BindingSource bindingSourceUsuarios;
        private List<UsuarioDTO> usuarios;
        private int index = 0;
        public FormUsuarios()
        {
            InitializeComponent();
            usuarios = new List<UsuarioDTO>();
            bindingSourceUsuarios = new();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            bindingSourceUsuarios.DataSource = usuarios = UsuarioController.Index();
            SetValues();
            dataUsuarios.DataSource = bindingSourceUsuarios;
        }

        private void SetValues()
        {
            if (usuarios.Count > 0)
            {
                lblShowNumUsuario.Text = $"#Usuario: {usuarios[index].Id}";
                tbShowNombre.Text = usuarios[index].Nombre;
                tbShowEmail.Text = usuarios[index].Email;
            }
            else
            {
                lblShowNumUsuario.Text = "#Usuario:";
                tbShowEmail.Text = string.Empty;
                tbShowNombre.Text = string.Empty;
            }
        }

        private void Filter()
        {
            bindingSourceUsuarios.DataSource = usuarios = UsuarioController.Filter(tbBNombre.Text, tbBEmail.Text);
            index = 0;
            SetValues();
        }

        private static bool EmailValido(string Email)
        {
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new(patron);
            return regex.IsMatch(Email);
        }

        private void tbBNombre_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            index = 0;
            SetValues();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            index = usuarios.Count > 0 ? usuarios.Count - 1 : 0;
            SetValues();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            index = index > 0 ? index - 1 : 0;
            SetValues();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            index = index < usuarios.Count - 1 ? usuarios.Count - 1 : index;
            SetValues();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbAgregarPass.Text == "" || tbAgregarNombre.Text == "")
            {
                MessageBox.Show("Llena todos los cmapos");
                return;
            }
            if (!EmailValido(tbAgregarEmail.Text))
            {
                MessageBox.Show("El email debe ser valido");
                return;
            }
            UsuarioController.Create(tbAgregarNombre.Text, tbAgregarEmail.Text, tbAgregarPass.Text);
            tbAgregarEmail.Text = string.Empty;
            tbAgregarNombre.Text = string.Empty;
            tbAgregarPass.Text = string.Empty;
            Filter();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (usuarios.Count == 0)
            {
                return;
            }
            if (tbShowEmail.Text == "" || tbShowNombre.Text == "")
            {
                MessageBox.Show("Llena todos los cmapos");
                return;
            }
            if (!EmailValido(tbShowEmail.Text))
            {
                MessageBox.Show("El email debe ser valido");
                return;
            }
            UsuarioController.Update(usuarios[index].Id, tbAgregarNombre.Text, tbAgregarEmail.Text, tbAgregarPass.Text);
            Filter();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            Program.formGestion = null;
            Dispose();
        }

        private void FormUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.adminForm?.Show();
        }
    }
}
