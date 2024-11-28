using System.ComponentModel.DataAnnotations;

namespace HomeEase_Smarthome_App.Models
{
    public class AutomationRule
    {
        [Key]
        public int RuleId { get; set; }

        [Required]
        public string RuleName { get; set; }

        [Required]
        public string Condition { get; set; }

        [Required]
        public string Action { get; set; }

        public int DeviceId { get; set; }

        [Required]
        public string Status { get; set; }

        // Navigation Property
        public virtual Device Device { get; set; }
    }
}
