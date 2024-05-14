using Aplicatie.API.Data;
using AplicatieAPI.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

namespace Aplicatie.API.Controllers {

[ApiController]
[Route("api/[controller]")]
public class AngajatiController : Controller
{
	private readonly AplicatieDbContext _aplicatieDbContext;
	public AngajatiController(AplicatieDbContext aplicatieDbContext)
	{
		_aplicatieDbContext = aplicatieDbContext;
	}
	[HttpGet]
	public async Task<IActionResult> GetAllAngajati()
	{
		var angajati = await _aplicatieDbContext.Angajati.ToListAsync();
		return Ok(angajati);
	}
	[HttpPost]
	public async Task<IActionResult> AddAngajat([FromBody] Angajat angajatRequest)
		{

			angajatRequest.Id = Guid.NewGuid();
			await _aplicatieDbContext.Angajati.AddAsync(angajatRequest);
			await _aplicatieDbContext.SaveChangesAsync();

			return Ok(angajatRequest);
		}

	}
}






