using Agendamento.Models;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Client> Clients { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
        }
    }
}