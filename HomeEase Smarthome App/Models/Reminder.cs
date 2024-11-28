using System.ComponentModel.DataAnnotations;

namespace HomeEase_Smarthome_App.Models
{
    public class Reminder
    {
        [Key]
        public int ReminderId { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime ReminderDateTime { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        [Required]
        public bool IsRecurring { get; set; }

        public string RecurrenceInterval { get; set; }

        [Required]
        public string PriorityLevel { get; set; }

        public DateTime? LastNotificationSent { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        // Navigation Property
        public virtual User User { get; set; }
    }
}
