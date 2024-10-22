using ReservacionesRestFull.Bussiness.Entities;
using ZstdSharp.Unsafe;

namespace ReservacionesRestFull.Data.Repositories
{
    public class RoomRepository
    {
        private readonly AppDBContext _dbContext;
        public RoomRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public int Insert(Room room)
        {
            _dbContext.Rooms.Add(room);
            var result = _dbContext.SaveChanges();
            return result;
        }

        public Room FindById(int id)
        {
            var result = _dbContext.Rooms.Find(id);
            if (result != null)
            {
                return result;
            }
            throw new Exception($"User {id} no existe!!");
        }

        public int Update(Room room)
        {
            var rSearch = _dbContext.Rooms.Find(room.Id);
            if (rSearch != null) {
                _dbContext.Update(room);
                return _dbContext.SaveChanges();
            }
            throw new Exception($"No existe {room.Id}");
        }

        public List<Room> GetAvailable()
        {
            return _dbContext.Rooms.Where(t=> t.Available).ToList();
        }

    }
}
