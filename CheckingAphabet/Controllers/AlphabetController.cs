    using CheckingAphabet.Services;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    namespace CheckingAphabet.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class AlphabetController : ControllerBase
        {
            private readonly IAlphabetService _alphabetService;

            public AlphabetController(IAlphabetService alphabetService)
            { 
                _alphabetService = alphabetService;
        
            }

        /// <summary>
        /// /// Checks if the input string contains all the alphabets from 'a' to 'z' atleast once.
        /// </summary>
        /// <param name="input">The input string to check.</param>
        /// <returns>True if the input contains all alphabets; otherwise, false.</returns>
        [HttpGet("check")]
            public IActionResult CheckAlphabets([FromQuery] string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return BadRequest("Input cannot be null or empty.");
                }

                var result = _alphabetService.ContainsAllAplphabets(input);
                return Ok(result);

            }

        }
    }
