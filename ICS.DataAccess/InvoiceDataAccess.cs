using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;
using System.Data;
using NpgsqlTypes;

namespace ICS.DataAccess
{
    public class InvoiceDataAccess
    {
        NpgsqlConnection Connection;
        NpgsqlCommand Command;

        public InvoiceDataAccess()
        {
            Connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ICSConnectionStr"].ConnectionString);
        }
        public void insert(int customer_id,int item_id,int quantity,int amount)
        {

            string sqlString= "INSERT INTO orders(customer_id,item_id,quantity,amount) VALUES(" + customer_id + ","+item_id+","+quantity+","+amount+")";
            
            Command = new NpgsqlCommand(sqlString, Connection);
            Command.CommandType = CommandType.Text;
             
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
           
        }
        public IDataReader getLastID()
        {
            string sqlString = "SELECT * FROM orders order by order_id desc limit 1";

            Command = new NpgsqlCommand(sqlString, Connection);
            Command.CommandType = CommandType.Text;

            Connection.Open();
            return Command.ExecuteReader(CommandBehavior.CloseConnection);
            
        }

    }
}
