using CheckingAphabet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckingAlphabet.Tests.Services
{
    public class AlphabetServiceTests
    {
        private readonly IAlphabetService _alphabetService;

        public AlphabetServiceTests()
        { 
        
            _alphabetService = new AlphabetService();
        }
        
        [Theory]
        [InlineData("The alphabet checking tests running", false)] // Test with sentence without all alphabets
        [InlineData("The five boxing wizards jump quickly.", true)] //Test with sentence with all alphabets
        [InlineData("abcdefghijklmnopqrstuvwxyz", true)] //Test with complete lowercase alphabet
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ", true)] //Test with complete uppercase alphabet
        [InlineData("1234567890^!@#$%&*()", false)] //Test numbers and special characters
        [InlineData("",false)] //Test with empty string
        [InlineData("s",false)] //Test with single character
        [InlineData("asda@$$ABS",false)] //Test with all lower case, upper case and special characters 
        public void ContainsAllAlphabets_Test(string input, bool expected)
        {
            var result = _alphabetService.ContainsAllAplphabets(input);
            Assert.Equal(expected, result);

        }


    }
}
