using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBook_System
{
    internal class SqlRespositry
    {
        string ConnectionString = @"Data Source=.;Initial Catalog=AddressBook;Integrated Security=True;";
        public List<Contact> GetContacts()
        {
            string SQL = "select * from contacts";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SQL, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Contact> con = new List<Contact>();
            while (reader.Read())
            {
                var c = new Contact();
                c.FirstName = reader.GetString(1);
                c.LastName = reader.GetString(2);
                c.Address= reader.GetString(3);
                c.City= reader.GetString(4);
                c.State= reader.GetString(5);
                c.ZipCode = reader.GetInt32(6);
                c.Email = reader.GetString(7);
                c.PhoneNumber= (int)reader.GetInt64(8);
                con.Add(c);
            }
            connection.Close();
            return con;
        }
    }
}
