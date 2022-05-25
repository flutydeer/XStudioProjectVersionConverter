namespace ProjectFileConverter
{
    partial class AdvancedOptionsWindow
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
            this.comboBoxInputOptions = new System.Windows.Forms.ComboBox();
            this.labelInputOptions = new System.Windows.Forms.Label();
            this.labelOutputOptions = new System.Windows.Forms.Label();
            this.comboBoxOutputOptions = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBoxTitleIcon = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.buttonClearInputOptions = new System.Windows.Forms.Button();
            this.buttonClearOutputOptions = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxInputOptions
            // 
            this.comboBoxInputOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.comboBoxInputOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInputOptions.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.comboBoxInputOptions.FormattingEnabled = true;
            this.comboBoxInputOptions.IntegralHeight = false;
            this.comboBoxInputOptions.ItemHeight = 24;
            this.comboBoxInputOptions.Location = new System.Drawing.Point(100, 54);
            this.comboBoxInputOptions.Name = "comboBoxInputOptions";
            this.comboBoxInputOptions.Size = new System.Drawing.Size(620, 32);
            this.comboBoxInputOptions.TabIndex = 16;
            // 
            // labelInputOptions
            // 
            this.labelInputOptions.AutoSize = true;
            this.labelInputOptions.BackColor = System.Drawing.Color.Transparent;
            this.labelInputOptions.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.labelInputOptions.Location = new System.Drawing.Point(12, 58);
            this.labelInputOptions.Name = "labelInputOptions";
            this.labelInputOptions.Size = new System.Drawing.Size(82, 24);
            this.labelInputOptions.TabIndex = 15;
            this.labelInputOptions.Text = "输入选项";
            // 
            // labelOutputOptions
            // 
            this.labelOutputOptions.AutoSize = true;
            this.labelOutputOptions.BackColor = System.Drawing.Color.Transparent;
            this.labelOutputOptions.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.labelOutputOptions.Location = new System.Drawing.Point(12, 96);
            this.labelOutputOptions.Name = "labelOutputOptions";
            this.labelOutputOptions.Size = new System.Drawing.Size(82, 24);
            this.labelOutputOptions.TabIndex = 15;
            this.labelOutputOptions.Text = "输出选项";
            // 
            // comboBoxOutputOptions
            // 
            this.comboBoxOutputOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.comboBoxOutputOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOutputOptions.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.comboBoxOutputOptions.FormattingEnabled = true;
            this.comboBoxOutputOptions.IntegralHeight = false;
            this.comboBoxOutputOptions.ItemHeight = 24;
            this.comboBoxOutputOptions.Items.AddRange(new object[] {
            "indented=true",
            "version=6.0.0;singer=何畅",
            "desample=10"});
            this.comboBoxOutputOptions.Location = new System.Drawing.Point(100, 92);
            this.comboBoxOutputOptions.Name = "comboBoxOutputOptions";
            this.comboBoxOutputOptions.Size = new System.Drawing.Size(620, 32);
            this.comboBoxOutputOptions.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(432, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 48);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(224)))));
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(626, 131);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(188, 48);
            this.buttonOK.TabIndex = 27;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // pictureBoxTitleIcon
            // 
            this.pictureBoxTitleIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitleIcon.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxTitleIcon.Name = "pictureBoxTitleIcon";
            this.pictureBoxTitleIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitleIcon.TabIndex = 31;
            this.pictureBoxTitleIcon.TabStop = false;
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
            this.BtnClose.Location = new System.Drawing.Point(762, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(64, 48);
            this.BtnClose.TabIndex = 30;
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
            this.LabelTitle.Location = new System.Drawing.Point(44, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(92, 27);
            this.LabelTitle.TabIndex = 29;
            this.LabelTitle.Text = "高级选项";
            // 
            // buttonClearInputOptions
            // 
            this.buttonClearInputOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonClearInputOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearInputOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearInputOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonClearInputOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearInputOptions.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClearInputOptions.ForeColor = System.Drawing.Color.Black;
            this.buttonClearInputOptions.Location = new System.Drawing.Point(726, 54);
            this.buttonClearInputOptions.Name = "buttonClearInputOptions";
            this.buttonClearInputOptions.Size = new System.Drawing.Size(88, 32);
            this.buttonClearInputOptions.TabIndex = 32;
            this.buttonClearInputOptions.Text = "清空";
            this.buttonClearInputOptions.UseVisualStyleBackColor = false;
            this.buttonClearInputOptions.Click += new System.EventHandler(this.buttonClearInputOptions_Click);
            // 
            // buttonClearOutputOptions
            // 
            this.buttonClearOutputOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonClearOutputOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearOutputOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearOutputOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonClearOutputOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearOutputOptions.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClearOutputOptions.ForeColor = System.Drawing.Color.Black;
            this.buttonClearOutputOptions.Location = new System.Drawing.Point(726, 92);
            this.buttonClearOutputOptions.Name = "buttonClearOutputOptions";
            this.buttonClearOutputOptions.Size = new System.Drawing.Size(88, 32);
            this.buttonClearOutputOptions.TabIndex = 32;
            this.buttonClearOutputOptions.Text = "清空";
            this.buttonClearOutputOptions.UseVisualStyleBackColor = false;
            this.buttonClearOutputOptions.Click += new System.EventHandler(this.buttonClearOutputOptions_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonHelp.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp.Location = new System.Drawing.Point(12, 131);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(88, 48);
            this.buttonHelp.TabIndex = 28;
            this.buttonHelp.Text = "帮助...";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdvancedOptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 189);
            this.Controls.Add(this.buttonClearOutputOptions);
            this.Controls.Add(this.buttonClearInputOptions);
            this.Controls.Add(this.pictureBoxTitleIcon);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxOutputOptions);
            this.Controls.Add(this.labelOutputOptions);
            this.Controls.Add(this.comboBoxInputOptions);
            this.Controls.Add(this.labelInputOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AdvancedOptionsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedOptions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvancedOptionsWindow_FormClosing);
            this.Load += new System.EventHandler(this.AdvancedOptionsWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AdvancedOptionsWindow_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInputOptions;
        private System.Windows.Forms.Label labelInputOptions;
        private System.Windows.Forms.Label labelOutputOptions;
        private System.Windows.Forms.ComboBox comboBoxOutputOptions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxTitleIcon;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button buttonClearInputOptions;
        private System.Windows.Forms.Button buttonClearOutputOptions;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Timer timer1;
    }
}