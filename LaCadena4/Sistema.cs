using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena4
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            string cadena;

            cadena = Validador.ValidarString("\n Ingrese una frase");

            Validador.ToLower(cadena);

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
