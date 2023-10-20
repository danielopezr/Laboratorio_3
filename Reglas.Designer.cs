namespace Laboratorio_3
{
    partial class ReglasForm
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
            this.txtValEndulzada = new System.Windows.Forms.TextBox();
            this.txtValRegalo = new System.Windows.Forms.TextBox();
            this.btnSiguiente1 = new System.Windows.Forms.Button();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.numericCantJugadores = new System.Windows.Forms.NumericUpDown();
            this.numericNumEndulzadas = new System.Windows.Forms.NumericUpDown();
            this.numericFrecEndulzadas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumEndulzadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrecEndulzadas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValEndulzada
            // 
            this.txtValEndulzada.Location = new System.Drawing.Point(437, 377);
            this.txtValEndulzada.Name = "txtValEndulzada";
            this.txtValEndulzada.Size = new System.Drawing.Size(120, 22);
            this.txtValEndulzada.TabIndex = 4;
            this.txtValEndulzada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValEndulzada_KeyPress);
            // 
            // txtValRegalo
            // 
            this.txtValRegalo.Location = new System.Drawing.Point(437, 439);
            this.txtValRegalo.Name = "txtValRegalo";
            this.txtValRegalo.Size = new System.Drawing.Size(120, 22);
            this.txtValRegalo.TabIndex = 6;
            this.txtValRegalo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValRegalo_KeyPress);
            // 
            // btnSiguiente1
            // 
            this.btnSiguiente1.BackColor = System.Drawing.Color.LightCoral;
            this.btnSiguiente1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente1.Location = new System.Drawing.Point(649, 490);
            this.btnSiguiente1.Name = "btnSiguiente1";
            this.btnSiguiente1.Size = new System.Drawing.Size(121, 51);
            this.btnSiguiente1.TabIndex = 7;
            this.btnSiguiente1.Text = "Siguiente";
            this.btnSiguiente1.UseVisualStyleBackColor = false;
            this.btnSiguiente1.Click += new System.EventHandler(this.btnSiguiente1_Click);
            // 
            // dateInicio
            // 
            this.dateInicio.CustomFormat = "dd/MM/yyyy";
            this.dateInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicio.Location = new System.Drawing.Point(437, 240);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(120, 24);
            this.dateInicio.TabIndex = 8;
            // 
            // numericCantJugadores
            // 
            this.numericCantJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCantJugadores.Location = new System.Drawing.Point(437, 120);
            this.numericCantJugadores.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericCantJugadores.Name = "numericCantJugadores";
            this.numericCantJugadores.Size = new System.Drawing.Size(120, 24);
            this.numericCantJugadores.TabIndex = 10;
            this.numericCantJugadores.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericCantJugadores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericCantJugadores_KeyPress);
            // 
            // numericNumEndulzadas
            // 
            this.numericNumEndulzadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNumEndulzadas.Location = new System.Drawing.Point(437, 178);
            this.numericNumEndulzadas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericNumEndulzadas.Name = "numericNumEndulzadas";
            this.numericNumEndulzadas.Size = new System.Drawing.Size(120, 24);
            this.numericNumEndulzadas.TabIndex = 11;
            this.numericNumEndulzadas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericNumEndulzadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericNumEndulzadas_KeyPress);
            // 
            // numericFrecEndulzadas
            // 
            this.numericFrecEndulzadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFrecEndulzadas.Location = new System.Drawing.Point(437, 300);
            this.numericFrecEndulzadas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFrecEndulzadas.Name = "numericFrecEndulzadas";
            this.numericFrecEndulzadas.Size = new System.Drawing.Size(120, 24);
            this.numericFrecEndulzadas.TabIndex = 12;
            this.numericFrecEndulzadas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFrecEndulzadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFrecEndulzadas_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Número de Jugadores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Número de Endulzadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Frecuencia de Endulzadas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha de la Primera Endulzada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Valor de las Endulzadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor del Regalo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "Características del Juego";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "(En días)";
            // 
            // ReglasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericFrecEndulzadas);
            this.Controls.Add(this.numericNumEndulzadas);
            this.Controls.Add(this.numericCantJugadores);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.btnSiguiente1);
            this.Controls.Add(this.txtValRegalo);
            this.Controls.Add(this.txtValEndulzada);
            this.Name = "ReglasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reglas";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumEndulzadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrecEndulzadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValEndulzada;
        private System.Windows.Forms.TextBox txtValRegalo;
        private System.Windows.Forms.Button btnSiguiente1;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.NumericUpDown numericCantJugadores;
        private System.Windows.Forms.NumericUpDown numericNumEndulzadas;
        private System.Windows.Forms.NumericUpDown numericFrecEndulzadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}