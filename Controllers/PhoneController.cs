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
    public class PhoneController : ControllerBase
    {
        private readonly PersonDBContext _context;

        public PhoneController(PersonDBContext context)
        {
            _context = context;
        }

        // GET: api/Person
        [HttpGet]
        public ActionResult Get()
        {
            try
            {

            return Ok(new Phone());

            }
            catch(Exception ex)
            {
                return BadRequest($"Error : {ex}");
            }
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}", Name = "GetPhone")]
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
        public ActionResult Post( Phone model)
        {
            try
            {
                _context.Phone.Add(model);
                _context.SaveChanges();

                return Ok("Bazinga!");

            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex}");
            }
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Phone model)
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

        // DELETE api/<PersonController>/5
        [HttpDelete("person/{id}")]
        public void Delete(int id)
        {
            var phone = _context.Phone.Where(p => p.Id == id).Single();

            _context.Phone.Remove(phone);
            _context.SaveChanges();
        }
    }
}
