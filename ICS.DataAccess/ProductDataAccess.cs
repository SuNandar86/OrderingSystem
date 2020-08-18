using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;
using System.Data;

namespace ICS.DataAccess
{
    public class ProductDataAccess {

        NpgsqlConnection Connection;
        NpgsqlCommand Command;

        public ProductDataAccess()
        {
            Connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ICSConnectionStr"].ConnectionString);
        }
        public IDataReader SelectList()
        {
            string queryString = "SELECT * from item";
            Command = new NpgsqlCommand(queryString, Connection);
            Command.CommandType = CommandType.Text;
            Connection.Open();
            return Command.ExecuteReader(CommandBehavior.CloseConnection); 
        }
        public IDataReader GetPrice(int product_id)
        {
            string queryString = "SELECT * from item where item_id="+product_id;
            Command = new NpgsqlCommand(queryString, Connection);
            Command.CommandType = CommandType.Text;
            Connection.Open();
            return Command.ExecuteReader(CommandBehavior.CloseConnection);

        }
    }
}
