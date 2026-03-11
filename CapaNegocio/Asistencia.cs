using System;

namespace CapaNegocio
{
    // Clase que representa un registro de asistencia
    public class Asistencia
    {
        public int      IdEstudiante;
        public DateTime Fecha;
        public bool     Presente;

        // Constructor
        public Asistencia(int idEstudiante, DateTime fecha, bool presente)
        {
            IdEstudiante = idEstudiante;
            Fecha        = fecha;
            Presente     = presente;
        }

        // Metodo funcion - verifica si el registro es valido
        public bool EsValido()
        {
            if (IdEstudiante == 0)
                return false;

            return true;
        }

        // Metodo funcion - verifica si hay alerta de inasistencia
        public bool VerificarAlerta(int totalClases, int asistencias)
        {
            if (totalClases == 0)
                return false;

            double porcentaje = (double)asistencias / totalClases * 100;

            if (porcentaje < 80)
                return true;
            else
                return false;
        }

        // Metodo funcion - calcula el porcentaje de asistencia
        public double CalcularPorcentaje(int totalClases, int asistencias)
        {
            if (totalClases == 0)
                return 0;

            return (double)asistencias / totalClases * 100;
        }
    }
}
