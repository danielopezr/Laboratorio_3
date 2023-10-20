using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    /// <summary>
    /// Clase que representa un jugador de Amigo Secreto.
    /// </summary>
    public class Jugador
    {
        String nombre;
        String correo;
        String endulzadaIdeal;
        String regaloIdeal;
        String amigoSecreto;

        /// <summary>
        /// Constructor de la clase Jugador.
        /// </summary>
        /// <param name="nombre">El nombre del jugador.</param>
        /// <param name="correo">La dirección de correo del jugador.</param>
        /// <param name="endulzadaIdeal">La descripción de la endulzada ideal del jugador.</param>
        /// <param name="regaloIdeal">La descripción del regalo ideal del jugador.</param>
        /// <param name="amigoSecreto">El nombre del amigo secreto asignado al jugador.</param>
        public Jugador(String nombre, String correo, String endulzadaIdeal, String regaloIdeal, String amigoSecreto)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.endulzadaIdeal = endulzadaIdeal;
            this.regaloIdeal = regaloIdeal;
            this.amigoSecreto = amigoSecreto;
        }

        /// <summary>
        /// Obtiene el nombre del jugador.
        /// </summary>
        public String getNombre()
        {
            return nombre;
        }

        /// <summary>
        /// Obtiene la dirección de correo del jugador.
        /// </summary>
        public String getCorreo()
        {
            return correo;
        }

        /// <summary>
        /// Obtiene la descripción de la endulzada ideal del jugador.
        /// </summary>
        public String getEndulzadaIdeal()
        {
            return endulzadaIdeal;
        }

        /// <summary>
        /// Obtiene la descripción del regalo ideal del jugador.
        /// </summary>
        public String getRegaloIdeal()
        {
            return regaloIdeal;
        }

        /// <summary>
        /// Obtiene el nombre del amigo secreto asignado al jugador.
        /// </summary>
        public String getAmigoSecreto()
        {
            return amigoSecreto;
        }

        /// <summary>
        /// Establece el nombre del jugador.
        /// </summary>
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Establece la dirección de correo del jugador.
        /// </summary>
        public void setCorreo(String correo)
        {
            this.correo = correo;
        }

        /// <summary>
        /// Establece la descripción de la endulzada ideal del jugador.
        /// </summary>
        public void setEndulzadaIdeal(String endulzadaIdeal)
        {
            this.endulzadaIdeal = endulzadaIdeal;
        }

        /// <summary>
        /// Establece la descripción del regalo ideal del jugador.
        /// </summary>
        public void setRegaloIdeal(String regaloIdeal)
        {
            this.regaloIdeal = regaloIdeal;
        }

        /// <summary>
        /// Establece el nombre del amigo secreto asignado al jugador.
        /// </summary>
        public void setAmigoSecreto(String amigo)
        {
            this.amigoSecreto = amigo;
        }
    }
}
