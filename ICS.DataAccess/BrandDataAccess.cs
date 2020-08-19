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
    public class BrandDataAccess
    {
        NpgsqlConnection Connection;
        NpgsqlCommand Command;

        public BrandDataAccess()
        {
            Connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ICSConnectionStr"].ConnectionString);
        }
        public IDataReader SelectList(int category_id)
        {
            string queryString = "SELECT * from brand where category_id="+category_id;
            Command = new NpgsqlCommand(queryString, Connection);
            Command.CommandType = CommandType.Text;
            Connection.Open();
            return Command.ExecuteReader(CommandBehavior.CloseConnection);

        }
    }
}
