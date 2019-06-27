using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gestion.Entities;
using Helpers;

namespace Gestion.Services {
    internal class ClientesDAL {

        public Cliente GetById(int intId) {
            Cliente         returnEntity = null;
            SqlParameter[]  parameterArray = new SqlParameter[1];
            SqlDataReader   currentReader = null;

            parameterArray[0] = new SqlParameter("@intId", intId);

            try {
                currentReader = DatabaseHelper.ExecuteReader("Clientes_GetById", parameterArray);
                if (currentReader != null) {
                    if (currentReader.HasRows) {
                        currentReader.Read();
                        returnEntity = DataReaderToObject(currentReader);
                    }
                }
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            DatabaseHelper.CloseAndDisposeReader(ref currentReader);

            return returnEntity;
        }

        public List<Cliente> GetByActivo(bool blnActivo) {
            List<Cliente>   returnList = new List<Cliente>();
            Cliente         currentEntity;
            SqlParameter[]  parameterArray = new SqlParameter[1];
            SqlDataReader   currentReader = null;


            parameterArray[0] = new SqlParameter("@blnActivo", blnActivo);

            try {
                currentReader = DatabaseHelper.ExecuteReader("Clientes_GetByActivo", parameterArray);
                if (currentReader != null) {
                    if (currentReader.HasRows) {
                        while (currentReader.Read()) {
                            currentEntity = DataReaderToObject(currentReader);
                            returnList.Add(currentEntity);
                        }
                    }
                }
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            DatabaseHelper.CloseAndDisposeReader(ref currentReader);

            return returnList;
        }

        public int Insert(Cliente newEntity) {
            List<Cliente>   returnList = new List<Cliente>();
            SqlParameter[]  parameterArray = new SqlParameter[3];
            int             intNewId = 0;

            parameterArray[0] = new SqlParameter("@strRazonSocial"  , newEntity.RazonSocial);
            parameterArray[1] = new SqlParameter("@strCUIT"         , newEntity.CUIT);
            parameterArray[2] = new SqlParameter("@blnActivo"       , newEntity.Activo);

            try {
                intNewId = DatabaseHelper.ExecuteNonQuery("Clientes_Insert", parameterArray);
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            return intNewId;
        }

        public int InsertScalar(Cliente newEntity) {
            List<Cliente>   returnList = new List<Cliente>();
            SqlParameter[]  parameterArray = new SqlParameter[3];
            int             intNewId = 0;
            object          currentObject;

            parameterArray[0] = new SqlParameter("@strRazonSocial"  , newEntity.RazonSocial);
            parameterArray[1] = new SqlParameter("@strCUIT"         , newEntity.CUIT);
            parameterArray[2] = new SqlParameter("@blnActivo"       , newEntity.Activo);

            try {
                currentObject = DatabaseHelper.ExecuteScalar("Clientes_InsertScalar", parameterArray);
                intNewId = Convert.ToInt32(currentObject);
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            return intNewId;
        }

        public List<Cliente> GetAll() {
            List<Cliente>   returnList = new List<Cliente>();
            Cliente         currentEntity;
            SqlDataReader   currentReader = null;

            try {
                currentReader = DatabaseHelper.ExecuteReader("Clientes_GetAll", null);
                if (currentReader.HasRows) {
                    while (currentReader.Read()) {
                        currentEntity = DataReaderToObject(currentReader);
                        returnList.Add(currentEntity);
                    }
                }
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            DatabaseHelper.CloseAndDisposeReader(ref currentReader);

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
