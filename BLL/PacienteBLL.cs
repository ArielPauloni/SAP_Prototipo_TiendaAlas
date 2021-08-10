using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace BLL
{
    public class PacienteBLL
    {
        PatologiaBLL gestorPatologia = new PatologiaBLL();

        public PacienteBE CrearPacienteAleatorio()
        {
            PacienteBE paciente = new PacienteBE();
            //Nombre:
            paciente.Nombre = string.Format("Paciente {0}", System.DateTime.Now.ToString("mm:ss.fff"));

            //Edad:
            Random rndEdad = new Random();
            paciente.Edad = short.Parse(rndEdad.Next(18, 91).ToString());

            //Genero:
            Random rndGenero = new Random();
            short genero = 0;
            if (paciente.Edad > 25)
            {
                genero = short.Parse(rndGenero.Next(0, 2).ToString());
            }
            else
            {
                //solo si es menor o igual de 25 agrego el género "otro"
                genero = short.Parse(rndGenero.Next(0, 3).ToString());
            }
            switch (genero)
            {
                case 0:
                    paciente.Genero = "Femenino";
                    break;
                case 1:
                    paciente.Genero = "Masculino";
                    break;
                case 2:
                    paciente.Genero = "Otro";
                    break;
            }

            //ActividadDeportiva
            Random rndDeporte = new Random();
            paciente.ActividadDeportiva = short.Parse(rndDeporte.Next(0, 8).ToString());

            //TiempoRelax
            Random rndRelax = new Random();
            paciente.TiempoRelax = short.Parse(rndRelax.Next(10, 21).ToString());

            //Fuma (con 20% de probabilidades)
            Random rndFuma = new Random();
            paciente.Fuma = rndFuma.Next(0, 11) > 8;

            //Patologia
            paciente.Patologias = new List<PatologiaBE>();
            paciente.Patologias.Add(gestorPatologia.CrearPatologiaAleatoria());

            return paciente;
        }
    }
}
