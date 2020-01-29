namespace TouristHelp.Models
{
    public class TouristBooking
    {
        public int? TouristId { get; set; }
        public string Bookings { get; set; }

        public TouristBooking(string name, string email, string pswd, string bookings)
        {
            Bookings = bookings;
        }

        public TouristBooking(int touristId, int user, string name, string email, string pswd, string bookings)
        {
            TouristId = touristId;
            Bookings = bookings;
        }
    }
}