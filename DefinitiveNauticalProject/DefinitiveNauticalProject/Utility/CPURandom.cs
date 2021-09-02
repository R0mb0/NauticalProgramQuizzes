using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;


namespace DefinitiveNauticalProject.Utility
{
    static class CPURandom
    {
        public static int Next(int min, int max)
        {
            /*The controls are inserted in waay to have aa generic method, but it will not be used because there is a controlled context*/
            if (min > max + 1)
            {
                throw new ArgumentOutOfRangeException(nameof(min));
            }
            if (min == max + 1) 
            { 
                return min; 
            }

            using (var rng = new RNGCryptoServiceProvider())
            {
                var data = new byte[4];
                rng.GetBytes(data);

                int generatedValue = Math.Abs(BitConverter.ToInt32(data, startIndex: 0));

                int diff = max + 1 - min;
                int mod = generatedValue % diff;
                int normalizedNumber = min + mod;

                return normalizedNumber;
            }
        }

    }
}
