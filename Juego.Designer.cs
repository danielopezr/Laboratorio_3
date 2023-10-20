namespace Laboratorio_3
{
    partial class JuegoForm
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
            this.btnCorreos = new System.Windows.Forms.Button();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelNumFrecEndulzadas = new System.Windows.Forms.Label();
            this.labelValEndulzada = new System.Windows.Forms.Label();
            this.labelValRegalo = new System.Windows.Forms.Label();
            this.btnGustos = new System.Windows.Forms.Button();
            this.btnProxEndulzada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateProxEndulzada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCorreos
            // 
            this.btnCorreos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCorreos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorreos.Location = new System.Drawing.Point(441, 423);
            this.btnCorreos.Name = "btnCorreos";
            this.btnCorreos.Size = new System.Drawing.Size(251, 54);
            this.btnCorreos.TabIndex = 0;
            this.btnCorreos.Text = "Correos Enviados";
            this.btnCorreos.UseVisualStyleBackColor = false;
            this.btnCorreos.Click += new System.EventHandler(this.btnCorreos_Click);
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(216, 117);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(108, 20);
            this.labelFechaInicio.TabIndex = 1;
            this.labelFechaInicio.Text = "Fecha de Inicio";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.Location = new System.Drawing.Point(216, 153);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(94, 20);
            this.labelFechaFin.TabIndex = 2;
            this.labelFechaFin.Text = "Fecha de Fin";
            // 
            // labelNumFrecEndulzadas
            // 
            this.labelNumFrecEndulzadas.AutoSize = true;
            this.labelNumFrecEndulzadas.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumFrecEndulzadas.Location = new System.Drawing.Point(65, 280);
            this.labelNumFrecEndulzadas.Name = "labelNumFrecEndulzadas";
            this.labelNumFrecEndulzadas.Size = new System.Drawing.Size(259, 20);
            this.labelNumFrecEndulzadas.TabIndex = 4;
            this.labelNumFrecEndulzadas.Text = "Cantidad y Frecuencia de Endulzadas";
            // 
            // labelValEndulzada
            // 
            this.labelValEndulzada.AutoSize = true;
            this.labelValEndulzada.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValEndulzada.Location = new System.Drawing.Point(179, 427);
            this.labelValEndulzada.Name = "labelValEndulzada";
            this.labelValEndulzada.Size = new System.Drawing.Size(158, 20);
            this.labelValEndulzada.TabIndex = 5;
            this.labelValEndulzada.Text = "Valor de la Endulzada";
            // 
            // labelValRegalo
            // 
            this.labelValRegalo.AutoSize = true;
            this.labelValRegalo.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValRegalo.Location = new System.Drawing.Point(179, 462);
            this.labelValRegalo.Name = "labelValRegalo";
            this.labelValRegalo.Size = new System.Drawing.Size(120, 20);
            this.labelValRegalo.TabIndex = 6;
            this.labelValRegalo.Text = "Valor del Regalo";
            // 
            // btnGustos
            // 
            this.btnGustos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGustos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGustos.Location = new System.Drawing.Point(441, 338);
            this.btnGustos.Name = "btnGustos";
            this.btnGustos.Size = new System.Drawing.Size(251, 56);
            this.btnGustos.TabIndex = 7;
            this.btnGustos.Text = "Gustos de los Jugadores";
            this.btnGustos.UseVisualStyleBackColor = false;
            this.btnGustos.Click += new System.EventHandler(this.btnGustos_Click);
            // 
            // btnProxEndulzada
            // 
            this.btnProxEndulzada.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnProxEndulzada.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxEndulzada.Location = new System.Drawing.Point(521, 268);
            this.btnProxEndulzada.Name = "btnProxEndulzada";
            this.btnProxEndulzada.Size = new System.Drawing.Size(79, 29);
            this.btnProxEndulzada.TabIndex = 8;
            this.btnProxEndulzada.Text = "Enviar";
            this.btnProxEndulzada.UseVisualStyleBackColor = false;
            this.btnProxEndulzada.Click += new System.EventHandler(this.btnProxEndulzada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Duración del Juego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de Fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Endulzadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Costo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Endulzada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Regalo:";
            // 
            // dateProxEndulzada
            // 
            this.dateProxEndulzada.CalendarFont = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateProxEndulzada.CustomFormat = "dd/MM/yyyy";
            this.dateProxEndulzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateProxEndulzada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateProxEndulzada.Location = new System.Drawing.Point(498, 235);
            this.dateProxEndulzada.Name = "dateProxEndulzada";
            this.dateProxEndulzada.Size = new System.Drawing.Size(127, 27);
            this.dateProxEndulzada.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Próxima Endulzada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ingrese la Fecha Actual:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(451, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "(Solo abrir si no participa en el juego)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Papyrus", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(412, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(299, 122);
            this.label11.TabIndex = 20;
            this.label11.Text = "AMIGO?\r\nSECRETO";
            // 
            // JuegoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateProxEndulzada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProxEndulzada);
            this.Controls.Add(this.btnGustos);
            this.Controls.Add(this.labelValRegalo);
            this.Controls.Add(this.labelValEndulzada);
            this.Controls.Add(this.labelNumFrecEndulzadas);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.btnCorreos);
            this.Name = "JuegoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorreos;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelNumFrecEndulzadas;
        private System.Windows.Forms.Label labelValEndulzada;
        private System.Windows.Forms.Label labelValRegalo;
        private System.Windows.Forms.Button btnGustos;
        private System.Windows.Forms.Button btnProxEndulzada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateProxEndulzada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}