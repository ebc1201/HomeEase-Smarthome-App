using System.ComponentModel.DataAnnotations;

namespace HomeEase_Smarthome_App.Models
{
    public class Alert
    {
        [Key]
        public int AlertId { get; set; }

        public int UserId { get; set; }

        [Required]
        public string AlertType { get; set; }

        [Required]
        public string AlertMessage { get; set; }

        [Required]
        public DateTime AlertTime { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public bool IsAcknowledged { get; set; }

        [Required]
        public string PriorityLevel { get; set; }

        public int? DeviceId { get; set; }
        public int? SensorId { get; set; }

        // Navigation Properties
        public virtual User User { get; set; }
        public virtual Device Device { get; set; }
        public virtual Sensor Sensor { get; set; }
    }
}
