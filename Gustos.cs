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
    public partial class GustosForm : Form
    {
        public GustosForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra las preferencias de los jugadores en un control de texto dentro del formulario.
        /// </summary>
        public void mostrarGustos(String gustos)
        {
            txtGustos.Text = gustos;
        }
    }
}
