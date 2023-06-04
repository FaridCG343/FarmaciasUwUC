namespace FarmaciasUwU.Views
{
    partial class FormPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnSeleccionar = new Button();
            button1 = new Button();
            button2 = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            pbProductImage = new PictureBox();
            lblProductPrice = new Label();
            lblProductDes = new Label();
            lblProductName = new Label();
            lblProductId = new Label();
            tbBPrecioMax = new TextBox();
            tbBPrecioMin = new TextBox();
            tbBDescripcion = new TextBox();
            label1 = new Label();
            tbBNombre = new TextBox();
            tbIdProducto = new TextBox();
            numUDCantidad = new NumericUpDown();
            lblTotal = new Label();
            btnPagar = new Button();
            btnAgregar = new Button();
            tbPago = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 387);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(605, 362);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(btnSeleccionar);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnAnterior);
            panel2.Controls.Add(btnPrimero);
            panel2.Controls.Add(pbProductImage);
            panel2.Controls.Add(lblProductPrice);
            panel2.Controls.Add(lblProductDes);
            panel2.Controls.Add(lblProductName);
            panel2.Controls.Add(lblProductId);
            panel2.Controls.Add(tbBPrecioMax);
            panel2.Controls.Add(tbBPrecioMin);
            panel2.Controls.Add(tbBDescripcion);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbBNombre);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(634, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 561);
            panel2.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(126, 470);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(100, 25);
            btnSeleccionar.TabIndex = 15;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(288, 471);
            button1.Name = "button1";
            button1.Size = new Size(50, 25);
            button1.TabIndex = 14;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnUltimo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(232, 471);
            button2.Name = "button2";
            button2.Size = new Size(50, 25);
            button2.TabIndex = 13;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(71, 471);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(50, 25);
            btnAnterior.TabIndex = 12;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(15, 471);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(50, 25);
            btnPrimero.TabIndex = 11;
            btnPrimero.Text = "<<";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // pbProductImage
            // 
            pbProductImage.Location = new Point(236, 202);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(100, 100);
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProductImage.TabIndex = 10;
            pbProductImage.TabStop = false;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductPrice.Location = new Point(19, 313);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(64, 18);
            lblProductPrice.TabIndex = 9;
            lblProductPrice.Text = "Precio:";
            // 
            // lblProductDes
            // 
            lblProductDes.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductDes.Location = new Point(19, 370);
            lblProductDes.Name = "lblProductDes";
            lblProductDes.Size = new Size(317, 92);
            lblProductDes.TabIndex = 8;
            lblProductDes.Text = "Descripción:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(19, 259);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(72, 18);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "Nombre: ";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductId.Location = new Point(19, 202);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(96, 18);
            lblProductId.TabIndex = 6;
            lblProductId.Text = "#Producto: ";
            // 
            // tbBPrecioMax
            // 
            tbBPrecioMax.Location = new Point(188, 124);
            tbBPrecioMax.Name = "tbBPrecioMax";
            tbBPrecioMax.PlaceholderText = "PrecioMax";
            tbBPrecioMax.Size = new Size(150, 23);
            tbBPrecioMax.TabIndex = 5;
            tbBPrecioMax.TextChanged += tbBusqueda_TextChanged;
            // 
            // tbBPrecioMin
            // 
            tbBPrecioMin.Location = new Point(8, 124);
            tbBPrecioMin.Name = "tbBPrecioMin";
            tbBPrecioMin.PlaceholderText = "PrecioMin";
            tbBPrecioMin.Size = new Size(150, 23);
            tbBPrecioMin.TabIndex = 4;
            tbBPrecioMin.TextChanged += tbBusqueda_TextChanged;
            // 
            // tbBDescripcion
            // 
            tbBDescripcion.Location = new Point(188, 69);
            tbBDescripcion.Name = "tbBDescripcion";
            tbBDescripcion.PlaceholderText = "Descripcion";
            tbBDescripcion.Size = new Size(150, 23);
            tbBDescripcion.TabIndex = 3;
            tbBDescripcion.TextChanged += tbBusqueda_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(147, 12);
            label1.Name = "label1";
            label1.Size = new Size(68, 18);
            label1.TabIndex = 2;
            label1.Text = "Buscar";
            // 
            // tbBNombre
            // 
            tbBNombre.Location = new Point(8, 69);
            tbBNombre.Name = "tbBNombre";
            tbBNombre.PlaceholderText = "Nombre";
            tbBNombre.Size = new Size(150, 23);
            tbBNombre.TabIndex = 1;
            tbBNombre.TextChanged += tbBusqueda_TextChanged;
            // 
            // tbIdProducto
            // 
            tbIdProducto.Location = new Point(12, 439);
            tbIdProducto.Name = "tbIdProducto";
            tbIdProducto.PlaceholderText = "#Producto";
            tbIdProducto.Size = new Size(150, 23);
            tbIdProducto.TabIndex = 2;
            tbIdProducto.TextChanged += tbProducto_TextChanged;
            // 
            // numUDCantidad
            // 
            numUDCantidad.Location = new Point(210, 439);
            numUDCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUDCantidad.Name = "numUDCantidad";
            numUDCantidad.Size = new Size(120, 23);
            numUDCantidad.TabIndex = 3;
            numUDCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(12, 501);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 18);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: ";
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(384, 496);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 5;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(384, 439);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbPago
            // 
            tbPago.Location = new Point(210, 496);
            tbPago.Name = "tbPago";
            tbPago.Size = new Size(100, 23);
            tbPago.TabIndex = 7;
            tbPago.TextChanged += tbPago_TextChanged;
            // 
            // FormPOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(984, 561);
            Controls.Add(tbPago);
            Controls.Add(btnAgregar);
            Controls.Add(btnPagar);
            Controls.Add(lblTotal);
            Controls.Add(numUDCantidad);
            Controls.Add(tbIdProducto);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "FormPOS";
            Text = "FormPOS";
            FormClosed += FormPOS_FormClosed;
            Load += FormPOS_Load;
            KeyDown += FormPOS_KeyDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox tbBPrecioMax;
        private TextBox tbBPrecioMin;
        private TextBox tbBDescripcion;
        private Label label1;
        private TextBox tbBNombre;
        private TextBox tbIdProducto;
        private NumericUpDown numUDCantidad;
        private Label lblTotal;
        private Button btnPagar;
        private Button btnAgregar;
        private PictureBox pbProductImage;
        private Label lblProductPrice;
        private Label lblProductDes;
        private Label lblProductName;
        private Label lblProductId;
        private Button btnSeleccionar;
        private Button button1;
        private Button button2;
        private Button btnAnterior;
        private Button btnPrimero;
        private TextBox tbPago;
    }
}