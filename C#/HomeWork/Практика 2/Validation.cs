using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.HomeWork._9_10;

public static class ValidationHelper
{
    public static void ValidateNotNullOrWhiteSpace(string value, string parameterName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(parameterName, $"{parameterName} cannot be null or whitespace.");
        }
    }
    public static void ValidateNotNull<T>(T value, string parameterName)
    {
        if (value == null)
        {
            throw new ArgumentNullException(parameterName, $"{parameterName} cannot be null.");
        }
    }
}