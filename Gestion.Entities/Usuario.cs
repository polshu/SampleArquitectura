using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Entities {
    public class Usuario {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }
        
        public string Clave { get; set; }

        public bool Activo { get; set; }

        public override string ToString() {
            string strReturnValue = "";
            strReturnValue = string.Format("Id:{0}, Nombre:'{1}', Email:'{2}', Clave:{3}, Activo:{4}",
                Id,
                Nombre,
                Email,
                Clave,
                (Activo ? "True" : "False")
                );
            return strReturnValue;
        }
    }
}
