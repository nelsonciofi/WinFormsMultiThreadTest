using System;
using System.Windows.Forms;

namespace WinFormsMultiThreadTest
{
    public partial class Form1 : Form
    {
        int progress1 = 0;
        int progress2 = 0;

        public Form1() 
            => InitializeComponent();

        /// <summary>
        /// Click on <see cref="ProgressStatusButton"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ProgressStatusButton_ClickAsync(object sender, EventArgs e)
        {
            ProgressStatusButton.Enabled = false;
            toolStripProgressBar1.Value = 0;

            ProgressController pg2 = new();

            pg2.OnCompleteStep += (i) =>
            {
                toolStripProgressBar1.Value = i+1;
                progress1 = i+1;
                SumProgress();
            };

            await pg2.Progress(toolStripProgressBar1.Minimum, toolStripProgressBar1.Maximum);

            ProgressStatusButton.Enabled = true;
        }

        /// <summary>
        /// Click on <see cref="ProgressBarButton"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ProgressBarButton_ClickAsync(object sender, EventArgs e)
        {
            ProgressBarButton.Enabled = false;
            progressBar1.Value = 0;

            ProgressController pg1 = new();
            pg1.OnCompleteStep += (i) =>
            {
                progressBar1.Value = i+1;
                progress2 = i+1;
                SumProgress();
            };

            await pg1.Progress(progressBar1.Minimum, progressBar1.Maximum, 10);
                        
            ProgressBarButton.Enabled = true;
        }

        /// <summary>
        /// Sum both progress values if check box is checked.
        /// </summary>
        private void SumProgress()
            => SumLabel.Text = checkBox1.Checked ? $"Total Progress: {progress1 + progress2}" : string.Empty;
    }
}
