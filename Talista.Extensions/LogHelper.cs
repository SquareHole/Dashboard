using System;
using System.Runtime.CompilerServices;
using Serilog;

namespace Talista.Extensions
{
    public static class LogHelper
    {
        public static void OnEnter(this object context, [CallerMemberName] string callerMemberName = null)
        {
            var logger = Log.Logger;
            logger.Debug($"Entering : {callerMemberName} - {DateTime.Now}");
        }

        public static void OnExit(this object context, [CallerMemberName] string callerMemberName = null)
        {
            var logger = Log.Logger;
            logger.Debug($"Exiting : {callerMemberName} - {DateTime.Now}");
        }

        public static void OnInfo(this object context, string message, params object[] data)
        {
            var logger = Log.Logger;
            logger.Information($"{message}", data);
        }
    }
}