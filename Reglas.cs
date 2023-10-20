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
    public partial class ReglasForm : Form
    {
        public ReglasForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic del botón "Siguiente" para configurar los detalles del juego.
        /// </summary>
        public void btnSiguiente1_Click(object sender, EventArgs e)
        {
            int cantidadJugadores = (int)numericCantJugadores.Value;
            int numeroEndulzadas = (int)numericNumEndulzadas.Value;
            int frecuenciaEndulzadas = (int)numericFrecEndulzadas.Value;

            String valorEndulzada = txtValEndulzada.Text;
            String valorRegalo = txtValRegalo.Text;

            DateTime fechaInicio = dateInicio.Value.Date;
            DateTime fechaFin = fechaInicio.AddDays((numeroEndulzadas - 1) * frecuenciaEndulzadas).Date;
            Jugador[] jugadores = { };

            AmigoSecreto juegoAmigoSecreto = new AmigoSecreto(cantidadJugadores, fechaInicio, fechaFin, numeroEndulzadas, frecuenciaEndulzadas, valorEndulzada, valorRegalo, jugadores);

            // Validar que las TextBox no estén vacías o nulas
            if (string.IsNullOrEmpty(valorEndulzada) || string.IsNullOrEmpty(valorRegalo))
            {
                MessageBox.Show("Por favor, ingresa un valor en todas las casillas.");
                return;
            }

            JugadoresForm jugadoresForm = new JugadoresForm(juegoAmigoSecreto);
            jugadoresForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Maneja el evento KeyPress del control numérico para evitar entradas de coma y punto.
        /// </summary>
        private void numericCantJugadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void numericNumEndulzadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void numericFrecEndulzadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Maneja el evento KeyPress del campo para permitir solo dígitos y teclas de control.
        /// </summary>
        private void txtValEndulzada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValRegalo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
