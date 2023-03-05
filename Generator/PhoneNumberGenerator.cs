using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlamenkoMockGenerator.Generator
{
    internal class PhoneNumberGenerator
    {
        string[] phoneNumberPrefixes = { "060", "061","062","063","064", "065", "066", "069" };

        int[] GenerateNumbers()
        {
            Random rnd = new Random();
            int first = rnd.Next(100, 999);
            int second = rnd.Next(100, 9999);
            int prefix = rnd.Next(0,8);
            return new int[] { prefix, first, second }; 
        }
        
        public string GetRandomPhoneNumber()
        {
            int[] generatedRandom = GenerateNumbers();

            return phoneNumberPrefixes[generatedRandom[0]] + "-" + generatedRandom[1] + "-" + generatedRandom[2];
        }
    }
}
