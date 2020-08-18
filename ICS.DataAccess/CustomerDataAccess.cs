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
    public class CustomerDataAccess
    {
        NpgsqlConnection Connection;
        NpgsqlCommand Command;

        public CustomerDataAccess()
        {
            Connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ICSConnectionStr"].ConnectionString);
        }
        public IDataReader SelectList()
        {
            string queryString = "SELECT * from customer";
            Command = new NpgsqlCommand(queryString, Connection);
            Command.CommandType = CommandType.Text;
            Connection.Open();
            return Command.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public void insert(string customer_name,string customer_phone,string customer_address,string customer_email,string gender)
        {

            string sqlString = "INSERT INTO customer(customer_name,customer_phone,customer_address,email,gender) VALUES('" + customer_name + "','" + customer_phone + "','" + customer_address + "','"+customer_email+"','"+gender+"')";

            Command = new NpgsqlCommand(sqlString, Connection);
            Command.CommandType = CommandType.Text;

            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();

        }
    }
}
