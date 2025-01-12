namespace CheckingAphabet.Services
{
    public class AlphabetService : IAlphabetService
    {
        /// <summary>
        ///    Checks if the input string contains all the alphabets from 'a' to 'z'.
        /// </summary>
        /// <param name="input">The input string to check.</param>
        /// <returns>True if the input contains all alphabets; otherwise, false.</returns>
        public bool ContainsAllAplphabets(string input)
        {

            var alphabetSet = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");

            foreach (char ch in input.ToLower())
            {
                alphabetSet.Remove(ch);
                if (!alphabetSet.Any()) 
                {
                    return true;

                }

            }
            return false;


        }
    }
}
