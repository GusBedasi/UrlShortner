using HashidsNet;
using System;
using System.Linq;

namespace UrlShortner.Seedwork
{
    public static class Code
    {
        private static readonly Random Random = new Random();

        private const string LowerCaseCharacters = "abcdefghijklmnopqrstuvxwyz";
        private const string UpperCaseCharacters = "ABCDERFGIJKLMNOPQRSTUVXWWYZ";

        private const string Digits = "0123456789";

        public static string Create(string prefix = null, int length = 16,
            bool useLowerCase = true, bool useUpperCase = true, bool useDigits = true)
        {
            var alphabet = string.Empty;

            if (useLowerCase) alphabet = string.Concat(alphabet, LowerCaseCharacters);
            if (useUpperCase) alphabet = string.Concat(alphabet, UpperCaseCharacters);
            if (useDigits) alphabet = string.Concat(alphabet, Digits);

            var salt = Guid.NewGuid().ToString();

            var hashids = new Hashids(salt, length, alphabet: alphabet);

            //Escolhe 3 números aleatoriamente para gerar o hash
            var numbers = Enumerable.Range(0, 3).Select(r => Random.Next(100)).ToList();

            var hash = hashids.Encode(numbers);

            if (string.IsNullOrWhiteSpace(prefix) == false) hash = string.Concat(prefix, hash);

            return hash;
        }
    }
}
