namespace FarmaciasUwU.App.Views
{
    partial class FormAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMenu));
            label1 = new Label();
            brnUsuarios = new Button();
            btnProductos = new Button();
            btnTickets = new Button();
            pictureBox1 = new PictureBox();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 27);
            label1.Name = "label1";
            label1.Size = new Size(252, 21);
            label1.TabIndex = 0;
            label1.Text = "¿Qué deseas hacer uwu?";
            // 
            // brnUsuarios
            // 
            brnUsuarios.Location = new Point(58, 114);
            brnUsuarios.Name = "brnUsuarios";
            brnUsuarios.Size = new Size(159, 23);
            brnUsuarios.TabIndex = 1;
            brnUsuarios.Text = "Gestionar usuarios";
            brnUsuarios.UseVisualStyleBackColor = true;
            brnUsuarios.Click += brnUsuarios_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(426, 114);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(159, 23);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Gestionar productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnTickets
            // 
            btnTickets.Location = new Point(241, 195);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(159, 23);
            btnTickets.TabIndex = 3;
            btnTickets.Text = "Consultar tickets";
            btnTickets.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gatouwu;
            pictureBox1.Location = new Point(167, 246);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(568, 433);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FormAdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 468);
            Controls.Add(btnRegresar);
            Controls.Add(pictureBox1);
            Controls.Add(btnTickets);
            Controls.Add(btnProductos);
            Controls.Add(brnUsuarios);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdminMenu";
            Text = "FormAdminMenu";
            FormClosed += FormAdminMenu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button brnUsuarios;
        private Button btnProductos;
        private Button btnTickets;
        private PictureBox pictureBox1;
        private Button btnRegresar;
    }
}