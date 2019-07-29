using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gestion.Entities;
using Gestion.EntitiesDTO;

namespace Gestion.Mappers {
    public class ClientesMapper {
        public static ClienteDTO ToDTO(Cliente source) {
            ClienteDTO returnEntity = null;

            if (source != null) {
                returnEntity = new ClienteDTO();
                returnEntity.Id     = source.Id;
                returnEntity.Nombre = source.RazonSocial;
                returnEntity.CUIT   = source.CUIT;
            }

            return returnEntity;
        }

        public static Cliente FromDTO(ClienteDTO source) {
            Cliente returnEntity = null;

            if (source != null) {
                returnEntity = new Cliente();
                returnEntity.Id             = source.Id;
                returnEntity.RazonSocial    = source.Nombre;
                returnEntity.CUIT           = source.CUIT;
            }

            return returnEntity;
        }
    }
}
