namespace Nap
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip = new DarkUI.Controls.DarkMenuStrip();
            saveClick = new ToolStripMenuItem();
            statusStrip = new DarkUI.Controls.DarkStatusStrip();
            runningTime = new ToolStripStatusLabel();
            textbox = new DarkUI.Controls.DarkTextBox();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += UpdateElapsed;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(60, 63, 65);
            menuStrip.ForeColor = Color.FromArgb(220, 220, 220);
            menuStrip.Items.AddRange(new ToolStripItem[] { saveClick });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(3, 2, 0, 2);
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "darkMenuStrip1";
            // 
            // saveClick
            // 
            saveClick.BackColor = Color.FromArgb(60, 63, 65);
            saveClick.ForeColor = Color.FromArgb(220, 220, 220);
            saveClick.Name = "saveClick";
            saveClick.Size = new Size(43, 20);
            saveClick.Text = "Save";
            saveClick.Click += saveToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.AutoSize = false;
            statusStrip.BackColor = Color.FromArgb(60, 63, 65);
            statusStrip.ForeColor = Color.FromArgb(220, 220, 220);
            statusStrip.Items.AddRange(new ToolStripItem[] { runningTime });
            statusStrip.Location = new Point(0, 418);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(0, 5, 0, 3);
            statusStrip.RightToLeft = RightToLeft.Yes;
            statusStrip.Size = new Size(800, 32);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 5;
            statusStrip.Text = "darkStatusStrip1";
            // 
            // runningTime
            // 
            runningTime.Name = "runningTime";
            runningTime.Size = new Size(33, 19);
            runningTime.Text = "Time";
            // 
            // textbox
            // 
            textbox.BackColor = Color.FromArgb(69, 73, 74);
            textbox.BorderStyle = BorderStyle.FixedSingle;
            textbox.Dock = DockStyle.Fill;
            textbox.ForeColor = Color.FromArgb(220, 220, 220);
            textbox.Location = new Point(0, 24);
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.ScrollBars = ScrollBars.Vertical;
            textbox.Size = new Size(800, 394);
            textbox.TabIndex = 6;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textbox);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Name = "Main";
            Text = "Notes";
            Load += Main_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DarkUI.Controls.DarkMenuStrip menuStrip;
        private ToolStripMenuItem saveClick;
        private DarkUI.Controls.DarkStatusStrip statusStrip;
        private ToolStripStatusLabel runningTime;
        private DarkUI.Controls.DarkTextBox textbox;
    }
}