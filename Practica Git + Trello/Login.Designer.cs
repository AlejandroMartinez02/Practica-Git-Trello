
namespace Practica_Git___Trello
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
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_avanzar = new System.Windows.Forms.Button();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Logo.BackgroundImage = global::Practica_Git___Trello.Properties.Resources.logo;
            this.pb_Logo.Location = new System.Drawing.Point(80, 31);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(626, 196);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(73, 313);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(205, 39);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre de usuario:";
            // 
            // btn_avanzar
            // 
            this.btn_avanzar.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_avanzar.FlatAppearance.BorderSize = 2;
            this.btn_avanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avanzar.ForeColor = System.Drawing.Color.White;
            this.btn_avanzar.Location = new System.Drawing.Point(620, 384);
            this.btn_avanzar.Name = "btn_avanzar";
            this.btn_avanzar.Size = new System.Drawing.Size(150, 58);
            this.btn_avanzar.TabIndex = 2;
            this.btn_avanzar.Text = "¡Comencemos!";
            this.btn_avanzar.UseVisualStyleBackColor = false;
            this.btn_avanzar.Click += new System.EventHandler(this.btn_avanzar_Click);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(284, 316);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(164, 23);
            this.tb_usuario.TabIndex = 3;
            this.tb_usuario.TextChanged += new System.EventHandler(this.tb_usuario_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.btn_avanzar);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.pb_Logo);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_avanzar;
        private System.Windows.Forms.TextBox tb_usuario;
    }
}