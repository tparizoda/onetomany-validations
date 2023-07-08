using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase 
{
    private readonly AppDbContext dbContext;
    public CarsController(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpPost]
    public async Task<ActionResult> CreateCarDto([FromBody] CreateCarDto carDto)
    {
        var owner = await dbContext.Users
            .FirstOrDefaultAsync(x => x.Id == carDto.OwnerId);
        if (owner is null)
            return BadRequest("Owner does not exist");

        var Savedcar = dbContext.Cars.Add(new Car
        {
            Id = Guid.NewGuid(),
            Brand = carDto.Brand,
            Model = carDto.Model,
            Color = carDto.Color,
            ManufacturedAt = carDto.ManufacturedAt,
            Owner = owner
        });

        await dbContext.SaveChangesAsync();

        return Ok(new GetCarDto
        {
            Id = Savedcar.Entity.Id,
            Brand = Savedcar.Entity.Brand,
            Model = Savedcar.Entity.Model,
            ManufacturedAt = Savedcar.Entity.ManufacturedAt,
            Color = Savedcar.Entity.Color,
            OwnerId = Savedcar.Entity.OWnerId,
            Owner = new GetUserDto(Savedcar.Entity.Owner)
        });
        
    }
}