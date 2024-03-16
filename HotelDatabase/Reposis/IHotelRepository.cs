using HotelDatabase.Model;
using Microsoft.Data.SqlClient;

namespace HotelDatabase.Reposis
{
    public interface IHotelRepository
    {
        List<Hotel> GetAll();

        List<Room> GetAllRooms();


    }
}