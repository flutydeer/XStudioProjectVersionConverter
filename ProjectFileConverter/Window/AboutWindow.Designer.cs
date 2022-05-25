namespace ProjectFileConverter
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.BtnClose = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonVisitGitHubHomepage = new System.Windows.Forms.Button();
            this.ButtonVisitDeveloperHomepage = new System.Windows.Forms.Button();
            this.ButtonCheckForUpdatesAtGitHub = new System.Windows.Forms.Button();
            this.ButtonCheckForUpdatesAtGitee = new System.Windows.Forms.Button();
            this.ButtonVisitGiteeHomepage = new System.Windows.Forms.Button();
            this.labelProductAndAuthorName = new System.Windows.Forms.Label();
            this.pictureBoxTitleIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxLarge = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLarge)).BeginInit();
            this.SuspendLayout();
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
            this.BtnClose.Location = new System.Drawing.Point(428, -1);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(64, 48);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "✕";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LabelTitle.Location = new System.Drawing.Point(50, 10);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(52, 27);
            this.LabelTitle.TabIndex = 11;
            this.LabelTitle.Text = "关于";
            this.LabelTitle.Visible = false;
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LableTitle_MouseDown);
            // 
            // ButtonVisitGitHubHomepage
            // 
            this.ButtonVisitGitHubHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ButtonVisitGitHubHomepage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonVisitGitHubHomepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonVisitGitHubHomepage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ButtonVisitGitHubHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVisitGitHubHomepage.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonVisitGitHubHomepage.Location = new System.Drawing.Point(12, 342);
            this.ButtonVisitGitHubHomepage.Name = "ButtonVisitGitHubHomepage";
            this.ButtonVisitGitHubHomepage.Size = new System.Drawing.Size(208, 50);
            this.ButtonVisitGitHubHomepage.TabIndex = 17;
            this.ButtonVisitGitHubHomepage.Text = "访问项目GitHub主页";
            this.ButtonVisitGitHubHomepage.UseVisualStyleBackColor = false;
            this.ButtonVisitGitHubHomepage.Click += new System.EventHandler(this.ButtonVisitGitHubHomepage_Click);
            // 
            // ButtonVisitDeveloperHomepage
            // 
            this.ButtonVisitDeveloperHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ButtonVisitDeveloperHomepage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonVisitDeveloperHomepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonVisitDeveloperHomepage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ButtonVisitDeveloperHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVisitDeveloperHomepage.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonVisitDeveloperHomepage.Location = new System.Drawing.Point(12, 398);
            this.ButtonVisitDeveloperHomepage.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ButtonVisitDeveloperHomepage.Name = "ButtonVisitDeveloperHomepage";
            this.ButtonVisitDeveloperHomepage.Size = new System.Drawing.Size(470, 50);
            this.ButtonVisitDeveloperHomepage.TabIndex = 18;
            this.ButtonVisitDeveloperHomepage.Text = "访问开发者B站主页";
            this.ButtonVisitDeveloperHomepage.UseVisualStyleBackColor = false;
            this.ButtonVisitDeveloperHomepage.Click += new System.EventHandler(this.ButtonVisitDeveloperHomepage_Click);
            // 
            // ButtonCheckForUpdatesAtGitHub
            // 
            this.ButtonCheckForUpdatesAtGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ButtonCheckForUpdatesAtGitHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonCheckForUpdatesAtGitHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonCheckForUpdatesAtGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ButtonCheckForUpdatesAtGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCheckForUpdatesAtGitHub.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonCheckForUpdatesAtGitHub.Location = new System.Drawing.Point(12, 286);
            this.ButtonCheckForUpdatesAtGitHub.Name = "ButtonCheckForUpdatesAtGitHub";
            this.ButtonCheckForUpdatesAtGitHub.Size = new System.Drawing.Size(208, 50);
            this.ButtonCheckForUpdatesAtGitHub.TabIndex = 19;
            this.ButtonCheckForUpdatesAtGitHub.Text = "从GitHub检查更新";
            this.ButtonCheckForUpdatesAtGitHub.UseVisualStyleBackColor = false;
            this.ButtonCheckForUpdatesAtGitHub.Click += new System.EventHandler(this.ButtonCheckForUpdatesAtGitHub_Click);
            // 
            // ButtonCheckForUpdatesAtGitee
            // 
            this.ButtonCheckForUpdatesAtGitee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ButtonCheckForUpdatesAtGitee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonCheckForUpdatesAtGitee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonCheckForUpdatesAtGitee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ButtonCheckForUpdatesAtGitee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCheckForUpdatesAtGitee.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonCheckForUpdatesAtGitee.Location = new System.Drawing.Point(226, 286);
            this.ButtonCheckForUpdatesAtGitee.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ButtonCheckForUpdatesAtGitee.Name = "ButtonCheckForUpdatesAtGitee";
            this.ButtonCheckForUpdatesAtGitee.Size = new System.Drawing.Size(256, 50);
            this.ButtonCheckForUpdatesAtGitee.TabIndex = 19;
            this.ButtonCheckForUpdatesAtGitee.Text = "从Gitee检查更新(推荐)";
            this.ButtonCheckForUpdatesAtGitee.UseVisualStyleBackColor = false;
            this.ButtonCheckForUpdatesAtGitee.Click += new System.EventHandler(this.ButtonCheckForUpdatesAtGitee_Click);
            // 
            // ButtonVisitGiteeHomepage
            // 
            this.ButtonVisitGiteeHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ButtonVisitGiteeHomepage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonVisitGiteeHomepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonVisitGiteeHomepage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ButtonVisitGiteeHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVisitGiteeHomepage.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonVisitGiteeHomepage.Location = new System.Drawing.Point(226, 342);
            this.ButtonVisitGiteeHomepage.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ButtonVisitGiteeHomepage.Name = "ButtonVisitGiteeHomepage";
            this.ButtonVisitGiteeHomepage.Size = new System.Drawing.Size(256, 50);
            this.ButtonVisitGiteeHomepage.TabIndex = 17;
            this.ButtonVisitGiteeHomepage.Text = "访问项目Gitee主页(推荐)";
            this.ButtonVisitGiteeHomepage.UseVisualStyleBackColor = false;
            this.ButtonVisitGiteeHomepage.Click += new System.EventHandler(this.ButtonVisitGiteeHomepage_Click);
            // 
            // labelProductAndAuthorName
            // 
            this.labelProductAndAuthorName.AutoSize = true;
            this.labelProductAndAuthorName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductAndAuthorName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProductAndAuthorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelProductAndAuthorName.Location = new System.Drawing.Point(88, 217);
            this.labelProductAndAuthorName.Name = "labelProductAndAuthorName";
            this.labelProductAndAuthorName.Size = new System.Drawing.Size(312, 48);
            this.labelProductAndAuthorName.TabIndex = 15;
            this.labelProductAndAuthorName.Text = "X StudioProjectFileConverter v1.1.0\r\n开发者：笛鹿FlutyDeer";
            this.labelProductAndAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxTitleIcon
            // 
            this.pictureBoxTitleIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitleIcon.Location = new System.Drawing.Point(12, 7);
            this.pictureBoxTitleIcon.Name = "pictureBoxTitleIcon";
            this.pictureBoxTitleIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitleIcon.TabIndex = 24;
            this.pictureBoxTitleIcon.TabStop = false;
            this.pictureBoxTitleIcon.Visible = false;
            // 
            // pictureBoxLarge
            // 
            this.pictureBoxLarge.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLarge.Location = new System.Drawing.Point(183, 68);
            this.pictureBoxLarge.Name = "pictureBoxLarge";
            this.pictureBoxLarge.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLarge.TabIndex = 20;
            this.pictureBoxLarge.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(491, 459);
            this.Controls.Add(this.pictureBoxTitleIcon);
            this.Controls.Add(this.pictureBoxLarge);
            this.Controls.Add(this.ButtonCheckForUpdatesAtGitee);
            this.Controls.Add(this.ButtonCheckForUpdatesAtGitHub);
            this.Controls.Add(this.ButtonVisitDeveloperHomepage);
            this.Controls.Add(this.ButtonVisitGiteeHomepage);
            this.Controls.Add(this.ButtonVisitGitHubHomepage);
            this.Controls.Add(this.labelProductAndAuthorName);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AboutWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AboutWindow_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLarge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonVisitGitHubHomepage;
        private System.Windows.Forms.Button ButtonVisitDeveloperHomepage;
        private System.Windows.Forms.Button ButtonCheckForUpdatesAtGitHub;
        private System.Windows.Forms.Button ButtonCheckForUpdatesAtGitee;
        private System.Windows.Forms.Button ButtonVisitGiteeHomepage;
        private System.Windows.Forms.Label labelProductAndAuthorName;
        private System.Windows.Forms.PictureBox pictureBoxLarge;
        private System.Windows.Forms.PictureBox pictureBoxTitleIcon;
        private System.Windows.Forms.Timer timer1;
    }
}