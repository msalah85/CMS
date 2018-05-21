using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Enums
{
    public enum AouthTypes
    {
        [StringValue("facebook")]
        facebook,
        [StringValue("twitter")]
        twitter,
        [StringValue("google")]
        google,
        [StringValue("custom")]
        custom
    }

    public class StringValue : System.Attribute
    {
        private readonly string _value;

        public StringValue(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

    }

}