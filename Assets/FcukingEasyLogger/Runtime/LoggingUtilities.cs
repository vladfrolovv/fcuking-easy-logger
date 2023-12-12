#region

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#endregion

namespace VLFrolov.FcukingEasyLogger
{
    public static class LoggingUtilities
    {
        private const bool LOGGING = true;

        public static void Log(string message, LogColor color = LogColor.white)
        {
            if (!LOGGING)
                return;

            Debug.Log($"<color={ColorsConverter.GetColor(color)}>[{StackTraceConverter.GetCallerClassName()}]</color> {message}");
        }

        public static void LogCollection<T>(string prefix, T collection, LogColor color = LogColor.white) where T : IEnumerable
        {
            if (!LOGGING)
                return;

            if (string.IsNullOrEmpty(prefix))
            {
                LogCollection(collection, color);
            }
            else
            {
                Debug.Log($"<color={ColorsConverter.GetColor(color)}>[{StackTraceConverter.GetCallerClassName()}]</color> "
                          + $"{prefix} {string.Join(", ", collection.Cast<object>())}");
            }
        }

        public static void LogCollection<T>(T collection, LogColor color = LogColor.white) where T : IEnumerable
        {
            if (!LOGGING)
                return;

            Debug.Log($"<color={ColorsConverter.GetColor(color)}>[{StackTraceConverter.GetCallerClassName()}]</color> "
                      + $"{string.Join(", ", collection.Cast<object>())}");
        }


        public static void LogMatrix<T>(string prefix, T[,] matrix, LogColor color = LogColor.white)
        {
            if (!LOGGING)
                return;

            Debug.Log($"<color={ColorsConverter.GetColor(color)}>[{StackTraceConverter.GetCallerClassName()}]</color> {prefix} \n"
                      + $"{string.Join("\n", Enumerable.Range(0, matrix.GetLength(0)).Select(i => string.Join(", ", Enumerable.Range(0, matrix.GetLength(1)).Select(j => matrix[i, j]))))}");
        }

        public static void LogMatrix<T>(string prefix, IEnumerable<T[]> matrix, LogColor color = LogColor.white)
        {
            if (!LOGGING)
                return;

            Debug.Log($"<color={ColorsConverter.GetColor(color)}>[{StackTraceConverter.GetCallerClassName()}]</color> {prefix} \n"
                      + $"{string.Join("\n", matrix.Select(row => string.Join(", ", row)))}");
        }

        public static void LogMatrix<T>(T[,] matrix, LogColor color = LogColor.white)
        {
            if (!LOGGING)
                return;

            Debug.Log($"<color={ColorsConverter.GetColor(color)}>[{StackTraceConverter.GetCallerClassName()}]</color>\n"
                      + $"{string.Join("\n", Enumerable.Range(0, matrix.GetLength(0)).Select(i => string.Join(", ", Enumerable.Range(0, matrix.GetLength(1)).Select(j => matrix[i, j]))))}");
        }

        public static void LogMatrix<T>(IEnumerable<T[]> matrix, LogColor color = LogColor.white)
        {
            if (!LOGGING)
                return;

            Debug.Log($"<color={ColorsConverter.GetColor(color)}>[{StackTraceConverter.GetCallerClassName()}]</color>\n"
                      + $"{string.Join("\n", matrix.Select(row => string.Join(", ", row)))}");
        }

        public static void LogHexagonalMatrix<T>(string prefix, T[,] matrix, LogColor color = LogColor.white)
        {
            string hexMatrix = "";
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                hexMatrix += "   ";
                for (int x = 1; x < matrix.GetLength(0); x += 2)
                {
                    hexMatrix += matrix[y, x] + "     ";
                }
                hexMatrix += "\n";
                for (int x = 0; x < matrix.GetLength(0); x += 2)
                {
                    hexMatrix += matrix[y, x] + "     ";
                }
                hexMatrix += "\n";
            }
            Debug.Log($"<color={ColorsConverter.GetColor(color)}>[{StackTraceConverter.GetCallerClassName()}]</color> {prefix} \n{hexMatrix}");
        }

    }

}
