namespace FarmaciasUwU.App.Views
{
    partial class FormUsuarios
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
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            btnCambiarPass = new Button();
            tbShowEmail = new TextBox();
            tbShowNombre = new TextBox();
            lblShowNumUsuario = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            tbAgregarPass = new TextBox();
            label4 = new Label();
            tbAgregarEmail = new TextBox();
            tbAgregarNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataUsuarios = new DataGridView();
            tbBNombre = new TextBox();
            tbBEmail = new TextBox();
            btnRegresar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnUltimo);
            groupBox1.Controls.Add(btnSiguiente);
            groupBox1.Controls.Add(btnAnterior);
            groupBox1.Controls.Add(btnPrimero);
            groupBox1.Controls.Add(btnCambiarPass);
            groupBox1.Controls.Add(tbShowEmail);
            groupBox1.Controls.Add(tbShowNombre);
            groupBox1.Controls.Add(lblShowNumUsuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(203, 162);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(214, 218);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(50, 25);
            btnUltimo.TabIndex = 9;
            btnUltimo.Text = ">>";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(158, 218);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(50, 25);
            btnSiguiente.TabIndex = 8;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(62, 218);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(50, 25);
            btnAnterior.TabIndex = 7;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(6, 218);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(50, 25);
            btnPrimero.TabIndex = 6;
            btnPrimero.Text = "<<";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnCambiarPass
            // 
            btnCambiarPass.Location = new Point(11, 162);
            btnCambiarPass.Name = "btnCambiarPass";
            btnCambiarPass.Size = new Size(157, 23);
            btnCambiarPass.TabIndex = 5;
            btnCambiarPass.Text = "Cambiar Contraseña";
            btnCambiarPass.UseVisualStyleBackColor = true;
            // 
            // tbShowEmail
            // 
            tbShowEmail.Location = new Point(125, 121);
            tbShowEmail.Name = "tbShowEmail";
            tbShowEmail.PlaceholderText = "Email";
            tbShowEmail.Size = new Size(100, 23);
            tbShowEmail.TabIndex = 4;
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
            lblShowNumUsuario.Size = new Size(57, 15);
            lblShowNumUsuario.TabIndex = 2;
            lblShowNumUsuario.Text = "#Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 124);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
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
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(tbAgregarPass);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbAgregarEmail);
            groupBox2.Controls.Add(tbAgregarNombre);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(348, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 273);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registrar usuarios";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(106, 219);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbAgregarPass
            // 
            tbAgregarPass.Location = new Point(154, 162);
            tbAgregarPass.Name = "tbAgregarPass";
            tbAgregarPass.PasswordChar = '*';
            tbAgregarPass.PlaceholderText = "Contraseña";
            tbAgregarPass.Size = new Size(100, 23);
            tbAgregarPass.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 165);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 5;
            label4.Text = "Contraseña";
            // 
            // tbAgregarEmail
            // 
            tbAgregarEmail.Location = new Point(154, 118);
            tbAgregarEmail.Name = "tbAgregarEmail";
            tbAgregarEmail.PlaceholderText = "Email";
            tbAgregarEmail.Size = new Size(100, 23);
            tbAgregarEmail.TabIndex = 4;
            // 
            // tbAgregarNombre
            // 
            tbAgregarNombre.Location = new Point(154, 71);
            tbAgregarNombre.Name = "tbAgregarNombre";
            tbAgregarNombre.PlaceholderText = "Nombre";
            tbAgregarNombre.Size = new Size(100, 23);
            tbAgregarNombre.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 121);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 74);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 0;
            label6.Text = "Nombre";
            // 
            // dataUsuarios
            // 
            dataUsuarios.AllowUserToAddRows = false;
            dataUsuarios.AllowUserToDeleteRows = false;
            dataUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsuarios.Location = new Point(12, 366);
            dataUsuarios.Name = "dataUsuarios";
            dataUsuarios.ReadOnly = true;
            dataUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataUsuarios.RowTemplate.Height = 25;
            dataUsuarios.Size = new Size(419, 173);
            dataUsuarios.TabIndex = 7;
            // 
            // tbBNombre
            // 
            tbBNombre.Location = new Point(30, 316);
            tbBNombre.Name = "tbBNombre";
            tbBNombre.PlaceholderText = "Nombre";
            tbBNombre.Size = new Size(150, 23);
            tbBNombre.TabIndex = 8;
            tbBNombre.TextChanged += tbBNombre_TextChanged;
            // 
            // tbBEmail
            // 
            tbBEmail.Location = new Point(215, 316);
            tbBEmail.Name = "tbBEmail";
            tbBEmail.PlaceholderText = "Email";
            tbBEmail.Size = new Size(150, 23);
            tbBEmail.TabIndex = 9;
            tbBEmail.TextChanged += tbBNombre_TextChanged;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(484, 316);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 551);
            Controls.Add(btnRegresar);
            Controls.Add(tbBEmail);
            Controls.Add(tbBNombre);
            Controls.Add(dataUsuarios);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            FormClosed += FormUsuarios_FormClosed;
            Load += FormUsuarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbShowEmail;
        private TextBox tbShowNombre;
        private Label lblShowNumUsuario;
        private Label label2;
        private Label label1;
        private Button btnCambiarPass;
        private GroupBox groupBox2;
        private TextBox tbAgregarPass;
        private Label label4;
        private TextBox tbAgregarEmail;
        private TextBox tbAgregarNombre;
        private Label label5;
        private Label label6;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private Button btnAgregar;
        private DataGridView dataUsuarios;
        private TextBox tbBNombre;
        private TextBox tbBEmail;
        private Button btnGuardar;
        private Button btnRegresar;
    }
}