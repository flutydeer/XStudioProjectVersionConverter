using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 工程文件版本转换工具
{
    public partial class Form1 : Form
    {
        int currentIndex = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //设置表头
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "序号";  
            ch.Width = 60;   
            ch.TextAlign = HorizontalAlignment.Left;  
            this.listView1.Columns.Add(ch);   
            this.listView1.BeginUpdate();  
            ColumnHeader ch2 = new ColumnHeader();
            ch2.Text = "文件路径";  
            ch2.Width = 520;   
            ch2.TextAlign = HorizontalAlignment.Left;  
            this.listView1.Columns.Add(ch2);   
            this.listView1.EndUpdate(); 
            ColumnHeader ch3 = new ColumnHeader();
            ch3.Text = "状态";  
            ch3.Width = 80;   
            ch3.TextAlign = HorizontalAlignment.Left;  
            this.listView1.Columns.Add(ch3);   
            this.listView1.EndUpdate(); 
            
            cbTargetVersion.SelectedIndex = cbTargetVersion.Items.IndexOf("X Studio 1.8.1(SVIP 6.0.0)");//设置目标版本下拉菜单默认值
            tbOutputPath.Text = System.Environment.CurrentDirectory;//设置输出目录的初始值为程序所在位置
        }

        private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择输出位置";
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if(string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                {
                    MessageBox.Show("不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                tbOutputPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "X Studio工程文件(*.svip)|*.svip";
            ofd.Title = "请选择svip文件";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //选好后将所有文件依次加入列表
                for(int i = 0; i < ofd.FileNames.Length; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = Convert.ToString(currentIndex);
                    currentIndex++;
                    lvi.SubItems.Add(ofd.FileNames[i]);
                    lvi.SubItems.Add("未转换");
                    this.listView1.Items.Add(lvi);
                }
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            //清空列表并复位序号
            this.listView1.Items.Clear();
            currentIndex = 1;
        }

        private void convertSvipFile(string targetVersion, string sourceFilePath, string outputPath)
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
            }
            catch (Exception ex)
            {
                string title = "X Studio工程文件版本转换工具";
                string msg = "应用出现异常：" + ex.Message;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(msg, title, buttons, MessageBoxIcon.Error);
            }
        }

        private string getTargetVersion(string dropdownItem)
        {
            //根据下拉菜单的值返回目标版本号
            switch(dropdownItem)
            {
                case "X Studio 1.8.1(SVIP 6.0.0)":
                    return "6.0.0";
                    break;
                default: return "6.0.0";
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count != 0)
            {
                //btnConvert.Text = "正在转换...";
                //progressBar.Value = 0;
                //依次读出列表子项目（文件路径）并转换
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    ListViewItem item = listView1.Items[i];
                    string path = item.SubItems[1].Text;
                    convertSvipFile(getTargetVersion(cbTargetVersion.Text), path, tbOutputPath.Text);
                    item.SubItems[2].Text = "已转换";
                    //progressBar.Value = (i + 1) / listView1.Items.Count * 100;
                }
                //progressBar.Value = 100;
                //btnConvert.Text = "开始转换";
                string title = "提示";
                string msg = "%s个文件转换完成！\n".Replace("%s", Convert.ToString(listView1.Items.Count));
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(msg, title, buttons, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("explorer.exe", tbOutputPath.Text);
            }
            else
            {
                string title = "提示";
                string msg = "请先添加文件。";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(msg, title, buttons, MessageBoxIcon.Warning);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            string title = "关于";
            string msg = "X Studio工程文件版本转换工具 v1.0.0\n开发者：笛鹿FlutyDeer";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(msg, title, buttons, MessageBoxIcon.Information);
        }

        private void btnOpenOutputFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", tbOutputPath.Text);
        }

        private void btnVisitHomepage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://space.bilibili.com/386270936");
        }
    }
}
