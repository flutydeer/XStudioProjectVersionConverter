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
    public partial class MessageWindow : MyForm
    {

        public MessageWindow(string Title, string[] Message, int Type)
        {
            InitializeComponent();
            Lable_Title.Text = Title;
            TextBox_Message.Lines = Message;
            Image imageTypeIcon = Properties.Resources.icon_info;
            pictureBoxTitleIcon.Image = Image.FromFile(Environment.CurrentDirectory + @"\Resources\icon.png");
            switch (Type)
            {
                case 0:
                    imageTypeIcon = Properties.Resources.icon_info;
                    break;
                case 1:
                    imageTypeIcon = Properties.Resources.icon_done;
                    break;
                case 2:
                    imageTypeIcon = Properties.Resources.icon_warning;
                    break;
                case 3:
                    imageTypeIcon = Properties.Resources.icon_error;
                    break;
                default:
                    break;
            }
            pictureBoxTypeIcon.Image = imageTypeIcon;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
