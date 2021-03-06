﻿using System;
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
        public IDataReader SelectList(int brand_id)
        {
            string queryString = "SELECT * from product where brand_id="+brand_id;
            Command = new NpgsqlCommand(queryString, Connection);
            Command.CommandType = CommandType.Text;
            Connection.Open();
            return Command.ExecuteReader(CommandBehavior.CloseConnection); 
        }
        public IDataReader GetPrice(int product_id)
        {
            string queryString = "SELECT * from product where product_id=" + product_id;
            Command = new NpgsqlCommand(queryString, Connection);
            Command.CommandType = CommandType.Text;
            Connection.Open();
            return Command.ExecuteReader(CommandBehavior.CloseConnection);

        }
    }
}
