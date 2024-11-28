using System.ComponentModel.DataAnnotations;

namespace HomeEase_Smarthome_App.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        public string RoomName { get; set; }

        public int UserId { get; set; }

        // Navigation Property
        public virtual User User { get; set; }
        public ICollection<Sensor> Sensors { get; set; }
    }
}
