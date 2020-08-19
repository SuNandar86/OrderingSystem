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
        public int insert(int customer_id,int item_id,int quantity,int amount,DateTime order_date)
        {

            string sqlString= "INSERT INTO orders(customer_id,product_id,quantity,amount,order_date) VALUES(" + customer_id + ","+item_id+","+quantity+","+amount+",'"+ order_date+"') returning order_id";
            
            Command = new NpgsqlCommand(sqlString, Connection);
            Command.CommandType = CommandType.Text;
            Connection.Open();
            string order_id= Command.ExecuteScalar().ToString();            
            Connection.Close();

            return Convert.ToInt32(order_id);           
        }         

    }
}
