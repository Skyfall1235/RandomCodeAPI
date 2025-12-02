using RandomAPI.Controllers;
using RandomAPI.DTOs;

public interface IHoursService
{
    HoursResponseDto Calculate(HoursRequestDto request);
}



