﻿namespace Interfaz_del_usuario
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(470, 285);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(119, 53);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(300, 33);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(92, 31);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "LOGIN";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(371, 140);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(321, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(371, 213);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(321, 23);
            txtPass.TabIndex = 4;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Controls.Add(btnIngresar);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private PictureBox pictureBox1;
        private Label lblLogin;
        private TextBox txtUsuario;
        private TextBox txtPass;
    }
}