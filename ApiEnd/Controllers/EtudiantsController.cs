using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiEnd.Data;
using ApiEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Identity.Web.Resource;

namespace ApiEnd.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    //[RequiredScope(RequiredScopesConfigurationKey ="AzireAd:scopes")]
    public class EtudiantsController : ControllerBase
    {
        private readonly AllContext _context;

        public EtudiantsController(AllContext context)
        {
            _context = context;
        }
        //Qobo781695
        // GET: api/Etudiants
        [HttpGet]
        [RequiredScope(RequiredScopesConfigurationKey = "AzireAd:scopes")]
        //[Authorize()]
        public async Task<ActionResult<IEnumerable<Etudiant>>> GetEleves()
        {
            if (_context.Eleves == null)
            {
                return NotFound();
            }
            return await _context.Eleves.ToListAsync();
        }

        // GET: api/Etudiants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Etudiant>> GetEtudiant(int id)
        {
          if (_context.Eleves == null)
          {
              return NotFound();
          }
            var etudiant = await _context.Eleves.FindAsync(id);

            if (etudiant == null)
            {
                return NotFound();
            }

            return etudiant;
        }

        // PUT: api/Etudiants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtudiant(int id, Etudiant etudiant)
        {
            if (id != etudiant.Id)
            {
                return BadRequest();
            }

            _context.Entry(etudiant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtudiantExists(id))
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

        // POST: api/Etudiants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Etudiant>> PostEtudiant(Etudiant etudiant)
        {
          if (_context.Eleves == null)
          {
              return Problem("Entity set 'AllContext.Eleves'  is null.");
          }
            _context.Eleves.Add(etudiant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEtudiant", new { id = etudiant.Id }, etudiant);
        }

        // DELETE: api/Etudiants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEtudiant(int id)
        {
            if (_context.Eleves == null)
            {
                return NotFound();
            }
            var etudiant = await _context.Eleves.FindAsync(id);
            if (etudiant == null)
            {
                return NotFound();
            }

            _context.Eleves.Remove(etudiant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EtudiantExists(int id)
        {
            return (_context.Eleves?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
