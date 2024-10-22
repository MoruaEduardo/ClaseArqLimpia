using ReservacionesRestFull.Bussiness.Entities;
using ReservacionesRestFull.Data.DTO;
using ReservacionesRestFull.Data.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace ReservacionesRestFull.Bussiness.Services.Implementation
{
    public class ReservationServiceImpl : IReservationService
    {
        private readonly UserRepository _userRepository;
        private readonly ReservationRepository _reservationRepository;
        private readonly RoomRepository _roomRepository;

        public ReservationServiceImpl(UserRepository userRepository,
                ReservationRepository reservationRepository,
                RoomRepository roomRepository)
        { 
            _userRepository = userRepository;
            _reservationRepository = reservationRepository;
            _roomRepository = roomRepository;
        }

        public List<Reservation> GetAll()
        {
            return _reservationRepository.GetAll();
        }

        public List<Room> GetAvailableRooms()
        {
            return _roomRepository.GetAvailable();
        }

        public int Insert(ReservationDTO dto)
        {
            var user = new User();
            try
            {
                user = _userRepository.FindById(dto.UserId);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"No existe el usuario {ex.Message}");
                throw ex;
            }

            //busqueda de cuerto
            var room = new Room();
            try
            {
                room = _roomRepository.FindById(dto.RoomId);
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message );
                throw ex;
            }

            if (room.Available)
            {
                Reservation reservation = new Reservation()
                {
                    UserId = user.Id,
                    RoomId = room.Id,
                    Begin = dto.Begin,
                    Final = dto.End
                };
                var result = _reservationRepository.Insert(reservation);
                room.Available = false;
                _roomRepository.Update(room);
                return result;
            }
            throw new Exception($"Habitación no disponible {room.Id} ");
        }
    }
}
