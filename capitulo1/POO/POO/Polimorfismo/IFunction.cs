using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    internal interface IFunction
    {
        void insertar();
        void saludar(string mensaje);

        

    }

    public class Impl1 : IFunction
    {
        public void insertar()
        {
            Console.WriteLine("implementación 1");
        }

        public void saludar(string mensaje)
        {
            Console.WriteLine("Implementación 1");
        }
    }
}
