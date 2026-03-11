using System;

namespace CapaNegocio
{
    // Clase para los  registro de asistencia
    public class Asistencia
    {
        public int IdEstudiante { get; set; }
        public DateTime Fecha { get; set; }
        public bool Presente { get; set; }

   
        public Asistencia(int idEstudiante, DateTime fecha, bool presente)
        {
            IdEstudiante = idEstudiante;
            Fecha        = fecha;
            Presente     = presente;
        }

        // metodo como funcion para saber si el registro el valido "por ahor no explota"
        public bool EsValido()
        {
            if (IdEstudiante == 0)
                return false;

            return true;
        }

        //         // Esto es un metodo como funcion para verificar alerta de inasistencia

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
