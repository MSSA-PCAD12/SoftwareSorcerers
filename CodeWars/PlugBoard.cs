using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class Plugboard
    {
        private Dictionary<char, char>? wiring;

        public Plugboard(string wirePairs = "")
        {
            wiring = new Dictionary<char, char>();

            if (!string.IsNullOrEmpty(wirePairs))
            {
                if (wirePairs.Length % 2 != 0)
                {
                    throw new ArgumentException("Wire pairs string must have an even number of characters");
                }
                if (wirePairs.Length > 20)
                {
                    throw new ArgumentException("Too many");
                }

                for (int i = 0; i < wirePairs.Length; i += 2)
                {
                    char first = wirePairs[i];
                    char second = wirePairs[i + 1];

                    // Check if the pair is the same
                    if (first == second)
                    {
                        throw new ArgumentException("Cannot pair a character with itself");
                    }

                    // Check if either character is already paired
                    if (wiring.ContainsKey(first) || wiring.ContainsKey(second))
                    {
                        throw new ArgumentException("Already paired");
                    }

                    wiring[first] = second;
                    wiring[second] = first;
                }
            }
        }

        public char Process(char input)
        {
            if (wiring.ContainsKey(input))
            {
                return wiring[input];
            }
            return input;
        }
    }
}
