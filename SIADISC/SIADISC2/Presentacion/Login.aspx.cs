using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace SIADISC2.Presentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected static readonly Regex REGEX = new Regex(@"^([0-9]+)\-");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
                Response.Redirect("~/Presentacion/Index.aspx");
        }

        protected void onAuthenticate(object sender, AuthenticateEventArgs e)
        {
            string rutStr = this.formLogin.UserName.Replace(".", "").Split('-')[0];
            int rut = int.Parse(rutStr);
            e.Authenticated = SIADISC2.Logica.Controlador.INSTANCE.ingresarAlSistema(rut, this.formLogin.Password);
        }
    }
}