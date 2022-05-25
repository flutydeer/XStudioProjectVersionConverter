using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjectFileConverter
{
    public static class ThemeUtils
    {
        public static bool IsDarkMode()
        {
            try
            {
                using (RegistryKey personalize = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", false))
                {
                    if (personalize.GetValueNames().Contains("AppsUseLightTheme"))
                    {
                        return (int)personalize.GetValue("AppsUseLightTheme") != 1;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static Color AccentColor(string themeName)
        {
            switch (themeName)
            {
                case "白色/黑色":
                    return ThemeColorAccentPurple();
                case "黄色-绿色":
                    return ThemeColorAccentGreen();
                case "绿色-蓝色":
                    return ThemeColorAccentBlue();
                case "蓝色-紫色":
                    return ThemeColorAccentPurple();
                default:
                    return ThemeColorAccentPurple();
            }
        }
        
        public static Color ThemeColorAccentPurple()
        {
            if (IsDarkMode())
            {
                return Color.FromArgb(152, 38, 224);
            }
            else
            {
                return Color.FromArgb(152, 38, 224);
            }
        }

        public static Color ThemeColorAccentGreen()
        {
            if (IsDarkMode())
            {
                return Color.FromArgb(77, 137, 91);
            }
            else
            {
                return Color.FromArgb(77, 137, 91);
            }
        }
        
        public static Color ThemeColorAccentBlue()
        {
            if (IsDarkMode())
            {
                return Color.FromArgb(0, 127, 255);
            }
            else
            {
                return Color.FromArgb(0, 127, 255);
            }
        }

        public static Color DarkForeColor()
        {
            return Color.FromArgb(240, 240, 240);
        }

        public static Color LightForeColor()
        {
            return Color.FromArgb(15, 15, 15);
        }

        public static Color CommonDarkBackColor()
        {
            return Color.FromArgb(50, 50, 50);
        }

        public static Color CommonLightBackColor()
        {
            return Color.FromArgb(251, 251, 251);
        }

        public static Color HighlightedListViewItemForeColor()
        {
            //return Color.FromArgb(152, 38, 224);
            return Color.White;
        }

        public static Color HighlightedListViewItemBackColor(string themeName)
        {
            //return Color.FromArgb(234, 212, 249);
            return AccentColor(themeName);
        }
        
        public static Button GetDarkButton(Button button)
        {
            button.ForeColor = DarkForeColor();
            button.BackColor = CommonDarkBackColor();
            button.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 69, 69);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            return button;
        }

        public static Button GetAccentButton(Button button, AppSettings appSettings)
        {
            button.BackColor = AccentColor(appSettings.Theme);
            return button;
        }

        public static Button GetDarkTitleCommonButton(Button button)
        {
            button.ForeColor = DarkForeColor();
            button.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            button.FlatAppearance.MouseOverBackColor = CommonDarkBackColor();
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            return button;
        }

        public static Button GetDarkTitleCloseButton(Button button)
        {
            button.ForeColor = DarkForeColor();
            return button;
        }

        public static ComboBox GetDarkComboBox(ComboBox comboBox)
        {
            comboBox.ForeColor = DarkForeColor();
            comboBox.BackColor = CommonDarkBackColor();
            return comboBox;
        }

        public static GroupBox GetDarkGroupBox(GroupBox groupBox)
        {
            groupBox.ForeColor = DarkForeColor();
            return groupBox;
        }

        public static Label GetDarkLabel(Label label)
        {
            label.ForeColor = DarkForeColor();
            return label;
        }

        public static ListView GetDarkListView(ListView listView)
        {
            listView.ForeColor = DarkForeColor();
            listView.BackColor = Color.FromArgb(30, 30, 30);
            return listView;
        }

        public static CheckBox GetDarkCheckBox(CheckBox checkBox)
        {
            checkBox.ForeColor = DarkForeColor();
            return checkBox;
        }

        public static Tuple<Color, Color> ThemeWindowBackgroundColor(string colorName)
        {
            switch (colorName)
            {
                case "白色/黑色":
                    return ThemeColorWhiteOrBlack();
                case "黄色-绿色":
                    return ThemeColorYellowToGreen();
                case "绿色-蓝色":
                    return ThemeColorGreenToBlue();
                case "蓝色-紫色":
                    return ThemeColorBlueToPurpule();
                default:
                    return ThemeColorBlueToPurpule();
            }
        }
        
        public static Tuple<Color, Color> ThemeColorWhiteOrBlack()
        {
            if (IsDarkMode())
            {
                return new Tuple<Color, Color>(Color.FromArgb(40, 40, 40), Color.FromArgb(40, 40, 40));
            }
            else
            {
                return new Tuple<Color, Color>(Color.FromArgb(243, 243, 243), Color.FromArgb(243, 243, 243));
            }
        }

        public static Tuple<Color, Color> ThemeColorYellowToGreen()
        {
            if (IsDarkMode())
            {
                return new Tuple<Color, Color>(Color.FromArgb(50, 47, 10), Color.FromArgb(13, 47, 13));
            }
            else
            {
                return new Tuple<Color, Color>(Color.FromArgb(249, 247, 224), Color.FromArgb(234, 249, 234));
            }
        }
        
        public static Tuple<Color, Color> ThemeColorGreenToBlue()
        {
            if (IsDarkMode())
            {
                return new Tuple<Color, Color>(Color.FromArgb(13, 47, 13), Color.FromArgb(13, 48, 71));
            }
            else
            {
                return new Tuple<Color, Color>(Color.FromArgb(234, 249, 234), Color.FromArgb(219, 237, 249));
            }
        }

        public static Tuple<Color, Color> ThemeColorBlueToPurpule()
        {
            Color FColor;
            Color TColor;
            if (IsDarkMode())
            {
                FColor = Color.FromArgb(13, 48, 71);
                TColor = Color.FromArgb(38, 11, 58);
            }
            else
            {
                FColor = Color.FromArgb(219, 237, 249);
                TColor = Color.FromArgb(239, 225, 250);
            }
            return new Tuple<Color, Color>(FColor, TColor);
        }

    }
}
