﻿using HashidsNet;
using System;
using System.Linq;

namespace UrlShortner.Seedwork
{
    public static class Code
    {
        private static Random _random = new Random();

        private static readonly string _lowerCaseCharacters = "abcdefghijklmnopqrstuvxwyz";
        private static readonly string _upperCaseCharacters = "ABCDERFGIJKLMNOPQRSTUVXWWYZ";

        private static readonly string _digits = "0123456789";

        public static string Create(string prefix = null, int length = 16,
            bool useLowerCase = true, bool useUpperCase = true, bool useDigits = true)
        {
            var alphabet = String.Empty;

            if (useLowerCase) alphabet = string.Concat(alphabet, _lowerCaseCharacters);
            if (useUpperCase) alphabet = string.Concat(alphabet, _upperCaseCharacters);
            if (useDigits) alphabet = string.Concat(alphabet, _digits);

            var salt = Guid.NewGuid().ToString();

            var hashids = new Hashids(salt, length, alphabet: alphabet);

            //Escolhe 3 números aleatoriamente para gerar o hash
            var numbers = Enumerable.Range(0, 3).Select(r => _random.Next(100)).ToList();

            var hash = hashids.Encode(numbers);

            if (string.IsNullOrWhiteSpace(prefix) == false) hash = string.Concat(prefix, hash);

            return hash;
        }
    }
}