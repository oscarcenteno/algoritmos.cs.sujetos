using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    public class ApellidosEnMayusculas
    {
        private string losApellidos;

        public ApellidosEnMayusculas(string elPrimerApellido, string elSegundoApellido)
        {
            losApellidos = $"{elPrimerApellido} {elSegundoApellido}";

        }

        public string ComoTexto()
        {
            return losApellidos.ToUpper();
        }
    }
}