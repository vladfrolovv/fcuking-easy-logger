using System.Collections.Generic;

namespace VLFrolov.FcukingEasyLogger
{
    public static class ColorsConverter
    {

        private static readonly Dictionary<LogColor, string> _colors = new Dictionary<LogColor, string>()
        {
            { LogColor.gray, "#808080" },
            { LogColor.pink, "#FFC0CB" },
            { LogColor.silver, "#C0C0C0" },
            { LogColor.gold, "#FFD700" },
            { LogColor.turquoise, "#40E0D0" },
            { LogColor.salmon, "#FA8072" },
            { LogColor.skyblue, "#87CEEB" },
            { LogColor.indigo, "#4B0082" },
            { LogColor.slategray, "#708090" },
            { LogColor.chocolate, "#D2691E" },
            { LogColor.violet, "#EE82EE" },
            { LogColor.chartreuse, "#7FFF00" },
            { LogColor.tomato, "#FF6347" },
        };


        public static string GetColor(LogColor color)
            => _colors.ContainsKey(color) ? _colors[color] : color.ToString();

    }
}
