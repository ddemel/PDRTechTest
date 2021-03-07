using System.Text.RegularExpressions;

namespace PDR.PatientBooking.Service.Validation
{
    public class EmailAddressValidation
    {
        public string Email { get; set; }

        public bool IsValid()
        {
            return Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
        }
    }
}
