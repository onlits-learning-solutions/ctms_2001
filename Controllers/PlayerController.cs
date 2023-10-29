using ctms_2001.Models;
using Microsoft.AspNetCore.Mvc;

namespace ctms_2001.Controllers;

public class PlayerController : Controller
{
    private readonly CTMSContext _context;

    public PlayerController(CTMSContext context)
    {
        _context = context;
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public string Create(Player player)
    {
        _context.Players.Add(new Player
        {
            FirstName = player.FirstName,
            MiddleName = player.MiddleName,
            LastName = player.LastName,
            Gender = player.Gender
        }
        );
        _context.SaveChanges();
        return "player created";
    }
}