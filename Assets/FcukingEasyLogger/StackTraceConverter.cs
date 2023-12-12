#region

using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

#endregion

namespace VLFrolov.FcukingEasyLogger
{
    public static class StackTraceConverter
    {
        public static string GetCallerClassName()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame callingFrame = stackTrace.GetFrame(2);
            MethodBase callingMethod = callingFrame.GetMethod();
            Type callingType = callingMethod.DeclaringType;

            return callingType != null ? callingType.Name : "UnknownClass";
        }


        public static void RemoveLoggerFromStackTrace()
        {
            var relevantStackFrames =
                Environment.StackTrace
                    .Split('\n')
                    .Skip(1)
                    .ToArray();
            var relevantStackTrace = string.Join("\n", relevantStackFrames);
        }
    }
}
