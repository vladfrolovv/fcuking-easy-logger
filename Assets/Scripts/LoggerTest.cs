
using System;
using UnityEngine;
using VLFrolov.FcukingEasyLogger;

namespace DefaultNamespace
{
    public class LoggerTest : MonoBehaviour
    {

        protected void Awake()
        {
            foreach (LogColor color in Enum.GetValues(typeof(LogColor)))
            {
                LoggingUtilities.Log($"This is {color} color log. Look how magnificent it is" , color);
            }

        }

    }
}
