using DatabaseRelationships.Data;
using DatabaseRelationships.DTO;
using DatabaseRelationships.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseRelationshipsController(DataContext context) : ControllerBase
    {
        private readonly DataContext _context = context;


        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacterById(int id)
        {
            var character = await _context.Characters.Include(c => c.Backpack).Include(c => c.Weapons).Include(c => c.Factions).FirstOrDefaultAsync(c => c.Id == id);
            if (character == null)
            {
                return NotFound("No such character");
            }
            else
            {
                return Ok(character);
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> CreateCharacter (CharacterCreateDto request)
        {

            var newCharacter = new Character
            {
                Name = request.Name,
            };

            var backpack = new Backpack
            {
                Description = request.Backpack.Description,
                Character = newCharacter,
            };

            var weapons = request.Weapons.Select(w => new Weapon { Name = w.Name, Character = newCharacter }).ToList();
            var factions = request.Factions.Select(f => new Factions { Name = f.Name, Character = new List<Character> { newCharacter} }).ToList();

            newCharacter.Backpack = backpack;
            newCharacter.Weapons = weapons;
            newCharacter.Factions = factions;

            _context.Characters.Add(newCharacter);

            await _context.SaveChangesAsync();

            return Ok(await _context.Characters.Include(c => c.Backpack).Include(c => c.Weapons).Include(c => c.Factions).ToListAsync());

        }
    }
}
