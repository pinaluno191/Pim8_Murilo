using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PimV8.Models;

namespace PimV8.Controllers
{
    [Route("/api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly PersonDBContext _context;

        public ValuesController(PersonDBContext context)
        {
            _context = context;
        }

        //Get : api/person
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Person>>> GetPerson()
        {
            return await _context.Person.ToListAsync();
        }

        //Get : /api/person/id
        [HttpGet("{id}")]

        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            var dPerson = await _context.Person.FindAsync(id);
            
            if(dPerson == null)
            {
                return NotFound();
            }

            return dPerson;
        }

        //Put : api/person/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson(int id, Person dPerson)
        {
            dPerson.Id = id;

            _context.Entry(dPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
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

        // Post: api/person
        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson (Person dPerson)
        {
            _context.Person.Add(dPerson);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerson", new { id = dPerson.Id }, dPerson);
        }


        //Delete: api/person/Id
        [HttpDelete("{id}")]
        public async Task<ActionResult<Person>> DeletePerson (int id)
        {
            var dPerson = await _context.Person.FindAsync(id);
            if (dPerson == null)
            {
                return NotFound();
            }

            _context.Person.Remove(dPerson);
            await _context.SaveChangesAsync();

            return dPerson;

        }





        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
