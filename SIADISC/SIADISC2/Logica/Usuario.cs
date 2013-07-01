using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIADISC2.Logica
{
    public class Usuario
    {

        private int rut;

        private string nombre;

        private string passwordHash;

        private string aPaterno;

        private string aMaterno;

        private int rol;

        public Usuario() { }

        public Usuario(int rut, string pass) {
            Dictionary<string, object> data = Persistencia.Persistencia.INSTANCE.cargarUsuario(rut);
            if (data != null)
                this.cargarDatos(data);
        }

        protected void cargarDatos(Dictionary<string, object> datosUsu) {
            Type self = this.GetType();
            foreach (KeyValuePair<string, object> entry in datosUsu)
            {
                FieldInfo field = self.GetField(entry.Key);
                field.SetValue(this, entry.Value);
            }
        }


        public int Rut { get { return this.rut; } set { this.rut = Rut; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = Nombre; } }
        public string PasswordHash { get { return this.passwordHash; } set { this.passwordHash = PasswordHash; } }
        public string APaterno { get { return this.aPaterno; } set { this.aPaterno = APaterno; } }
        public string AMaterno { get { return this.aMaterno; } set { this.aPaterno = AMaterno; } }
        public int Rol { get { return this.rol; } set { this.rol = Rol; } }
    }
}