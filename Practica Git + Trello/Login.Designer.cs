﻿
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_avanzar = new System.Windows.Forms.Button();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica_Git___Trello.Properties.Resources.kahoot1;
            this.pictureBox1.Location = new System.Drawing.Point(158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(55, 378);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(237, 39);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre de usuario:";
            // 
            // btn_avanzar
            // 
            this.btn_avanzar.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_avanzar.FlatAppearance.BorderSize = 2;
            this.btn_avanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avanzar.ForeColor = System.Drawing.Color.White;
            this.btn_avanzar.Location = new System.Drawing.Point(655, 492);
            this.btn_avanzar.Name = "btn_avanzar";
            this.btn_avanzar.Size = new System.Drawing.Size(133, 58);
            this.btn_avanzar.TabIndex = 2;
            this.btn_avanzar.Text = "¡Comencemos!";
            this.btn_avanzar.UseVisualStyleBackColor = false;
            this.btn_avanzar.Click += new System.EventHandler(this.btn_avanzar_Click);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(285, 384);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(146, 27);
            this.tb_usuario.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.btn_avanzar);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_avanzar;
        private System.Windows.Forms.TextBox tb_usuario;
    }
}