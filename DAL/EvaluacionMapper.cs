using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BE;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DAL
{
    public class EvaluacionMapper
    {
        public int guardarEvaluacionJSON(List<EvaluacionBE> evaluaciones)
        {
            try
            {
                string json = JsonConvert.SerializeObject(evaluaciones.ToArray(), Formatting.Indented);
                System.IO.File.WriteAllText("Evaluaciones.json", json);
                return 1;
            }
            catch (Exception) { return 0; }
        }

        public string leerEvaluacionesJSON()
        {
            List<EvaluacionBE> evaluaciones = JsonConvert.DeserializeObject<List<EvaluacionBE>>(File.ReadAllText("Evaluaciones.json"));
            return JsonConvert.SerializeObject(evaluaciones.ToArray(), Formatting.Indented);
        }

        public List<EvaluacionBE> leerEvaluacionesJSONToList()
        {
            List<EvaluacionBE> evaluaciones = JsonConvert.DeserializeObject<List<EvaluacionBE>>(File.ReadAllText("Evaluaciones.json"));
            return evaluaciones;
        }
    }
}
