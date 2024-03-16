namespace HotelDatabase.Model
{
    public class Room
    {
        public int Room_No { get; set; }
        public int Hotel_No { get; set; }
        public char Types { get; set; }
        public double? Price { get; set; }



        public Room()
        {
            
        }

        public Room(int room_No, int hotel_No, char types, double? price)
        {
            Room_No = room_No;
            Hotel_No = hotel_No;
            Types = types;
            Price = price;
        }

        public override string ToString()
        {
            return $"Room Number: {Room_No}, Hotel Number: {Hotel_No}, Type: {Types}, Price: {Price ?? 0}";
        }
    }
    

    
    
}
