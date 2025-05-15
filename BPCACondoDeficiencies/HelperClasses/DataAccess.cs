using System;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BPCACondoDeficiencies.DataAccess
{
    public static class DataAccess
    {
        [ThreadStatic]
        private static SqlConnection _connection;

        public static void Initialize()
        {
            _connection = new SqlConnection(Startup.ConnectionString);
        }

        internal static DataSet ExecuteDataSet(string sprocName, params object[] parameters)
        {
            if (parameters.Length != 0 && (parameters.Length % 2) != 0)
            {
                throw new Exception("There is a parameter mismatch.");
            }

            DataSet retVal = new DataSet();
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sprocName;

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                        i++;
                    }

                    if (_connection == null)
                        _connection = new SqlConnection(Startup.ConnectionString);

                    cmd.Connection = _connection;

                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        da.Fill(retVal);
                    }
                }
                finally
                {
                    if (cmd.Connection.State != ConnectionState.Closed)
                        cmd.Connection.Close();
                }
            }
            return retVal;
        }

        internal static DataTable ExecuteDataTable(string sprocName, params object[] parameters)
        {
            if (parameters.Length != 0 && (parameters.Length % 2) != 0)
            {
                throw new Exception("There is a parameter mismatch.");
            }

            DataTable retVal = new DataTable();
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sprocName;

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                        i++;
                    }

                    if (_connection == null)
                        _connection = new SqlConnection(Startup.ConnectionString);

                    cmd.Connection = _connection;

                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        retVal.Load(dr);
                    }
                }
                catch (Exception ex) {
                    throw (ex);
                }
                finally
                {
                    if (cmd.Connection.State != ConnectionState.Closed)
                        cmd.Connection.Close();
                }
            }
            return retVal;
        }

        internal static DataTable ExecuteNonQuery(string sprocName, params object[] parameters)
        {
            if (parameters.Length != 0 && (parameters.Length % 2) != 0)
            {
                throw new Exception("There is a parameter mismatch.");
            }

            DataTable retVal = new DataTable();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sprocName;

                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                    i++;
                }

                if (_connection == null)
                    _connection = new SqlConnection(Startup.ConnectionString);

                try
                {
                    cmd.Connection = _connection;
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
                catch (Exception ex) {
                    throw ex;
                }
                finally
                {
                    if (cmd.Connection.State != ConnectionState.Closed)
                        cmd.Connection.Close();

                    cmd.Dispose();
                }
            }
            return retVal;
        }

        internal static object ExecuteScalar(string sprocName, params object[] parameters)
        {
            if (parameters.Length != 0 && (parameters.Length % 2) != 0)
            {
                throw new Exception("There is a parameter mismatch.");
            }

            DataTable retVal = new DataTable();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sprocName;

                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                    i++;
                }

                if (_connection == null)
                    _connection = new SqlConnection(Startup.ConnectionString);

                try
                {
                    cmd.Connection = _connection;
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
                finally
                {
                    if (cmd.Connection.State != ConnectionState.Closed)
                        cmd.Connection.Close();

                    cmd.Dispose();
                }
            }
            return retVal;
        }
        internal static object ExecuteScalar(CommandType commandType, string commandString, params object[] parameters)
        {
            if (parameters.Length != 0 && (parameters.Length % 2) != 0)
            {
                throw new Exception("There is a parameter mismatch.");
            }

            object retVal = null;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = commandType;
                cmd.CommandText = commandString;

                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                    i++;
                }

                if (_connection == null)
                    _connection = new SqlConnection(Startup.ConnectionString);

                try
                {
                    cmd.Connection = _connection;
                    cmd.Connection.Open();
                    retVal = cmd.ExecuteScalar();
                    cmd.Connection.Close();
                }
                finally
                {
                    if (cmd.Connection.State != ConnectionState.Closed)
                        cmd.Connection.Close();

                    cmd.Dispose();
                }
            }
            return retVal;
        }
    }
}
