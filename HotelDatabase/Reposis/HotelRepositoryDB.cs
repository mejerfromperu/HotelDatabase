using HotelDatabase.Model;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Data.SqlClient;

namespace HotelDatabase.Reposis
{
    public class HotelRepositoryDB : IHotelRepository
    {


        public List<Hotel> GetAll()
        {
            List<Hotel> list = new List<Hotel>();

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            connection.Open();

            string sql = "SELECT * FROM Hotel";
            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Hotel hotel = ReadHotel(reader);
                list.Add(hotel);
            }


            connection.Close();
            return list;


        }
        private Hotel ReadHotel(SqlDataReader reader)
        {
            Hotel hotel = new Hotel();

            hotel.Hotel_no = reader.GetInt32(0);
            hotel.Name = reader.GetString(1);
            hotel.Address = reader.GetString(2);

            return hotel;
        }



        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                string sql = "SELECT * FROM Room";
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Room room = ReadRoom(reader);
                    rooms.Add(room);
                }
            }

            return rooms;
        }

        private Room ReadRoom(SqlDataReader reader)
        {
            Room room = new Room();

            room.Room_No = reader.GetInt32(0);
            room.Hotel_No = reader.GetInt32(1);
            room.Price = reader.IsDBNull(3) ? null : (double?)reader.GetDouble(3);

            return room;
        }


    }
}
