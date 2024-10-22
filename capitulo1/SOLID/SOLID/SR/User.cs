using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SR
{
    public class User
    {
        public string? Email {  get; set; }
        public string? Password { get; set; }
    }

    public class EncriptyonService
    {
        public static string Encrypt(string data)
        {
            var encoding =Encoding.UTF8.GetBytes(data);
            var sha256 = SHA256.HashData(encoding);
            var dataEncrypted = Convert.ToHexString(sha256);
            return dataEncrypted;
        } 
    }

    public class UserRegistry
    {
        private List<User> Users = new List<User>();

        public bool Registry(User user)
        {
            if (user.Email.Length > 0 && user.Password.Length >= 8)
            {
                /*ENCRIPTAR PASSWORD*/
                var passwordEncripted = EncriptyonService.Encrypt(user.Email);

                /*END ECRIPTAR PASSWORD*/

                Users.Add(new User { Email = user.Email, Password = passwordEncripted });
                return true;
            }
            return false;
        }
    }
    //public class UserRegistry
    //{
    //    private List<User> Users = new List<User>();

    //    public bool Registry(User user)
    //    {
    //        if(user.Email.Length > 0 && user.Password.Length >= 8)
    //        {
    //            /*ENCRIPTAR PASSWORD*/

    //            var encoding =Encoding.UTF8.GetBytes(user.Password);
    //            var sha256=SHA256.HashData(encoding);
    //            var passwordEncripted = Convert.ToHexString(sha256);

    //            /*END ECRIPTAR PASSWORD*/

    //            Users.Add(new User { Email = user.Email, Password=passwordEncripted });
    //            return true;
    //        }
    //        return false;
    //    }
    //}
}
