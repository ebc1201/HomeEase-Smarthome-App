using HomeEase_Smarthome_App.Data;
using HomeEase_Smarthome_App.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeEase_Smarthome_App.Services
{
    public class ReminderService : IReminderService
    {
        private readonly HomeEaseDbContext _context;

        public ReminderService(HomeEaseDbContext context)
        {
            _context = context;
        }

        // Method to get all reminders
        public async Task<IEnumerable<ReminderDbo>> GetAllRemindersAsync()
        {
            // Fetch the list of reminders from the database
            var reminders = await _context.Reminders.ToListAsync();

            // Manually map Reminder to ReminderDbo
            var reminderDboList = reminders.Select(r => new ReminderDbo
            {
                ReminderId = r.ReminderId,
                Title = r.Title,
                ReminderDateTime = r.ReminderDateTime,
                Category = r.Category
                // Map other properties as needed
            }).ToList();

            return reminderDboList;
        }

        //public async Task<IEnumerable<ReminderDbo>> GetAllRemindersAsync()
        //{
        //    var reminders = await _context.Reminders.ToListAsync();

        //    var reminderDboList = reminders.Select(r => new ReminderDbo
        //    {
        //        ReminderId = r.ReminderId,
        //        Title = r.Title,
        //        ReminderDateTime = r.ReminderDateTime,
        //        // Map other properties similarly
        //    }).ToList();

        //    return reminderDboList;
        //}


        // Method to add a reminder
        public async Task AddReminderAsync(ReminderDbo reminder)
        {
            // Convert ReminderDbo to Reminder (the EF entity) before saving
            var reminderEntity = new Reminder
            {

                ReminderId = reminder.ReminderId,
                Title = reminder.Title,
                ReminderDateTime = reminder.ReminderDateTime,
                Category = reminder.Category
                // Map other properties as needed
            };

            // Add the reminder entity to the database
            _context.Reminders.Add(reminderEntity);
            await _context.SaveChangesAsync();
        }

        public Task<ReminderDbo> GetReminderByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
