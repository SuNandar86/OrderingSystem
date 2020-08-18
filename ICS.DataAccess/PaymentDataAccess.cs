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
    public class PaymentDataAccess
    {
        NpgsqlConnection Connection;
        NpgsqlCommand Command;

        public PaymentDataAccess()
        {
            Connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ICSConnectionStr"].ConnectionString);
        }
        public void insert(int order_id,int customer_id,string payment_type,int amount,DateTime payment_date)
        {
            string sqlString = "INSERT INTO payment(order_id,customer_id,payment_type,amount,payment_date) VALUES(" + order_id + "," + customer_id + ",'" + payment_type + "',"+amount+",'" +payment_date+"')";
            Command = new NpgsqlCommand(sqlString, Connection);
            Command.CommandType = CommandType.Text;

            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();

        }
    }
}
