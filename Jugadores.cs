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
    public partial class JugadoresForm : Form
    {
        private List<Jugador> listaJugadores;
        private AmigoSecreto juegoAmigoSecreto;

        /// <summary>
        /// Constructor de la clase JugadoresForm.
        /// </summary>
        /// <param name="juegoAmigoSecreto">La instancia de AmigoSecreto utilizada en el juego.</param>
        public JugadoresForm(AmigoSecreto juegoAmigoSecreto)
        {
            InitializeComponent();
            listaJugadores = new List<Jugador>();
            this.juegoAmigoSecreto = juegoAmigoSecreto;
        }

        /// <summary>
        /// Maneja el evento de clic del botón "Enviar" para agregar un nuevo jugador.
        /// </summary>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String correo = txtCorreo.Text;
            String endulzadaIdeal = txtEndulzadaIdeal.Text;
            String regaloIdeal = txtRegaloIdeal.Text;
            String amigoSecreto = "";

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(endulzadaIdeal) || string.IsNullOrEmpty(regaloIdeal))
            {
                MessageBox.Show("Por favor, complete todas las casillas.");
                return; // Salir del método si alguna casilla está vacía
            }

            if (!correoValido(correo))
            {
                MessageBox.Show("Ingresa un correo electrónico válido.");
                return; // Salir del método si el correo no es válido
            }

            if (juegoAmigoSecreto.getCantidadJugadores() - 1 == listaJugadores.Count)
            {
                btnEnviar.Enabled = false; // Deshabilitar el botón "Enviar"
                btnIniciar.Enabled = true; // Habilitar el botón "Iniciar"
            }

            Jugador jugador = new Jugador(nombre, correo, endulzadaIdeal, regaloIdeal, amigoSecreto);
            listaJugadores.Add(jugador);

            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtEndulzadaIdeal.Text = "";
            txtRegaloIdeal.Text = "";
        }

        /// <summary>
        /// Maneja el evento de clic del botón "Iniciar" para comenzar el juego.
        /// </summary>
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Jugador[] jugadoresAmigoSecreto = listaJugadores.ToArray();;

            jugadoresAmigoSecreto = AmigoSecreto.amigoSecretoAleatorio(jugadoresAmigoSecreto);
            juegoAmigoSecreto.setJugadores(jugadoresAmigoSecreto);

            JuegoForm juegoForm = new JuegoForm(juegoAmigoSecreto);
            juegoForm.mostrarInformacion();
            juegoForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Maneja el evento KeyPress para el campo de nombre, permitiendo solo letras y control.
        /// </summary>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Verifica si un correo electrónico tiene un formato válido utilizando una expresión regular.
        /// </summary>
        private bool correoValido(string correo)
        {
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(correo, patronCorreo);
        }

        /// <summary>
        /// Maneja el evento de clic del botón "Volver" para regresar al formulario de Reglas.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            ReglasForm reglasForm = new ReglasForm();
            reglasForm.Show();
        }
    }
}
