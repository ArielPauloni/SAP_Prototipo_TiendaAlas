using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace BLL
{
    public class PatologiaBLL
    {
        public PatologiaBE CrearPatologiaAleatoria()
        {
            Random rndPatologia = new Random();
            short patologiaId = short.Parse(rndPatologia.Next(0, 7).ToString());
            PatologiaBE patologia = new PatologiaBE();
            switch (patologiaId)
            {
                case 0:
                    patologia.Descripcion = "Angustia";
                    break;
                case 1:
                    patologia.Descripcion = "Ansiedad";
                    break;
                case 2:
                    patologia.Descripcion = "Baja autoestima";
                    break;
                case 3:
                    patologia.Descripcion = "Depresión";
                    break;
                case 4:
                    patologia.Descripcion = "Estrés";
                    break;
                case 5:
                    patologia.Descripcion = "Lumbalgia";
                    break;
                case 6:
                    patologia.Descripcion = "Migraña";
                    break;
            }
            return patologia;
        }
    }
}
