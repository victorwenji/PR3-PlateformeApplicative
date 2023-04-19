using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiEnd.Data;
using ApiEnd.Models;

namespace ApiEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresencesController : ControllerBase
    {
        private readonly AllContext _context;

        public PresencesController(AllContext context)
        {
            _context = context;
        }

        // GET: api/Presences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Presence>>> GetPresences()
        {
          if (_context.Presences == null)
          {
              return NotFound();
          }
            return await _context.Presences.ToListAsync();
        }

        // GET: api/Presences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Presence>> GetPresence(int id)
        {
          if (_context.Presences == null)
          {
              return NotFound();
          }
            var presence = await _context.Presences.FindAsync(id);

            if (presence == null)
            {
                return NotFound();
            }

            return presence;
        }

        // PUT: api/Presences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPresence(int id, Presence presence)
        {
            if (id != presence.PresenceId)
            {
                return BadRequest();
            }

            _context.Entry(presence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PresenceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Presences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Presence>> PostPresence(Presence presence)
        {
          if (_context.Presences == null)
          {
              return Problem("Entity set 'AllContext.Presences'  is null.");
          }
            _context.Presences.Add(presence);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPresence", new { id = presence.PresenceId }, presence);
        }

        // DELETE: api/Presences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePresence(int id)
        {
            if (_context.Presences == null)
            {
                return NotFound();
            }
            var presence = await _context.Presences.FindAsync(id);
            if (presence == null)
            {
                return NotFound();
            }

            _context.Presences.Remove(presence);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PresenceExists(int id)
        {
            return (_context.Presences?.Any(e => e.PresenceId == id)).GetValueOrDefault();
        }
    }
}
