using Microsoft.AspNetCore.Mvc;

namespace CollegeFestMVC.Controllers;

public class FestController : Controller
{
    // In-memory storage is intentional for this assignment; data resets on restart.
    private static readonly List<Participant> Participants = new();
    private static int _nextId = 1;

    private static readonly Dictionary<string, decimal> EventFees = new()
    {
        ["Code Sprint"] = 0m,
        ["Web Design Challenge"] = 150m,
        ["Robotics Arena"] = 600m,
        ["Tech Quiz"] = 50m
    };

    public IActionResult Index()
    {
        return View(Participants.OrderBy(p => p.ParticipantId).ToList());
    }

    [HttpGet]
    public IActionResult Register()
    {
        ViewBag.Events = EventFees;
        return View(new Participant());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Participant participant)
    {
        ViewBag.Events = EventFees;

        if (!ModelState.IsValid)
            return View(participant);

        participant.ParticipantId = _nextId++;
        participant.RegistrationFee = EventFees.GetValueOrDefault(participant.EventName, 0m);
        participant.IsConfirmed = true;
        Participants.Add(participant);

        TempData["SuccessMessage"] = $"Registration saved for {participant.ParticipantName}.";
        return RedirectToAction(nameof(Details), new { id = participant.ParticipantId });
    }

    public IActionResult Details(int id)
    {
        var participant = Participants.FirstOrDefault(p => p.ParticipantId == id);
        if (participant is null)
            return NotFound();

        return View(participant);
    }

    public IActionResult Welcome()
    {
        return View();
    }
}
