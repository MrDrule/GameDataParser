﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.Logging
{
    public class Logger
    {
        private readonly string _logFileName;

        public Logger(string logFileNAme)
        {
            _logFileName = logFileNAme;
        }
        public void Log(Exception ex)
        {
            var entry =
    $@"[{DateTime.Now}]
Exception message: {ex.Message}
Stack trace: {ex.StackTrace}

";
            File.AppendAllText(_logFileName, entry);
        }
    } 
}
