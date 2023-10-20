using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio_3
{
    public partial class JuegoForm : Form
    {
        private AmigoSecreto juegoAmigoSecreto;

        /// <summary>
        /// Constructor de la clase JuegoForm.
        /// </summary>
        /// <param name="juegoAmigoSecreto">El objeto AmigoSecreto que contiene la información del juego.</param>
        public JuegoForm(AmigoSecreto juegoAmigoSecreto)
        {
            InitializeComponent();
            this.juegoAmigoSecreto = juegoAmigoSecreto;
        }

        /// <summary>
        /// Muestra la información del juego en el formulario.
        /// </summary>
        public void mostrarInformacion()
        {
            labelFechaInicio.Text = juegoAmigoSecreto.getFechaInicio().ToString("d");
            labelFechaFin.Text = juegoAmigoSecreto.getFechaFin().ToString("d");
            labelValEndulzada.Text = String.Format("${0}", juegoAmigoSecreto.getValorEndulzada().ToString());
            labelValRegalo.Text = String.Format("${0}", juegoAmigoSecreto.getValorRegalo().ToString());

            if (juegoAmigoSecreto.getFrecuenciaEndulzadas() == 1)
            {
                labelNumFrecEndulzadas.Text = String.Format("Se realizarán {0} endulzadas, una cada\r\ndía.", juegoAmigoSecreto.getNumeroEndulzadas().ToString());
            }
            if (juegoAmigoSecreto.getFrecuenciaEndulzadas() != 1)
            {
                labelNumFrecEndulzadas.Text = String.Format("Se realizarán {0} endulzadas, una cad\r\n{1} días.", juegoAmigoSecreto.getNumeroEndulzadas().ToString(), juegoAmigoSecreto.getFrecuenciaEndulzadas().ToString());
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Gustos" para mostrar los gustos de los jugadores.
        /// </summary>
        private void btnGustos_Click(object sender, EventArgs e)
        {
            StringBuilder gustos = new StringBuilder();
            for (int i = 0; i < juegoAmigoSecreto.getJugadores().Length; i++)
            {
                gustos.AppendFormat("\r\n{0}:\r\nEndulzada Ideal: {1}\r\nRegalo Ideal: {2}\r\n", juegoAmigoSecreto.getJugadores()[i].getNombre(), juegoAmigoSecreto.getJugadores()[i].getEndulzadaIdeal(), juegoAmigoSecreto.getJugadores()[i].getRegaloIdeal());
            }

            GustosForm gustosForm = new GustosForm();
            gustosForm.mostrarGustos(gustos.ToString());
            gustosForm.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Correos" para mostrar los correos de los jugadores.
        /// </summary>
        private void btnCorreos_Click(object sender, EventArgs e)
        {
            StringBuilder correos = new StringBuilder();
            for (int i = 0; i < juegoAmigoSecreto.getJugadores().Length; i++)
            {
                correos.AppendFormat("\r\nPara: {0}\r\nAsunto: Amigo Secreto\r\n¡Hola, {1}!\r\nTu amig@ secret@ es {2}. ¡Prepara tu endulzada y regalo sorpresa para hacer esos días más especiales!\r\n¡Hasta el próximo juego!\r\n", juegoAmigoSecreto.getJugadores()[i].getCorreo(), juegoAmigoSecreto.getJugadores()[i].getNombre(), juegoAmigoSecreto.getJugadores()[i].getAmigoSecreto());
            }

            CorreosForm correosForm = new CorreosForm();
            correosForm.mostrarCorreos(correos.ToString());
            correosForm.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Próxima Endulzada" para calcular y mostrar los días restantes para la próxima endulzada.
        /// </summary>
        private void btnProxEndulzada_Click(object sender, EventArgs e)
        {
            List<DateTime> proximasEndulzadas = AmigoSecreto.fechasEndulzadas(juegoAmigoSecreto.getFechaInicio(), juegoAmigoSecreto.getFrecuenciaEndulzadas(), juegoAmigoSecreto.getNumeroEndulzadas());

            DateTime fechaActual = dateProxEndulzada.Value.Date;
            int proximaEndulzada = AmigoSecreto.proximaEndulzada(proximasEndulzadas, fechaActual);

            if (proximaEndulzada == -1)
            {
                MessageBox.Show("Ya no hay más endulzadas.");
            }

            if (proximaEndulzada != -1)
            {
                MessageBox.Show("La proxima endulzada es en " + proximaEndulzada + " dias");
            }
        }
    }
}
