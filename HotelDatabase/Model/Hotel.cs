namespace HotelDatabase.Model
{
    public class Hotel
    {

        public int Hotel_no { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Hotel()
        {
            
        }

        public Hotel(int hotel_no, string name, string address)
        {
            Hotel_no = hotel_no;
            Name = name;
            Address = address;
        }


    }
}
