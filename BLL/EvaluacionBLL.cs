using System;
using System.Collections.Generic;
using System.Text;
using BE;
using DAL;

namespace BLL
{
    public class EvaluacionBLL
    {
        TratamientoBLL gestorTratamiento = new TratamientoBLL();
        PacienteBLL gestorPaciente = new PacienteBLL();

        public EvaluacionBE CrearEvaluacionAleatoria()
        {
            EvaluacionBE evaluacion = new EvaluacionBE();

            Random rndGradoSatisfaccion = new Random();
            short GradoSatisfaccion = short.Parse(rndGradoSatisfaccion.Next(0, 101).ToString());

            if (GradoSatisfaccion < 2) { evaluacion.GradoSatisfaccion = 0; }
            else if (GradoSatisfaccion < 4) { evaluacion.GradoSatisfaccion = 1; }
            else if (GradoSatisfaccion < 9) { evaluacion.GradoSatisfaccion = 2; }
            else if (GradoSatisfaccion < 14) { evaluacion.GradoSatisfaccion = 3; }
            else if (GradoSatisfaccion < 20) { evaluacion.GradoSatisfaccion = 4; }
            else if (GradoSatisfaccion < 30) { evaluacion.GradoSatisfaccion = 5; }
            else if (GradoSatisfaccion < 45) { evaluacion.GradoSatisfaccion = 6; }
            else if (GradoSatisfaccion < 65) { evaluacion.GradoSatisfaccion = 7; }
            else if (GradoSatisfaccion < 85) { evaluacion.GradoSatisfaccion = 8; }
            else if (GradoSatisfaccion < 95) { evaluacion.GradoSatisfaccion = 9; }
            else { evaluacion.GradoSatisfaccion = 10; }

            evaluacion.Tratamiento = gestorTratamiento.CrearTratamientoAleatorio();
            evaluacion.Paciente = gestorPaciente.CrearPacienteAleatorio();

            return evaluacion;
        }

        public int guardarEvaluacionesJSON(List<EvaluacionBE> evaluaciones)
        {
            EvaluacionMapper m = new EvaluacionMapper();
            return m.guardarEvaluacionJSON(evaluaciones);
        }

        public string leerEvaluacionesJSON()
        {
            EvaluacionMapper m = new EvaluacionMapper();
            return m.leerEvaluacionesJSON();
        }

        public List<EvaluacionBE> leerEvaluacionesJSONToList()
        {
            EvaluacionMapper m = new EvaluacionMapper();
            return m.leerEvaluacionesJSONToList();
        }
    }
}
