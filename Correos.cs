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
    public partial class CorreosForm : Form
    {
        public CorreosForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra la lista de correos en un control de texto dentro del formulario.
        /// </summary>
        public void mostrarCorreos(String correos)
        {
            txtCorreos.Text = correos;
        }
    }
}
