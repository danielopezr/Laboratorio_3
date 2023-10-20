namespace Laboratorio_3
{
    partial class GustosForm
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
            this.txtGustos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGustos
            // 
            this.txtGustos.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGustos.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGustos.Location = new System.Drawing.Point(12, 12);
            this.txtGustos.Multiline = true;
            this.txtGustos.Name = "txtGustos";
            this.txtGustos.ReadOnly = true;
            this.txtGustos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGustos.Size = new System.Drawing.Size(558, 529);
            this.txtGustos.TabIndex = 0;
            // 
            // GustosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.txtGustos);
            this.Name = "GustosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gustos de los Jugadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGustos;
    }
}