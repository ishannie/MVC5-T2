using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BigSchool.ViewModels
{
    internal class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                                                "dd/M/yyyy",
                                                CultureInfo.CurrentCulture,
                                                DateTimeStyles.None,
                                                out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}