using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_UML
{
    public class Temporada
    {
        public string FechaProduccion
        {
            get;
            set;
        }

        public string FechaEstreno
        {
            get;
            set;
        }

        public bool Empezada
        {
            get;
            set;
        }

        public bool Cancelada
        {
            get;
            set;
        }

        public Capitulo Capitulos
        {
            get;
            set;
        }

        public Temporada Siguiente
        {
            get;
            set;
        }

        public void OrdenarTemporadas()
        {
            throw new System.NotImplementedException();
        }

        public void ProgresoTemporada()
        {
            throw new System.NotImplementedException();
        }

        public void CancelarTemporada()
        {
            throw new System.NotImplementedException();
        }
    }
}