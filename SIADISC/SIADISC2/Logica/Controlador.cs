using System;
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
            Usuario usuario = new Usuario(rut, pass);
            SESSION["usuario"] = usuario;
            // TODO: validar Pass
            return true;
        }

    }
}