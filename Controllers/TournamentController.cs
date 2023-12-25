using Microsoft.AspNetCore.Mvc;
using ctms_2001.Models;

namespace ctms_2001.Controllers;

public class TournamentController : Controller
{
    private readonly CTMSContext _context;
    public TournamentController(CTMSContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var tournaments = _context.Tournaments.ToList<Tournament>();
        return View(tournaments);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public string Create(Tournament tournament)
    {
        _context.Tournaments.Add(new Tournament
        {
            Name = tournament.Name,
            StartDate = tournament.StartDate,
            EndDate = tournament.EndDate,
            Venue = tournament.Venue
        });
        _context.SaveChanges();
        return "Tournament Created!";
    }
}