using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_UML
{
    public class Serie
    {
        public string Titulo
        {
            get;
            set;
        }

        public int Anio
        {
            get;
            set;
        }

        public string Sinopsis
        {
            get;
            set;
        }

        public string Genero
        {
            get;
            set;
        }

        public bool Favorita
        {
            get;
            set;
        }

        public Temporada Primero
        {
            get;
            set;
        }

        public void SugerirSeries()
        {
            throw new System.NotImplementedException();
        }

        public void AgregarCapitulos()
        {
            throw new System.NotImplementedException();
        }
    }
}