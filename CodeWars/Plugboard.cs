using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class Plugboard
    {
        private readonly Dictionary<char, char> _wiring;
        public Plugboard(string wiringPairs)
        {
            if (string.IsNullOrEmpty(wiringPairs))
                throw new ArgumentNullException(nameof(wiringPairs), "Wiring pairs cannot be null or empty.");
            if (wiringPairs.Length % 2 != 0)
                throw new ArgumentException("Wiring pairs must be in even numbers.", nameof(wiringPairs));

            _wiring = GenerateWiring(wiringPairs);
        }
        private Dictionary<char, char> GenerateWiring(string wiringPairs)
        {
            var wiring = new Dictionary<char, char>();
            for (int i = 0; i < wiringPairs.Length; i += 2)
            {
                char a = wiringPairs[i];
                char b = wiringPairs[i + 1];

                ValidateCharacters(a, b);
                if (wiring.ContainsKey(a) || wiring.ContainsKey(b))
                    throw new ArgumentException("Duplicate or conflicting wiring detected.");

                wiring[a] = b;
                wiring[b] = a;
            }
            return wiring;
        }
        private void ValidateCharacters(char a, char b)
        {
            if (!IsValidCharacter(a) || !IsValidCharacter(b))
                throw new ArgumentException("Wiring pairs must only contain letters A-Z.");
        }
        public char Process(char input)
        {
            return _wiring.TryGetValue(input, out char output) ? output : input;
        }

        private bool IsValidCharacter(char c)
        {
            return c >= 'A' && c <= 'Z';
        }
    }
}
