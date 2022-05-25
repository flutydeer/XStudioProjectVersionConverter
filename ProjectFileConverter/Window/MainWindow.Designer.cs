namespace ProjectFileConverter
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.listView1 = new System.Windows.Forms.ListView();
            this.LbListEmpityHint = new System.Windows.Forms.Label();
            this.btnInvertSelection = new System.Windows.Forms.Button();
            this.btnClearSelectedItem = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.ProgressbarBackground = new System.Windows.Forms.Panel();
            this.ProgressbarForeground = new System.Windows.Forms.Panel();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.ButtonAddFile = new System.Windows.Forms.Button();
            this.btnOpenOutputFolder = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.timerForProgressbar = new System.Windows.Forms.Timer(this.components);
            this.btnOptions = new System.Windows.Forms.Button();
            this.pictureBoxTitleIcon = new System.Windows.Forms.PictureBox();
            this.labelTips = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonAdvancedOptions = new System.Windows.Forms.Button();
            this.comboBoxOutputDirectory = new System.Windows.Forms.ComboBox();
            this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
            this.labelOutputPath = new System.Windows.Forms.Label();
            this.labelTargetFormat = new System.Windows.Forms.Label();
            this.comBoxTargetFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressbarBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(12, 98);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(650, 279);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // LbListEmpityHint
            // 
            this.LbListEmpityHint.AllowDrop = true;
            this.LbListEmpityHint.AutoSize = true;
            this.LbListEmpityHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.LbListEmpityHint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbListEmpityHint.ForeColor = System.Drawing.Color.DarkGray;
            this.LbListEmpityHint.Location = new System.Drawing.Point(162, 224);
            this.LbListEmpityHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbListEmpityHint.Name = "LbListEmpityHint";
            this.LbListEmpityHint.Size = new System.Drawing.Size(374, 27);
            this.LbListEmpityHint.TabIndex = 26;
            this.LbListEmpityHint.Text = "列表空空如也，快来添加文件叭( •̀ ω •́ )✧";
            this.LbListEmpityHint.DragDrop += new System.Windows.Forms.DragEventHandler(this.LbListEmpityHint_DragDrop);
            this.LbListEmpityHint.DragEnter += new System.Windows.Forms.DragEventHandler(this.LbListEmpityHint_DragEnter);
            // 
            // btnInvertSelection
            // 
            this.btnInvertSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnInvertSelection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInvertSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInvertSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnInvertSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvertSelection.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInvertSelection.Location = new System.Drawing.Point(271, 383);
            this.btnInvertSelection.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInvertSelection.Name = "btnInvertSelection";
            this.btnInvertSelection.Size = new System.Drawing.Size(127, 41);
            this.btnInvertSelection.TabIndex = 6;
            this.btnInvertSelection.Text = "反向选择";
            this.btnInvertSelection.UseVisualStyleBackColor = false;
            this.btnInvertSelection.Click += new System.EventHandler(this.btnInvertSelection_Click);
            // 
            // btnClearSelectedItem
            // 
            this.btnClearSelectedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnClearSelectedItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearSelectedItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearSelectedItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnClearSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSelectedItem.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearSelectedItem.Location = new System.Drawing.Point(402, 383);
            this.btnClearSelectedItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClearSelectedItem.Name = "btnClearSelectedItem";
            this.btnClearSelectedItem.Size = new System.Drawing.Size(127, 41);
            this.btnClearSelectedItem.TabIndex = 7;
            this.btnClearSelectedItem.Text = "移除已选";
            this.btnClearSelectedItem.UseVisualStyleBackColor = false;
            this.btnClearSelectedItem.Click += new System.EventHandler(this.btnClearSelectedItem_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnClearList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearList.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearList.Location = new System.Drawing.Point(533, 383);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(128, 41);
            this.btnClearList.TabIndex = 8;
            this.btnClearList.Text = "清空列表";
            this.btnClearList.UseVisualStyleBackColor = false;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // ProgressbarBackground
            // 
            this.ProgressbarBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ProgressbarBackground.Controls.Add(this.ProgressbarForeground);
            this.ProgressbarBackground.Controls.Add(this.BtnConvert);
            this.ProgressbarBackground.Location = new System.Drawing.Point(528, 527);
            this.ProgressbarBackground.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProgressbarBackground.Name = "ProgressbarBackground";
            this.ProgressbarBackground.Size = new System.Drawing.Size(133, 50);
            this.ProgressbarBackground.TabIndex = 3;
            // 
            // ProgressbarForeground
            // 
            this.ProgressbarForeground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(224)))));
            this.ProgressbarForeground.Location = new System.Drawing.Point(0, 0);
            this.ProgressbarForeground.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressbarForeground.Name = "ProgressbarForeground";
            this.ProgressbarForeground.Size = new System.Drawing.Size(20, 50);
            this.ProgressbarForeground.TabIndex = 0;
            // 
            // BtnConvert
            // 
            this.BtnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(224)))));
            this.BtnConvert.FlatAppearance.BorderSize = 0;
            this.BtnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConvert.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConvert.ForeColor = System.Drawing.Color.White;
            this.BtnConvert.Location = new System.Drawing.Point(0, 0);
            this.BtnConvert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(133, 50);
            this.BtnConvert.TabIndex = 16;
            this.BtnConvert.Text = "开始转换";
            this.BtnConvert.UseVisualStyleBackColor = false;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // ButtonAddFile
            // 
            this.ButtonAddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ButtonAddFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ButtonAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddFile.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonAddFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ButtonAddFile.Location = new System.Drawing.Point(12, 51);
            this.ButtonAddFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonAddFile.Name = "ButtonAddFile";
            this.ButtonAddFile.Size = new System.Drawing.Size(142, 41);
            this.ButtonAddFile.TabIndex = 3;
            this.ButtonAddFile.Text = "添加文件...";
            this.ButtonAddFile.UseVisualStyleBackColor = false;
            this.ButtonAddFile.Click += new System.EventHandler(this.ButtonAddFile_Click);
            // 
            // btnOpenOutputFolder
            // 
            this.btnOpenOutputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnOpenOutputFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpenOutputFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpenOutputFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnOpenOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenOutputFolder.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenOutputFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnOpenOutputFolder.Location = new System.Drawing.Point(369, 527);
            this.btnOpenOutputFolder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOpenOutputFolder.Name = "btnOpenOutputFolder";
            this.btnOpenOutputFolder.Size = new System.Drawing.Size(152, 50);
            this.btnOpenOutputFolder.TabIndex = 15;
            this.btnOpenOutputFolder.Text = "打开输出目录...";
            this.btnOpenOutputFolder.UseVisualStyleBackColor = false;
            this.btnOpenOutputFolder.Click += new System.EventHandler(this.BtnOpenOutputFolder_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAbout.Location = new System.Drawing.Point(12, 526);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(82, 50);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "关于...";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LabelTitle.Location = new System.Drawing.Point(47, 10);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(256, 27);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "SVIP工程文件版本转换工具";
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseDown);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.AccessibleDescription = "";
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnMinimize.Location = new System.Drawing.Point(552, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(60, 48);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.Text = "–";
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(35)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(34)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnClose.Location = new System.Drawing.Point(612, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(60, 48);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "✕";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // timerForProgressbar
            // 
            this.timerForProgressbar.Interval = 50;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnOptions.Location = new System.Drawing.Point(98, 526);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(82, 50);
            this.btnOptions.TabIndex = 14;
            this.btnOptions.Text = "选项...";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // pictureBoxTitleIcon
            // 
            this.pictureBoxTitleIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitleIcon.Location = new System.Drawing.Point(12, 7);
            this.pictureBoxTitleIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxTitleIcon.Name = "pictureBoxTitleIcon";
            this.pictureBoxTitleIcon.Size = new System.Drawing.Size(30, 32);
            this.pictureBoxTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitleIcon.TabIndex = 25;
            this.pictureBoxTitleIcon.TabStop = false;
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.BackColor = System.Drawing.Color.Transparent;
            this.labelTips.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.labelTips.Location = new System.Drawing.Point(159, 59);
            this.labelTips.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(406, 24);
            this.labelTips.TabIndex = 4;
            this.labelTips.Text = "不保证转换后的文件能被相应的软件读取或保存。";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonAdvancedOptions
            // 
            this.buttonAdvancedOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonAdvancedOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdvancedOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdvancedOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonAdvancedOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdvancedOptions.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAdvancedOptions.Location = new System.Drawing.Point(350, 451);
            this.buttonAdvancedOptions.Margin = new System.Windows.Forms.Padding(2, 0, 0, 3);
            this.buttonAdvancedOptions.Name = "buttonAdvancedOptions";
            this.buttonAdvancedOptions.Size = new System.Drawing.Size(122, 32);
            this.buttonAdvancedOptions.TabIndex = 30;
            this.buttonAdvancedOptions.Text = "高级选项...";
            this.buttonAdvancedOptions.UseVisualStyleBackColor = false;
            this.buttonAdvancedOptions.Visible = false;
            this.buttonAdvancedOptions.Click += new System.EventHandler(this.buttonAdvancedOptions_Click);
            // 
            // comboBoxOutputDirectory
            // 
            this.comboBoxOutputDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.comboBoxOutputDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOutputDirectory.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxOutputDirectory.FormattingEnabled = true;
            this.comboBoxOutputDirectory.IntegralHeight = false;
            this.comboBoxOutputDirectory.ItemHeight = 24;
            this.comboBoxOutputDirectory.Location = new System.Drawing.Point(98, 488);
            this.comboBoxOutputDirectory.Name = "comboBoxOutputDirectory";
            this.comboBoxOutputDirectory.Size = new System.Drawing.Size(469, 32);
            this.comboBoxOutputDirectory.TabIndex = 31;
            // 
            // btnBrowseOutputFolder
            // 
            this.btnBrowseOutputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnBrowseOutputFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBrowseOutputFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBrowseOutputFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnBrowseOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseOutputFolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowseOutputFolder.Location = new System.Drawing.Point(572, 488);
            this.btnBrowseOutputFolder.Margin = new System.Windows.Forms.Padding(2, 0, 0, 3);
            this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            this.btnBrowseOutputFolder.Size = new System.Drawing.Size(90, 32);
            this.btnBrowseOutputFolder.TabIndex = 32;
            this.btnBrowseOutputFolder.Text = "浏览...";
            this.btnBrowseOutputFolder.UseVisualStyleBackColor = false;
            this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
            // 
            // labelOutputPath
            // 
            this.labelOutputPath.AutoSize = true;
            this.labelOutputPath.BackColor = System.Drawing.Color.Transparent;
            this.labelOutputPath.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOutputPath.Location = new System.Drawing.Point(8, 492);
            this.labelOutputPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutputPath.Name = "labelOutputPath";
            this.labelOutputPath.Size = new System.Drawing.Size(82, 24);
            this.labelOutputPath.TabIndex = 27;
            this.labelOutputPath.Text = "输出目录";
            // 
            // labelTargetFormat
            // 
            this.labelTargetFormat.AutoSize = true;
            this.labelTargetFormat.BackColor = System.Drawing.Color.Transparent;
            this.labelTargetFormat.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTargetFormat.Location = new System.Drawing.Point(8, 455);
            this.labelTargetFormat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.labelTargetFormat.Name = "labelTargetFormat";
            this.labelTargetFormat.Size = new System.Drawing.Size(82, 24);
            this.labelTargetFormat.TabIndex = 28;
            this.labelTargetFormat.Text = "目标格式";
            // 
            // comBoxTargetFormat
            // 
            this.comBoxTargetFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.comBoxTargetFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTargetFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comBoxTargetFormat.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comBoxTargetFormat.FormattingEnabled = true;
            this.comBoxTargetFormat.IntegralHeight = false;
            this.comBoxTargetFormat.ItemHeight = 24;
            this.comBoxTargetFormat.Items.AddRange(new object[] {
            "X Studio 1.8(SVIP 6.0.0)"});
            this.comBoxTargetFormat.Location = new System.Drawing.Point(98, 451);
            this.comBoxTargetFormat.Name = "comBoxTargetFormat";
            this.comBoxTargetFormat.Size = new System.Drawing.Size(247, 32);
            this.comBoxTargetFormat.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(7, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "转换设置";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(670, 588);
            this.Controls.Add(this.buttonAdvancedOptions);
            this.Controls.Add(this.comboBoxOutputDirectory);
            this.Controls.Add(this.btnBrowseOutputFolder);
            this.Controls.Add(this.labelOutputPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTargetFormat);
            this.Controls.Add(this.comBoxTargetFormat);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnClearSelectedItem);
            this.Controls.Add(this.btnInvertSelection);
            this.Controls.Add(this.LbListEmpityHint);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.pictureBoxTitleIcon);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonAddFile);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnOpenOutputFolder);
            this.Controls.Add(this.ProgressbarBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌声合成软件工程文件转换工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.ProgressbarBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ButtonAddFile;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnOpenOutputFolder;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox pictureBoxTitleIcon;
        private System.Windows.Forms.Panel ProgressbarBackground;
        private System.Windows.Forms.Panel ProgressbarForeground;
        private System.Windows.Forms.Timer timerForProgressbar;
        private System.Windows.Forms.Label LbListEmpityHint;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClearSelectedItem;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Button btnInvertSelection;
        private System.Windows.Forms.Button buttonAdvancedOptions;
        private System.Windows.Forms.ComboBox comboBoxOutputDirectory;
        private System.Windows.Forms.Button btnBrowseOutputFolder;
        private System.Windows.Forms.Label labelOutputPath;
        private System.Windows.Forms.Label labelTargetFormat;
        private System.Windows.Forms.ComboBox comBoxTargetFormat;
        private System.Windows.Forms.Label label1;
    }
}

