using System.Diagnostics;
using DarkUI.Forms;

namespace Nap
{
    public partial class Main : DarkForm
    {
        Stopwatch stopwatch = new Stopwatch();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) => stopwatch.Start();

        private void UpdateElapsed(object sender, EventArgs e)
        {
            TimeSpan timeSpan = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            runningTime.Text = elapsedTime.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folder = @"notes\";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            var modifiedInput = textbox.Text + "\r\n\r\nTotal time: " + runningTime.Text;
            string getFormat = DateTime.Now.ToString(@"yyyy.MM.dd-_-HH.mm.ss");
            TextWriter writer = new StreamWriter(folder + getFormat.ToString() + ".txt");
            writer.Write(modifiedInput);
            writer.Close();
            modifiedInput = "";
        }
    }
}