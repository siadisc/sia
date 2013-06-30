using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIADISC2.Logica
{
    public class Alumno : Usuario
    {

        private string carrera;

        private string matricula;

        private string telefonoFijo;

        private string telefonoMovil;

        private string direccion;

        private List<Solicitud> solicitudes;

        private int numAyudantias;

        public Alumno() { }

    }
}