using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class PlayerController : ControllerBase
{
    private PlayerRepo repo;
    public PlayerController(PlayerRepo repo)
    {
        this.repo = repo;
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddPlayer([FromBody] Player player)
    {
        if(player == null || string.IsNullOrWhiteSpace(player.name))
        return BadRequest("invalid data");
        await repo.AddPlayer(player.name, player.scores);
        return Ok("Player added");

    }
    [HttpPost("update")]
    public async Task<IActionResult> Updatelayer([FromBody] Player player)
    {
        if(player == null || string.IsNullOrWhiteSpace(player.name))
        return BadRequest("invalid data");
        await repo.Update(player.name, player.scores);
        return Ok("Player added");

    }
}