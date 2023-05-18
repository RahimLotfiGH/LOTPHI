using LOTPHI.OTPGenerator.Models;
using LOTPHI.OTPGenerator.Utilities;


namespace LOTPHI.OTPGenerator.OTPServices.Servises
{
    public class OTPGeneratorService 
    {

        public static string GenerateOtp(string secretKey, int length)
        {
            var date = DateTime.UtcNow.ToLongDateString();
            var time = DateTime.UtcNow.ToLongTimeString();

            var otp = LOTPHI(secretKey + date + time, length);

            return otp.ToString;
        }

        private static OTP LOTPHI(string secretKey, int length)
        {

            if (string.IsNullOrEmpty(secretKey))
                secretKey = OtpConsts.DefultOtpSecretKey;

            secretKey = OtpHashHelper.GetSha256Hash(secretKey);


            return new OTP
            {
                Value = GeneraeOtpValue(secretKey, length),
            };

        }

        private static string GeneraeOtpValue(string secretKey, int length)
        {
            var secretKeyLen = secretKey.Length -
                               1 -
                               OtpConsts.OtpCoefficientOfDifference;

            var value = string.Empty;

            for (int lengthIndex = 0; lengthIndex < length - 1; ++lengthIndex)
                value += GetOtpChar(secretKey[secretKeyLen - lengthIndex]);

            return value;
        }

        public static bool ValidateOtp(string secretKey, string otp, int secends)
        {
            var date = DateTime.UtcNow.ToLongDateString();
            var time = DateTime.UtcNow;
            var otpLength = otp.Length;
            var mainOtp = otp.Substring(1, otpLength - 1);

            for (int i = 0; i <= secends; ++i)
            {
                var timeNew = time.AddSeconds(-i);

                var rotp = LOTPHI(secretKey + date + timeNew.ToLongTimeString(), otpLength);
              
                if (mainOtp == rotp.Value)
                    return true;
            }

            return false;
        }


        private static char GetOtpChar(char value)
        {
            var charValue = value - '0';

            var otpValue = Math.Abs((charValue % 10)) + 48;

            return (char)otpValue;
        }

    }
}
