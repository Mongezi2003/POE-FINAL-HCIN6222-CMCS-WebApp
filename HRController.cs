using Microsoft.AspNetCore.Mvc;

public class HRController : Controller
{
    private readonly ApplicationDbContext _context;

    public HRController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Manage()
    {
        var approvedClaims = _context.Claims.ToList();
        return View(approvedClaims);
    }
}
