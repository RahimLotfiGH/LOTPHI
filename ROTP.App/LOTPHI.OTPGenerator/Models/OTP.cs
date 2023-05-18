
namespace LOTPHI.OTPGenerator.Models
{
    internal class OTP
    {

        public OTP()
        {

            Salt = GetSalt;
        }

        public char Salt { get; set; }

        public string Value { get; set; }

        public new string ToString => Salt + Value;

        private static char GetSalt => new Random().Next(0, 9).ToString()[0];

    }
}
