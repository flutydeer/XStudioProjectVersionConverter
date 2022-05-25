using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFileConverter
{
    public partial class AboutWindow : WindowBase
    {
        private AppSettings appSettings;

        public AboutWindow(AppSettings appSettingsFromMain)
        {
            appSettings = appSettingsFromMain;
            InitializeComponent();
            pictureBoxLarge.Image = Properties.Resources.icon_large;
            pictureBoxTitleIcon.Image = Properties.Resources.icon_large;
            labelProductAndAuthorName.Text = Application.ProductName + Application.ProductVersion +  "\n开发者：" + Application.CompanyName;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LableTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void ButtonVisitDeveloperHomepage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://space.bilibili.com/386270936");
        }

        private void ButtonCheckForUpdatesAtGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/flutydeer/XStudioProjectVersionConverter/releases");
        }

        private void ButtonVisitGitHubHomepage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/flutydeer/XStudioProjectVersionConverter");
        }

        private void ButtonVisitGiteeHomepage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://gitee.com/flutydeer/XStudioProjectVersionConverter");
        }

        private void ButtonCheckForUpdatesAtGitee_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://gitee.com/flutydeer/XStudioProjectVersionConverter/releases");
        }

        private void AboutWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush b = new LinearGradientBrush(ClientRectangle, ThemeUtils.ThemeWindowBackgroundColor(appSettings.Theme).Item1, ThemeUtils.ThemeWindowBackgroundColor(appSettings.Theme).Item2, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, ClientRectangle);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity >= 1)
            {
                timer1.Enabled = false;
            }
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            if (ThemeUtils.IsDarkMode())
            {
                LabelTitle.ForeColor = Color.FromArgb(240, 240, 240);

                BtnClose.ForeColor = Color.FromArgb(240, 240, 240);

                labelProductAndAuthorName.ForeColor = Color.FromArgb(240, 240, 240);

                ButtonCheckForUpdatesAtGitHub = ThemeUtils.GetDarkButton(ButtonCheckForUpdatesAtGitHub);
                ButtonCheckForUpdatesAtGitee = ThemeUtils.GetDarkButton(ButtonCheckForUpdatesAtGitee);
                ButtonVisitDeveloperHomepage = ThemeUtils.GetDarkButton(ButtonVisitDeveloperHomepage);
                ButtonVisitGitHubHomepage = ThemeUtils.GetDarkButton(ButtonVisitGitHubHomepage);
                ButtonVisitGiteeHomepage = ThemeUtils.GetDarkButton(ButtonVisitGiteeHomepage);
                
            }
            Opacity = 0;
        }

        private void labelProductAndAuthorName_Click(object sender, EventArgs e)
        {

        }
    }
}
