using System.Text;
using System.Security.Cryptography;

namespace LOTPHI.OTPGenerator.Utilities
{
    public class OtpHashHelper
    {
        public static string GetSha256Hash(string input)
        {
            var message = Encoding.UTF8.GetBytes(input);

            using var alg = SHA512.Create();

            string hex = string.Empty;

            var hashValue = alg.ComputeHash(message);

            foreach (byte x in hashValue)            
                hex += String.Format("{0:x2}", x);
            
            return hex;

        }


    }
}
