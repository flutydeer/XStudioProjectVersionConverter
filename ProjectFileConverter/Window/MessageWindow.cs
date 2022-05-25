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
    public partial class MessageWindow : WindowBase
    {
        public enum MessageType
        {
            Info,
            Done,
            Warning,
            Error
        }

        private AppSettings appSettings;
        private bool isExpanded = false;
        
        public MessageWindow(AppSettings appSettingsFromMain, string Title, string[] Message, MessageType type)
        {
            appSettings = appSettingsFromMain;
            InitializeComponent();
            LabelTitle.Text = Title;
            TextBoxMessage.Lines = Message;
            Image imageTypeIcon = Properties.Resources.icon_info;
            pictureBoxTitleIcon.Image = Properties.Resources.icon_large;
            switch (type)
            {
                case MessageType.Info:
                    imageTypeIcon = Properties.Resources.icon_info;
                    break;
                case MessageType.Done:
                    imageTypeIcon = Properties.Resources.icon_done;
                    break;
                case MessageType.Warning:
                    imageTypeIcon = Properties.Resources.icon_warning;
                    break;
                case MessageType.Error:
                    imageTypeIcon = Properties.Resources.icon_error;
                    break;
                default:
                    break;
            }
            pictureBoxTypeIcon.Image = imageTypeIcon;
            FlashWindow(Handle, true);
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessageWindow_Resize(object sender, EventArgs e)
        {
            Point pointBtnCloseLocation = new Point(Width - BtnClose.Width, 0);
            BtnClose.Location = pointBtnCloseLocation;
        }

        private void BtnExpand_Click(object sender, EventArgs e)
        {
            if (!isExpanded)
            {
                BtnExpand.Text = "折叠";
                Height += 300;
                TextBoxMessage.Height += 300;
                Button_OK.Location = new Point(Button_OK.Location.X, Button_OK.Location.Y + 300);
                BtnCopyDetails.Location = new Point(BtnCopyDetails.Location.X, BtnCopyDetails.Location.Y + 300);
                BtnExpand.Location = new Point(BtnExpand.Location.X, BtnExpand.Location.Y + 300);
                isExpanded = true;
            }
            else
            {
                BtnExpand.Text = "展开";
                Height -= 300;
                TextBoxMessage.Height -= 300;
                Button_OK.Location = new Point(Button_OK.Location.X, Button_OK.Location.Y - 300);
                BtnCopyDetails.Location = new Point(BtnCopyDetails.Location.X, BtnCopyDetails.Location.Y - 300);
                BtnExpand.Location = new Point(BtnExpand.Location.X, BtnExpand.Location.Y - 300);
                isExpanded = false;
            }
        }

        private void BtnCopyDetails_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Join("\r\n", TextBoxMessage.Lines));
            BtnCopyDetails.Text = "✓已复制到剪贴板！";
        }

        private void MessageWindow_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MessageWindow_Load(object sender, EventArgs e)
        {
            Button_OK.BackColor = ThemeUtils.AccentColor(appSettings.Theme);
            if (ThemeUtils.IsDarkMode())
            {
                BackColor = Color.FromArgb(40, 40, 40);
                LabelTitle.ForeColor = Color.FromArgb(240, 240, 240);
                BtnClose.ForeColor = Color.FromArgb(240, 240, 240);
                TextBoxMessage.BackColor = Color.FromArgb(40, 40, 40);
                TextBoxMessage.ForeColor = Color.FromArgb(240, 240, 240);
                BtnExpand = ThemeUtils.GetDarkButton(BtnExpand);
                BtnCopyDetails = ThemeUtils.GetDarkButton(BtnCopyDetails);
                Button_OK.BackColor = ThemeUtils.AccentColor(appSettings.Theme);
            }
            Opacity = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity >= 1)
            {
                timer1.Enabled = false;
            }
        }
    }
}
