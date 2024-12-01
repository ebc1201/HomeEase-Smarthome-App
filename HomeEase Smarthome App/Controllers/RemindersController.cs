using HomeEase_Smarthome_App.Models;
using Microsoft.AspNetCore.Mvc;
using HomeEase_Smarthome_App.Data;

public class RemindersController : Controller
{
    private readonly IReminderService _reminderService;

    public RemindersController(IReminderService reminderService)
    {
        _reminderService = reminderService;
    }

    public async Task<IActionResult> Index()
    {
        var reminders = await _reminderService.GetAllRemindersAsync();
        return View("Reminders",reminders);
    }

    public IActionResult Reminders()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(ReminderDbo reminder)
    {
        if (ModelState.IsValid)
        {
            await _reminderService.AddReminderAsync(reminder);
            return RedirectToAction(nameof(Reminders));
        }
        return View(reminder);
    }
}