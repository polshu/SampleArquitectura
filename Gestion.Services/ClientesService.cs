using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gestion.Entities;

namespace Gestion.Services {
    public class ClientesService {
        private static ClientesDAL GetDAL() {
            return new ClientesDAL();
        }
        
        public static Cliente GetById(int intId) {
            Cliente     returnEntity;
            ClientesDAL currentDAL = GetDAL();

            returnEntity = currentDAL.GetById(intId);

            return returnEntity;
        }

        public static List<Cliente> GetAll() {
            List<Cliente>   returnList = new List<Cliente>();
            ClientesDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetAll();

            return returnList;
        }

        public static List<Cliente> GetActivos() {
            List<Cliente>   returnList = new List<Cliente>();
            ClientesDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetByActivo(true);

            return returnList;
        }

        public static List<Cliente> GetInActivos() {
            List<Cliente>   returnList = new List<Cliente>();
            ClientesDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetByActivo(false);

            return returnList;
        }

        public static int Insert(Cliente newEntity) {
            int         intNewId;
            ClientesDAL currentDAL = GetDAL();

            intNewId = currentDAL.Insert(newEntity);
            return intNewId;
        }

        public static int InsertScalar(Cliente newEntity) {
            int         intNewId;
            ClientesDAL currentDAL = GetDAL();

            intNewId = currentDAL.InsertScalar(newEntity);
            return intNewId;
        }

        public static int InsertValid(Cliente newEntity, out string strErrores) {
            int         intNewId = 0;
            ClientesDAL currentDAL = GetDAL();

            if (IsValid(newEntity, out strErrores)) {
                intNewId = currentDAL.InsertScalar(newEntity);
            }

            return intNewId;
        }

        public static bool IsValid(Cliente testEntity, out string strErrores) {
            bool blnReturnValue = true;
            strErrores = "";

            if (testEntity != null) {
                // Valido la razon social.
                if (testEntity.RazonSocial.Trim().Length == 0) {
                    strErrores += "La Razon Social es invalida.";
                    blnReturnValue = false;
                }

                // Valido el CUIT. (11 caracteres de largo)
                if ((testEntity.CUIT.Trim().Length > 0) && (testEntity.CUIT.Trim().Length != 11)) {
                    strErrores += "Formato de CUIT invalido.";
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
