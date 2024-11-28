using HomeEase_Smarthome_App.Models;
using Microsoft.EntityFrameworkCore;



namespace HomeEase_Smarthome_App.Data
{
    public class HomeEaseDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<AutomationRule> AutomationRules { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Alert> Alerts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set custom table names
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Device>().ToTable("Devices");
            modelBuilder.Entity<Room>().ToTable("Rooms");
            modelBuilder.Entity<Sensor>().ToTable("Sensors");
            modelBuilder.Entity<AutomationRule>().ToTable("AutomationRules");
            modelBuilder.Entity<Reminder>().ToTable("Reminders");
            modelBuilder.Entity<Alert>().ToTable("Alerts");

            // Configure relationships in EF Core
            modelBuilder.Entity<Device>()
                .HasOne(d => d.User)
                .WithMany(u => u.Devices)
                .HasForeignKey(d => d.UserId);

            modelBuilder.Entity<Room>()
                .HasOne(r => r.User)
                .WithMany(u => u.Rooms)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Sensor>()
                .HasOne(s => s.Device)
                .WithMany(d => d.Sensors)
                .HasForeignKey(s => s.DeviceId);

            modelBuilder.Entity<Sensor>()
                .HasOne(s => s.Room)
                .WithMany(r => r.Sensors)
                .HasForeignKey(s => s.RoomId);

            modelBuilder.Entity<AutomationRule>()
                .HasOne(a => a.Device)
                .WithMany(d => d.AutomationRules)
                .HasForeignKey(a => a.DeviceId);

            modelBuilder.Entity<Reminder>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reminders)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Alert>()
                .HasOne(a => a.User)
                .WithMany(u => u.Alerts)
                .HasForeignKey(a => a.UserId);

            // Identity property configurations
            modelBuilder.Entity<User>()
                .Property(u => u.UserId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Device>()
                .Property(d => d.DeviceId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Room>()
                .Property(r => r.RoomId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Sensor>()
                .Property(s => s.SensorId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<AutomationRule>()
                .Property(ar => ar.RuleId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Reminder>()
                .Property(r => r.ReminderId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Alert>()
                .Property(a => a.AlertId)
                .ValueGeneratedOnAdd();
        }

    }
}