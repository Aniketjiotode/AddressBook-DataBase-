using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Xml.Linq;

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
        public bool UpdateContacts()
        {
            Console.WriteLine("Enter 1 to update FirstName\nEnter 2 to update LastName\nEnter 3 to update Address\nEnter 4 and to update City\nEnter 5  to update State\nEnter 6 to update Zipcode\nEnter 7 to update Email\nEnter 8 to update PhoneNumber");
            var input =int.Parse(Console.ReadLine());
            switch (input)
            {
            
                case 1:
                        Console.WriteLine("Enter the Id Number");
                        var id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Update FirstName");
                        var fname = Console.ReadLine();
                        string Sql = $"update contacts set FirstName='{fname}' where Id={id}";
                        SqlConnection con = new SqlConnection(ConnectionString);
                        SqlCommand sqlCommand = new SqlCommand(Sql, con);
                        con.Open();
                        int output = sqlCommand.ExecuteNonQuery();
                        con.Close();
                         return output > 0;                                     
                case 2:
                    Console.WriteLine("Enter the Id Number");
                    var id2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Update LastName");
                    var lname = Console.ReadLine();
                    string Sql2 = $"update contacts set LastName='{lname}' where Id={id2}";
                    SqlConnection con2 = new SqlConnection(ConnectionString);
                    SqlCommand sqlCommand2 = new SqlCommand(Sql2, con2);
                    con2.Open();
                    int output2 = sqlCommand2.ExecuteNonQuery();
                    con2.Close();
                    return output2 > 0;     
                case 3:
                    Console.WriteLine("Enter the Id Number");
                    var id3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Update Address");
                    var address = Console.ReadLine();
                    string Sql3 = $"update contacts set Address='{address}' where Id={id3}";
                    SqlConnection con3 = new SqlConnection(ConnectionString);
                    SqlCommand sqlCommand3 = new SqlCommand(Sql3, con3);
                    con3.Open();
                    int output3 = sqlCommand3.ExecuteNonQuery();
                    con3.Close();
                    return output3 > 0;    
                case 4:
                    Console.WriteLine("Enter the Id Number");
                    var id4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Update City Name");
                    var city = Console.ReadLine();
                    string Sql4 = $"update contacts set City='{city}' where Id={id4}";
                    SqlConnection con4 = new SqlConnection(ConnectionString);
                    SqlCommand sqlCommand4 = new SqlCommand(Sql4, con4);
                    con4.Open();
                    int output4 = sqlCommand4.ExecuteNonQuery();
                    con4.Close();
                    return output4 > 0; 
                case 5:
                    Console.WriteLine("Enter the Id Number");
                    var id5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Update state Name");
                    var state = Console.ReadLine();
                    string Sql5 = $"update contacts set State='{state}' where Id={id5}";
                    SqlConnection con5 = new SqlConnection(ConnectionString);
                    SqlCommand sqlCommand5 = new SqlCommand(Sql5, con5);
                    con5.Open();
                    int output5 = sqlCommand5.ExecuteNonQuery();
                    con5.Close();
                    return output5 > 0; 
                case 6:
                    Console.WriteLine("Enter the Id Number");
                    var id6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Update Zipcode");
                    var zipcode = int.Parse(Console.ReadLine());
                    string Sql6 = $"update contacts set ZipCode={zipcode} where Id={id6}";
                    SqlConnection con6 = new SqlConnection(ConnectionString);
                    SqlCommand sqlCommand6 = new SqlCommand(Sql6, con6);
                    con6.Open();
                    int output6 = sqlCommand6.ExecuteNonQuery();
                    con6.Close();
                    return output6 > 0;
                case 7:
                    Console.WriteLine("Enter the Id Number");
                    var id7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Update EmailId");
                    var email = Console.ReadLine();
                    string Sql7 = $"update contacts set Email='{email}' where Id={id7}";
                    SqlConnection con7 = new SqlConnection(ConnectionString);
                    SqlCommand sqlCommand7 = new SqlCommand(Sql7, con7);
                    con7.Open();
                    int output7 = sqlCommand7.ExecuteNonQuery();
                    con7.Close();
                    return output7 > 0;
                case 8:
                    Console.WriteLine("Enter the Id Number");
                    var id8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Update phoneNumber");
                    var number = int.Parse(Console.ReadLine());
                    string Sql8 = $"update contacts set PhoneNumber={number} where Id={id8}";
                    SqlConnection con8 = new SqlConnection(ConnectionString);
                    SqlCommand sqlCommand8 = new SqlCommand(Sql8, con8);
                    con8.Open();
                    int output8 = sqlCommand8.ExecuteNonQuery();
                    con8.Close();
                    return output8 > 0;
                default: Console.WriteLine("Enter Number between 1 to 8");
                    break;
              
            }

            return false;        
        }
        public List<Contact> GetContactsByDate(string date)
        {
            string SQL = $"select * from contacts where Date='{date}'";
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
                c.Address = reader.GetString(3);
                c.City = reader.GetString(4);
                c.State = reader.GetString(5);
                c.ZipCode = reader.GetInt32(6);
                c.Email = reader.GetString(7);
                c.PhoneNumber = (int)reader.GetInt64(8);
                con.Add(c);
            }
            connection.Close();
            return con;
        }
        public List<Contact> GetContactsByStateOrCity(string input)
        {
            string SQL = $"select * from contacts where City='{input}' or State='{input}'";
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
                c.Address = reader.GetString(3);
                c.City = reader.GetString(4);
                c.State = reader.GetString(5);
                c.ZipCode = reader.GetInt32(6);
                c.Email = reader.GetString(7);
                c.PhoneNumber = (int)reader.GetInt64(8);
                con.Add(c);
            }
            connection.Close();
            return con;
        }
    }
}
