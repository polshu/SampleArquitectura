using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gestion.Entities;

namespace Gestion.Services {
    public class UsuariosService {
        private static UsuariosDAL GetDAL() {
            return new UsuariosDAL();
        }
        
        public static Usuario GetById(int intId) {
            Usuario     returnEntity;
            UsuariosDAL currentDAL = GetDAL();

            returnEntity = currentDAL.GetById(intId);

            return returnEntity;
        }

        public static Usuario GetByEmailClave(string strEmail, string strClave) {
            Usuario returnEntity;
            UsuariosDAL currentDAL = GetDAL();

            returnEntity = currentDAL.GetByEmailClave(strEmail, strClave);

            return returnEntity;
        }

        public static List<Usuario> GetAll() {
            List<Usuario>   returnList = new List<Usuario>();
            UsuariosDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetAll();

            return returnList;
        }

        public static List<Usuario> GetActivos() {
            List<Usuario>   returnList = new List<Usuario>();
            UsuariosDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetByActivo(true);

            return returnList;
        }

        public static List<Usuario> GetInActivos() {
            List<Usuario>   returnList = new List<Usuario>();
            UsuariosDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetByActivo(false);

            return returnList;
        }

        public static int Insert(Usuario newEntity) {
            int         intNewId;
            UsuariosDAL currentDAL = GetDAL();

            intNewId = currentDAL.Insert(newEntity);
            return intNewId;
        }

        public static int InsertScalar(Usuario newEntity) {
            int         intNewId;
            UsuariosDAL currentDAL = GetDAL();

            intNewId = currentDAL.InsertScalar(newEntity);
            return intNewId;
        }

        public static int InsertValid(Usuario newEntity, out string strErrores) {
            int         intNewId = 0;
            UsuariosDAL currentDAL = GetDAL();

            if (IsValid(newEntity, out strErrores)) {
                intNewId = currentDAL.InsertScalar(newEntity);
            }

            return intNewId;
        }

        public static bool IsValid(Usuario testEntity, out string strErrores) {
            bool blnReturnValue = true;
            strErrores = "";

            if (testEntity != null) {
                // Valido el nombre.
                if (testEntity.Nombre.Trim().Length == 0) {
                    strErrores += "El nombre es invalido.";
                    blnReturnValue = false;
                }

                // Valido el email, si lo puso quye haya puesto un arroba.
                if ((testEntity.Email.Trim().Length > 0) && (!testEntity.Email.Contains("@"))) {
                    strErrores += "Falta el arroba en el email.";
                    blnReturnValue = false;
                }

                // Valido el email, si lo puso quye haya puesto un arroba.
                if ((testEntity.Clave.Trim().Length > 4)) {
                    strErrores += "La Clave debe tener al menos 4 caracteres.";
                    blnReturnValue = false;
                }
            } else {
                strErrores += "El objeto es NULL!!";
                blnReturnValue = false;
            }
            return blnReturnValue;
        }
    }
}
