using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Agencia.Data;
using Agencia.Model;

namespace Agencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinosController : ControllerBase
    {
        private readonly DataContext _context;

        public DestinosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Destino>> GetDestinos()
        {
            return Ok(_context.Destinos.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<Destino> GetDestino(int id)
        {
            var destino = _context.Destinos.Find(id);

            if (destino == null)
            {
                return NotFound("Destino não encontrado");
            }

            return Ok(destino);
        }

        [HttpPost]
        public ActionResult<Destino> PostDestino(Destino destino)
        {
            if (ModelState.IsValid)
            {
                _context.Destinos.Add(destino);
                _context.SaveChanges();

                return CreatedAtAction("GetDestino", new { id = destino.DestinoId }, destino);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult PutDestino(int id, Destino destino)
        {
            if (id != destino.DestinoId)
            {
                return BadRequest("IDs não coincidem");
            }

            if (ModelState.IsValid)
            {
                _context.Entry(destino).State = EntityState.Modified;

                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestinoExists(id))
                    {
                        return NotFound("Destino não encontrado");
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDestino(int id)
        {
            var destino = _context.Destinos.Find(id);
            if (destino == null)
            {
                return NotFound("Destino não encontrado");
            }

            _context.Destinos.Remove(destino);
            _context.SaveChanges();

            return NoContent();
        }

        private bool DestinoExists(int id)
        {
            return _context.Destinos.Any(e => e.DestinoId == id);
        }
    }
}