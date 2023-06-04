using FarmaciasUwU.App.Controllers;
using FarmaciasUwU.App.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FarmaciasUwU.App.Views
{
    public partial class FormProducto : Form
    {
        private int index = 0;
        private List<Producto> productos;
        private BindingSource bindingSourceProductos;
        public FormProducto()
        {
            InitializeComponent();
            productos = new();
            bindingSourceProductos = new BindingSource();
        }

        private void SetValues()
        {
            if (productos.Count > 0)
            {
                lblShowNumUsuario.Text = $"#Producto: {productos[index].Id}";
                tbShowNombre.Text = productos[index].Nombre;
                tbShowDes.Text = productos[index].Descripcion;
                tbShowPrecio.Text = productos[index].Precio.ToString();
                using MemoryStream ms = new MemoryStream(productos[index].Imagen);
                pbShowImg.Image = Image.FromStream(ms);
            }
            else
            {
                lblShowNumUsuario.Text = "#Producto:";
                tbShowNombre.Text = string.Empty;
                tbShowDes.Text = string.Empty;
                tbShowPrecio.Text = string.Empty;
                pbShowImg.Image = null;
            }
        }

        private void Filter()
        {
            bindingSourceProductos.DataSource = productos = ProductoController.Filter(tbBNombre.Text, tbBDescripcion.Text, float.Parse(tbBPrecioMin.Text == "" ? "0" : tbBPrecioMin.Text), float.Parse(tbBPrecioMax.Text == "" ? "0" : tbBPrecioMax.Text));
            index = 0;
            SetValues();
        }

        private void tbBNombre_TextChanged(object sender, EventArgs e)
        {
            string patron = @"\d+\.?\d*";
            Regex regex = new(patron);
            tbBPrecioMax.Text = regex.Match(tbBPrecioMax.Text).Value;
            tbBPrecioMin.Text = regex.Match(tbBPrecioMin.Text).Value;
            Filter();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            index = 0;
            SetValues();
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            index = productos.Count > 0 ? productos.Count - 1 : 0;
            SetValues();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            index = index > 0 ? index - 1 : 0;
            SetValues();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            index = index < productos.Count - 1 ? productos.Count - 1 : index;
            SetValues();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            Program.formGestion = null;
            Dispose();
        }

        private void FormProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.adminForm?.Show();
        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {
            string patron = @"\d+\.?\d*";
            Regex regex = new(patron);
            TextBox txt = (TextBox)sender;
            txt.Text = regex.Match(txt.Text).Value;
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            DialogResult dr = fileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ((PictureBox)sender).Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                return;
            }
            if (pbShowImg.Image == null || tbShowDes.Text == "" || tbShowNombre.Text == "" || tbShowPrecio.Text == "")
            {
                MessageBox.Show("Debes de rellenar todos los campos", "Atencion");
                return;
            }
            using MemoryStream ms = new();
            pbShowImg.Image.Save(ms, pbShowImg.Image.RawFormat);
            ProductoController.Update(productos[index].Id, tbShowNombre.Text, tbShowDes.Text, float.Parse(tbShowPrecio.Text), ms.ToArray());
            Filter();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            bindingSourceProductos.DataSource = productos = ProductoController.Index();
            SetValues();
            dataProductos.DataSource = bindingSourceProductos;
            dataProductos.Columns["Imagen"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (pbAgregarImg.Image == null || tbAgregarDescripcion.Text == "" || tbAgregarNombre.Text == "" || tbAgregarPrecio.Text == "")
            {
                MessageBox.Show("Debes de rellenar todos los campos", "Atencion");
                return;
            }
            using MemoryStream ms = new();
            pbAgregarImg.Image.Save(ms, pbAgregarImg.Image.RawFormat);
            ProductoController.Create(tbAgregarNombre.Text, tbAgregarDescripcion.Text, float.Parse(tbAgregarPrecio.Text), ms.ToArray());
            pbAgregarImg.Image = null;
            tbAgregarDescripcion.Text = string.Empty;
            tbAgregarNombre.Text = string.Empty;
            tbAgregarPrecio.Text = string.Empty;
            Filter();
        }
    }
}
