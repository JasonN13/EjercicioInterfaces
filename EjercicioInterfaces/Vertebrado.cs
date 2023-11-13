using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class Vertebrado : Animal, Interface
    {

        public string? tipo;
        public string? tienepatas;
        public int numeropatas;
        public bool esdomestico;


        public void imprimir1()
        {
            if (imprimirValidar())
            {
                Console.WriteLine("Nombre :" + nombre);
            }
            Console.WriteLine("Color :" + color);
            Console.WriteLine("Tamaño :" + tamano);
            Console.WriteLine("Familia :" + familia);
            Console.WriteLine("Tipo :" + tipo);
            Console.WriteLine("Tiene patas :" + tienepatas);
            Console.WriteLine("Numero de patas :" + numeropatas);
            Console.WriteLine("Es domestico :" + esdomestico);
        }

        public void imprimirInformacion()
        { if (nombre != null && color != null && tamano != null && familia != null && tipo != null && tienepatas != null)
            {
                Console.WriteLine("Toda la informacion registrada esta completa");
            }
            else
            {
                Console.WriteLine("La información del animal no está completa");
            }
                
        }

        public bool imprimirValidar()
        {
            if (nombre != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
