using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TimeTracker
{
    class TotalTime
    {
        public List<string> hoursLog = new List<string> { };

        public TotalTime()
        {
            ReadLog();
        }

        public void ReadLog(string fileName = "log.txt")
        {
            bool wantsToLocate = true;
            StreamReader reader;
            FileInfo fileInfo = new FileInfo(fileName);
            while (!fileInfo.Exists && wantsToLocate == true)
            {
                // ask user if they want to locate file. if not, too bad.
                DialogResult result = MessageBox.Show("Log file could not be found.\r\nWould you like to locate it?",
                    "File Not Found", MessageBoxButtons.YesNo);
                // user selected yes, they want to locate file manually.
                if (result == DialogResult.Yes)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    DialogResult result2 = ofd.ShowDialog();
                    fileName = ofd.FileName;
                    // user cancelled
                    if (result2 != DialogResult.OK)
                    {
                        MessageBox.Show("No log file found, cancelling request.");
                        wantsToLocate = false;
                        return;
                    }
                }

            }
            if (fileInfo.Exists && fileInfo.Length > 0)
            {
                reader = new StreamReader(fileName);
                int i = 0;
                while (!reader.EndOfStream)
                {
                    hoursLog[i] = reader.ReadLine();
                    i++;
                }
            }
        }

        public void TokenizeLog()
        {
            for (int i = 0; i < hoursLog.Count; i++)
            {
                int totalHours;

            }
        }

    }
}
