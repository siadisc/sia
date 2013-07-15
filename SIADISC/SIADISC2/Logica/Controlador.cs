using System;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace SIADISC2.Logica
{
    public class Controlador
    {

        public static readonly Controlador INSTANCE = new Controlador();

        private Persistencia.Persistencia PERSISTENCIA = Persistencia.Persistencia.INSTANCE;

        private HttpSessionState SESSION = HttpContext.Current.Session;

        private Controlador() {

        }

        public bool ingresarAlSistema(int rut, string pass) {

            // Crea el usuario
            Usuario usuario = new Usuario(rut, pass);

            // se cargaron los datos?
            bool usuExiste = usuario.Rut != null;

            // Validar pass
            if (usuExiste)
                usuExiste = this.validarPass(usuario, pass);

            // Crear sesión
            if (usuExiste) {
                SESSION["usuario"] = usuario;
            }

            return usuExiste;
        }

        public bool validarPass(Usuario usu, string pass) {

            // Obtiene el string secreto de la aplicación
            string salt = ConfigurationManager.AppSettings["AppKey"];

            // Realiza la operación SHA1(pass + salt)
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(pass + salt);
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] result = sha.ComputeHash(data);
            string passwordHash = Encoding.UTF8.GetString(result);

            // Realiza la comprobación
            return usu.PasswordHash == passwordHash;            
        }

    }
}