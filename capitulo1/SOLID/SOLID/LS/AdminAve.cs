using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LS
{

    public interface IVolar
    {
        void volar();
      
    }
    public interface ICorrer
    {
        void correr();
    }

    public interface INadar
    {
        void nadar();
    }
    //public interface IAve
    //{
    //    void volar();
    //    void nadar();
    //    void correr();
    //}

    public class Pinguino : ICorrer,INadar
    {
        public void correr()
        {
            Console.WriteLine("Corre lento");
        }

        public void nadar()
        {
            Console.WriteLine("nada muy bien");
        }

        public void volar()
        {
            throw new Exception("No vuela");
        }
    }
    public class Paloma : ICorrer,IVolar
    {
        public void correr()
        {
            Console.WriteLine("Corre poquito");
        }

        public void nadar()
        {
            Console.WriteLine("No nada");
        }

        public void volar()
        {
            Console.WriteLine("Si vuela bien");
        }
    }

    public class Eagle : ICorrer, IVolar
    {
        public void correr()
        {
            Console.WriteLine("Corre poquito");
        }

        public void volar()
        {
            Console.WriteLine("Si vuela bien");
        }
    }

    internal class AdminAve
    {
        private List<IVolar> voladores= new List<IVolar>();

        public bool InsertVolador(Eagle ave)
        {
                voladores.Add(ave);
                return true;       
        }
    }

    //internal class AdminAve
    //{
    //    private List<IVolar> voladores = new List<IVolar>();

    //    public bool InsertVolador(Pinguino ave)
    //    {
    //        try
    //        {
    //            ave.volar();
    //            voladores.Add(ave);
    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //        return false;
    //    }
    //}
}
