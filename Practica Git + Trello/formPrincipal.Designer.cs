
namespace Practica_Git___Trello
{
    partial class formPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.boton_D = new System.Windows.Forms.Button();
            this.boton_C = new System.Windows.Forms.Button();
            this.boton_B = new System.Windows.Forms.Button();
            this.boton_A = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_D
            // 
            this.boton_D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_D.FlatAppearance.BorderSize = 0;
            this.boton_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_D.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boton_D.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boton_D.Location = new System.Drawing.Point(334, 74);
            this.boton_D.Margin = new System.Windows.Forms.Padding(0);
            this.boton_D.Name = "boton_D";
            this.boton_D.Size = new System.Drawing.Size(334, 74);
            this.boton_D.TabIndex = 3;
            this.boton_D.Text = "D";
            this.boton_D.UseVisualStyleBackColor = false;
            // 
            // boton_C
            // 
            this.boton_C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_C.BackColor = System.Drawing.Color.Yellow;
            this.boton_C.FlatAppearance.BorderSize = 0;
            this.boton_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_C.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boton_C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boton_C.Location = new System.Drawing.Point(0, 74);
            this.boton_C.Margin = new System.Windows.Forms.Padding(0);
            this.boton_C.Name = "boton_C";
            this.boton_C.Size = new System.Drawing.Size(334, 74);
            this.boton_C.TabIndex = 2;
            this.boton_C.Text = "C";
            this.boton_C.UseVisualStyleBackColor = false;
            // 
            // boton_B
            // 
            this.boton_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.boton_B.FlatAppearance.BorderSize = 0;
            this.boton_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_B.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boton_B.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boton_B.Location = new System.Drawing.Point(334, 0);
            this.boton_B.Margin = new System.Windows.Forms.Padding(0);
            this.boton_B.Name = "boton_B";
            this.boton_B.Size = new System.Drawing.Size(334, 74);
            this.boton_B.TabIndex = 1;
            this.boton_B.Text = "B";
            this.boton_B.UseVisualStyleBackColor = false;
            this.boton_B.Click += new System.EventHandler(this.boton_B_Click);
            // 
            // boton_A
            // 
            this.boton_A.BackColor = System.Drawing.Color.Brown;
            this.boton_A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boton_A.FlatAppearance.BorderSize = 0;
            this.boton_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_A.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boton_A.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boton_A.Location = new System.Drawing.Point(0, 0);
            this.boton_A.Margin = new System.Windows.Forms.Padding(0);
            this.boton_A.Name = "boton_A";
            this.boton_A.Size = new System.Drawing.Size(334, 74);
            this.boton_A.TabIndex = 0;
            this.boton_A.Text = "A";
            this.boton_A.UseVisualStyleBackColor = false;
            this.boton_A.Click += new System.EventHandler(this.boton_A_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.boton_A);
            this.panel1.Controls.Add(this.boton_C);
            this.panel1.Controls.Add(this.boton_B);
            this.panel1.Controls.Add(this.boton_D);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 157);
            this.panel1.TabIndex = 5;
            this.panel1.SizeChanged += new System.EventHandler(this.CambioTamaño);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 68);
            this.label1.TabIndex = 6;
            this.label1.Text = "1 ¿Cual es la velocidad de la luz?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.ticks);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_D;
        private System.Windows.Forms.Button boton_C;
        private System.Windows.Forms.Button boton_B;
        private System.Windows.Forms.Button boton_A;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

