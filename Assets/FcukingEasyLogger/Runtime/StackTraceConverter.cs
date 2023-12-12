#region

using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

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

            return callingType != null ?
                Regex.Replace(callingType.Name, "(\\B[A-Z])", " $1") :
                "UnknownClass";
        }

    }
}
