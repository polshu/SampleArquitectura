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
    internal class UsuariosDAL {

        public Usuario GetById(int intId) {
            Usuario         returnEntity    = null;
            SqlParameter[]  parameterArray  = new SqlParameter[1];
            SqlDataReader   currentReader   = null;

            parameterArray[0] = new SqlParameter("@intId", intId);

            try {
                currentReader = DatabaseHelper.ExecuteReader("Usuarios_GetById", parameterArray);
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

        public Usuario GetByEmailClave(string strEmail, string strClave) {
            Usuario         returnEntity    = null;
            SqlParameter[]  parameterArray  = new SqlParameter[2];
            SqlDataReader   currentReader   = null;

            parameterArray[0] = new SqlParameter("@strEmail", strEmail);
            parameterArray[1] = new SqlParameter("@strClave", strClave);

            try {
                currentReader = DatabaseHelper.ExecuteReader("Usuarios_GetByEmailClave", parameterArray);
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
        

        public List<Usuario> GetByActivo(bool blnActivo) {
            List<Usuario>   returnList = new List<Usuario>();
            Usuario         currentEntity;
            SqlParameter[]  parameterArray = new SqlParameter[1];
            SqlDataReader   currentReader = null;


            parameterArray[0] = new SqlParameter("@blnActivo", blnActivo);

            try {
                currentReader = DatabaseHelper.ExecuteReader("Usuarios_GetByActivo", parameterArray);
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

        public int Insert(Usuario newEntity) {
            List<Usuario>   returnList = new List<Usuario>();
            SqlParameter[]  parameterArray = new SqlParameter[4];
            int             intNewId = 0;

            parameterArray[0] = new SqlParameter("@strNombre"   , newEntity.Nombre);
            parameterArray[1] = new SqlParameter("@strEmail"    , newEntity.Email);
            parameterArray[2] = new SqlParameter("@strClave"    , newEntity.Clave);
            parameterArray[3] = new SqlParameter("@blnActivo"   , newEntity.Activo);

            try {
                intNewId = DatabaseHelper.ExecuteNonQuery("Usuarios_Insert", parameterArray);
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            return intNewId;
        }

        public int InsertScalar(Usuario newEntity) {
            List<Usuario>   returnList = new List<Usuario>();
            SqlParameter[]  parameterArray = new SqlParameter[4];
            int             intNewId = 0;
            object          currentObject;

            parameterArray[0] = new SqlParameter("@strNombre", newEntity.Nombre);
            parameterArray[1] = new SqlParameter("@strEmail", newEntity.Email);
            parameterArray[2] = new SqlParameter("@strClave", newEntity.Clave);
            parameterArray[3] = new SqlParameter("@blnActivo", newEntity.Activo);

            try {
                currentObject = DatabaseHelper.ExecuteScalar("Usuarios_InsertScalar", parameterArray);
                intNewId = Convert.ToInt32(currentObject);
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            return intNewId;
        }

        public List<Usuario> GetAll() {
            List<Usuario>   returnList = new List<Usuario>();
            Usuario         currentEntity;
            SqlDataReader   currentReader = null;

            try {
                currentReader = DatabaseHelper.ExecuteReader("Usuarios_GetAll", null);
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

        private Usuario DataReaderToObject(SqlDataReader currentReader) {
            Usuario returnEntity = null;

            if (currentReader != null) {
                returnEntity = new Usuario();
                returnEntity.Id     = (currentReader["Id"] != DBNull.Value ? (int)currentReader["Id"] : 0);
                returnEntity.Nombre = (currentReader["Nombre"] != DBNull.Value ? (string)currentReader["Nombre"] : "");
                returnEntity.Email  = (currentReader["Email"] != DBNull.Value ? (string)currentReader["Email"] : "");
                returnEntity.Clave = (currentReader["Clave"] != DBNull.Value ? (string)currentReader["Clave"] : "");
                returnEntity.Activo = (currentReader["Activo"] != DBNull.Value ? (bool)currentReader["Activo"] : false);
            }

            return returnEntity;
        }
    }
}
