using Microsoft.EntityFrameworkCore;
using ReservacionesRestFull.Bussiness.Entities;

namespace ReservacionesRestFull.Data.Repositories
{
    public class ReservationRepository
    {
        private readonly AppDBContext _dbContext;
        public ReservationRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public int Insert(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            var result = _dbContext.SaveChanges();
            return result;
        }

        public Reservation FindById(int id)
        {
            var result = _dbContext.Reservations.Find(id);
            if (result != null)
            {
                return result;
            }
            throw new Exception($"Reservation {id} no existe!!");
        }

        public List<Reservation> GetAll()
        {
            return _dbContext.Reservations.Include(t => t.Room)
                .Include(t => t.User).ToList();
        }

    }
}
