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

        public Database(string server, string database, string user, string pwsd)
        {
            mySqlConnection = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + pwsd + ";");
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
    }
}
