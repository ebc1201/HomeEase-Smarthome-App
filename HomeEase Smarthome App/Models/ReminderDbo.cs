using System.ComponentModel.DataAnnotations;

namespace HomeEase_Smarthome_App.Models
{
    public class ReminderDbo
    {
        public enum ReminderCategory
        {
            Medication,
            Appointments,
            MealsAndLiquids,
            Exercise
        }
        public int ReminderId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } // Title of the reminder

        [Required]
        public DateTime ReminderDateTime { get; set; } // Time and date for the reminder

        [Required]
        [StringLength(50)]
        public string Category { get; set; } // Category (Medication, Appointments, etc.)
    }
}
