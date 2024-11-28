using System.ComponentModel.DataAnnotations;

namespace HomeEase_Smarthome_App.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Email { get; set; }

        public string ProfilePicture { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime? LastLogin { get; set; }

        // Navigation Properties
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Reminder> Reminders { get; set; }
        public virtual ICollection<Alert> Alerts { get; set; }
    }
}
