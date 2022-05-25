using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjectFileConverter
{
    public partial class AdvancedOptionsWindow : WindowBase
    {
        private AppSettings appSettings;
        public string inputOptions = "";
        public string outputOptions = "";

        public AdvancedOptionsWindow(AppSettings appSettingsFromMain, string inputOptionsFromMainWindow, string outputOptionsFromMainWindow)
        {
            appSettings = appSettingsFromMain;
            InitializeComponent();
            pictureBoxTitleIcon.Image = Properties.Resources.icon_large;
            comboBoxInputOptions.Text = inputOptionsFromMainWindow;
            comboBoxOutputOptions.Text = outputOptionsFromMainWindow;
        }


        private void AdvancedOptionsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            inputOptions = comboBoxInputOptions.Text;
            outputOptions = comboBoxOutputOptions.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/yqzhishen/opensvip/blob/main/README.md");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AdvancedOptionsWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush b = new LinearGradientBrush(ClientRectangle, ThemeUtils.ThemeWindowBackgroundColor(appSettings.Theme).Item1, ThemeUtils.ThemeWindowBackgroundColor(appSettings.Theme).Item2, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, ClientRectangle);
        }

        private void AdvancedOptionsWindow_Load(object sender, EventArgs e)
        {
            buttonOK.BackColor = ThemeUtils.AccentColor(appSettings.Theme);
            if (ThemeUtils.IsDarkMode())
            {
                
                LabelTitle = ThemeUtils.GetDarkLabel(LabelTitle);

                BtnClose = ThemeUtils.GetDarkTitleCloseButton(BtnClose);

                labelInputOptions = ThemeUtils.GetDarkLabel(labelInputOptions);

                comboBoxInputOptions = ThemeUtils.GetDarkComboBox(comboBoxInputOptions);

                buttonClearInputOptions = ThemeUtils.GetDarkButton(buttonClearInputOptions);

                labelOutputOptions = ThemeUtils.GetDarkLabel(labelOutputOptions);

                comboBoxOutputOptions = ThemeUtils.GetDarkComboBox(comboBoxOutputOptions);

                buttonClearOutputOptions = ThemeUtils.GetDarkButton(buttonClearOutputOptions);
                
                buttonHelp = ThemeUtils.GetDarkButton(buttonHelp);
                
                btnCancel = ThemeUtils.GetDarkButton(btnCancel);

                buttonOK.BackColor = Color.FromArgb(91, 22, 133);
            }
            Opacity = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity >= 1)
            {
                timer1.Enabled = false;
            }
        }

        private void buttonClearInputOptions_Click(object sender, EventArgs e)
        {
            comboBoxInputOptions.Text = "";
        }

        private void buttonClearOutputOptions_Click(object sender, EventArgs e)
        {
            comboBoxOutputOptions.Text = "";
        }
    }
}
