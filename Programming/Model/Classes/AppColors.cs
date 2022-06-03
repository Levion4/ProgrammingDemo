using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит все цвета, которые используются в приложении.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет нормального состояния.
        /// </summary>
        public static readonly System.Drawing.Color NormalColor = System.Drawing.Color.White;

        /// <summary>
        /// Цвет ошибки.
        /// </summary>
        public static readonly System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        /// <summary>
        /// Цвет зимы.
        /// </summary>
        public static readonly System.Drawing.Color WinterColor = System.Drawing.Color.Blue;

        /// <summary>
        /// Цвет весны.
        /// </summary>
        public static readonly System.Drawing.Color SpringColor = System.Drawing.Color.Green;

        /// <summary>
        /// Цвет лета.
        /// </summary>
        public static readonly System.Drawing.Color SummerColor = System.Drawing.Color.Yellow;

        /// <summary>
        /// Цвет осени.
        /// </summary>
        public static readonly System.Drawing.Color AutumnColor = System.Drawing.Color.Orange;

        /// <summary>
        /// Цвет нормального состояния элементов на панели.
        /// </summary>
        public static readonly System.Drawing.Color NormalPanelColor =
            System.Drawing.Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет ошибки элементов на панели.
        /// </summary>
        public static readonly System.Drawing.Color ErrorPanelColor =
            System.Drawing.Color.FromArgb(127, 255, 127, 127);
    }
}
