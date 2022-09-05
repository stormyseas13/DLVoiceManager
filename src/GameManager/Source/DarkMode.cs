using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Source {
    public class DarkMode  {
        private static bool UsingLightTheme() {
            var registryKey = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            var appsUseLightTheme = registryKey?.GetValue("AppsUseLightTheme");

            if (appsUseLightTheme is null) {
                return true;
            }
            else {
                return Convert.ToBoolean(appsUseLightTheme,
                    CultureInfo.InvariantCulture);
            }
        }

        public static void DarkTheme() {
            if (!UsingLightTheme()) {
                // styles for dark mode
                var backgroundColor = Color.FromArgb(12, 12, 12);
                var foregroundColor = Color.White;
                var panelColor = Color.FromArgb(28, 28, 28);
                var buttonColor = Color.FromArgb(44, 44, 44);
                var actionButtonColor = Color.DodgerBlue;
                var buttonBorderSize = 0;
                var buttonFlatStyle = FlatStyle.Flat;
                var textboxBorderStyle = BorderStyle.None;

                // properties taken from the form designer
                

            }

        }

                
    }
}
