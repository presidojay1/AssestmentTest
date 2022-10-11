using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTINTERVIEW.Data;
using TESTINTERVIEW.Repository;

namespace TESTINTERVIEW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly IMovieRepository _movieRepository;

        private readonly DataContext _context;

        public MovieController(IMovieRepository movieRepository, DataContext context)
        {

            _movieRepository = movieRepository;
            _context = context;
        }

        [HttpGet("{MovieId}")]
        public async Task<IActionResult> GetMovieByName(string MovieId)
        {

            var movie = await _movieRepository.GetMovieByIdAsync(MovieId);

            if (movie == null)
            {
                return NotFound("check your API");
            }
               
            return Ok(movie);
        }
    }
}
