using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PimV8.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PimV8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //incluido comentário para ver o Git funcionando
        //Ernando 17/11/2020   mai um pouco

        private readonly PersonDBContext _context;
        public PersonController(PersonDBContext context)
        {
            _context = context;
        }

        // GET: api/Person
        [HttpGet]
        public ActionResult Get()
        {
            try
            {

            return Ok(new Person());

            }
            catch(Exception ex)
            {
                return BadRequest($"Error : {ex}");
            }
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {

                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex}");
            }
        }

        // POST api/person
        [HttpPost]
        public ActionResult Post( Person model)
        {
            try
            {
                _context.Person.Add(model);
                _context.SaveChanges();

                return Ok("Bazinga!");

            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex}");
            }
        }

        // PUT api/person/5
        [HttpPut("/person/{id}")]
        public ActionResult Put(int id, Person model)
        {
            try
            {
                if(_context.Person.AsNoTracking().FirstOrDefault(h => h.Id == id) !=null)
                {
                    _context.Update(model);
                    _context.SaveChanges();
                    return Ok("Bazinga!");
                }

                return Ok("Não encontrado");

            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex}");
            }
        }

        // DELETE api/person/5
        [HttpDelete("/person/{id}")]
        public void Delete(int id)
        {
            var person = _context.Person.Where(p => p.Id == id).Single();

            _context.Person.Remove(person);
            _context.SaveChanges();
        }
    }
}
