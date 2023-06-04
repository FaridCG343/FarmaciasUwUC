namespace FarmaciasUwU.App.Views
{
    partial class FormProducto
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
            btnRegresar = new Button();
            tbBPrecioMin = new TextBox();
            tbBNombre = new TextBox();
            dataProductos = new DataGridView();
            groupBox1 = new GroupBox();
            pbShowImg = new PictureBox();
            tbShowPrecio = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            tbShowDes = new TextBox();
            tbShowNombre = new TextBox();
            lblShowNumUsuario = new Label();
            lblDescripcion = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pbAgregarImg = new PictureBox();
            tbAgregarPrecio = new TextBox();
            label3 = new Label();
            btnAgregar = new Button();
            tbAgregarDescripcion = new TextBox();
            tbAgregarNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbBDescripcion = new TextBox();
            tbBPrecioMax = new TextBox();
            fileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataProductos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowImg).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAgregarImg).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(767, 374);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 16;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // tbBPrecioMin
            // 
            tbBPrecioMin.Location = new Point(474, 374);
            tbBPrecioMin.Name = "tbBPrecioMin";
            tbBPrecioMin.PlaceholderText = "PrecioMin";
            tbBPrecioMin.Size = new Size(119, 23);
            tbBPrecioMin.TabIndex = 15;
            tbBPrecioMin.TextChanged += tbBNombre_TextChanged;
            // 
            // tbBNombre
            // 
            tbBNombre.Location = new Point(41, 374);
            tbBNombre.Name = "tbBNombre";
            tbBNombre.PlaceholderText = "Nombre";
            tbBNombre.Size = new Size(150, 23);
            tbBNombre.TabIndex = 14;
            tbBNombre.TextChanged += tbBNombre_TextChanged;
            // 
            // dataProductos
            // 
            dataProductos.AllowUserToAddRows = false;
            dataProductos.AllowUserToDeleteRows = false;
            dataProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProductos.Location = new Point(23, 424);
            dataProductos.Name = "dataProductos";
            dataProductos.ReadOnly = true;
            dataProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataProductos.RowTemplate.Height = 25;
            dataProductos.Size = new Size(431, 173);
            dataProductos.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbShowImg);
            groupBox1.Controls.Add(tbShowPrecio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnUltimo);
            groupBox1.Controls.Add(btnSiguiente);
            groupBox1.Controls.Add(btnAnterior);
            groupBox1.Controls.Add(btnPrimero);
            groupBox1.Controls.Add(tbShowDes);
            groupBox1.Controls.Add(tbShowNombre);
            groupBox1.Controls.Add(lblShowNumUsuario);
            groupBox1.Controls.Add(lblDescripcion);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 295);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // pbShowImg
            // 
            pbShowImg.BackColor = Color.FromArgb(224, 224, 224);
            pbShowImg.Location = new Point(293, 22);
            pbShowImg.Name = "pbShowImg";
            pbShowImg.Size = new Size(75, 75);
            pbShowImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbShowImg.TabIndex = 12;
            pbShowImg.TabStop = false;
            pbShowImg.Click += pbImage_Click;
            // 
            // tbShowPrecio
            // 
            tbShowPrecio.Location = new Point(125, 190);
            tbShowPrecio.Name = "tbShowPrecio";
            tbShowPrecio.PlaceholderText = "Precio";
            tbShowPrecio.Size = new Size(100, 23);
            tbShowPrecio.TabIndex = 11;
            tbShowPrecio.TextChanged += tbPrecio_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 193);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Precio";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(293, 193);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(265, 246);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(50, 25);
            btnUltimo.TabIndex = 9;
            btnUltimo.Text = ">>";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(209, 246);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(50, 25);
            btnSiguiente.TabIndex = 8;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(113, 246);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(50, 25);
            btnAnterior.TabIndex = 7;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(57, 246);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(50, 25);
            btnPrimero.TabIndex = 6;
            btnPrimero.Text = "<<";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // tbShowDes
            // 
            tbShowDes.Location = new Point(125, 121);
            tbShowDes.Multiline = true;
            tbShowDes.Name = "tbShowDes";
            tbShowDes.PlaceholderText = "Descripcion";
            tbShowDes.Size = new Size(243, 54);
            tbShowDes.TabIndex = 4;
            // 
            // tbShowNombre
            // 
            tbShowNombre.Location = new Point(125, 74);
            tbShowNombre.Name = "tbShowNombre";
            tbShowNombre.PlaceholderText = "Nombre";
            tbShowNombre.Size = new Size(100, 23);
            tbShowNombre.TabIndex = 3;
            // 
            // lblShowNumUsuario
            // 
            lblShowNumUsuario.AutoSize = true;
            lblShowNumUsuario.Location = new Point(18, 37);
            lblShowNumUsuario.Name = "lblShowNumUsuario";
            lblShowNumUsuario.Size = new Size(66, 15);
            lblShowNumUsuario.TabIndex = 2;
            lblShowNumUsuario.Text = "#Producto:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(18, 124);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 77);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pbAgregarImg);
            groupBox2.Controls.Add(tbAgregarPrecio);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(tbAgregarDescripcion);
            groupBox2.Controls.Add(tbAgregarNombre);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(474, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 295);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar productos";
            // 
            // pbAgregarImg
            // 
            pbAgregarImg.BackColor = Color.FromArgb(224, 224, 224);
            pbAgregarImg.Location = new Point(293, 22);
            pbAgregarImg.Name = "pbAgregarImg";
            pbAgregarImg.Size = new Size(75, 75);
            pbAgregarImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAgregarImg.TabIndex = 12;
            pbAgregarImg.TabStop = false;
            pbAgregarImg.Click += pbImage_Click;
            // 
            // tbAgregarPrecio
            // 
            tbAgregarPrecio.Location = new Point(125, 190);
            tbAgregarPrecio.Name = "tbAgregarPrecio";
            tbAgregarPrecio.PlaceholderText = "Precio";
            tbAgregarPrecio.Size = new Size(100, 23);
            tbAgregarPrecio.TabIndex = 11;
            tbAgregarPrecio.TextChanged += tbPrecio_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 193);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "Precio";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(293, 193);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbAgregarDescripcion
            // 
            tbAgregarDescripcion.Location = new Point(125, 121);
            tbAgregarDescripcion.Multiline = true;
            tbAgregarDescripcion.Name = "tbAgregarDescripcion";
            tbAgregarDescripcion.PlaceholderText = "Descripcion";
            tbAgregarDescripcion.Size = new Size(243, 54);
            tbAgregarDescripcion.TabIndex = 4;
            // 
            // tbAgregarNombre
            // 
            tbAgregarNombre.Location = new Point(125, 74);
            tbAgregarNombre.Name = "tbAgregarNombre";
            tbAgregarNombre.PlaceholderText = "Nombre";
            tbAgregarNombre.Size = new Size(100, 23);
            tbAgregarNombre.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 124);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 1;
            label5.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 77);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 0;
            label6.Text = "Nombre";
            // 
            // tbBDescripcion
            // 
            tbBDescripcion.Location = new Point(197, 375);
            tbBDescripcion.Name = "tbBDescripcion";
            tbBDescripcion.PlaceholderText = "Descripcion";
            tbBDescripcion.Size = new Size(271, 23);
            tbBDescripcion.TabIndex = 17;
            tbBDescripcion.TextChanged += tbBNombre_TextChanged;
            // 
            // tbBPrecioMax
            // 
            tbBPrecioMax.Location = new Point(599, 374);
            tbBPrecioMax.Name = "tbBPrecioMax";
            tbBPrecioMax.PlaceholderText = "PrecioMax";
            tbBPrecioMax.Size = new Size(116, 23);
            tbBPrecioMax.TabIndex = 18;
            tbBPrecioMax.TextChanged += tbBNombre_TextChanged;
            // 
            // fileDialog
            // 
            fileDialog.FileName = "openFileDialog1";
            fileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 616);
            Controls.Add(tbBPrecioMax);
            Controls.Add(tbBDescripcion);
            Controls.Add(groupBox2);
            Controls.Add(btnRegresar);
            Controls.Add(tbBPrecioMin);
            Controls.Add(tbBNombre);
            Controls.Add(dataProductos);
            Controls.Add(groupBox1);
            Name = "FormProducto";
            Text = "FormProducto";
            FormClosed += FormProducto_FormClosed;
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowImg).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAgregarImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private TextBox tbBPrecioMin;
        private TextBox tbBNombre;
        private DataGridView dataProductos;
        private GroupBox groupBox1;
        private Button btnGuardar;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private TextBox tbShowDes;
        private TextBox tbShowNombre;
        private Label lblShowNumUsuario;
        private Label lblDescripcion;
        private Label label1;
        private TextBox tbShowPrecio;
        private Label label2;
        private PictureBox pbShowImg;
        private GroupBox groupBox2;
        private PictureBox pbAgregarImg;
        private TextBox tbAgregarPrecio;
        private Label label3;
        private Button btnAgregar;
        private TextBox tbAgregarDescripcion;
        private TextBox tbAgregarNombre;
        private Label label5;
        private Label label6;
        private TextBox tbBDescripcion;
        private TextBox tbBPrecioMax;
        private OpenFileDialog fileDialog;
    }
}