using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;
using System.Data;

namespace ICS.DataAccess
{
    public class CategoryDataAccess
    {
        NpgsqlConnection Connection;
        NpgsqlCommand Command;

        public CategoryDataAccess()
        {
            Connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ICSConnectionStr"].ConnectionString);
        }
        public IDataReader SelectList()
        {
            string queryString = "SELECT * from category";
            Command = new NpgsqlCommand(queryString, Connection);
            Command.CommandType = CommandType.Text;
            Connection.Open();
            return Command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
