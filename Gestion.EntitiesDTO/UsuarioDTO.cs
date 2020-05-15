using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.EntitiesDTO {
    public class UsuarioDTO {
        public int Id { get; set; }

        public string NombreCompleto { get; set; }

        public string Mail { get; set; }

        public bool Activo { get; set; }
    }
}
