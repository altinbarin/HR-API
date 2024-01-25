using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public static class EmailConvertHelper
    {
        private static readonly Dictionary<char, char> TurkishToEnglishMapping = new Dictionary<char, char>
    {
        {'ü', 'u'},
        {'ğ', 'g'},
        {'ş', 's'},
        {'ı', 'i'},
        {'ö', 'o'},
        {'ç', 'c'}
    };

        public static string ConvertTurkishCharactersToEnglish(string input)
        {
            StringBuilder resultBuilder = new StringBuilder(input.Length);

            foreach (char character in input.ToLowerInvariant())
            {
                if (TurkishToEnglishMapping.TryGetValue(character, out char replacement))
                {
                    resultBuilder.Append(replacement);
                }
                else
                {
                    resultBuilder.Append(character);
                }
            }

            return resultBuilder.ToString();
        }

        public static string GenerateDefaultEmail(string firstName, string lastName)
        {
            string convertedFirstName = ConvertTurkishCharactersToEnglish(firstName.ToLower());
            string convertedLastName = ConvertTurkishCharactersToEnglish(lastName.ToLower());

            return $"{convertedFirstName}.{convertedLastName}@bilgeadamboost.com";
        }
    }
}
