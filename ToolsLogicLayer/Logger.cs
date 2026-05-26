using System;
using System.Diagnostics;
using System.IO;

namespace ToolsLogicLayer
{
    public static class Logger
    {
        public enum LogType
        {
            Information, Error
        }
        private static string sourceName = "BetterPcApp";
        public static void Log(string message, LogType type)
        {
            try
            {
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }
                EventLog.WriteEntry(sourceName, message, (type == LogType.Information) ? EventLogEntryType.Information : EventLogEntryType.Warning);
            }
            catch
            {
            }
        }
    }
}
