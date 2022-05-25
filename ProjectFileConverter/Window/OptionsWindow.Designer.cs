namespace ProjectFileConverter
{
    partial class OptionsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsWindow));
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxOpenSvipPath = new System.Windows.Forms.ComboBox();
            this.labelOpenSvipPath = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTitleIcon = new System.Windows.Forms.PictureBox();
            this.labelDoneMessage = new System.Windows.Forms.Label();
            this.comboBoxDoneMessageAppearance = new System.Windows.Forms.ComboBox();
            this.checkBoxOpenOutputDir = new System.Windows.Forms.CheckBox();
            this.checkBoxShowCommandBeforeConverting = new System.Windows.Forms.CheckBox();
            this.buttonClearHistoryOutputDir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonBrowse.Enabled = false;
            this.buttonBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBrowse.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowse.Location = new System.Drawing.Point(726, 54);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(88, 32);
            this.buttonBrowse.TabIndex = 44;
            this.buttonBrowse.Text = "浏览...";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(35)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(34)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(762, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 48);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelTitle.Location = new System.Drawing.Point(44, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(52, 27);
            this.labelTitle.TabIndex = 40;
            this.labelTitle.Text = "选项";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonHelp.Enabled = false;
            this.buttonHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonHelp.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp.Location = new System.Drawing.Point(12, 295);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(88, 50);
            this.buttonHelp.TabIndex = 38;
            this.buttonHelp.Text = "帮助...";
            this.buttonHelp.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(432, 295);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(188, 50);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(224)))));
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(626, 295);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(188, 50);
            this.buttonOK.TabIndex = 37;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTheme.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.IntegralHeight = false;
            this.comboBoxTheme.ItemHeight = 24;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "白色/黑色",
            "黄色-绿色",
            "绿色-蓝色",
            "蓝色-紫色"});
            this.comboBoxTheme.Location = new System.Drawing.Point(238, 92);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(576, 32);
            this.comboBoxTheme.TabIndex = 35;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.BackColor = System.Drawing.Color.Transparent;
            this.labelTheme.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.labelTheme.Location = new System.Drawing.Point(12, 96);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(208, 24);
            this.labelTheme.TabIndex = 33;
            this.labelTheme.Text = "主题（需要重启应用）：";
            // 
            // comboBoxOpenSvipPath
            // 
            this.comboBoxOpenSvipPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.comboBoxOpenSvipPath.Enabled = false;
            this.comboBoxOpenSvipPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOpenSvipPath.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.comboBoxOpenSvipPath.FormattingEnabled = true;
            this.comboBoxOpenSvipPath.IntegralHeight = false;
            this.comboBoxOpenSvipPath.ItemHeight = 24;
            this.comboBoxOpenSvipPath.Location = new System.Drawing.Point(238, 54);
            this.comboBoxOpenSvipPath.Name = "comboBoxOpenSvipPath";
            this.comboBoxOpenSvipPath.Size = new System.Drawing.Size(482, 32);
            this.comboBoxOpenSvipPath.TabIndex = 1;
            // 
            // labelOpenSvipPath
            // 
            this.labelOpenSvipPath.AutoSize = true;
            this.labelOpenSvipPath.BackColor = System.Drawing.Color.Transparent;
            this.labelOpenSvipPath.Enabled = false;
            this.labelOpenSvipPath.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.labelOpenSvipPath.Location = new System.Drawing.Point(12, 58);
            this.labelOpenSvipPath.Name = "labelOpenSvipPath";
            this.labelOpenSvipPath.Size = new System.Drawing.Size(220, 24);
            this.labelOpenSvipPath.TabIndex = 34;
            this.labelOpenSvipPath.Text = "OpenSvip.Console路径：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxTitleIcon
            // 
            this.pictureBoxTitleIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitleIcon.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxTitleIcon.Name = "pictureBoxTitleIcon";
            this.pictureBoxTitleIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitleIcon.TabIndex = 42;
            this.pictureBoxTitleIcon.TabStop = false;
            // 
            // labelDoneMessage
            // 
            this.labelDoneMessage.AutoSize = true;
            this.labelDoneMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelDoneMessage.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.labelDoneMessage.Location = new System.Drawing.Point(12, 134);
            this.labelDoneMessage.Name = "labelDoneMessage";
            this.labelDoneMessage.Size = new System.Drawing.Size(172, 24);
            this.labelDoneMessage.TabIndex = 33;
            this.labelDoneMessage.Text = "操作完成提示样式：";
            // 
            // comboBoxDoneMessageAppearance
            // 
            this.comboBoxDoneMessageAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.comboBoxDoneMessageAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoneMessageAppearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDoneMessageAppearance.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.comboBoxDoneMessageAppearance.FormattingEnabled = true;
            this.comboBoxDoneMessageAppearance.IntegralHeight = false;
            this.comboBoxDoneMessageAppearance.ItemHeight = 24;
            this.comboBoxDoneMessageAppearance.Items.AddRange(new object[] {
            "消息弹窗（可显示完整的详细信息）",
            "Windows 10/11原生Toast通知"});
            this.comboBoxDoneMessageAppearance.Location = new System.Drawing.Point(238, 130);
            this.comboBoxDoneMessageAppearance.Name = "comboBoxDoneMessageAppearance";
            this.comboBoxDoneMessageAppearance.Size = new System.Drawing.Size(576, 32);
            this.comboBoxDoneMessageAppearance.TabIndex = 35;
            // 
            // checkBoxOpenOutputDir
            // 
            this.checkBoxOpenOutputDir.AutoSize = true;
            this.checkBoxOpenOutputDir.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOpenOutputDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBoxOpenOutputDir.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxOpenOutputDir.Location = new System.Drawing.Point(16, 170);
            this.checkBoxOpenOutputDir.Name = "checkBoxOpenOutputDir";
            this.checkBoxOpenOutputDir.Size = new System.Drawing.Size(230, 28);
            this.checkBoxOpenOutputDir.TabIndex = 45;
            this.checkBoxOpenOutputDir.Text = "转换完成后打开输出目录";
            this.checkBoxOpenOutputDir.UseVisualStyleBackColor = false;
            // 
            // checkBoxShowCommandBeforeConverting
            // 
            this.checkBoxShowCommandBeforeConverting.AutoSize = true;
            this.checkBoxShowCommandBeforeConverting.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowCommandBeforeConverting.Enabled = false;
            this.checkBoxShowCommandBeforeConverting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBoxShowCommandBeforeConverting.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxShowCommandBeforeConverting.Location = new System.Drawing.Point(16, 208);
            this.checkBoxShowCommandBeforeConverting.Name = "checkBoxShowCommandBeforeConverting";
            this.checkBoxShowCommandBeforeConverting.Size = new System.Drawing.Size(554, 28);
            this.checkBoxShowCommandBeforeConverting.TabIndex = 45;
            this.checkBoxShowCommandBeforeConverting.Text = "【用于调试】转换文件前显示命令（切勿在转换大量文件前开启）";
            this.checkBoxShowCommandBeforeConverting.UseVisualStyleBackColor = false;
            // 
            // buttonClearHistoryOutputDir
            // 
            this.buttonClearHistoryOutputDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonClearHistoryOutputDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearHistoryOutputDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearHistoryOutputDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonClearHistoryOutputDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearHistoryOutputDir.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClearHistoryOutputDir.Location = new System.Drawing.Point(12, 244);
            this.buttonClearHistoryOutputDir.Name = "buttonClearHistoryOutputDir";
            this.buttonClearHistoryOutputDir.Size = new System.Drawing.Size(384, 45);
            this.buttonClearHistoryOutputDir.TabIndex = 46;
            this.buttonClearHistoryOutputDir.Text = "清除输出目录历史记录";
            this.buttonClearHistoryOutputDir.UseVisualStyleBackColor = false;
            this.buttonClearHistoryOutputDir.Click += new System.EventHandler(this.buttonClearHistoryOutputDir_Click);
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(826, 357);
            this.Controls.Add(this.buttonClearHistoryOutputDir);
            this.Controls.Add(this.checkBoxShowCommandBeforeConverting);
            this.Controls.Add(this.checkBoxOpenOutputDir);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxDoneMessageAppearance);
            this.Controls.Add(this.labelDoneMessage);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.comboBoxOpenSvipPath);
            this.Controls.Add(this.labelOpenSvipPath);
            this.Controls.Add(this.pictureBoxTitleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "OptionsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsWindow_FormClosing);
            this.Load += new System.EventHandler(this.OptionsWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OptionsWindow_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.ComboBox comboBoxOpenSvipPath;
        private System.Windows.Forms.Label labelOpenSvipPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxTitleIcon;
        private System.Windows.Forms.Label labelDoneMessage;
        private System.Windows.Forms.ComboBox comboBoxDoneMessageAppearance;
        private System.Windows.Forms.CheckBox checkBoxOpenOutputDir;
        private System.Windows.Forms.CheckBox checkBoxShowCommandBeforeConverting;
        private System.Windows.Forms.Button buttonClearHistoryOutputDir;
    }
}