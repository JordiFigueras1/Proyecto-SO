namespace Cliente_versión_1
{
    partial class Form1
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
            this.Peticion = new System.Windows.Forms.GroupBox();
            this.Iniciar_sesion = new System.Windows.Forms.Button();
            this.Registro = new System.Windows.Forms.Button();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Partidas_en_comun = new System.Windows.Forms.Button();
            this.partidas_ganadas = new System.Windows.Forms.Button();
            this.Partida_mas_larga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jugador1 = new System.Windows.Forms.TextBox();
            this.jugador2 = new System.Windows.Forms.TextBox();
            this.Conectar = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.Peticion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Peticion
            // 
            this.Peticion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Peticion.Controls.Add(this.Iniciar_sesion);
            this.Peticion.Controls.Add(this.Registro);
            this.Peticion.Controls.Add(this.contraseña);
            this.Peticion.Controls.Add(this.nombre);
            this.Peticion.Controls.Add(this.label2);
            this.Peticion.Controls.Add(this.label1);
            this.Peticion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peticion.Location = new System.Drawing.Point(298, 100);
            this.Peticion.Name = "Peticion";
            this.Peticion.Size = new System.Drawing.Size(262, 184);
            this.Peticion.TabIndex = 0;
            this.Peticion.TabStop = false;
            this.Peticion.Text = "Petición";
            // 
            // Iniciar_sesion
            // 
            this.Iniciar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciar_sesion.Location = new System.Drawing.Point(134, 120);
            this.Iniciar_sesion.Name = "Iniciar_sesion";
            this.Iniciar_sesion.Size = new System.Drawing.Size(98, 33);
            this.Iniciar_sesion.TabIndex = 12;
            this.Iniciar_sesion.Text = "Iniciar sesión";
            this.Iniciar_sesion.UseVisualStyleBackColor = true;
            this.Iniciar_sesion.Click += new System.EventHandler(this.Iniciar_sesion_Click);
            // 
            // Registro
            // 
            this.Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.Location = new System.Drawing.Point(33, 120);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(95, 33);
            this.Registro.TabIndex = 11;
            this.Registro.Text = "Registrarse";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(134, 77);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(111, 21);
            this.contraseña.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(134, 46);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(111, 21);
            this.nombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.Partidas_en_comun);
            this.groupBox2.Controls.Add(this.partidas_ganadas);
            this.groupBox2.Controls.Add(this.Partida_mas_larga);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas";
            // 
            // Partidas_en_comun
            // 
            this.Partidas_en_comun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partidas_en_comun.Location = new System.Drawing.Point(21, 138);
            this.Partidas_en_comun.Name = "Partidas_en_comun";
            this.Partidas_en_comun.Size = new System.Drawing.Size(147, 29);
            this.Partidas_en_comun.TabIndex = 10;
            this.Partidas_en_comun.Text = "Partidas en común";
            this.Partidas_en_comun.UseVisualStyleBackColor = true;
            this.Partidas_en_comun.Click += new System.EventHandler(this.Partidas_en_comun_Click);
            // 
            // partidas_ganadas
            // 
            this.partidas_ganadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partidas_ganadas.Location = new System.Drawing.Point(21, 88);
            this.partidas_ganadas.Name = "partidas_ganadas";
            this.partidas_ganadas.Size = new System.Drawing.Size(147, 35);
            this.partidas_ganadas.TabIndex = 9;
            this.partidas_ganadas.Text = "Partidas ganadas";
            this.partidas_ganadas.UseVisualStyleBackColor = true;
            this.partidas_ganadas.Click += new System.EventHandler(this.partidas_ganadas_Click);
            // 
            // Partida_mas_larga
            // 
            this.Partida_mas_larga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partida_mas_larga.Location = new System.Drawing.Point(21, 44);
            this.Partida_mas_larga.Name = "Partida_mas_larga";
            this.Partida_mas_larga.Size = new System.Drawing.Size(147, 29);
            this.Partida_mas_larga.TabIndex = 8;
            this.Partida_mas_larga.Text = "Partida más larga";
            this.Partida_mas_larga.UseVisualStyleBackColor = true;
            this.Partida_mas_larga.Click += new System.EventHandler(this.Partida_mas_larga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jugador1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jugador2";
            // 
            // jugador1
            // 
            this.jugador1.Location = new System.Drawing.Point(419, 30);
            this.jugador1.Name = "jugador1";
            this.jugador1.Size = new System.Drawing.Size(111, 20);
            this.jugador1.TabIndex = 4;
            // 
            // jugador2
            // 
            this.jugador2.Location = new System.Drawing.Point(419, 56);
            this.jugador2.Name = "jugador2";
            this.jugador2.Size = new System.Drawing.Size(111, 20);
            this.jugador2.TabIndex = 5;
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(30, 23);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(86, 27);
            this.Conectar.TabIndex = 6;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(138, 23);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(92, 27);
            this.Desconectar.TabIndex = 7;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 296);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.jugador2);
            this.Controls.Add(this.jugador1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Peticion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Peticion.ResumeLayout(false);
            this.Peticion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Peticion;
        private System.Windows.Forms.Button Iniciar_sesion;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Partidas_en_comun;
        private System.Windows.Forms.Button partidas_ganadas;
        private System.Windows.Forms.Button Partida_mas_larga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jugador1;
        private System.Windows.Forms.TextBox jugador2;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Desconectar;
    }
}

