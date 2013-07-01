using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIADISC2.Logica;

namespace SIADISC2.Presentacion
{
    public partial class Main : System.Web.UI.MasterPage
    {

        protected string title = "SIADISC";

        protected Usuario usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["usuario"] != null)
                this.usuario = (Usuario)Session["usuario"];
            else
                Response.Redirect("~/Presentacion/Login.aspx");
        }

        public string Title { get { return this.title; } }
    }
}