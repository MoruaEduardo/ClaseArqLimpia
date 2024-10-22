using Microsoft.EntityFrameworkCore;
using ReservacionesRestFull.Bussiness.Entities;

namespace ReservacionesRestFull.Data
{
    /*ESTA CLASE RRPRESENTA AL CONTEXTO (CONEXION) A LA BASE DE DATOS*/
    public class AppDBContext : DbContext
    {
        public AppDBContext() { }
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }

        /*DECLARANDO ENTIDADES*/
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("server=localhst;port=3306");   

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(t=>t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Room>().Property(t => t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Reservation>().Property(t => t.Id).ValueGeneratedOnAdd();

            /*FK*/
            modelBuilder.Entity<Room>().HasMany(t=>t.Reservations).WithOne(t=>t.Room).HasForeignKey(t=>t.RoomId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
