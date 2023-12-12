#region

using System;
using System.Collections.Generic;
using UnityEngine;
using VLFrolov.FcukingEasyLogger;

#endregion

namespace Runtime
{
    public class LoggerTest : MonoBehaviour
    {

        protected void Awake()
        {
            foreach (LogColor color in Enum.GetValues(typeof(LogColor)))
            {
                LoggingUtilities.Log($"This is {color} color log. Look how magnificent it is", color);
            }

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, };
            int[] array = new[] { 1, 2, 3, 4, 5, };
            HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5, };
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, });
            Stack<int> stack = new Stack<int>(new[] { 1, 2, 3, 4, 5, });
            LinkedList<int> linkedList = new LinkedList<int>(new[] { 1, 2, 3, 4, 5, });
            Dictionary<int, bool> dictionary = new Dictionary<int, bool>() {
                { 1, true },
                { 2, true },
                { 3, false },
                { 4, true },
                { 5, false },
            };

            int[,] twoDArray = new int[3, 3] {
                { 1, 2, 3, },
                { 4, 5, 6, },
                { 7, 8, 9, },
            };

            int[][] jaggedArray = new int[3][] {
                new int[3] { 1, 2, 3, },
                new int[3] { 4, 5, 6, },
                new int[3] { 7, 8, 9, },
            };

            LoggingUtilities.LogCollection($"Easy logging for List:", list, LogColor.gold);
            LoggingUtilities.LogCollection($"Easy logging for Array:", array, LogColor.black);
            LoggingUtilities.LogCollection($"Easy logging for Hash set:", hashSet, LogColor.teal);
            LoggingUtilities.LogCollection($"Easy logging for Queue:", queue, LogColor.cyan);
            LoggingUtilities.LogCollection($"Easy logging for Dictionary:", dictionary, LogColor.green);
            LoggingUtilities.LogCollection($"Easy logging for Stack:", stack, LogColor.orange);
            LoggingUtilities.LogCollection($"Easy logging for Linked List:", linkedList, LogColor.brown);

            LoggingUtilities.LogMatrix($"Easy logging for 2D Array:", twoDArray, LogColor.brown);
            LoggingUtilities.LogMatrix($"Easy logging for Jagged Array:", jaggedArray, LogColor.brown);
        }
    }
}
