using System.ComponentModel.DataAnnotations;

namespace HomeEase_Smarthome_App.Models
{
    public class Sensor
    {
        [Key]
        public int SensorId { get; set; }

        [Required]
        public string SensorName { get; set; }

        [Required]
        public string SensorType { get; set; }

        public int DeviceId { get; set; }
        public int RoomId { get; set; }

        [Required]
        public string Status { get; set; }

        // Navigation Properties
        public virtual Device Device { get; set; }
        public virtual Room Room { get; set; }
    }
}
