using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Empezar" para abrir el formulario de Reglas.
        /// </summary>
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            ReglasForm reglasForm = new ReglasForm();
            reglasForm.Show();
            this.Hide();
        }
    }
}
