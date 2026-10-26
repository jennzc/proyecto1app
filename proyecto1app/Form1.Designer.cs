namespace proyecto1app
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnivel = new System.Windows.Forms.Label();
            this.laciertos = new System.Windows.Forms.Label();
            this.lerrores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tnombre2 = new System.Windows.Forms.TextBox();
            this.biniciar = new System.Windows.Forms.Button();
            this.tnombre = new System.Windows.Forms.TextBox();
            this.rdosjugadores = new System.Windows.Forms.RadioButton();
            this.rindividual = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bverificar = new System.Windows.Forms.Button();
            this.trespuesta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lnum2 = new System.Windows.Forms.Label();
            this.loperador = new System.Windows.Forms.Label();
            this.lnum1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lstestadisticas = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(391, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juego de Números";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lnivel);
            this.panel2.Controls.Add(this.laciertos);
            this.panel2.Controls.Add(this.lerrores);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(982, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 258);
            this.panel2.TabIndex = 1;
            // 
            // lnivel
            // 
            this.lnivel.AutoSize = true;
            this.lnivel.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnivel.Location = new System.Drawing.Point(68, 14);
            this.lnivel.Name = "lnivel";
            this.lnivel.Size = new System.Drawing.Size(20, 20);
            this.lnivel.TabIndex = 7;
            this.lnivel.Text = "0";
            // 
            // laciertos
            // 
            this.laciertos.AutoSize = true;
            this.laciertos.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laciertos.Location = new System.Drawing.Point(98, 62);
            this.laciertos.Name = "laciertos";
            this.laciertos.Size = new System.Drawing.Size(20, 20);
            this.laciertos.TabIndex = 6;
            this.laciertos.Text = "0";
            // 
            // lerrores
            // 
            this.lerrores.AutoSize = true;
            this.lerrores.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lerrores.Location = new System.Drawing.Point(94, 107);
            this.lerrores.Name = "lerrores";
            this.lerrores.Size = new System.Drawing.Size(20, 20);
            this.lerrores.TabIndex = 5;
            this.lerrores.Text = "0";
            this.lerrores.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Errores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aciertos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nivel:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tnombre2);
            this.panel3.Controls.Add(this.biniciar);
            this.panel3.Controls.Add(this.tnombre);
            this.panel3.Controls.Add(this.rdosjugadores);
            this.panel3.Controls.Add(this.rindividual);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 143);
            this.panel3.TabIndex = 2;
            // 
            // tnombre2
            // 
            this.tnombre2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tnombre2.Location = new System.Drawing.Point(340, 14);
            this.tnombre2.Name = "tnombre2";
            this.tnombre2.Size = new System.Drawing.Size(129, 22);
            this.tnombre2.TabIndex = 15;
            // 
            // biniciar
            // 
            this.biniciar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.biniciar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biniciar.Location = new System.Drawing.Point(16, 97);
            this.biniciar.Name = "biniciar";
            this.biniciar.Size = new System.Drawing.Size(110, 30);
            this.biniciar.TabIndex = 14;
            this.biniciar.Text = "Iniciar";
            this.biniciar.UseVisualStyleBackColor = false;
            this.biniciar.Click += new System.EventHandler(this.biniciar_Click);
            // 
            // tnombre
            // 
            this.tnombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tnombre.Location = new System.Drawing.Point(194, 12);
            this.tnombre.Name = "tnombre";
            this.tnombre.Size = new System.Drawing.Size(129, 22);
            this.tnombre.TabIndex = 1;
            // 
            // rdosjugadores
            // 
            this.rdosjugadores.AutoSize = true;
            this.rdosjugadores.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdosjugadores.Location = new System.Drawing.Point(16, 62);
            this.rdosjugadores.Name = "rdosjugadores";
            this.rdosjugadores.Size = new System.Drawing.Size(102, 21);
            this.rdosjugadores.TabIndex = 3;
            this.rdosjugadores.TabStop = true;
            this.rdosjugadores.Text = "2 Jugadores";
            this.rdosjugadores.UseVisualStyleBackColor = true;
            // 
            // rindividual
            // 
            this.rindividual.AutoSize = true;
            this.rindividual.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rindividual.Location = new System.Drawing.Point(16, 36);
            this.rindividual.Name = "rindividual";
            this.rindividual.Size = new System.Drawing.Size(93, 21);
            this.rindividual.TabIndex = 2;
            this.rindividual.TabStop = true;
            this.rindividual.Text = "Individual";
            this.rindividual.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del Jugador:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.bverificar);
            this.panel4.Controls.Add(this.trespuesta);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lnum2);
            this.panel4.Controls.Add(this.loperador);
            this.panel4.Controls.Add(this.lnum1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(13, 286);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(948, 370);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // bverificar
            // 
            this.bverificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bverificar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bverificar.Location = new System.Drawing.Point(19, 210);
            this.bverificar.Name = "bverificar";
            this.bverificar.Size = new System.Drawing.Size(166, 46);
            this.bverificar.TabIndex = 13;
            this.bverificar.Text = "Verificar";
            this.bverificar.UseVisualStyleBackColor = false;
            this.bverificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // trespuesta
            // 
            this.trespuesta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trespuesta.Location = new System.Drawing.Point(19, 164);
            this.trespuesta.Name = "trespuesta";
            this.trespuesta.Size = new System.Drawing.Size(166, 22);
            this.trespuesta.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Digite su respuesta:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(335, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "?";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(307, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "=";
            // 
            // lnum2
            // 
            this.lnum2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lnum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnum2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnum2.Location = new System.Drawing.Point(211, 69);
            this.lnum2.Name = "lnum2";
            this.lnum2.Size = new System.Drawing.Size(90, 26);
            this.lnum2.TabIndex = 8;
            // 
            // loperador
            // 
            this.loperador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loperador.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loperador.Location = new System.Drawing.Point(115, 69);
            this.loperador.Name = "loperador";
            this.loperador.Size = new System.Drawing.Size(90, 26);
            this.loperador.TabIndex = 7;
            // 
            // lnum1
            // 
            this.lnum1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lnum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnum1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnum1.Location = new System.Drawing.Point(19, 69);
            this.lnum1.Name = "lnum1";
            this.lnum1.Size = new System.Drawing.Size(90, 26);
            this.lnum1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Operación:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lstestadisticas);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(982, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 258);
            this.panel5.TabIndex = 2;
            // 
            // lstestadisticas
            // 
            this.lstestadisticas.BackColor = System.Drawing.Color.White;
            this.lstestadisticas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstestadisticas.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstestadisticas.FormattingEnabled = true;
            this.lstestadisticas.ItemHeight = 20;
            this.lstestadisticas.Location = new System.Drawing.Point(16, 52);
            this.lstestadisticas.Name = "lstestadisticas";
            this.lstestadisticas.Size = new System.Drawing.Size(167, 180);
            this.lstestadisticas.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estadísticas:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 668);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Proyecto 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdosjugadores;
        private System.Windows.Forms.RadioButton rindividual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lerrores;
        private System.Windows.Forms.Label lnivel;
        private System.Windows.Forms.Label laciertos;
        private System.Windows.Forms.Label lnum2;
        private System.Windows.Forms.Label loperador;
        private System.Windows.Forms.Label lnum1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox trespuesta;
        private System.Windows.Forms.Button bverificar;
        private System.Windows.Forms.Button biniciar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstestadisticas;
        private System.Windows.Forms.TextBox tnombre2;
    }
}

