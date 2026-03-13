using CapaDatos;
using System;

namespace CapaNegocio
{
    public class AsistenciaNegocio
    {
        AsistenciaDatos datos = new AsistenciaDatos();

        // Registra
        public string GuardarAsistencia(int idEstudiante, DateTime fecha, bool presente)
        {
            Asistencia a = new Asistencia(idEstudiante, fecha, presente);

            if (a.EsValido() == false)
                return "Selecciona un estudiante valido.";

            datos.RegistrarAsistencia(idEstudiante, fecha, presente);
            return "";
        }

        // Metodo funcion (verifica si hay alerta de inasistencia
        public bool VerificarAlerta(int totalClases, int asistencias)
        {
            Asistencia a = new Asistencia(0, DateTime.Today, false);
            return a.VerificarAlerta(totalClases, asistencias);
        }

        // calculo de procentaje en funcion
        public double CalcularPorcentaje(int totalClases, int asistencias)
        {
            Asistencia a = new Asistencia(0, DateTime.Today, false);
            return a.CalcularPorcentaje(totalClases, asistencias);
        }
    }
}
