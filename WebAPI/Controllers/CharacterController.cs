using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character{Id = 1,Name = "Bilbo"}
        };

        [HttpGet("GetAll")]
        public IActionResult GetCharacter()
        {
            return Ok(characters);
        }

        [HttpGet("GetOne")]
        public IActionResult GetSingleCharacter()
        {
            return Ok(characters.FirstOrDefault());
        }

        [HttpGet("{id}")]
        public IActionResult GetCharacterById(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult CreateCharacter(Character character)
        {
            characters.Add(character);
            return Ok(characters);
        }
    }
}
