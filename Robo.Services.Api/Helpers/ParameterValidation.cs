using System;
using System.Collections.Generic;

namespace Robo.Services.Api.Extensions
{
    public static class ParameterValidation
    {
        public static bool ValidateParameterIsNotNull(IDictionary<string, object> parameterList)
        {
            if (parameterList is null)
                return false;

            foreach(var parameter in parameterList)
            {
                if(parameter.Value is null)
                    return false;
            }

            return true;

        }

        public static bool ValidateParameterIsNotZero(IDictionary<string, object> parameterList)
        {
            if (parameterList is null)
                return false;

            foreach (var parameter in parameterList)
            {
                if (parameter.Value is null)
                    return false;
            }

            return true;

        }

        public static bool ValidateFutureDate(string date)
        {
            if (string.IsNullOrEmpty(date))
                return false;

            if (Convert.ToDateTime(date) > DateTime.Now)
                return false;

            return true;

        }
    }
}
