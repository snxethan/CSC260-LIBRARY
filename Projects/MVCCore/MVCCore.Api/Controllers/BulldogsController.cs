using Microsoft.AspNetCore.Mvc;
using MVCCore.Shared.Models;


namespace MVCCore.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BulldogsController : ControllerBase
{
    private static readonly List<Bulldog> Bulldogs = new()
    {
        // place holder images from https://picsum.photos/
        new Bulldog { Id = 1, Name = "Max", Breed = "English Bulldog", ImageUrl = "https://picsum.photos/300/200?random=1" },
        new Bulldog { Id = 2, Name = "Bella", Breed = "French Bulldog", ImageUrl = "https://picsum.photos/300/200?random=2" },
        new Bulldog { Id = 3, Name = "ethan dog", Breed = "cool dog",ImageUrl = "https://www.snxethan.dev/images/avatar/avatar.png" },
        new Bulldog { Id = 4, Name = "Cat", Breed = "cool cat", ImageUrl = "https://www.snxethan.dev/images/avatar/avatar_christmas2.gif"}
    };

    [HttpGet]
    public ActionResult<List<Bulldog>> GetAll() => Bulldogs;

    [HttpGet("{id}")]
    public ActionResult<Bulldog> GetById(int id)
    {
        var dog = Bulldogs.FirstOrDefault(b => b.Id == id);
        if (dog == null) return NotFound();
        return Ok(dog);
    }


    [HttpPost]
    public ActionResult<Bulldog> Add([FromBody] Bulldog newDog)
    {
        newDog.Id = Bulldogs.Any() ? Bulldogs.Max(b => b.Id) + 1 : 1;
        Bulldogs.Add(newDog);
        return CreatedAtAction(nameof(GetById), new { id = newDog.Id }, newDog);
    }


    [HttpPut("{id}")]
    public IActionResult Update(int id, Bulldog updatedDog)
    {
        var dog = Bulldogs.FirstOrDefault(b => b.Id == id);
        if (dog == null) return NotFound();

        dog.Name = updatedDog.Name;
        dog.Breed = updatedDog.Breed;
        dog.ImageUrl = updatedDog.ImageUrl;

        return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var dog = Bulldogs.FirstOrDefault(b => b.Id == id);
        if (dog == null) return NotFound();

        Bulldogs.Remove(dog);
        return NoContent();
    }
    
}