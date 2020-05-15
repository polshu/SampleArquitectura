using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gestion.Entities;
using Gestion.EntitiesDTO;

namespace Gestion.Mappers {
    public class UsuariosMapper {
        public static UsuarioDTO ToDTO(Usuario source) {
            UsuarioDTO returnEntity = null;

            if (source != null) {
                returnEntity = new UsuarioDTO();
                returnEntity.Id             = source.Id;
                returnEntity.NombreCompleto = source.Nombre;
                returnEntity.Mail           = source.Email;
                returnEntity.Activo         = source.Activo;
            }

            return returnEntity;
        }

        public static Usuario FromDTO(UsuarioDTO source) {
            Usuario returnEntity = null;

            if (source != null) {
                returnEntity = new Usuario();
                returnEntity.Id     = source.Id;
                returnEntity.Nombre = source.NombreCompleto;
                returnEntity.Email  = source.Mail;
                returnEntity.Activo = source.Activo;
            }

            return returnEntity;
        }

        public static List<UsuarioDTO> ToDTOList(List<Usuario> sourceList) {
            List<UsuarioDTO> returnList = null;
            UsuarioDTO      tempEntity;

            if (sourceList != null) {
                returnList = new List<UsuarioDTO>();
                foreach (Usuario currentItem in sourceList) {
                    tempEntity = ToDTO(currentItem);
                    returnList.Add(tempEntity);
                }
            }

            return returnList;
        }

        public static List<Usuario> FromDTOList(List<UsuarioDTO> sourceList) {
            List<Usuario> returnList = null;
            Usuario tempEntity;

            if (sourceList != null) {
                returnList = new List<Usuario>();
                foreach (UsuarioDTO currentItem in sourceList) {
                    tempEntity = FromDTO(currentItem);
                    returnList.Add(tempEntity);
                }
            }

            return returnList;
        }
    }
}
