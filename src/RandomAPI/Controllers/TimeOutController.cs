using Microsoft.AspNetCore.Mvc;
using RandomAPI.DTOs;

[ApiController]
[Route("api/[controller]")]
public class HoursController : ControllerBase
{
    private readonly IHoursService _hoursService;

    public HoursController(IHoursService hoursService)
    {
        _hoursService = hoursService;
    }

    [HttpPost("calculate")]
    public ActionResult<HoursResponseDto> Calculate(HoursRequestDto dto)
    {
        try
        {
            var result = _hoursService.Calculate(dto);
            return Ok(result);
        }
        catch (FormatException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
}
