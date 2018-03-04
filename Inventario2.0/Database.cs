using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inventario2._0
{

    class Database
    {

        private MySqlDataAdapter mySqlDataAdapter=null;
        private MySqlConnection mySqlConnection = null;
        private bool mySqlConnectionOpened = false;

        //default credentials
        private string server = "localhost";
        private string database = "inventario";
        private string user = "root";
        private string password = "";

        public Database(string server, string database, string user, string pwsd)
        {
            this.initilize(server, database, user, pwsd);
        }

        public Database()
        {
            this.initilize(this.server, this.database, this.user, this.password);
        }

        private void initilize(string server, string database, string user, string pwsd)
        {
            mySqlConnection = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + pwsd + "; Allow User Variables=True;");
        }

        public bool openConnection()
        {
            try
            {
                mySqlConnection.Open();
                mySqlConnectionOpened = true;
                return mySqlConnectionOpened;
            }
            catch (MySqlException e)
            {
                mySqlConnectionOpened = false;
                return mySqlConnectionOpened;
            }
        }

        public MySqlDataAdapter getMySqlDataAdapter(string query)
        {
            try
            {
                if (mySqlConnectionOpened)
                {
                    mySqlDataAdapter = new MySqlDataAdapter(query, this.mySqlConnection);
                    return mySqlDataAdapter;
                }
                else
                {
                    this.openConnection();
                    return this.getMySqlDataAdapter(query);
                }
            }
            catch(MySqlException ex)
            {
                return null;
            }
            
        }

        public bool closeConnection()
        {
            try
            {
                this.mySqlConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public int executeNonQuery(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, this.mySqlConnection);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch(MySqlException e)
            {
                System.Console.WriteLine(e.ToString());
                return -1;
            }
        }

        public MySqlDataReader executeReader(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, this.mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch(MySqlException e)
            {
                System.Console.WriteLine(e.ToString());
                return null;
            }
        }


    }
}
