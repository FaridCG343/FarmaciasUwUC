namespace FarmaciasUwU.Views
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            tbUsuario = new TextBox();
            tbPassword = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(324, 150);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.PlaceholderText = "Usuario";
            tbUsuario.Size = new Size(150, 23);
            tbUsuario.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(324, 211);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(150, 23);
            tbPassword.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(356, 281);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(78, 25);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(tbPassword);
            Controls.Add(tbUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsuario;
        private TextBox tbPassword;
        private Button btnIngresar;
    }
}