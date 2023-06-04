using FarmaciasUwU.App.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciasUwU.App.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void SetPassword(string password)
        {
            Password = PasswordHelper.HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            return PasswordHelper.VerifyPassword(password, Password);
        }
    }
}
