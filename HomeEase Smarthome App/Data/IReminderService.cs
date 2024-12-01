using HomeEase_Smarthome_App.Models;
using System;

namespace HomeEase_Smarthome_App.Data
{
    public interface IReminderService
    {

        Task<IEnumerable<ReminderDbo>> GetAllRemindersAsync();
        Task<ReminderDbo> GetReminderByIdAsync(int id);
        Task AddReminderAsync(ReminderDbo reminder);
        // Add any other methods for your service as needed
    }
}