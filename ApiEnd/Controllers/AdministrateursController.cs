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
    public class AdministrateursController : ControllerBase
    {
        private readonly AllContext _context;

        public AdministrateursController(AllContext context)
        {
            _context = context;
        }

        // GET: api/Administrateurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrateurs>>> GetAdministrateurs()
        {
          if (_context.Administrateurs == null)
          {
              return NotFound();
          }
            return await _context.Administrateurs.ToListAsync();
        }

        // GET: api/Administrateurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Administrateurs>> GetAdministrateurs(int id)
        {
          if (_context.Administrateurs == null)
          {
              return NotFound();
          }
            var administrateurs = await _context.Administrateurs.FindAsync(id);

            if (administrateurs == null)
            {
                return NotFound();
            }

            return administrateurs;
        }

        // PUT: api/Administrateurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdministrateurs(int id, Administrateurs administrateurs)
        {
            if (id != administrateurs.Id)
            {
                return BadRequest();
            }

            _context.Entry(administrateurs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministrateursExists(id))
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

        // POST: api/Administrateurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Administrateurs>> PostAdministrateurs(Administrateurs administrateurs)
        {
          if (_context.Administrateurs == null)
          {
              return Problem("Entity set 'AllContext.Administrateurs'  is null.");
          }
            _context.Administrateurs.Add(administrateurs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdministrateurs", new { id = administrateurs.Id }, administrateurs);
        }

        // DELETE: api/Administrateurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdministrateurs(int id)
        {
            if (_context.Administrateurs == null)
            {
                return NotFound();
            }
            var administrateurs = await _context.Administrateurs.FindAsync(id);
            if (administrateurs == null)
            {
                return NotFound();
            }

            _context.Administrateurs.Remove(administrateurs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdministrateursExists(int id)
        {
            return (_context.Administrateurs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
