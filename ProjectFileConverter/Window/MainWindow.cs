using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Windows.Foundation.Collections;

namespace ProjectFileConverter
{
    public partial class MainWindow : WindowBase
    {
        
        int currentIndex = 1;
        string outputPath;
        string targetFormat;
        private string inputOptions = "";
        private string outputOptions = "";

        private AppSettings appSettings = new AppSettings();

        List<string> pathList = new List<string>();

        private delegate void SetProgress(int i, int ipos, string vinfo);
        private delegate void SetListViewItemTextDelegate(int index, string status);
        private delegate void ShowDoneWindow(string status, int total, int successed, string[] logArray, int logCount);

        private void SetConvertingProgress(int i, int ipos, string vinfo)
        {
            if (InvokeRequired)
            {
                SetProgress setpos = new SetProgress(SetConvertingProgress);
                Invoke(setpos, new object[] {i, ipos, vinfo });
            }
            else
            {
                SetProgressbarProgress(ipos);
                LabelTitle.Text = string.Format("正在转换文件，已完成{0}%", ipos);
                Text = string.Format("{0}%", ipos);
            }
        }

        private void SetListViewItemText(int index, string status)
        {
            if (InvokeRequired)
            {
                SetListViewItemTextDelegate setpos = new SetListViewItemTextDelegate(SetListViewItemText);
                Invoke(setpos, new object[] { index, status });
            }
            else
            {
                ListViewItem item = listView1.Items[index];
                item.SubItems[2].Text = status;
                listView1.EnsureVisible(index);
            }
        }

        private void ShowConvertDoneWindow(string status, int total, int successed, string[] logArray, int logCount)
        {
            if (InvokeRequired)
            {
                ShowDoneWindow doneWindow = new ShowDoneWindow(ShowConvertDoneWindow);
                Invoke(doneWindow, new object[] { status, total, successed, logArray, logCount });
            }
            else
            {
                if (appSettings.DoneMessageAppearance == "Windows 10/11原生Toast通知")
                {
                    new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddText(String.Format("{0}个文件转换完成，{1}个成功，{2}个失败。", Convert.ToString(listView1.Items.Count), successed, listView1.Items.Count - successed))
                    .AddText("点击打开输出目录")
                    .AddButton(new ToastButton()
                        .SetContent("打开输出目录")
                        .AddArgument("action", "openOutputPath")
                        .SetBackgroundActivation())
                    .AddButton(new ToastButton()
                        .SetContent("确定")
                        .AddArgument("action", "ok")
                        .SetBackgroundActivation())
                    .AddAppLogoOverride(new Uri(Environment.CurrentDirectory + @"\Resources\icon_done.png"), ToastGenericAppLogoCrop.Circle)
                    .Show();
                }
                else
                {

                    string title = "转换完成";
                    string[] headMessage = { String.Format("{0}个文件转换完成，{1}个成功，{2}个失败。", Convert.ToString(listView1.Items.Count), successed, listView1.Items.Count - successed) };
                    string[] fullMessage = new string[headMessage.Length + logArray.Length];
                    headMessage.CopyTo(fullMessage, 0);
                    logArray.CopyTo(fullMessage, headMessage.Length);
                    if (logCount > 0)
                    {
                        new MessageWindow(appSettings, title, fullMessage, MessageWindow.MessageType.Error).ShowDialog();
                    }
                    else
                    {
                        new MessageWindow(appSettings, title, fullMessage, MessageWindow.MessageType.Done).ShowDialog();
                    }
                }
                //设置转换后的界面
                LabelTitle.Text = Application.ProductName;
                Text = LabelTitle.Text;
                BtnClose.Enabled = true;
                ButtonAddFile.Enabled = true;
                BtnConvert.Enabled = true;
                BtnConvert.Visible = true;
                btnClearList.Enabled = true;
                comBoxTargetFormat.Enabled = true;
                comboBoxOutputDirectory.Enabled = true;
                btnBrowseOutputFolder.Enabled = true;
                TaskbarManager.SetProgressState(TaskbarProgressBarState.NoProgress);
                SetProgressbarProgress(0);

                if (appSettings.IsOpenOutputDir)
                {
                    Process.Start("explorer.exe", comboBoxOutputDirectory.Text);
                }
            }
        }

        public MainWindow(AppSettings appSettingsFromFile)
        {
            InitializeComponent();
            //SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            appSettings = appSettingsFromFile;
        }

        private AppSettings InitAppSettings(AppSettings appSettings)
        {
            if (appSettings.LastTargetFormat == null)
            {
                appSettings.LastTargetFormat = "X Studio 1.8(SVIP 6.0.0)";
            }
            if (appSettings.OpenSvipPath == null)
            {
                appSettings.OpenSvipPath = Environment.CurrentDirectory + "\\OpenSvip.Console.exe";
            }
            return appSettings;
        }

        //private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        //{
        //    if (e.Category == UserPreferenceCategory.Window)
        //    {
        //        if (ThemeUtils.IsDarkMode())
        //        {
        //            SwitchToDarkMode();
        //        }
        //    }
        //}

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (ThemeUtils.IsDarkMode())
            {
                SwitchToDarkMode();
            }
            BtnConvert = ThemeUtils.GetAccentButton(BtnConvert, appSettings);
            ProgressbarForeground.BackColor = ThemeUtils.AccentColor(appSettings.Theme);
            Opacity = 0;
            Size size = Screen.PrimaryScreen.WorkingArea.Size;
            Left = (size.Width - Width) / 2;
            Top = (size.Height - Height) / 2;
            Point pointBtnCloseLocation = new Point(Width - BtnClose.Width, 0);
            BtnClose.Location = pointBtnCloseLocation;
            Point pointBtnMinimizeLocation = new Point(Width - BtnMinimize.Width * 2, 0);
            BtnMinimize.Location = pointBtnMinimizeLocation;
            WindowState = FormWindowState.Normal;
            InitListView();
            comboBoxOutputDirectory.Text = Environment.CurrentDirectory;//设置输出目录的初始值为程序所在位置
            try
            {
                comBoxTargetFormat.SelectedIndex = comBoxTargetFormat.Items.IndexOf(appSettings.LastTargetFormat);
            }
            catch (Exception)
            {
                comBoxTargetFormat.SelectedIndex = comBoxTargetFormat.Items.IndexOf("X Studio 1.8(SVIP 6.0.0)");//设置目标版本下拉菜单默认值
            }
            try
            {
                if (appSettings.HistoryOutputDir != null)
                {
                    foreach (var path in appSettings.HistoryOutputDir)
                    {
                        comboBoxOutputDirectory.Items.Add(path);
                        comboBoxOutputDirectory.Text = comboBoxOutputDirectory.Items[0].ToString();
                    }
                }
            }
            catch (Exception)
            {
                //comboBoxOutputDirectory.Text = @"C:\Temp";
            }
            pictureBoxTitleIcon.Image = Properties.Resources.icon_large;
            SetProgressbarProgress(0);
            Thread nothread = new Thread(new ThreadStart(ToastBackground));
            nothread.Start();
        }
        private Tuple<bool, string> ConvertSvipFile(string targetVersion, string sourceFilePath, string outputPath)
        {
            try
            {
                string fileName = Path.GetFileName(sourceFilePath);
                File.Copy(sourceFilePath, outputPath + @"\" + fileName, true);
                FileStream fileStream = new FileStream(outputPath + @"\" + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                byte[] fileHead = new byte[] { 0x04, 0x53, 0x56, 0x49, 0x50, 0x05 };//svip文件头
                byte[] targetVersionBytes = Encoding.UTF8.GetBytes(targetVersion);
                byte[] bytes = new byte[fileHead.Length + targetVersionBytes.Length];
                fileHead.CopyTo(bytes, 0);
                targetVersionBytes.CopyTo(bytes, fileHead.Length);
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.Flush();
                fileStream.Close();
                Tuple<bool, string> result = new Tuple<bool, string>(true, "");
                return result;
            }
            catch (Exception ex)
            {
                Tuple<bool, string> result = new Tuple<bool, string>(false, ex.Message);
                return result;
            }
        }

        private Tuple<bool, string> ConvertProjectFile(string inputIdentifier, string outputIdentifier, string sourceFilePath, string outputPath)
        {
            try
            {
                string fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
                if (inputIdentifier == "")
                {
                    inputIdentifier = Path.GetExtension(sourceFilePath).Replace(".", "");
                }
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                string strCMD = string.Format(appSettings.OpenSvipPath + " -i {0} \"{1}\" -o {2} \"{3}\\{4}.{5}\" {6} {7}", inputIdentifier, sourceFilePath, outputIdentifier, outputPath, fileName, outputIdentifier, GetInputOptions(), GetOutputOptions());
                string[] msg = { strCMD };
                if (appSettings.IsShowCommandBeforeConverting)
                {
                    new MessageWindow(appSettings, "执行命令", msg, MessageWindow.MessageType.Info).ShowDialog();
                }
                p.StandardInput.WriteLine(strCMD + "&exit");
                p.StandardInput.AutoFlush = true;
                string strOuput = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                p.Close();
                Tuple<bool, string> result = new Tuple<bool, string>(true, strOuput);
                return result;
            }
            catch (Exception ex)
            {
                Tuple<bool, string> result = new Tuple<bool, string>(false, ex.Message);
                return result;
            }
        }

        private string GetInputOptions()
        {
            if (inputOptions != null && inputOptions != "")
            {
                return "--input-options " + inputOptions;
            }
            else
            {
                return "";
            }
        }

        private string GetOutputOptions()
        {
            if (outputOptions != null && outputOptions != "")
            {
                return "--output-options " + outputOptions;
            }
            else
            {
                return "";
            }
        }

        private string GetTargetVersion(string dropdownItem)
        {
            //根据下拉菜单的值返回目标版本号
            switch (dropdownItem)
            {
                case "X Studio 1.8.1(SVIP 6.0.0)":
                    return "6.0.0";
                case "X Studio 2.0.x(SVIP 7.0.0)":
                    return "7.0.0";
                default: return "6.0.0";
            }
        }

        private void ConvertFile()
        {
            int successedCount = 0;
            int progress = 0;
            List<string> log = new List<string>();
            for (int i = 0; (i < listView1.Items.Count); i++)
            {
                SetListViewItemText(i, "正在转换");
                string path = pathList[i];
                Tuple<bool, string> result;
                switch (targetFormat)
                {
                    case "X Studio 1.8(SVIP 6.0.0)":
                        if (Path.GetExtension(path) != ".svip")
                        {
                            inputOptions = "version=6.0.0";
                            result = ConvertProjectFile("", "svip", path, outputPath);
                        }
                        else
                        {
                            result = ConvertSvipFile(GetTargetVersion(targetFormat), path, outputPath);
                        }
                        break;
                    case "X Studio 2.0(SVIP 7.0.0)":
                        if (Path.GetExtension(path) != ".svip")
                        {
                            result = ConvertProjectFile("", "svip", path, outputPath);
                        }
                        else
                        {
                            result = ConvertSvipFile(GetTargetVersion(targetFormat), path, outputPath);
                        }
                        break;
                    case "Synthesizer V":
                        result = ConvertProjectFile("", "svp", path, outputPath);
                        break;
                    case "歌叽歌叽":
                        result = ConvertProjectFile("", "gj", path, outputPath);
                        break;
                    case "自定义":
                        result = ConvertProjectFile(appSettings.Identifier.InputIdentifier, appSettings.Identifier.OutputIdentifier, path, outputPath);
                        break;
                    default:
                        result = ConvertSvipFile(GetTargetVersion(targetFormat), path, outputPath);
                        break;
                }
                if (result.Item1)
                {
                    SetListViewItemText(i, "成功");
                    successedCount++;
                }
                else
                {
                    SetListViewItemText(i, "失败");
                    log.Add((i + 1).ToString() + Path.GetFileName(path) + "转换失败，因为" + result.Item2 + "\n");
                }
                progress = (i + 1) * 100 / listView1.Items.Count;
                SetConvertingProgress(i, progress, "");
            }
            string[] logArray = new string[log.Count];
            for (int index = 0; index < log.Count; index++)
            {
                logArray[index] = log[index];
            }
            ShowConvertDoneWindow("", listView1.Items.Count, successedCount, logArray, log.Count);
        }

        //用户界面处理

        private void SwitchToDarkMode()
        {
            LabelTitle = ThemeUtils.GetDarkLabel(LabelTitle);

            BtnMinimize = ThemeUtils.GetDarkTitleCommonButton(BtnMinimize);

            BtnClose = ThemeUtils.GetDarkTitleCloseButton(BtnClose);

            ButtonAddFile = ThemeUtils.GetDarkButton(ButtonAddFile);

            labelTips = ThemeUtils.GetDarkLabel(labelTips);

            listView1 = ThemeUtils.GetDarkListView(listView1);

            LbListEmpityHint.BackColor = Color.FromArgb(30, 30, 30);

            btnInvertSelection = ThemeUtils.GetDarkButton(btnInvertSelection);

            btnClearSelectedItem = ThemeUtils.GetDarkButton(btnClearSelectedItem);

            btnClearList = ThemeUtils.GetDarkButton(btnClearList);
            
            labelTargetFormat = ThemeUtils.GetDarkLabel(labelTargetFormat);

            comBoxTargetFormat = ThemeUtils.GetDarkComboBox(comBoxTargetFormat);

            buttonAdvancedOptions = ThemeUtils.GetDarkButton(buttonAdvancedOptions);

            labelOutputPath = ThemeUtils.GetDarkLabel(labelOutputPath);

            comboBoxOutputDirectory = ThemeUtils.GetDarkComboBox(comboBoxOutputDirectory);

            btnBrowseOutputFolder = ThemeUtils.GetDarkButton(btnBrowseOutputFolder);

            btnAbout = ThemeUtils.GetDarkButton(btnAbout);

            btnOptions = ThemeUtils.GetDarkButton(btnOptions);

            btnOpenOutputFolder = ThemeUtils.GetDarkButton(btnOpenOutputFolder);

            BtnConvert = ThemeUtils.GetAccentButton(BtnConvert, appSettings);

            ProgressbarBackground.BackColor = ThemeUtils.CommonDarkBackColor();
            ProgressbarForeground.BackColor = ThemeUtils.AccentColor(appSettings.Theme);
        }

        private void ToastBackground()
        {
            // Listen to notification activation
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                // Obtain the arguments from the notification
                ToastArguments args = ToastArguments.Parse(toastArgs.Argument);

                // Obtain any user input (text boxes, menu selections) from the notification
                ValueSet userInput = toastArgs.UserInput;

                switch (toastArgs.Argument)
                {
                    case "action=openOutputPath":
                        Process.Start("explorer.exe", @"C:\Temp");
                        break;
                    case "action=ok":
                        
                        break;
                    default:
                        break;
                }
            };
        }

        private void InitListView()
        {
            //设置表头
            ColumnHeader ch1 = new ColumnHeader
            {
                Text = "序号",
                Width = (int)(listView1.Width * 0.1),
                TextAlign = HorizontalAlignment.Left,
            };
            listView1.Columns.Add(ch1);
            listView1.BeginUpdate();
            ColumnHeader ch2 = new ColumnHeader
            {
                Text = "文件路径",
                Width = (int)(listView1.Width * 0.7),
                TextAlign = HorizontalAlignment.Left
            };
            listView1.Columns.Add(ch2);
            listView1.EndUpdate();
            ColumnHeader ch3 = new ColumnHeader
            {
                Text = "状态",
                Width = listView1.Width - ch1.Width - ch2.Width,
                TextAlign = HorizontalAlignment.Left,
            };
            listView1.Columns.Add(ch3);
            listView1.EndUpdate();
        }

        private void SetProgressbarProgress(int progressInPercentage)
        {
            timerForProgressbar.Enabled = true;
            ProgressbarForeground.Width = progressInPercentage * ProgressbarBackground.Width / 100;
            TaskbarManager.SetProgressValue(progressInPercentage, 100);
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            new AboutWindow(appSettings).ShowDialog();
        }

        private void BtnOpenOutputFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxOutputDirectory.Text))
            {
                ShowEmptyOutputFolderWarningWindow();
                return;
            }
            Process.Start("explorer.exe", comboBoxOutputDirectory.Text);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
            ToastNotificationManagerCompat.Uninstall();
            Environment.Exit(0);
        }

        private void Label_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x0112, 0xF012, 0);
        }

        private void ShowEmptyOutputFolderWarningWindow()
        {
            string title = "提示";
            string[] msg = { "输出目录不能为空" };
            new MessageWindow(appSettings, title, msg, MessageWindow.MessageType.Warning).ShowDialog();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush b = new LinearGradientBrush(ClientRectangle, ThemeUtils.ThemeWindowBackgroundColor(appSettings.Theme).Item1, ThemeUtils.ThemeWindowBackgroundColor(appSettings.Theme).Item2, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, ClientRectangle);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            using (OptionsWindow optionsWindow = new OptionsWindow(appSettings))
            {
                if (optionsWindow.ShowDialog() == DialogResult.OK)
                {
                    appSettings.OpenSvipPath = optionsWindow.openSvipPath;
                    appSettings.Theme = optionsWindow.theme;
                    appSettings.DoneMessageAppearance = optionsWindow.doneMessageAppearance;
                    appSettings.IsOpenOutputDir = optionsWindow.isOpenOutputDir;
                    appSettings.IsShowCommandBeforeConverting = optionsWindow.isShowCommandBeforeConverting;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity >= 1)
            {
                timer1.Enabled = false;
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxOutputDirectory.Text))
            {
                ShowEmptyOutputFolderWarningWindow();
                return;
            }
            if (listView1.Items.Count != 0)
            {
                //写入界面的配置
                appSettings.LastTargetFormat = comBoxTargetFormat.Text;
                if (appSettings.HistoryOutputDir == null)
                {
                    appSettings.HistoryOutputDir = new List<string>();
                    appSettings.HistoryOutputDir.Add(comboBoxOutputDirectory.Text);
                }
                else if (!appSettings.HistoryOutputDir.Contains(comboBoxOutputDirectory.Text))
                {
                    appSettings.HistoryOutputDir.Add(comboBoxOutputDirectory.Text);
                }

                //设置转换时的界面
                LabelTitle.Text = "正在转换文件，已完成0%";
                Text = "0%";
                BtnClose.Enabled = false;
                ButtonAddFile.Enabled = false;
                BtnConvert.Enabled = false;
                BtnConvert.Visible = false;
                btnClearList.Enabled = false;
                comBoxTargetFormat.Enabled = false;
                comboBoxOutputDirectory.Enabled = false;
                btnBrowseOutputFolder.Enabled = false;
                TaskbarManager.SetProgressState(TaskbarProgressBarState.Normal);
                SetProgressbarProgress(0);

                //依次读出列表子项目（文件路径）并转换
                outputPath = comboBoxOutputDirectory.Text;
                targetFormat = comBoxTargetFormat.Text;
                for (int i = 0; (i < listView1.Items.Count); i++)
                {
                    ListViewItem item = listView1.Items[i];
                    pathList.Add(item.SubItems[1].Text);
                }
                Thread fThread = new Thread(new ThreadStart(ConvertFile));
                fThread.Start();
            }
            else
            {
                string title = "提示";
                string[] msg = { "请先添加文件。" };
                new MessageWindow(appSettings, title, msg, MessageWindow.MessageType.Warning).ShowDialog();
            }
        }

        private void ButtonBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "请选择输出位置"
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                comboBoxOutputDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                //Filter = "所有支持的工程文件(*.svip;*.svp;*.gj)|*.svip;*.svp;*.gj|X Studio工程文件(*.svip)|*.svip|Synthesizer V工程文件(*.svp)|*.svp|歌叽歌叽工程文件(*.gj)|*.gj",
                Filter = "X Studio工程文件(*.svip)|*.svip",
                Title = "请选择工程文件"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //选好后将所有文件依次加入列表
                LbListEmpityHint.Visible = false;
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    ListViewItem lvi = new ListViewItem
                    {
                        Text = Convert.ToString(currentIndex),
                        BackColor = GetListViewItemBackColor(),
                        ForeColor = GetGetListViewItemForeColor(),
                    };
                    currentIndex++;
                    lvi.SubItems.Add(ofd.FileNames[i]);
                    lvi.SubItems.Add("未转换");
                    listView1.Items.Add(lvi);
                }
            }
        }

        private Color GetListViewItemBackColor()
        {
            if (ThemeUtils.IsDarkMode())
            {
                return Color.FromArgb(30, 30, 30);
            }
            else
            {
                return Color.FromArgb(251, 251, 251);
            }
        }

        private Color GetGetListViewItemForeColor()
        {
            if (ThemeUtils.IsDarkMode())
            {
                return Color.White;
            }
            else
            {
                return Color.Black;
            }
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            //清空列表并复位序号
            listView1.Items.Clear();
            currentIndex = 1;
            LbListEmpityHint.Visible = true;
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            StringFormat sf = new StringFormat();
            Font headerFont = new Font("微软雅黑", 10.8f, FontStyle.Regular);
            sf.Alignment = StringAlignment.Near;
            if (ThemeUtils.IsDarkMode())
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0)), e.Bounds);
                e.Graphics.DrawString(e.Header.Text, headerFont, new SolidBrush(Color.FromArgb(225, 225, 225)), e.Bounds, sf);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), e.Bounds);
                e.Graphics.DrawString(e.Header.Text, headerFont, new SolidBrush(Color.FromArgb(30, 30, 30)), e.Bounds, sf);
            }
            //e.DrawText();
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in listView1.Items)
                {
                    if (ThemeUtils.IsDarkMode())
                    {
                        lvi.ForeColor = ThemeUtils.DarkForeColor();
                        lvi.BackColor = Color.FromArgb(30, 30, 30);
                    }
                    else
                    {
                        lvi.ForeColor = ThemeUtils.LightForeColor();
                        lvi.BackColor = ThemeUtils.CommonLightBackColor();
                    }
                }
                //修改选中项颜色
                listView1.SelectedItems[0].SubItems[0].ForeColor = ThemeUtils.HighlightedListViewItemForeColor();
                listView1.SelectedItems[0].SubItems[0].BackColor = ThemeUtils.HighlightedListViewItemBackColor(appSettings.Theme);
                //去掉选中项背景
                listView1.SelectedItems[0].Selected = false;
            }
        }

        private void btnClearSelectedItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                if (lvi.Checked)
                {
                    //lvi.Remove();
                    listView1.Items.Remove(lvi);
                }
            }
            currentIndex = 1;
            foreach (ListViewItem lvi in listView1.Items)
            {
                lvi.Text = Convert.ToString(currentIndex);
                currentIndex++;
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }

        private void cbTargetVersion_DrawItem(object sender, DrawItemEventArgs e)
        {
            //// Draw the background
            ////e.DrawBackground();
            //e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(251, 251, 251)), e.Bounds);
            //// Get the item text
            //string text = ((ComboBox)sender).Items[e.Index].ToString();
            //// Determine the forecolor based on whether or not the item is selected
            //Brush brush;
            //brush = Brushes.Red;
            //// Draw the text
            //e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        }

        private void buttonAdvancedOptions_Click(object sender, EventArgs e)
        {
            using (AdvancedOptionsWindow advancedOptionsWindow = new AdvancedOptionsWindow(appSettings, inputOptions, outputOptions))
            {
                if (advancedOptionsWindow.ShowDialog() == DialogResult.OK)
                {
                    inputOptions = advancedOptionsWindow.inputOptions;
                    outputOptions = advancedOptionsWindow.outputOptions;
                }
            }
        }

        private void btnInvertSelection_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                foreach (ListViewItem lvi in listView1.Items)
                {
                    lvi.Checked = !lvi.Checked;
                }
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            HandleDragEnter(e);
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            AddDragFileToList(sender, e);
        }

        private void AddDragFileToList(object sender, DragEventArgs e)
        {
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (File.Exists(file) && Path.GetExtension(file).ToLower() == ".svip")
                {
                    ListViewItem lvi = new ListViewItem(Convert.ToString(currentIndex));
                    lvi.SubItems.Add(Path.GetFullPath(file));
                    lvi.SubItems.Add("未转换");
                    listView1.Items.Add(lvi);
                    currentIndex++;
                }
            }
            LbListEmpityHint.Visible = false;
        }

        private void LbListEmpityHint_DragEnter(object sender, DragEventArgs e)
        {
            HandleDragEnter(e);
        }
        
        private void HandleDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LbListEmpityHint_DragDrop(object sender, DragEventArgs e)
        {
            AddDragFileToList(sender, e);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var stream = new FileStream(Environment.CurrentDirectory + "\\appSettings.json", FileMode.Create, FileAccess.Write);
            var writer = new StreamWriter(stream, Encoding.UTF8);
            var jsonString = JsonConvert.SerializeObject(appSettings);
            foreach (var ch in jsonString)
            {
                writer.Write(ch);
            }
            writer.Flush();
            stream.Flush();
            writer.Close();
            stream.Close();
        }

        private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            //选择输出路径
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "请选择输出路径",
                ShowNewFolderButton = true
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                comboBoxOutputDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
