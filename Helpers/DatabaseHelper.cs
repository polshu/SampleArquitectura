using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers {
    public class DatabaseHelper {

        public static SqlConnection GetConnection() {
            return GetConnection(false);
        }

        public static SqlConnection GetConnection(bool blnOpen) {
            string          strConnectionString;
            SqlConnection   returnConnection;

            strConnectionString = AppSettingsHelper.GetAppSetting("DatabaseConnectionString", "");

            returnConnection = new SqlConnection(strConnectionString);
            if (blnOpen) {
                TryOpenConnection(returnConnection);
            }

            return returnConnection;
        }

        public static bool TryOpenConnection(SqlConnection currentConnection) {
            bool blnReturnValue = false;

            if (currentConnection != null) {
                try {
                    currentConnection.Open();
                    blnReturnValue = true;
                } catch (Exception ex) {
                    throw;
                }
            }
            return blnReturnValue;
        }

        public static bool CloseConnection(SqlConnection currentConnection) {
            bool blnReturnValue = false;

            if (currentConnection != null) {
                if(currentConnection.State != ConnectionState.Closed) {
                    currentConnection.Close();
                    blnReturnValue = true;
                }
            }

            return blnReturnValue;
        }

        public static void CloseAndDisposeReader(ref SqlDataReader currentReader) {
            if (currentReader != null) {
                if (!currentReader.IsClosed) {
                    currentReader.Close();
                }
                currentReader.Dispose();
                currentReader = null;
            }
        }

        public static int ExecuteNonQuery(string storedProcedureName, SqlParameter[] parameterArray) {
            SqlConnection   connection;
            SqlCommand      command;
            int             intReturnValue = 0; 

            connection          = GetConnection(true);
            command             = new SqlCommand(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (parameterArray != null) {
                foreach (SqlParameter item in parameterArray) {
                    command.Parameters.AddWithValue(item.ParameterName, item.Value);
                }
            }

            try {
                intReturnValue = command.ExecuteNonQuery();
            } catch (Exception ex) {
                throw;
            }
            command.Dispose();
            CloseConnection(connection);

            return intReturnValue;
        }

        public static object ExecuteScalar(string storedProcedureName, SqlParameter[] parameterArray) {
            SqlConnection   connection;
            SqlCommand      command;
            object          oReturnValue = null; 

            connection          = GetConnection(true);
            command             = new SqlCommand(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (parameterArray != null) {
                foreach (SqlParameter item in parameterArray) {
                    command.Parameters.AddWithValue(item.ParameterName, item.Value);
                }
            }

            try {
                oReturnValue = (object)command.ExecuteScalar();
            } catch (Exception ex) {
                throw;
            }
            command.Dispose();
            CloseConnection(connection);

            return oReturnValue;
        }

        public static SqlDataReader ExecuteReader(string storedProcedureName) {
            return ExecuteReader(storedProcedureName, null);
        }

        public static SqlDataReader ExecuteReader(string storedProcedureName, SqlParameter[] parameterArray) {
            SqlConnection   connection;
            SqlCommand      command;
            SqlDataReader   returnReader = null;

            connection          = GetConnection(true);
            command             = new SqlCommand(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (parameterArray != null) {
                foreach (SqlParameter item in parameterArray) {
                    command.Parameters.AddWithValue(item.ParameterName, item.Value);
                }
            }

            try {
                returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            } catch (Exception ex) {
                throw;
            }

            return returnReader;
        }

        public static object ToDBNull(string strValue) {
            object returnObject = DBNull.Value;
            if (!string.IsNullOrEmpty(strValue)) {
                returnObject = strValue;
            }
            return returnObject;
        }
    }
}
