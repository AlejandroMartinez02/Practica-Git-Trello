﻿
namespace Practica_Git___Trello
{
    partial class Resultado
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
        // 
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_cambiaNombre = new System.Windows.Forms.Button();
            this.principal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Top1 = new System.Windows.Forms.Label();
            this.Top2 = new System.Windows.Forms.Label();
            this.Top3 = new System.Windows.Forms.Label();
            this.Top4 = new System.Windows.Forms.Label();
            this.Top5 = new System.Windows.Forms.Label();
            this.Top6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(757, 504);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(144, 80);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "SALIR DEL JUEGO";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.cerrarJuego);
            // 
            // btn_cambiaNombre
            // 
            this.btn_cambiaNombre.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_cambiaNombre.ForeColor = System.Drawing.Color.White;
            this.btn_cambiaNombre.Location = new System.Drawing.Point(757, 380);
            this.btn_cambiaNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cambiaNombre.Name = "btn_cambiaNombre";
            this.btn_cambiaNombre.Size = new System.Drawing.Size(144, 80);
            this.btn_cambiaNombre.TabIndex = 1;
            this.btn_cambiaNombre.Text = "CAMBIAR NOMBRE";
            this.btn_cambiaNombre.UseVisualStyleBackColor = false;
            this.btn_cambiaNombre.Click += new System.EventHandler(this.cambiarNombre);
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.Color.SlateBlue;
            this.principal.ForeColor = System.Drawing.Color.White;
            this.principal.Location = new System.Drawing.Point(757, 257);
            this.principal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(144, 80);
            this.principal.TabIndex = 2;
            this.principal.Text = "REINICIAR MISMO NOMBRE";
            this.principal.UseVisualStyleBackColor = false;
            this.principal.Click += new System.EventHandler(this.reiniciar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "RESULTADOS";
            // 
            // Top1
            // 
            this.Top1.AutoSize = true;
            this.Top1.Location = new System.Drawing.Point(63, 317);
            this.Top1.Name = "Top1";
            this.Top1.Size = new System.Drawing.Size(47, 20);
            this.Top1.TabIndex = 4;
            this.Top1.Text = "TOP 1";
            // 
            // Top2
            // 
            this.Top2.AutoSize = true;
            this.Top2.Location = new System.Drawing.Point(63, 440);
            this.Top2.Name = "Top2";
            this.Top2.Size = new System.Drawing.Size(47, 20);
            this.Top2.TabIndex = 5;
            this.Top2.Text = "TOP 2";
            // 
            // Top3
            // 
            this.Top3.AutoSize = true;
            this.Top3.Location = new System.Drawing.Point(63, 564);
            this.Top3.Name = "Top3";
            this.Top3.Size = new System.Drawing.Size(47, 20);
            this.Top3.TabIndex = 6;
            this.Top3.Text = "TOP 3";
            // 
            // Top4
            // 
            this.Top4.AutoSize = true;
            this.Top4.Location = new System.Drawing.Point(403, 317);
            this.Top4.Name = "Top4";
            this.Top4.Size = new System.Drawing.Size(47, 20);
            this.Top4.TabIndex = 7;
            this.Top4.Text = "TOP 4";
            // 
            // Top5
            // 
            this.Top5.AutoSize = true;
            this.Top5.Location = new System.Drawing.Point(403, 440);
            this.Top5.Name = "Top5";
            this.Top5.Size = new System.Drawing.Size(47, 20);
            this.Top5.TabIndex = 8;
            this.Top5.Text = "TOP 5";
            // 
            // Top6
            // 
            this.Top6.AutoSize = true;
            this.Top6.Location = new System.Drawing.Point(403, 564);
            this.Top6.Name = "Top6";
            this.Top6.Size = new System.Drawing.Size(47, 20);
            this.Top6.TabIndex = 9;
            this.Top6.Text = "TOP 6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica_Git___Trello.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(153, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 196);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Top6);
            this.Controls.Add(this.Top5);
            this.Controls.Add(this.Top4);
            this.Controls.Add(this.Top3);
            this.Controls.Add(this.Top2);
            this.Controls.Add(this.Top1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.btn_cambiaNombre);
            this.Controls.Add(this.btn_Close);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Resultado";
            this.Text = "Resultado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_cambiaNombre;
        private System.Windows.Forms.Button principal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Top1;
        private System.Windows.Forms.Label Top2;
        private System.Windows.Forms.Label Top3;
        private System.Windows.Forms.Label Top4;
        private System.Windows.Forms.Label Top5;
        private System.Windows.Forms.Label Top6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}