namespace HomeEase_Smarthome_App.Models
{
    public enum ReminderCategory
    {
        Medication,
        Appointments,
        Exercise,
        MealsAndLiquids,
        Work,
        Personal
    }

    public static class ReminderCategoryExtensions
    {
        public static string GetIcon(this ReminderCategory category)
        {
            switch (category)
            {
                case ReminderCategory.Medication:
                    return "pill";  // Example: FontAwesome icon name
                case ReminderCategory.Appointments:
                    return "calendar";
                case ReminderCategory.Exercise:
                    return "dumbbell";
                case ReminderCategory.Work:
                    return "briefcase";
                case ReminderCategory.Personal:
                    return "user";
                default:
                    return "question";  // Default icon if not found
            }
        }
    }
}
