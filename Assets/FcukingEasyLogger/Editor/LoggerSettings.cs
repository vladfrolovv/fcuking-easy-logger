#region

using UnityEditor;

#endregion

#if UNITY_EDITOR

namespace VLFrolov.FcukingEasyLogger.Editor
{
    public class LoggerSettings : EditorWindow
    {

        private const string _switchMenuItem = "Assets/Logger/Logs Enabled";
        private const string _versionMenuItem = "Assets/Logger/Version";

        [MenuItem(_versionMenuItem)]
        public static void ShowPluginVersion()
        {
            EditorUtility.DisplayDialog(_versionMenuItem, $"Current version: {LoggerVersion.VERSION}", "Close");
        }

    }
}

#endif
