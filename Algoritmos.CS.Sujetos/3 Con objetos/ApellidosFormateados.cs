using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    public class ApellidosFormateados
    {
        string losApellidosEnMayusculas;

        public ApellidosFormateados(string elPrimerApellido, string elSegundoApellido)
        {
            losApellidosEnMayusculas = ObtengaLosApellidosEnMayusculas(elPrimerApellido, elSegundoApellido);
        }

        private static string ObtengaLosApellidosEnMayusculas(string elPrimerApellido, string elSegundoApellido)
        {
            return new ApellidosEnMayusculas(elPrimerApellido, elSegundoApellido).ComoTexto();
        }

        public string ComoTexto()
        {
            return ElimineLosEspaciosAlFinal(losApellidosEnMayusculas);
        }

        private static string ElimineLosEspaciosAlFinal(string losApellidosEnMayusculas)
        {
            return losApellidosEnMayusculas.TrimEnd();
        }
    }
}