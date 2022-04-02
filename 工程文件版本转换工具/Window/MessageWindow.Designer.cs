namespace 工程文件版本转换工具
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWindow));
            this.Button_OK = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Lable_Title = new System.Windows.Forms.Label();
            this.TextBox_Message = new System.Windows.Forms.TextBox();
            this.pictureBoxTitleIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxTypeIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Button_OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_OK.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_OK.ForeColor = System.Drawing.Color.Black;
            this.Button_OK.Location = new System.Drawing.Point(12, 176);
            this.Button_OK.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(540, 50);
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
            // Lable_Title
            // 
            this.Lable_Title.AutoSize = true;
            this.Lable_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lable_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Lable_Title.Location = new System.Drawing.Point(50, 11);
            this.Lable_Title.Name = "Lable_Title";
            this.Lable_Title.Size = new System.Drawing.Size(92, 27);
            this.Lable_Title.TabIndex = 18;
            this.Lable_Title.Text = "提示标题";
            // 
            // TextBox_Message
            // 
            this.TextBox_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TextBox_Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Message.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Message.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Message.Location = new System.Drawing.Point(118, 51);
            this.TextBox_Message.Multiline = true;
            this.TextBox_Message.Name = "TextBox_Message";
            this.TextBox_Message.ReadOnly = true;
            this.TextBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Message.Size = new System.Drawing.Size(431, 119);
            this.TextBox_Message.TabIndex = 22;
            this.TextBox_Message.Text = "提示文本";
            // 
            // pictureBoxTitleIcon
            // 
            this.pictureBoxTitleIcon.Location = new System.Drawing.Point(12, 8);
            this.pictureBoxTitleIcon.Name = "pictureBoxTitleIcon";
            this.pictureBoxTitleIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitleIcon.TabIndex = 23;
            this.pictureBoxTitleIcon.TabStop = false;
            // 
            // pictureBoxTypeIcon
            // 
            this.pictureBoxTypeIcon.Image = global::工程文件版本转换工具.Properties.Resources.icon_info;
            this.pictureBoxTypeIcon.Location = new System.Drawing.Point(12, 51);
            this.pictureBoxTypeIcon.Name = "pictureBoxTypeIcon";
            this.pictureBoxTypeIcon.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxTypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTypeIcon.TabIndex = 24;
            this.pictureBoxTypeIcon.TabStop = false;
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(561, 238);
            this.Controls.Add(this.pictureBoxTypeIcon);
            this.Controls.Add(this.pictureBoxTitleIcon);
            this.Controls.Add(this.TextBox_Message);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.Lable_Title);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MessageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提示";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label Lable_Title;
        private System.Windows.Forms.TextBox TextBox_Message;
        private System.Windows.Forms.PictureBox pictureBoxTitleIcon;
        private System.Windows.Forms.PictureBox pictureBoxTypeIcon;
    }
}