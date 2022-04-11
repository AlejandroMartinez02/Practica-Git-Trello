
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
            this.lbl_pregunta = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_D
            // 
            this.boton_D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.boton_D.FlatAppearance.BorderSize = 0;
            this.boton_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_D.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boton_D.ForeColor = System.Drawing.SystemColors.Desktop;
            this.boton_D.Location = new System.Drawing.Point(382, 99);
            this.boton_D.Margin = new System.Windows.Forms.Padding(0);
            this.boton_D.Name = "boton_D";
            this.boton_D.Size = new System.Drawing.Size(382, 99);
            this.boton_D.TabIndex = 3;
            this.boton_D.Text = "D";
            this.boton_D.UseVisualStyleBackColor = false;
            this.boton_D.Click += new System.EventHandler(this.responder);
            // 
            // boton_C
            // 
            this.boton_C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(119)))), ((int)(((byte)(187)))));
            this.boton_C.FlatAppearance.BorderSize = 0;
            this.boton_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_C.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boton_C.ForeColor = System.Drawing.SystemColors.Desktop;
            this.boton_C.Location = new System.Drawing.Point(0, 99);
            this.boton_C.Margin = new System.Windows.Forms.Padding(0);
            this.boton_C.Name = "boton_C";
            this.boton_C.Size = new System.Drawing.Size(382, 99);
            this.boton_C.TabIndex = 2;
            this.boton_C.Text = "C";
            this.boton_C.UseVisualStyleBackColor = false;
            this.boton_C.Click += new System.EventHandler(this.responder);
            // 
            // boton_B
            // 
            this.boton_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.boton_B.FlatAppearance.BorderSize = 0;
            this.boton_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_B.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boton_B.ForeColor = System.Drawing.SystemColors.Desktop;
            this.boton_B.Location = new System.Drawing.Point(382, 0);
            this.boton_B.Margin = new System.Windows.Forms.Padding(0);
            this.boton_B.Name = "boton_B";
            this.boton_B.Size = new System.Drawing.Size(382, 99);
            this.boton_B.TabIndex = 1;
            this.boton_B.Text = "B";
            this.boton_B.UseVisualStyleBackColor = false;
            this.boton_B.Click += new System.EventHandler(this.responder);
            // 
            // boton_A
            // 
            this.boton_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(223)))), ((int)(((byte)(127)))));
            this.boton_A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boton_A.FlatAppearance.BorderSize = 0;
            this.boton_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_A.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boton_A.ForeColor = System.Drawing.SystemColors.Desktop;
            this.boton_A.Location = new System.Drawing.Point(0, 0);
            this.boton_A.Margin = new System.Windows.Forms.Padding(0);
            this.boton_A.Name = "boton_A";
            this.boton_A.Size = new System.Drawing.Size(382, 99);
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
            this.panel1.Location = new System.Drawing.Point(0, 327);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 209);
            this.panel1.TabIndex = 5;
            // 
            // lbl_pregunta
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(193)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 91);
            this.label1.TabIndex = 6;
            this.label1.Text = "1 ¿Cual es la velocidad de la luz?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.contador);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.contador2);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pregunta 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(702, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 52);
            this.label3.TabIndex = 8;
            this.label3.Text = "30";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.Location = new System.Drawing.Point(12, 112);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(17, 20);
            this.lbl_tiempo.TabIndex = 7;
            this.lbl_tiempo.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.ticks2);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "formPrincipal";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.cambiarTamanyo);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_D;
        private System.Windows.Forms.Button boton_C;
        private System.Windows.Forms.Button boton_B;
        private System.Windows.Forms.Button boton_A;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Label lbl_pregunta;
        private System.Windows.Forms.Timer timer1;
    }
}

