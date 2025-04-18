using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.HomeWork._9_10;

public struct ContactInfo
{
    public string Email { get; set;}
    public string PhoneNumber { get; set; }
    public ContactInfo(string email, string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentNullException(nameof(email), "Email cannot be null or whitespace.");
        }

        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentNullException(nameof(phoneNumber), "Phone number cannot be null or whitespace.");
        }

        Email = email;
        PhoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return $"\nEmail: {Email}\nPhone: {PhoneNumber}";
    }
}