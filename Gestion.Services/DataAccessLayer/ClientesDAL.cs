using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gestion.Entities;

namespace Gestion.Services {
    internal class ClientesDAL {

        public Cliente GetById(int intId) {
            Cliente returnEntity = null;



            return returnEntity;
        }

        public List<Cliente> GetAll() {
            List<Cliente> returnList = new List<Cliente>();


            return returnList;
        }

        public List<Cliente> GetByActivo(bool blnActivo) {
            List<Cliente> returnList = new List<Cliente>();


            return returnList;
        }



        private Cliente DataReaderToObject(SqlDataReader currentReader) {
            Cliente returnEntity = null;

            if (currentReader != null) {
                returnEntity = new Cliente();
                returnEntity.Id             = (currentReader["Id"] != DBNull.Value ? (int)currentReader["Id"] : 0);
                returnEntity.RazonSocial    = (currentReader["RazonSocial"] != DBNull.Value ? (string)currentReader["RazonSocial"] : "");
                returnEntity.CUIT           = (currentReader["CUIT"] != DBNull.Value ? (string)currentReader["CUIT"] : "");
                returnEntity.Activo         = (currentReader["Activo"] != DBNull.Value ? (bool)currentReader["Activo"] : false);
            }

            return returnEntity;
        }

    }
}
