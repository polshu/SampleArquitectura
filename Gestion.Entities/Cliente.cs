using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Entities {
    public class Cliente {
        public int Id { get; set; }

        public string RazonSocial { get; set; }

        public string CUIT { get; set; }

        public bool Activo { get; set; }

    }
}
