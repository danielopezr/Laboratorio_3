namespace Laboratorio_3
{
    partial class CorreosForm
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
            this.txtCorreos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCorreos
            // 
            this.txtCorreos.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCorreos.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreos.Location = new System.Drawing.Point(12, 12);
            this.txtCorreos.Multiline = true;
            this.txtCorreos.Name = "txtCorreos";
            this.txtCorreos.ReadOnly = true;
            this.txtCorreos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCorreos.Size = new System.Drawing.Size(558, 529);
            this.txtCorreos.TabIndex = 0;
            // 
            // CorreosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.txtCorreos);
            this.Name = "CorreosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Correos Enviados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreos;
    }
}