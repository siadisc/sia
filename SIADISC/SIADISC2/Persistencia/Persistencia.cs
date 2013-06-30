using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace SIADISC2.Persistencia
{
    public class Persistencia
    {

        // Singleton
        public static readonly Persistencia INSTANCE = new Persistencia();

        protected Db db;

        private Persistencia() {
            this.db = new Db(ConfigurationManager.ConnectionStrings["dev"].ConnectionString);            
        }

        public Dictionary<string, object> cargarUsuario(int rut) {
            return this.db.byPk("rut", rut, "usuario");
        }

        public Db Db { get { return this.db; } }

    }
}