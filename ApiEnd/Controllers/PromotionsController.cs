﻿using System;
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
    public class PromotionsController : ControllerBase
    {
        private readonly AllContext _context;

        public PromotionsController(AllContext context)
        {
            _context = context;
        }

        // GET: api/Promotions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Promotion>>> GetPromotion()
        {
          if (_context.Promotion == null)
          {
              return NotFound();
          }
            return await _context.Promotion.ToListAsync();
        }

        // GET: api/Promotions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Promotion>> GetPromotion(int id)
        {
          if (_context.Promotion == null)
          {
              return NotFound();
          }
            var promotion = await _context.Promotion.FindAsync(id);

            if (promotion == null)
            {
                return NotFound();
            }

            return promotion;
        }

        // PUT: api/Promotions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPromotion(int id, Promotion promotion)
        {
            if (id != promotion.Id)
            {
                return BadRequest();
            }

            _context.Entry(promotion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromotionExists(id))
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

        // POST: api/Promotions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Promotion>> PostPromotion(Promotion promotion)
        {
          if (_context.Promotion == null)
          {
              return Problem("Entity set 'AllContext.Promotion'  is null.");
          }
            _context.Promotion.Add(promotion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPromotion", new { id = promotion.Id }, promotion);
        }

        // DELETE: api/Promotions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePromotion(int id)
        {
            if (_context.Promotion == null)
            {
                return NotFound();
            }
            var promotion = await _context.Promotion.FindAsync(id);
            if (promotion == null)
            {
                return NotFound();
            }

            _context.Promotion.Remove(promotion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PromotionExists(int id)
        {
            return (_context.Promotion?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
