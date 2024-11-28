using HomeEase_Smarthome_App.Models;
using System.ComponentModel.DataAnnotations;

namespace HomeEase_Smarthome_App.Models
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }

        [Required]
        public string DeviceName { get; set; }

        [Required]
        public string DeviceType { get; set; }

        [Required]
        public string Status { get; set; }

        public int UserId { get; set; }

        // Navigation Property
        public virtual User User { get; set; }
        public ICollection<Sensor> Sensors { get; set; }
        public ICollection<AutomationRule> AutomationRules { get; set; }
    }
}
