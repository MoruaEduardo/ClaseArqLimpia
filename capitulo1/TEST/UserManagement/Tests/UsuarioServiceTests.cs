using Xunit;
using UserManagement.Models;
using UserManagement.Services;

namespace UserManagement.Tests
{
    public class UsuarioServiceTests
    {
        [Fact]
        public void InsertUserTest()
        {
            //ARRANQUE
            var servicio = new UsuarioService();
            var usuario = new Usuario(1, "eduardo", "eduardo@gmail.com");
            //ACCION
            servicio.CrearUsuario(usuario);
            var result = servicio.ObtenerUsuarioPorId(usuario.Id);

            //ASERCION

            Assert.NotNull(result);
            Assert.Equal(usuario.Nombre, result.Nombre);
            Assert.Equal(usuario.Email,result.Email);
        }

        //public void Test() { 
        //    throw new NotImplementedException();
        //}
    }
}