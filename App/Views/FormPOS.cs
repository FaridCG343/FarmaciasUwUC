using FarmaciasUwU.App.Controllers;
using FarmaciasUwU.App.Models;
using FarmaciasUwU.App.Structs;
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

namespace FarmaciasUwU.Views
{
    public partial class FormPOS : Form
    {
        private List<Producto> productos;
        private Dictionary<string, ProductoStruct> carrito;
        private BindingSource carritoSource = new();
        private int index;
        private float total;
        private int contadorEspecial = 0;
        private float subTotalAnterior;
        public FormPOS()
        {
            InitializeComponent();
            productos = new();
            carrito = new();
        }

        private void FormPOS_KeyDown(object sender, KeyEventArgs e)
        {
            switch (contadorEspecial)
            {
                case 0:
                    contadorEspecial = e.KeyData == Keys.Up ? 1 : 0;
                    break;
                case 1:
                    contadorEspecial = e.KeyData == Keys.Down ? 2 : 0;
                    break;
                case 2:
                    contadorEspecial = e.KeyData == Keys.Up ? 3 : 0;
                    break;
                case 3:
                    contadorEspecial = e.KeyData == Keys.Down ? 4 : 0;
                    break;
                case 4:
                    contadorEspecial = e.KeyData == Keys.Left ? 5 : 0;
                    break;
                case 5:
                    contadorEspecial = e.KeyData == Keys.Right ? 6 : 0;
                    break;
                case 6:
                    contadorEspecial = e.KeyData == Keys.A ? 7 : 0;
                    break;
                case 7:
                    contadorEspecial = e.KeyData == Keys.B ? 8 : 0;
                    if (contadorEspecial == 8)
                    {
                        MessageBox.Show("Has activado el modo de administrador");
                        Program.adminForm ??= new();
                        Program.adminForm.Show();
                        Hide();
                    }
                    break;
            }
        }

        private void FormPOS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void SetValues()
        {
            if (productos.Count > 0)
            {
                lblProductId.Text = $"#Producto: {productos[index].Id}";
                lblProductName.Text = "Nombre: " + productos[index].Nombre;
                lblProductDes.Text = "Descripcion: " + productos[index].Descripcion;
                lblProductPrice.Text = "Precio: " + productos[index].Precio.ToString();
                using MemoryStream ms = new(productos[index].Imagen);
                pbProductImage.Image = Image.FromStream(ms);
            }
            else
            {
                lblProductId.Text = "#Producto:";
                lblProductName.Text = "Nombre: ";
                lblProductDes.Text = "Descripcion: ";
                lblProductPrice.Text = "Precio: ";
                pbProductImage.Image = null;
            }
        }
        private void Filter()
        {
            productos = ProductoController.Filter(tbBNombre.Text, tbBDescripcion.Text, float.Parse(tbBPrecioMin.Text == "" ? "0" : tbBPrecioMin.Text), float.Parse(tbBPrecioMax.Text == "" ? "0" : tbBPrecioMax.Text));
            index = 0;
            SetValues();
        }
        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            string patron = @"\d+\.?\d*";
            Regex regex = new(patron);
            TextBox tb = (TextBox)sender;
            tb.Text = regex.Match(tb.Text).Value;
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (productos.Count > 0)
            {
                tbIdProducto.Text = productos[index].Id.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (carrito.ContainsKey(tbIdProducto.Text))
            {
                total -= carrito[tbIdProducto.Text].SubTotal;
                carrito[tbIdProducto.Text].Cantidad += (int)numUDCantidad.Value;
                total += carrito[tbIdProducto.Text].SubTotal;
            }
            else
            {
                Producto? producto = ProductoController.Get(int.Parse(tbIdProducto.Text));
                if (producto == null)
                {
                    MessageBox.Show("No se encontró el producto");
                }
                else
                {
                    carrito[tbIdProducto.Text] = new(producto, (int)numUDCantidad.Value);
                    total += carrito[tbIdProducto.Text].SubTotal;
                }
            }
            lblTotal.Text = $"Total: {total}";
            tbIdProducto.Text = string.Empty;
            numUDCantidad.Value = 1;
            carritoSource.DataSource = carrito.Values.ToList();
        }

        private void FormPOS_Load(object sender, EventArgs e)
        {
            carritoSource.DataSource = carrito.Values.ToList();
            dataGridView1.DataSource = carritoSource;
            dataGridView1.Columns["Cantidad"].ReadOnly = false;
            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                if (columna.Name != "Cantidad")
                {
                    columna.ReadOnly = true;
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is ArgumentException)
            {
                MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.CancelEdit();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value > 0)
            {
                total -= subTotalAnterior;
                total += (float)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            }
            if ((int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == 0)
            {
                total -= subTotalAnterior;
                _ = carrito.Remove(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "");
                carritoSource.DataSource = carrito.Values.ToList();
            }
            lblTotal.Text = $"Total: {total}";
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            subTotalAnterior = (float)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (tbPago.Text == "" || total == 0)
            {
                return;
            }
            float pago = float.Parse(tbPago.Text);
            if (total > pago)
            {
                MessageBox.Show("El pago no puede ser menor al total");
                return;
            }
            List<object> result = TicketController.Create(Program.user.Id, total, carrito);
            Ticket ticket = (Ticket)result[0];
            List<TicketDetails> details = (List<TicketDetails>)result[1];
            string ticketInfo = $"#Ticket: {ticket.Id} \n" +
                $"Le atendió {Program.user.Nombre}\n" + // Asegúrate de verificar si ticket.Usuario es null
                $"Fecha {ticket.CreatedAt}\n" +
                $"--------------------------\n";

            foreach (TicketDetails detail in details)
            {
                Producto? producto = ProductoController.Get(detail.ProductId);
                ticketInfo += $"{producto?.Nombre}   x{detail.Cantidad}  {detail.Subtotal}\n"; // Asegúrate de verificar si detail.Producto es null
            }

            ticketInfo += $"Total: {total}\n" + $"Pago: {pago}\n" + $"Cambio {pago - total}";
            MessageBox.Show(ticketInfo);
            reiniciar();

        }

        private void tbPago_TextChanged(object sender, EventArgs e)
        {
            string patron = @"\d+\.?\d*";
            Regex regex = new(patron); 
            TextBox tb = (TextBox)sender;
            tb.Text = regex.Match(tb.Text).Value;
        }

        private void tbProducto_TextChanged(object sender, EventArgs e)
        {
            string patron = @"\d+";
            Regex regex = new(patron);
            TextBox tb = (TextBox)sender;
            tb.Text = regex.Match(tb.Text).Value;
        }

        public void reiniciar()
        {
            carrito = new();
            carritoSource.DataSource = carrito.Values.ToArray();
            total = 0;
            lblTotal.Text = $"Total: {total}";
        }
    }
}
