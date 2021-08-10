using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace BLL
{
    public class TratamientoBLL
    {
        public TratamientoBE CrearTratamientoAleatorio()
        {
            TratamientoBE tratamiento = new TratamientoBE();

            Random rndTratamiento = new Random();
            short probTratamiento = short.Parse(rndTratamiento.Next(0, 101).ToString());

            if (probTratamiento < 25) { tratamiento.Descripcion = "Reiki"; }
            else if (probTratamiento < 50) { tratamiento.Descripcion = "Sanación Angelical"; }
            else if (probTratamiento < 75) { tratamiento.Descripcion = "Meditación"; }
            else { tratamiento.Descripcion = "Registros Akáshicos"; }

            return tratamiento;
        }

        /// <summary>
        /// Sugiere tratamiento para el paciente con más cantidad de características similares dentro de los 
        /// de la lista de evaluaciones (más de 2 coincidencias). Debe coincidir también la patología y 
        ///  tener una calificación mayor a 5 en la evaluación.
        /// </summary>
        /// <param name="paciente">Paciente al que se le quiere sugerir tratamiento</param>
        /// <param name="evaluaciones">Lista de evaluaciones cargadas en el sistema</param>
        /// <returns></returns>
        public TratamientoBE SugerirTratamiento(PacienteBE paciente, List<EvaluacionBE> evaluaciones)
        {
            List<EvaluacionBE> evaluacionesConMismaPatologia = new List<EvaluacionBE>();
            List<Tuple<EvaluacionBE, short>> rankingEvaluacionesConMismaPatologia = new List<Tuple<EvaluacionBE, short>>();
            TratamientoBE tratamientoRecomendado = null;
            Boolean malEvaluada = false;

            foreach (PatologiaBE patologiaConsulta in paciente.Patologias)
            {
                foreach (EvaluacionBE evaluacion in evaluaciones)
                {
                    foreach (PatologiaBE patologiaEvaluada in evaluacion.Paciente.Patologias)
                    {
                        if (patologiaConsulta.Descripcion == patologiaEvaluada.Descripcion)
                        {
                            //Solo si el grado de Satisfacción es mayor a 5
                            if (evaluacion.GradoSatisfaccion > 5)
                            {
                                evaluacionesConMismaPatologia.Add(evaluacion);
                                malEvaluada = false;
                            }
                            else { malEvaluada = true; }
                        }
                    }
                }
            }

            if (evaluacionesConMismaPatologia.Count == 0 && !malEvaluada) { throw new BLL.PatologiaNoEvaluadaException(string.Format(@"Patología ""{0}"" sin evaluaciones previas", paciente.Patologias[0].Descripcion)); }
            else if (evaluacionesConMismaPatologia.Count == 0 && malEvaluada) { throw new BLL.PatologiaMalEvaluadaException(string.Format(@"Patología ""{0}"" con evaluaciones insatisfactorias", paciente.Patologias[0].Descripcion)); }
            else
            {
                //Ranking (ordenado) de pacientes con más cantidad de características similares
                foreach (EvaluacionBE eva in evaluacionesConMismaPatologia)
                {
                    short cantidadAciertos = 0;
                    if (paciente.Fuma == eva.Paciente.Fuma) { cantidadAciertos++; }
                    if (paciente.Genero == eva.Paciente.Genero) { cantidadAciertos++; }
                    if (Enumerable.Range(paciente.Edad - 7, paciente.Edad + 7).Contains(eva.Paciente.Edad)) { cantidadAciertos++; }
                    if (Enumerable.Range(paciente.ActividadDeportiva - 1, paciente.ActividadDeportiva + 1).Contains(eva.Paciente.ActividadDeportiva)) { cantidadAciertos++; }
                    if (Enumerable.Range(paciente.TiempoRelax - 5, paciente.TiempoRelax + 5).Contains(eva.Paciente.TiempoRelax)) { cantidadAciertos++; }

                    if (cantidadAciertos > 2)
                    { rankingEvaluacionesConMismaPatologia.Add(new Tuple<EvaluacionBE, short>(eva, cantidadAciertos)); }
                }
                if (rankingEvaluacionesConMismaPatologia.Count > 0)
                {
                    rankingEvaluacionesConMismaPatologia = rankingEvaluacionesConMismaPatologia.OrderByDescending(i => i.Item2).ToList();
                    Tuple<EvaluacionBE, short> mayorCoincidencia = rankingEvaluacionesConMismaPatologia.FirstOrDefault();
                    tratamientoRecomendado = mayorCoincidencia.Item1.Tratamiento;
                }
                else
                {
                    throw new BLL.PacienteSinCoincidenciasSuficientesException(string.Format(@"Para la patología ""{0}"", no hay pacientes previos con suficientes coincidencias con el actual.",
                 paciente.Patologias[0].Descripcion));
                }
            }

            return tratamientoRecomendado;
        }
    }
}
