using HotelDatabase.Model;
using HotelDatabase.Reposis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelDatabase.Pages.HotelsDisplay
{
    public class IndexModel : PageModel
    {



        public IHotelRepository _repo;

        public IndexModel(IHotelRepository repo)
        {
            _repo = repo;
        }


        /*
         * properties til view
         */
        public List<Hotel> Hotels { get; set; }

        




        public void OnGet()
        {
            Hotels = _repo.GetAll();

        }

    }
}
