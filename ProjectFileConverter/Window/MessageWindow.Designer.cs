namespace ProjectFileConverter
{
    partial class MessageWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWindow));
            this.Button_OK = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.pictureBoxTitleIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxTypeIcon = new System.Windows.Forms.PictureBox();
            this.BtnExpand = new System.Windows.Forms.Button();
            this.BtnCopyDetails = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(224)))));
            this.Button_OK.FlatAppearance.BorderSize = 0;
            this.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_OK.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_OK.ForeColor = System.Drawing.Color.White;
            this.Button_OK.Location = new System.Drawing.Point(364, 176);
            this.Button_OK.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(188, 50);
            this.Button_OK.TabIndex = 21;
            this.Button_OK.Text = "确定";
            this.Button_OK.UseVisualStyleBackColor = false;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
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
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(497, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(64, 48);
            this.BtnClose.TabIndex = 19;
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
            this.LabelTitle.Location = new System.Drawing.Point(50, 11);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(92, 27);
            this.LabelTitle.TabIndex = 18;
            this.LabelTitle.Text = "提示标题";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMessage.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxMessage.ForeColor = System.Drawing.Color.Black;
            this.TextBoxMessage.Location = new System.Drawing.Point(118, 51);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.ReadOnly = true;
            this.TextBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxMessage.Size = new System.Drawing.Size(431, 119);
            this.TextBoxMessage.TabIndex = 22;
            this.TextBoxMessage.Text = "提示文本";
            // 
            // pictureBoxTitleIcon
            // 
            this.pictureBoxTitleIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitleIcon.Location = new System.Drawing.Point(12, 8);
            this.pictureBoxTitleIcon.Name = "pictureBoxTitleIcon";
            this.pictureBoxTitleIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitleIcon.TabIndex = 23;
            this.pictureBoxTitleIcon.TabStop = false;
            // 
            // pictureBoxTypeIcon
            // 
            this.pictureBoxTypeIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTypeIcon.Image = global::ProjectFileConverter.Properties.Resources.icon_info;
            this.pictureBoxTypeIcon.Location = new System.Drawing.Point(12, 51);
            this.pictureBoxTypeIcon.Name = "pictureBoxTypeIcon";
            this.pictureBoxTypeIcon.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxTypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTypeIcon.TabIndex = 24;
            this.pictureBoxTypeIcon.TabStop = false;
            // 
            // BtnExpand
            // 
            this.BtnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BtnExpand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnExpand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnExpand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpand.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnExpand.ForeColor = System.Drawing.Color.Black;
            this.BtnExpand.Location = new System.Drawing.Point(12, 176);
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.Size = new System.Drawing.Size(100, 50);
            this.BtnExpand.TabIndex = 25;
            this.BtnExpand.Text = "展开";
            this.BtnExpand.UseVisualStyleBackColor = false;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // BtnCopyDetails
            // 
            this.BtnCopyDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BtnCopyDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCopyDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCopyDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnCopyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopyDetails.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCopyDetails.ForeColor = System.Drawing.Color.Black;
            this.BtnCopyDetails.Location = new System.Drawing.Point(118, 176);
            this.BtnCopyDetails.Name = "BtnCopyDetails";
            this.BtnCopyDetails.Size = new System.Drawing.Size(240, 50);
            this.BtnCopyDetails.TabIndex = 26;
            this.BtnCopyDetails.Text = "复制详细信息";
            this.BtnCopyDetails.UseVisualStyleBackColor = false;
            this.BtnCopyDetails.Click += new System.EventHandler(this.BtnCopyDetails_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(561, 238);
            this.Controls.Add(this.BtnCopyDetails);
            this.Controls.Add(this.BtnExpand);
            this.Controls.Add(this.pictureBoxTypeIcon);
            this.Controls.Add(this.pictureBoxTitleIcon);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LabelTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MessageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提示";
            this.Load += new System.EventHandler(this.MessageWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MessageWindow_Paint);
            this.Resize += new System.EventHandler(this.MessageWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.PictureBox pictureBoxTitleIcon;
        private System.Windows.Forms.PictureBox pictureBoxTypeIcon;
        private System.Windows.Forms.Button BtnExpand;
        private System.Windows.Forms.Button BtnCopyDetails;
        private System.Windows.Forms.Timer timer1;
    }
}