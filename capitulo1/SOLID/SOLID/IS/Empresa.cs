using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.IS
{
    public interface ICommons
    {
        void EntrarReuniones();

        void Registro();
    }

    public interface IDevelop
    {
        void Desarrollar();
        void EjecutaTest();
        void EntraReunioes();
    }

    public interface IFunciones
    {
        void Desarrollar();
        void Gerenciar();
        void EntrarReuniones();

        void AdministrarFacturas();

        void Registro();
    }


    public class Developer : IDevelop, ICommons
    {
        public void Desarrollar()
        {
            throw new NotImplementedException();
        }

        public void EjecutaTest()
        {
            throw new NotImplementedException();
        }

        public void EntraReunioes()
        {
            throw new NotImplementedException();
        }

        public void EntrarReuniones()
        {
            throw new NotImplementedException();
        }

        public void Registro()
        {
            throw new NotImplementedException();
        }
    }
    //public class Developer : IFunciones
    //{
    //    public void AdministrarFacturas()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Desarrollar()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void EntrarReuniones()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Gerenciar()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Registro()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    internal class Empresa
    {

    }
}
