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
    public class ClientesController : ControllerBase
    {
        private readonly DataContext _context;

        public ClientesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> GetClientes()
        {
            return Ok(_context.Clientes.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> GetCliente(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }

            return Ok(cliente);
        }

        [HttpPost]
        public ActionResult<Cliente> PostCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();

                return CreatedAtAction("GetCliente", new { id = cliente.ClienteId }, cliente);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.ClienteId)
            {
                return BadRequest("IDs não coincidem");
            }

            if (ModelState.IsValid)
            {
                _context.Entry(cliente).State = EntityState.Modified;

                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(id))
                    {
                        return NotFound("Cliente não encontrado");
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
        public IActionResult DeleteCliente(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            return NoContent();
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.ClienteId == id);
        }
    }
}