
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
            this.btn_avanzar = new System.Windows.Forms.Button();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Logo.BackgroundImage = global::Practica_Git___Trello.Properties.Resources.logo;
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Logo.Location = new System.Drawing.Point(170, 101);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(466, 157);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.Click += new System.EventHandler(this.pb_Logo_Click);
            // 
            // btn_avanzar
            // 
            this.btn_avanzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btn_avanzar.FlatAppearance.BorderSize = 0;
            this.btn_avanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_avanzar.ForeColor = System.Drawing.Color.White;
            this.btn_avanzar.Location = new System.Drawing.Point(29, 76);
            this.btn_avanzar.Name = "btn_avanzar";
            this.btn_avanzar.Size = new System.Drawing.Size(236, 34);
            this.btn_avanzar.TabIndex = 2;
            this.btn_avanzar.Text = "¡Comencemos!";
            this.btn_avanzar.UseVisualStyleBackColor = false;
            this.btn_avanzar.Click += new System.EventHandler(this.btn_avanzar_Click);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_usuario.Location = new System.Drawing.Point(29, 24);
            this.tb_usuario.MaxLength = 20;
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.PlaceholderText = "¡Introduce usuario!";
            this.tb_usuario.Size = new System.Drawing.Size(236, 31);
            this.tb_usuario.TabIndex = 3;
            this.tb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btn_avanzar);
            this.panel1.Controls.Add(this.tb_usuario);
            this.panel1.Location = new System.Drawing.Point(240, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 133);
            this.panel1.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_Logo);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button btn_avanzar;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Panel panel1;
    }
}