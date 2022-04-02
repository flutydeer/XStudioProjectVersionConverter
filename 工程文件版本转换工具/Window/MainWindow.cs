using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace 工程文件版本转换工具
{
    public partial class MainWindow : MyForm
    {
        int currentIndex = 1;

        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            InitListView();
            cbTargetVersion.SelectedIndex = cbTargetVersion.Items.IndexOf("X Studio 1.8.1(SVIP 6.0.0)");//设置目标版本下拉菜单默认值
            tbOutputPath.Text = Environment.CurrentDirectory;//设置输出目录的初始值为程序所在位置
        }

        private void InitListView()
        {
            //设置表头
            ColumnHeader ch = new ColumnHeader
            {
                Text = "序号",
                Width = 60,
                TextAlign = HorizontalAlignment.Left
            };
            listView1.Columns.Add(ch);
            listView1.BeginUpdate();
            ColumnHeader ch2 = new ColumnHeader
            {
                Text = "文件路径",
                Width = 500,
                TextAlign = HorizontalAlignment.Left
            };
            listView1.Columns.Add(ch2);
            listView1.EndUpdate();
            ColumnHeader ch3 = new ColumnHeader
            {
                Text = "状态",
                Width = 80,
                TextAlign = HorizontalAlignment.Left,
            };
            listView1.Columns.Add(ch3);
            listView1.EndUpdate();
        }

        private void ButtonBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "请选择输出位置"
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbOutputPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "X Studio工程文件(*.svip)|*.svip",
                Title = "请选择svip文件"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //选好后将所有文件依次加入列表
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    ListViewItem lvi = new ListViewItem
                    {
                        Text = Convert.ToString(currentIndex)
                    };
                    currentIndex++;
                    lvi.SubItems.Add(ofd.FileNames[i]);
                    lvi.SubItems.Add("未转换");
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            //清空列表并复位序号
            listView1.Items.Clear();
            currentIndex = 1;
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

        private string GetTargetVersion(string dropdownItem)
        {
            //根据下拉菜单的值返回目标版本号
            switch (dropdownItem)
            {
                case "X Studio 1.8.1(SVIP 6.0.0)":
                    return "6.0.0";
                default: return "6.0.0";
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOutputPath.Text))
            {
                PopupEmptyOutputFolderWarnedWindow();
                return;
            }
            if (listView1.Items.Count != 0)
            {
                //依次读出列表子项目（文件路径）并转换
                int successedCount = 0;
                List<string> log = new List<string>();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    ListViewItem item = listView1.Items[i];
                    string path = item.SubItems[1].Text;
                    item.SubItems[2].Text = "已转换";
                    Tuple<bool, string> result = ConvertSvipFile(GetTargetVersion(cbTargetVersion.Text), path, tbOutputPath.Text);
                    if (result.Item1)
                    {
                        item.SubItems[2].Text = "成功";
                        //log.Add((i + 1).ToString() + "【成功】" + Path.GetFileName(path) + "\n");
                        successedCount++;
                    }
                    else
                    {
                        item.SubItems[2].Text = "失败";
                        log.Add((i + 1).ToString() + "【失败】" + Path.GetFileName(path) + "因为" + result.Item2 + "\n");
                    }
                }
                string[] logArray = new string[log.Count];
                for (int index = 0; index < log.Count; index++)
                {
                    logArray[index] = log[index];
                }
                string title = "转换完成";
                string[] headMessage = { String.Format("{0}个文件转换完成，{1}个成功，{2}个失败。", Convert.ToString(listView1.Items.Count), successedCount, listView1.Items.Count - successedCount) };
                string[] fullMessage = new string[headMessage.Length + logArray.Length];
                headMessage.CopyTo(fullMessage, 0);
                logArray.CopyTo(fullMessage, headMessage.Length);
                if (log.Count > 0)
                {
                    new MessageWindow(title, fullMessage, 3).ShowDialog();
                }
                else
                {
                    new MessageWindow(title, fullMessage, 1).ShowDialog();
                }
                
                if (checkBox1.Checked)
                {
                    System.Diagnostics.Process.Start("explorer.exe", tbOutputPath.Text);
                }
            }
            else
            {
                string title = "提示";
                string[] msg = { "请先添加文件。" };
                new MessageWindow(title, msg, 2).ShowDialog();
            }
        }


        private void BtnAbout_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void BtnOpenOutputFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOutputPath.Text))
            {
                PopupEmptyOutputFolderWarnedWindow();
                return;
            }
            System.Diagnostics.Process.Start("explorer.exe", tbOutputPath.Text);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Label_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x0112, 0xF012, 0);
        }

        private static void PopupEmptyOutputFolderWarnedWindow()
        {
            string title = "提示";
            string[] msg = { "输出目录不能为空" };
            new MessageWindow(title, msg, 2).ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClearMemory();
        }
    }
}
