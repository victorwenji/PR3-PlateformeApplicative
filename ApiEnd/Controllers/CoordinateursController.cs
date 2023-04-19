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
    public class CoordinateursController : ControllerBase
    {
        private readonly AllContext _context;

        public CoordinateursController(AllContext context)
        {
            _context = context;
        }

        // GET: api/Coordinateurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coordinateurs>>> GetCoordinateurs()
        {
          if (_context.Coordinateurs == null)
          {
              return NotFound();
          }
            return await _context.Coordinateurs.ToListAsync();
        }

        // GET: api/Coordinateurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coordinateurs>> GetCoordinateurs(int id)
        {
          if (_context.Coordinateurs == null)
          {
              return NotFound();
          }
            var coordinateurs = await _context.Coordinateurs.FindAsync(id);

            if (coordinateurs == null)
            {
                return NotFound();
            }

            return coordinateurs;
        }

        // PUT: api/Coordinateurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoordinateurs(int id, Coordinateurs coordinateurs)
        {
            if (id != coordinateurs.Id)
            {
                return BadRequest();
            }

            _context.Entry(coordinateurs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoordinateursExists(id))
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

        // POST: api/Coordinateurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Coordinateurs>> PostCoordinateurs(Coordinateurs coordinateurs)
        {
          if (_context.Coordinateurs == null)
          {
              return Problem("Entity set 'AllContext.Coordinateurs'  is null.");
          }
            _context.Coordinateurs.Add(coordinateurs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCoordinateurs", new { id = coordinateurs.Id }, coordinateurs);
        }

        // DELETE: api/Coordinateurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoordinateurs(int id)
        {
            if (_context.Coordinateurs == null)
            {
                return NotFound();
            }
            var coordinateurs = await _context.Coordinateurs.FindAsync(id);
            if (coordinateurs == null)
            {
                return NotFound();
            }

            _context.Coordinateurs.Remove(coordinateurs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CoordinateursExists(int id)
        {
            return (_context.Coordinateurs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
