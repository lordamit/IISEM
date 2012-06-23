﻿using System;

namespace IISExpressManager
{
    internal class FindOperatingSystemBasedInfo
    {
        internal static string OperatingSystemSpecificIISLocation()
        {
            int size = IntPtr.Size;

            if (size == 8) return @"C:\Program Files (x86)\IIS Express\iisexpress.exe";
            if (size == 4) return @"C:\Program Files\IIS Express\iisexpress.exe";

            return "null";
        }
    }
}