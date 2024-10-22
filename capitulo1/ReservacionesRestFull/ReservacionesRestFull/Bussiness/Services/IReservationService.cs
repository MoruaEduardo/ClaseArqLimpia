using ReservacionesRestFull.Bussiness.Entities;
using ReservacionesRestFull.Data.DTO;

namespace ReservacionesRestFull.Bussiness.Services
{
    public interface IReservationService
    {
        List<Reservation> GetAll();
        int Insert(ReservationDTO dto);

        List<Room> GetAvailableRooms();

    }
}
