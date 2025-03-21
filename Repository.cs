using Microsoft.EntityFrameworkCore;

public class PlayerRepo(PlayerContext context)
{
    public async Task AddPlayer(string _name, int _scores)
    {
        await context.players.AddAsync(new Player
        {
            name = _name,
            scores = _scores
        });

        await context.SaveChangesAsync();
    }
    public async Task<List<Player>> GetAll()
    {
        return await context.players.ToListAsync();
    }
    public async Task Update(string _name, int _scores)
    {
        var player = await context.players.Where(p => p.name == _name).FirstOrDefaultAsync();
        player.scores = _scores;
        context.players.Update(player);
        await context.SaveChangesAsync();
    }
}