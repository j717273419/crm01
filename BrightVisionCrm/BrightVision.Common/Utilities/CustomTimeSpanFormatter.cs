﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrightVision.Common.Utilities
{
    public class CustomTimeSpanFormatter : IFormatProvider, ICustomFormatter
    {
        // The GetFormat method of the IFormatProvider interface. 
        // This must return an object that provides formatting services for the specified type. 
        public object GetFormat(System.Type type)
        {
            return this;
        }
        // The Format method of the ICustomFormatter interface. 
        // This must format the specified value according to the specified format settings. 
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            var timespan = TimeSpan.Parse(arg.ToString());
            string ret = timespan.ToString(format);
            return ret;
        }
    }
}
