﻿using System;

namespace BasicWebServer.HTTP
{
    public static class Guard
    {
        public static void AgainstNull(object value, string name = null)
        {
            if (value == null)
            {
                name ??= "Value";

                throw new ArgumentNullException($"{name} can not be null");
            }
        }
    }
}
