﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using Veterinary.API.Data;
using Veterinary.Shared.Entities;

namespace Veterinary.API.Controllers
{


    [ApiController]
    [Route("/api/owners")]
    public class OwnersController : ControllerBase
    {


        private readonly DataContext _context;
        public OwnersController(DataContext context)
        {

            _context = context;

        }



        //Get por Lista--- Select * From Owners
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Owners.ToListAsync());


        }

        [HttpPost]

        public async Task<ActionResult> Post(Owner owner)
        {

            _context.Add(owner);
            await _context.SaveChangesAsync();

            return Ok(owner);



        }



        // Dlete-- Borrar un registro

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Owners
                .Where(a => a.Id == id)
                .ExecuteDeleteAsync();






            if (FilasAfectadas == 0)
            {

                return NotFound();

            }
            else
            {
                return NoContent();



            }
        }

        // Post- insertar un nuevo Owner



        // Put- modificar un Owner
        [HttpPut]

        public async Task<ActionResult> Put(Owner owner)
        {

            _context.Update(owner);
            await _context.SaveChangesAsync();

            return Ok(owner);



        }






        //Get por parámetro--- Select * from Owner Where id=2
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var owner = await _context.Owners.FirstOrDefaultAsync(x => x.Id == id);
            if (owner == null)
            {

                return NotFound();

            }
            else
            {
                return Ok(owner);



            }










        }
    }

}



