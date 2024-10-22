namespace ReservacionesRestFull.Bussiness.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int RoomId { get; set; }

        public Room? Room { get; set; }
        public DateTime? Begin { get; set; }
        public DateTime? Final { get; set; }

        public Reservation() { }
        public Reservation (int UserId, int RoomId, DateTime Beging, DateTime End)
        {
            this.UserId = UserId;
            this.RoomId = RoomId;
            this.Begin = Beging;
            this.Final = End;
        }
    }
}
