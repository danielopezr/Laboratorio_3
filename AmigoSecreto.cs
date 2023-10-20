using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    /// <summary>
    /// Clase que representa un juego de Amigo Secreto.
    /// </summary>
    public class AmigoSecreto
    {
        int cantidadJugadores;
        DateTime fechaInicio;
        DateTime fechaFin;
        int numeroEndulzadas;
        int frecuenciaEndulzadas;
        String valorEndulzadas;
        String valorRegalo;
        Jugador[] jugadores;

        /// Constructor para la creación de un objeto AmigoSecreto.
        /// </summary>
        /// <param name="cantidadJugadores">La cantidad de jugadores en el juego.</param>
        /// <param name="fechaInicio">La fecha de inicio del juego.</param>
        /// <param name="fechaFin">La fecha de fin del juego.</param>
        /// <param name="numeroEndulzadas">El número de endulzadas del juego.</param>
        /// <param name="frecuenciaEndulzadas">La frecuencia en días de las endulzadas.</param>
        /// <param name="valorEndulzadas">El valor de las endulzadas.</param>
        /// <param name="valorRegalo">El valor del regalos.</param>
        /// <param name="jugadores">Un arreglo de objetos Jugador.</param>
        public AmigoSecreto(int cantidadJugadores, DateTime fechaInicio, DateTime fechaFin, int numeroEndulzadas, int frecuenciaEndulzadas, String valorEndulzadas, String valorRegalo, Jugador[] jugadores)
        {
            this.cantidadJugadores = cantidadJugadores;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.numeroEndulzadas = numeroEndulzadas;
            this.frecuenciaEndulzadas = frecuenciaEndulzadas;
            this.valorEndulzadas = valorEndulzadas;
            this.valorRegalo = valorRegalo;
            this.jugadores = jugadores;
        }

        /// <summary>
        /// Obtiene la cantidad de jugadores en el juego.
        /// </summary>
        public int getCantidadJugadores()
        {
            return cantidadJugadores;
        }

        /// <summary>
        /// Obtiene la fecha de inicio del juego.
        /// </summary>
        public DateTime getFechaInicio()
        {
            return fechaInicio;
        }

        /// <summary>
        /// Obtiene la fecha de fin del juego.
        /// </summary>
        public DateTime getFechaFin()
        {
            return fechaFin;
        }

        /// <summary>
        /// Obtiene el número de endulzadas del juego.
        /// </summary>
        public int getNumeroEndulzadas()
        {
            return numeroEndulzadas;
        }

        /// <summary>
        /// Obtiene la frecuencia en días de las endulzadas.
        /// </summary>
        public int getFrecuenciaEndulzadas()
        {
            return frecuenciaEndulzadas;
        }

        /// <summary>
        /// Obtiene el valor de las endulzadas.
        /// </summary>
        public String getValorEndulzada()
        {
            return valorEndulzadas;
        }

        /// <summary>
        /// Obtiene el valor del regalo.
        /// </summary>
        public String getValorRegalo()
        {
            return valorRegalo;
        }

        /// <summary>
        /// Obtiene un arreglo de objetos Jugador.
        /// </summary>
        public Jugador[] getJugadores()
        {
            return jugadores;
        }

        /// <summary>
        /// Establece la cantidad de jugadores en el juego.
        /// </summary>
        public void setCantidadJugadores(int cantidadJugadores)
        {
            this.cantidadJugadores = cantidadJugadores;
        }

        /// <summary>
        /// Establece la fecha de inicio del juego.
        /// </summary>
        public void setFechaInicio(DateTime fechaInicio)
        {
            this.fechaInicio = fechaInicio;
        }

        /// <summary>
        /// Establece la fecha de fin del juego.
        /// </summary>
        public void setFechaFin(DateTime fechaFin)
        {
            this.fechaFin = fechaFin;
        }

        /// <summary>
        /// Establece el número de endulzadas del juego.
        /// </summary>
        public void setNumeroEndulzada(int numeroEndulzada)
        {
            this.numeroEndulzadas = numeroEndulzada;
        }

        /// <summary>
        /// Establece la frecuencia en días de las endulzadas.
        /// </summary>
        public void setFrecuenciaEndulzada(int frecuenciaEndulzada)
        {
            this.frecuenciaEndulzadas = frecuenciaEndulzada;
        }

        /// <summary>
        /// Establece el valor de las endulzadas.
        /// </summary>
        public void setValorEndulzada(string valorEndulzada)
        {
            this.valorEndulzadas = valorEndulzada;
        }

        /// <summary>
        /// Establece el valor del regalos.
        /// </summary>
        public void setValorRegalo(string valorRegalo)
        {
            this.valorRegalo = valorRegalo;
        }

        /// <summary>
        /// Establece un arreglo de objetos Jugador.
        /// </summary>
        public void setJugadores(Jugador[] jugadores)
        {
            this.jugadores = jugadores;
        }

        /// <summary>
        /// Asigna aleatoriamente a cada jugador un amigo secreto sin que se asignen a sí mismos.
        /// </summary>
        /// <param name="jugadores">Un array de objetos Jugador que representa a los participantes.</param>
        /// <returns>Un array de objetos Jugador con amigos secretos asignados de forma aleatoria.</returns>
        public static Jugador[] amigoSecretoAleatorio(Jugador[] jugadores)
        {
            String[] amigosSecretos = new String[jugadores.Length];
            for (int i = 0; i < jugadores.Length; i++)
            {
                amigosSecretos[i] = jugadores[i].getNombre();
            }

            Random rnd = new Random();
            bool val = true;
            while (val)
            {
                for (int i = amigosSecretos.Length - 1; i > 0; i--)
                {
                    int j = rnd.Next(i + 1);

                    String temp = amigosSecretos[i];
                    amigosSecretos[i] = amigosSecretos[j];
                    amigosSecretos[j] = temp;
                }

                int cont = 0;
                for (int i = 0; i < jugadores.Length; i++)
                {
                    if (jugadores[i].getNombre() == amigosSecretos[i])
                    {
                        cont++;
                    }
                }

                if (cont == 0)
                {
                    val = false;
                }
            }

            for (int i = 0; i < jugadores.Length; i++)
            {
                jugadores[i].setAmigoSecreto(amigosSecretos[i]);
            }

            return jugadores;
        }

        /// <summary>
        /// Calcula y devuelve una lista de fechas de endulzadas basadas en la fecha de inicio, la frecuencia y el número de endulzadas.
        /// </summary>
        /// <param name="fechaInicio">La fecha en la que comienza el juego de amigo secreto.</param>
        /// <param name="frecuenciaEndulzadas">La frecuencia de las endulzadas en días.</param>
        /// <param name="numeroEndulzadas">El número total de endulzadas, incluyendo el regalo final.</param>
        /// <returns>Una lista de fechas que representan las endulzadas planificadas.</returns>
        public static List<DateTime> fechasEndulzadas(DateTime fechaInicio, int frecuenciaEndulzadas, int numeroEndulzadas)
        {
            List<DateTime> fechasEndulzadas = new List<DateTime>();
            fechasEndulzadas.Add(fechaInicio.Date); // Agrega la fecha de inicio

            for (int i = 1; i < numeroEndulzadas; i++)
            {
                fechaInicio = fechaInicio.AddDays(frecuenciaEndulzadas).Date;
                fechasEndulzadas.Add(fechaInicio);
            }

            return fechasEndulzadas;
        }

        /// <summary>
        /// Calcula cuántos días faltan hasta la próxima endulzada a partir de la fecha actual.
        /// </summary>
        /// <param name="fechasEndulzadas">Una lista de fechas de endulzadas planificadas.</param>
        /// <param name="fechaActual">La fecha actual para calcular los días restantes.</param>
        /// <returns>El número de días restantes hasta la próxima endulzada o -1 si no hay más endulzadas programadas.</returns>
        public static int proximaEndulzada(List<DateTime> fechasEndulzadas, DateTime fechaActual)
        {
            DateTime proximaEndulzada = fechasEndulzadas.FirstOrDefault(f => f > fechaActual);

            if (proximaEndulzada != default(DateTime))
            {
                TimeSpan tiempoRestante = proximaEndulzada.Date - fechaActual.Date;
                return tiempoRestante.Days;
            }

            return -1;
        }
    }
}
