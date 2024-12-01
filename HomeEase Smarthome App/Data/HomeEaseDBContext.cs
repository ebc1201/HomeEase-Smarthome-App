using Microsoft.EntityFrameworkCore;
using HomeEase_Smarthome_App.Models;



namespace HomeEase_Smarthome_App.Data
{
    public class HomeEaseDbContext : DbContext
    {
        public HomeEaseDbContext(DbContextOptions options) : base(options) { 
        
        
        }

        public DbSet<Reminder> Reminders {  get; set; }
        public DbSet<ReminderDbo> RemindersDbo { get; set; }

    }
}