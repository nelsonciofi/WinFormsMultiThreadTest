
namespace WinFormsMultiThreadTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressBarButton = new System.Windows.Forms.Button();
            this.ProgressStatusButton = new System.Windows.Forms.Button();
            this.SumLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 106);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(773, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
            // 
            // ProgressBarButton
            // 
            this.ProgressBarButton.Location = new System.Drawing.Point(15, 135);
            this.ProgressBarButton.Name = "ProgressBarButton";
            this.ProgressBarButton.Size = new System.Drawing.Size(163, 28);
            this.ProgressBarButton.TabIndex = 2;
            this.ProgressBarButton.Text = "Progress The Bar";
            this.ProgressBarButton.UseVisualStyleBackColor = true;
            this.ProgressBarButton.Click += new System.EventHandler(this.ProgressBarButton_ClickAsync);
            // 
            // ProgressStatusButton
            // 
            this.ProgressStatusButton.Location = new System.Drawing.Point(12, 397);
            this.ProgressStatusButton.Name = "ProgressStatusButton";
            this.ProgressStatusButton.Size = new System.Drawing.Size(166, 28);
            this.ProgressStatusButton.TabIndex = 3;
            this.ProgressStatusButton.Text = "Progress The Status";
            this.ProgressStatusButton.UseVisualStyleBackColor = true;
            this.ProgressStatusButton.Click += new System.EventHandler(this.ProgressStatusButton_ClickAsync);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(520, 253);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(0, 15);
            this.SumLabel.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(501, 231);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Sum Progress";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.ProgressStatusButton);
            this.Controls.Add(this.ProgressBarButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Async Update UI";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button ProgressBarButton;
        private System.Windows.Forms.Button ProgressStatusButton;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

