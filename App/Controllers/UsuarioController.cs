using FarmaciasUwU.App.Models;
using FarmaciasUwU.App.Structs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciasUwU.App.Controllers
{
    public class UsuarioController
    {
        public static List<UsuarioDTO> Index()
        {
            Connection db = new();
            var query = db.Usuarios.Select(user => new UsuarioDTO { 
                Id = user.Id,
                Nombre = user.Nombre,
                Email = user.Email,
            });
            return query.ToList();
        }

        public static List<UsuarioDTO> Filter(string? nombre, string? email)
        {
            Connection db = new();
            var query = db.Usuarios.Select(user => new UsuarioDTO
            {
                Id = user.Id,
                Nombre = user.Nombre,
                Email = user.Email,
            });
            if (!string.IsNullOrEmpty(email))
            {
                query = query.Where(x => x.Email.Contains(email));
            }
            if (!string.IsNullOrEmpty(nombre))
            {
                query = query.Where(x => x.Nombre.Contains(nombre));
            }
            return query.ToList();
        }

        public static Usuario? Update(int id, string? nombre, string? email, string? password)
        {
            Connection db = new();
            Usuario? usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return null;
            }
            usuario.Email = string.IsNullOrEmpty(email) ? usuario.Email : email;
            usuario.Nombre = string.IsNullOrEmpty(nombre) ? usuario.Nombre : nombre;
            if (!string.IsNullOrEmpty(password))
            {
                usuario.SetPassword(password);
            }
            db.Usuarios.Update(usuario);
            db.SaveChanges();
            return usuario;
        }

        public static void Delete(int id)
        {
            Connection db = new();
            Usuario? usuario = db.Usuarios.Find(id);
            if (usuario != null)
            {
                db.Usuarios.Remove(usuario);
                db.SaveChanges();
            }
        }

        public static Usuario Create(string nombre, string email, string password)
        {
            Connection db = new();

            Usuario usuario = new()
            {
                Email = email,
                Nombre = nombre
            };
            usuario.SetPassword(password);
            db.Usuarios.Add(usuario);
            db.SaveChanges();
            return usuario;
        }

        public static Usuario? LogIn(string username, string password)
        {
            Connection db = new();
            Usuario? usuario = db.Usuarios.FirstOrDefault(x => x.Nombre == username);
            if (usuario == null || !usuario.VerifyPassword(password))
            {
                return null;
            }
            return usuario;
        }

        public static bool ChangePassword(string username, string password)
        {
            Connection db = new();
            Usuario? usuario = db.Usuarios.FirstOrDefault(y => y.Nombre == username);
            if (usuario == null)
            {
                return false;
            }
            usuario.SetPassword(password.Trim());
            db.SaveChanges();
            return true;
        }
    }
}
