using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27_AddressBook_Part_2
{
    public class AddressBookRepository
    {
        public static string ConnectingString = @"Data Source=LAPTOP-5KJG784B;Initial Catalog=address_book_service_DB;User ID=RonitKP;Password=password;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Connection = null;

        public void AddressBookSystem()
        {
            try
            {
                using (Connection = new SqlConnection(ConnectingString))
                {
                    CreatePerson create = new CreatePerson();
                    string query = "select * from addressbook";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    Connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            create.Serial_Number = Convert.ToInt32(reader["Serial_Number"] == DBNull.Value ? default : reader["Serial_Number"]);
                            create.First_Name = reader["First_Name"] == DBNull.Value ? default : reader["First_Name"].ToString();
                            create.Address = reader["Address"] == DBNull.Value ? default : reader["Address"].ToString();
                            create.Last_Name = reader["Last_Name"] == DBNull.Value ? default : reader["Last_Name"].ToString();
                            create.City = reader["City"] == DBNull.Value ? default : reader["City"].ToString();
                            create.State = reader["State"] == DBNull.Value ? default : reader["State"].ToString();
                            create.Zip = Convert.ToInt32(reader["Zip"] == DBNull.Value ? default : reader["Zip"]);
                            
                            create.Phone = Convert.ToInt64(reader["Phone"] == DBNull.Value ? default : reader["Phone"]);
                            create.Email = reader["Email"] == DBNull.Value ? default : reader["Email"].ToString();
                            create.Type = reader["Type"] == DBNull.Value ? default : reader["Type"].ToString();
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", create.Serial_Number,create.First_Name,create.Last_Name,create.Address,create.City,create.State,create.Zip,create.Phone,create.Email,create.Type);
                            Console.WriteLine("\n");
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateContactInformation(CreatePerson create)
        {
            try
            {
                using (Connection = new SqlConnection(ConnectingString))
                {
                    CreatePerson create1 = new CreatePerson();
                    SqlCommand command = new SqlCommand("dbo.spUpdateContactInformation",Connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@First_Name", create.First_Name);
                    command.Parameters.AddWithValue("@Last_Name", create.Last_Name);
                    command.Parameters.AddWithValue("@Phone", create.Phone);
                    Connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result != 0)
                        Console.WriteLine("Updated successfully");
                    else
                    
                        Console.WriteLine("Unsuccessfull");    
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public void AddContact(CreatePerson create)
        {
            try
            {
                Connection = new SqlConnection(ConnectingString);
                SqlCommand cmd = new SqlCommand("dbo.spAddContact", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@First_Name", create.First_Name);
                cmd.Parameters.AddWithValue("@Last_Name",create.Last_Name);
                cmd.Parameters.AddWithValue("@Address",create.Address);
                cmd.Parameters.AddWithValue("@Type",create.Type);
                cmd.Parameters.AddWithValue("@City",create.City);
                cmd.Parameters.AddWithValue("@State", create.State);
                cmd.Parameters.AddWithValue("@Email", create.Email);
                cmd.Parameters.AddWithValue("@Zip", create.Zip);
                cmd.Parameters.AddWithValue("@Phone", create.Phone);
                cmd.Prepare();
                Connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result != 0)
                    Console.WriteLine("Employee inserted successfully into table");
                else
                    Console.WriteLine("Not Insertes");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
