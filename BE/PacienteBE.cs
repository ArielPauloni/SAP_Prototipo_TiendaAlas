using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class PacienteBE
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private short edad;

        public short Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        private string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private short actividadDeportiva;

        public short ActividadDeportiva
        {
            get { return actividadDeportiva; }
            set { actividadDeportiva = value; }
        }

        private short tiempoRelax;

        public short TiempoRelax
        {
            get { return tiempoRelax; }
            set { tiempoRelax = value; }
        }

        private bool fuma;

        public bool Fuma
        {
            get { return fuma; }
            set { fuma = value; }
        }

        private List<PatologiaBE> patologias;

        public List<PatologiaBE> Patologias
        {
            get { return patologias; }
            set { patologias = value; }
        }

    }
}
