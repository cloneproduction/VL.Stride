﻿using System;
using System.Collections.Generic;
using System.Text;
using Xenko.Core.Diagnostics;

namespace VL.Xenko.Core
{
    public static class LoggerExtensions
    {
        public static ILogger GetLoggerresult(string name = null) 
            => new LoggerResult(name);
    }
}
