using Microsoft.AspNetCore.Mvc;

namespace ctms_2001.Controllers;

public class TournamentController : Controller
{
    public IActionResult Index()
    {

        return View();
    }
}