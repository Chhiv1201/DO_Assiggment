using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SingleTon
{
    public class Database
        //: IDisposable
    {
        /// <summary>
        /// The connection which is established when connecting to the database.
        /// </summary>
        private SqlConnection _conn;

        private static object lock_ = new object();

        /// <summary>
        /// A command which can be used to execute queries.
        /// </summary>
        private SqlCommand _cmd;

        /// <summary>
        /// The private singleton instance of the database.
        /// </summary>
        private static Database _instance;

        /// <summary>
        /// The constructor.
        /// </summary>
        private Database()
        {
            //Connect(@"Data Source=DESKTOP-IF2VHJQ\ATECH;Initial Catalog=DO;Integrated Security=True");
        }

        /// <summary>
        /// The public singleton instance of the database
        /// </summary>
        public static Database Instance
        {
            get
            {
                lock (lock_)
                {
                    if (_instance == null)
                    {
                        //Create a new instance if it is not already done.
                        _instance = new Database();
                    }
                }
                return _instance;
            }
        }


        /// <summary>
        /// Return whether the connection is open or not.
        /// </summary>
        public bool isConnected
        {
            get { return _conn.State == ConnectionState.Open; }
        }

        /// <summary>
        /// This method will let the user connect to the database with a given connection string.
        /// </summary>
        /// <param name="conStr">The connection string</param>
        public void Connect(string conStr)
        {
            //Make the connection
            _conn = new SqlConnection(conStr);

            //Open the connection
            _conn.Open();
        }

        /// <summary>
        /// This method will let the user connect to the database given specific values.
        /// </summary>
        /// <param name="ip">The IP-address of the database (. for local)</param>
        /// <param name="db">The name of the database</param>
        /// <param name="uid">The user ID</param>
        /// <param name="pw">The password</param>
        public void Connect(string ip, string db, string uid, string pw)
        {
            //Make the connection
            _conn = new SqlConnection(@"Data Source=" + ip + ";Database=" + db + ";Uid=" + uid + ";Pwd=" + pw + ";Allow User Variables=True");

            //Open the connection
            _conn.Open();
        }
        public void DefaultConnect()
        {
            //Make the connection
            _conn = new SqlConnection(@"Data Source=DESKTOP-IF2VHJQ\ATECH;Initial Catalog=DO;Integrated Security=True");

            //Open the connection
            _conn.Open();
        }

        public void Disconnect()
        {

            //Close the connection
            _conn.Close();
        }

        /// <summary>
        /// This method will execute the given query and will return the result given from the database
        /// </summary>
        /// <param name="query">The query</param>
        /// <returns>The result given from the database</returns>
        public DataTable Read(string query)
        {
            DataTable _resultTable = new DataTable();

            //Only procede if there is a connection. Return null otherwise.
            if (_conn == null)
            {
                return null;
            }

            //Create the command with the given query
            _cmd = new SqlCommand(query, _conn);
            try
            {
                //We need SqlDataAdapter to store all rows in the datatable
                using (SqlDataAdapter adapter = new SqlDataAdapter(_cmd))
                {
                    adapter.Fill(_resultTable);
                }
            }
            catch (SqlException SqlException)
            {
                throw SqlException;
            }
            //Return the result.
            return _resultTable;
        }

        public object Transaction(string query, Dictionary<string, dynamic> parameters) //Insert, Delete, Update
        {
            if (_conn == null)
            {
                return null;
            }

            _cmd = new SqlCommand(query, _conn);


            foreach (var item in parameters)
            {
                _cmd.Parameters.AddWithValue( "@"+ item.Key, item.Value);
            }
            int result = _cmd.ExecuteNonQuery();

            // Check Error
            if (result < 0)
            {
                throw new Exception("Error When excute Query: ( " + query+" )");
            }
            
            return result;
        } 
        
        public object excute_SP(string proc_Name, Dictionary<string, dynamic> parameters)
        {

            object response = new object();
            List<object> lstResult = new List<object>();
            Dictionary<string, dynamic> result = new Dictionary<string, dynamic>();
            SqlCommand command = new SqlCommand(proc_Name, _conn);
            List<string> Columns = new List<string>();


            command.CommandType = CommandType.StoredProcedure;
            foreach (var item in parameters)
            {
                command.Parameters.AddWithValue("@" + item.Key, item.Value);
            }
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new Dictionary<string, dynamic>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string column = reader.GetName(i);
                        result.Add(column, reader[i]);

                        if (!Columns.Contains(column)) Columns.Add(column);
                    }
                    lstResult.Add(result);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            //db_.Connection.D();
            response = lstResult;
            return response;
        }

        //public void Dispose()
        //{
        //    Disconnect();
        //}
    }
}
