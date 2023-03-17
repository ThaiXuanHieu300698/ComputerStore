using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class PhoneNumberValidation
    {
        public static bool IsValid(string phoneNumber)
        {
            try
            {
                if(String.IsNullOrEmpty(phoneNumber))
                {
                    return false;
                }
                var r = new Regex(@"^(0[0-9]{9,10})$");
                bool a =  r.IsMatch(phoneNumber);
                return a;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
