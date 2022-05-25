using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjectFileConverter
{
    public partial class OptionsWindow : WindowBase
    {
        private AppSettings appSettings;
        public string openSvipPath;
        public string theme;
        public string doneMessageAppearance;
        public bool isOpenOutputDir;
        public bool isShowCommandBeforeConverting;

        public OptionsWindow(AppSettings appSettingsFromMain)
        {
            appSettings = appSettingsFromMain;
            InitializeComponent();
            comboBoxOpenSvipPath.Text = appSettings.OpenSvipPath;
            if (appSettings.Theme != null && appSettings.Theme != "")
            {
                comboBoxTheme.Text = appSettings.Theme;
            }
            else
            {
                comboBoxTheme.Text = "蓝色-紫色";
            }
            if (appSettings.DoneMessageAppearance != null && appSettings.DoneMessageAppearance != "")
            {
                comboBoxDoneMessageAppearance.Text = appSettings.DoneMessageAppearance;
            }
            else
            {
                comboBoxDoneMessageAppearance.Text = "Windows 10/11原生Toast通知";
            }
            checkBoxOpenOutputDir.Checked = appSettings.IsOpenOutputDir;
            checkBoxShowCommandBeforeConverting.Checked = appSettings.IsShowCommandBeforeConverting;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity >= 1)
            {
                timer1.Enabled = false;
            }
        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            buttonOK.BackColor = ThemeUtils.AccentColor(appSettings.Theme);
            if (ThemeUtils.IsDarkMode())
            {
                SwitchToDarkMode();
            }
            pictureBoxTitleIcon.Image = Properties.Resources.icon_large;
            comboBoxDoneMessageAppearance.SelectedItem = comboBoxDoneMessageAppearance.Items.IndexOf("Windows 10/11原生Toast通知");
            if (appSettings.HistoryOutputDir != null && appSettings.HistoryOutputDir.Count > 0)
            {
                buttonClearHistoryOutputDir.Text += String.Format("（{0}条）", appSettings.HistoryOutputDir.Count);
            }
            Opacity = 0;
        }

        private void SwitchToDarkMode()
        {
            labelTitle = ThemeUtils.GetDarkLabel(labelTitle);
            btnClose = ThemeUtils.GetDarkTitleCloseButton(btnClose);
            labelOpenSvipPath = ThemeUtils.GetDarkLabel(labelOpenSvipPath);
            buttonBrowse = ThemeUtils.GetDarkButton(buttonBrowse);
            comboBoxOpenSvipPath = ThemeUtils.GetDarkComboBox(comboBoxOpenSvipPath);
            labelTheme = ThemeUtils.GetDarkLabel(labelTheme);
            comboBoxTheme = ThemeUtils.GetDarkComboBox(comboBoxTheme);
            labelDoneMessage = ThemeUtils.GetDarkLabel(labelDoneMessage);
            comboBoxDoneMessageAppearance = ThemeUtils.GetDarkComboBox(comboBoxDoneMessageAppearance);
            checkBoxOpenOutputDir = ThemeUtils.GetDarkCheckBox(checkBoxOpenOutputDir);
            checkBoxShowCommandBeforeConverting = ThemeUtils.GetDarkCheckBox(checkBoxShowCommandBeforeConverting);
            buttonClearHistoryOutputDir = ThemeUtils.GetDarkButton(buttonClearHistoryOutputDir);
            buttonHelp = ThemeUtils.GetDarkButton(buttonHelp);
            buttonCancel = ThemeUtils.GetDarkButton(buttonCancel);
            buttonOK = ThemeUtils.GetAccentButton(buttonOK, appSettings);
        }

        private void OptionsWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush b = new LinearGradientBrush(ClientRectangle, ThemeUtils.ThemeWindowBackgroundColor(appSettings.Theme).Item1, ThemeUtils.ThemeWindowBackgroundColor(appSettings.Theme).Item2, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, ClientRectangle);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "OpenSvip.Console.exe|OpenSvip.Console.exe",
                Title = "请选择\"OpenSvip.Console.exe\"",
                InitialDirectory = Environment.CurrentDirectory
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                comboBoxOpenSvipPath.Text = ofd.FileName;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OptionsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            openSvipPath = comboBoxOpenSvipPath.Text;
            theme = comboBoxTheme.Text;
            doneMessageAppearance = comboBoxDoneMessageAppearance.Text;
            isOpenOutputDir = checkBoxOpenOutputDir.Checked;
            isShowCommandBeforeConverting = checkBoxShowCommandBeforeConverting.Checked;
        }

        private void buttonClearHistoryOutputDir_Click(object sender, EventArgs e)
        {
            if (appSettings.HistoryOutputDir != null)
            {
                appSettings.HistoryOutputDir.Clear();
            }
            string[] msg = { "清除历史输出目录成功" };
            new MessageWindow(appSettings, "提示", msg, MessageWindow.MessageType.Done).ShowDialog();
        }
    }
}
