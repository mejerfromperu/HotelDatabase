using HotelDatabase.Model;
using HotelDatabase.Reposis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelDatabase.Pages.HotelsDisplay
{
    public class RoomsIndexModel : PageModel
    {
        public IHotelRepository _repo;

        public RoomsIndexModel(IHotelRepository repo)
        {
            _repo = repo;
        }

        public double averagepPrice { get; set; }
        /*
         * properties til view
         */
        public List<Room> Rooms { get; set; }





        public void OnGet()
        {
            Rooms = _repo.GetAllRooms();
            if (Rooms.Any())
            {
                averagepPrice = (double)Rooms.Average(room => room.Price);
            }
            
        }
    }
}
