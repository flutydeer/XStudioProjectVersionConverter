using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 工程文件版本转换工具
{
    public partial class AboutWindow : MyForm
    {
        private bool formMove = false;//窗体是否移动
        private Point formPoint;//记录窗体的位置

        public AboutWindow()
        {
            InitializeComponent();
            pictureBoxLarge.Image = Image.FromFile(Environment.CurrentDirectory + @"\Resources\icon.png");
            pictureBoxTitleIcon.Image = Image.FromFile(Environment.CurrentDirectory + @"\Resources\icon.png");
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
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
    }
}
