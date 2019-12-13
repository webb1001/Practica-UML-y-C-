using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_UML
{
    public class Usuario : Serie
    {
        public string Nombre
        {
            get;
            set;
        }

        public string Apellido
        {
            get;
            set;
        }

        public string Correo
        {
            get;
            set;
        }

        public string FechaNacimiento
        {
            get;
            set;
        }

        public void AgregarFavorita()
        {
            throw new System.NotImplementedException();
        }
    }
}