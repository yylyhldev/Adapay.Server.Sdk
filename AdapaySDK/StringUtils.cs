﻿using System;
using System.Collections.Generic;

namespace AdapaySDK
{
    public class StringUtils
    {
        public static string tryGetNotNullValue(Dictionary<string, object> dict, string key)
        {
            object value = null;
            dict.TryGetValue(key, out value);
            if (string.IsNullOrWhiteSpace((string)value))
            {
                throw new Exception(value + " cannot be empty");
            }
            return (string)value;

        }

    }
}
