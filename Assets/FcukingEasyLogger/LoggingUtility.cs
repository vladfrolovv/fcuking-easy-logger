#region

using System.Collections.Generic;
using System.Text.RegularExpressions;
using Debug = UnityEngine.Debug;

#endregion

namespace VLFrolov.FcukingEasyLogger
{
    public static class LoggingUtility
    {
        private const bool LOGGING = true;

        public static void Log(string message, LogColor color = LogColor.white)
        {
            if (!LOGGING)
                return;

            string classCaller = Regex.Replace(StackTraceConverter.GetCallerClassName(), "(\\B[A-Z])", " $1");
            Debug.Log($"<color={ColorsConverter.GetColor(color)}>[{classCaller}]</color> {message}");
        }


        public static void LogList<T>(string prefix, IList<T> list)
        {
            if (!LOGGING)
                return;

            Debug.Log($"{prefix} {string.Join(", ", list)}");
        }

    }

}