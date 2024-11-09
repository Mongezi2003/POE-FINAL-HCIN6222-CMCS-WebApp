using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

public class ClaimsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ClaimsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Claim claim, IFormFile[] documents)
    {
        if (ModelState.IsValid)
        {
            _context.Claims.Add(claim);
            await _context.SaveChangesAsync();

            if (documents != null)
            {
                foreach (var document in documents)
                {
                    if (document.Length > 0)
                    {
                        var filePath = Path.Combine("uploads", document.FileName);
                        if (!Directory.Exists("uploads"))
                        {
                            Directory.CreateDirectory("uploads");
                        }
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await document.CopyToAsync(stream);
                        }
                        var supportingDocument = new SupportingDocument
                        {
                            ClaimID = claim.ClaimID,
                            FilePath = filePath
                        };
                        _context.SupportingDocuments.Add(supportingDocument);
                    }
                }
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        return View(claim);
    }
}
