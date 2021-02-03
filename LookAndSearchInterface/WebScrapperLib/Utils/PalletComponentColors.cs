using System.Collections.Generic;
using System.Drawing;

namespace WebScrapperLib.Utils
{
    public static partial class DataGridViewHeaderColors
    {
        /// <summary>
        /// [0] - BackColor
        /// [1] - ForeColor
        /// [2] - SelectionBackColor
        /// [3] - SelectionForeColor
        /// </summary>
        public static Dictionary<string, List<Color>> PalletDic = new Dictionary<string, List<Color>>
        {
            {"Blue#Header", new List<Color>{ Color.FromArgb(0, 174, 219), Color.White, Color.FromArgb(0, 198, 247), Color.FromArgb(17, 17, 17) } },
            {"Blue#Row", new List<Color>{ Color.FromArgb(0, 174, 219), Color.White, Color.FromArgb(0, 198, 247), Color.FromArgb(17, 17, 17) } },
            {"Blue#Cell", new List<Color>{ Color.White, Color.FromArgb(136, 136, 136), Color.FromArgb(0, 198, 247), Color.FromArgb(17, 17, 17) } },
            {"Black#Header", new List<Color>{ Color.Black, Color.White, Color.LightGray, Color.White } },
            {"Black#Row", new List<Color>{ Color.LightGray, Color.DimGray, Color.DarkGray, Color.White } },
            {"Black#Cell", new List<Color>{ Color.LightGray, Color.DimGray, Color.DarkGray, Color.White } },
            {"Pink#Header", new List<Color>{ Color.FromArgb(192, 0 , 192), Color.White, Color.FromArgb(64, 0, 64), Color.White } },
            {"Pink#Row", new List<Color>{ Color.FromArgb(255, 192, 255), Color.FromArgb(192, 0, 192), Color.FromArgb(64, 0, 64), Color.White } },
            {"Pink#Cell", new List<Color>{ Color.FromArgb(255, 192, 255), Color.FromArgb(192, 0, 192), Color.FromArgb(64, 0, 64), Color.White } },
        };
    }

    public static partial class DataGridViewCellsColors
    {
        /// <summary>
        /// [0] - BackgroundColor
        /// </summary>
        public static Dictionary<string, List<Color>> PalletDic = new Dictionary<string, List<Color>>
        {
            {"Blue#Header", new List<Color>{ Color.WhiteSmoke, Color.White } },
            {"Blue#Row", new List<Color>{ Color.WhiteSmoke, Color.White } },
            {"Blue#Cell", new List<Color>{ Color.WhiteSmoke, Color.White } },
            {"Black#Header", new List<Color>{ Color.WhiteSmoke, Color.White } },
            {"Black#Row", new List<Color>{ Color.WhiteSmoke, Color.White } },
            {"Black#Cell", new List<Color>{ Color.WhiteSmoke, Color.White } },
            {"Pink#Header", new List<Color>{ Color.WhiteSmoke, Color.White } },
            {"Pink#Row", new List<Color>{ Color.WhiteSmoke, Color.White } },
            {"Pink#Cell", new List<Color>{ Color.WhiteSmoke, Color.White } },
        };
    }

    public static partial class DataGridViewCellSize
    {
        /// <summary>
        /// [0] - FontSize
        /// </summary>
        public static Dictionary<string, int> PalletDic = new Dictionary<string, int>
        {
            {"Blue#Header", 9 },
            {"Blue#Row", 8 },
            {"Blue#Cell", 8 },
            {"Black#Header", 9 },
            {"Black#Row", 8 },
            {"Black#Cell", 8 },
            {"Pink#Header", 9 },
            {"Pink#Row", 8 },
            {"Pink#Cell", 8 },
        };
    }
}
