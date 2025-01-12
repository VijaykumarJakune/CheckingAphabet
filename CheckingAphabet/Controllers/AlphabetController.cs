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
