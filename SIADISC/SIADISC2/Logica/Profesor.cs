using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIADISC2.Logica
{
    public class Profesor : Usuario
    {

        private List<Asignatura> asignaturas;

        private bool esEncargadoDocencia;

        public Profesor() {
        }

    }
}