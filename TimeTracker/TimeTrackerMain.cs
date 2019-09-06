using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// need for streamwriter
using System.Diagnostics; // need for the Process.Start which is used to open my text file.
using System.Windows.Input;

namespace TimeTracker
{
    public partial class TimeTrackerMain : Form
    {
        public bool status;//true = "on"
        public TimerStatusClass TimerStatus;
        public TimeSpan timeSpan;
        public TimeTrackerMain()
        {
            InitializeComponent(); 
        }

        public void TimerStatusChange(ref TimeSpan timeSpan)
        {
            //change the status**************** NOT SURE IF THIS IS WORKING
            if (status)
            {
                TimerStatus = new TimerStatusClass(false);
            }
            else
            {
                TimerStatus = new TimerStatusClass(true);
            }

            status = TimerStatus.GetStatus();
            if (status)
            {
                //When I click start:

                //start timer
                timerForCurrentTask.Enabled = true;
                timerForBreaks.Enabled = true;
                breakBar.Visible = true;
                //Save time to log, and a variable
                //save current task to log and variable
                WriteToLog(true);
                //change button text to stop
                btnStartStop.Text = "Stop";
                //hide current task textbox
                tbCurrentTask.Visible = false;
                //show current task label
                lblCurrentTask.Visible = true;
                //show current task time
                lblCurrentTaskTime.Text = "0h 0m 0s";
                lblCurrentTaskTime.Visible = true;
            }
            else
            {
                //When I click stop:

                //stop timer
                //save time span to variable and log
                timeSpan = DateTime.Now - TimerStatus.TimeOfEvent;
                timerForBreaks.Enabled = false;
                breakBar.Visible = false;
                WriteToLog(false);
                //change button text to "start"
                btnStartStop.Text = "Start";
                // make current task text box visible
                tbCurrentTask.Visible = true;
                //make current task label invisible
                lblCurrentTask.Visible = false;
                // make timer invisible
                lblCurrentTaskTime.Visible = false;
            }
            btnStartStop.BackColor = TimerStatus.GetColor();
        }
        
        public void WriteToLog(bool isStartEvent)
        {
            StreamWriter writer;
            FileInfo logFile = new FileInfo("Log.txt");
            if (logFile.Exists)
            {
                writer = File.AppendText("Log.txt");
            }
            else
            {
                writer = File.CreateText("Log.txt");
                writer.WriteLine("Date.                  Start Time.  Project Name.  Time Spent On Project.");
                writer.WriteLine("_________________________________________________________________________");
            }

            if (isStartEvent)
            {
                writer.Write(Environment.NewLine + TimerStatus.GetTimeOfEvent().ToLongDateString() + ".  " + TimerStatus.GetTimeOfEvent().ToLongTimeString() + 
                    ".  " + lblCurrentTask.Text + ".  " + "Time Spent: ");
            }
            else
            {
                writer.Write(lblCurrentTaskTime.Text);
            }
            writer.Close();
        }

        private void TimeTrackerMain_Load(object sender, EventArgs e)
        {
            TimerStatus = new TimerStatusClass(false);
            status = false;
            //change button text to "start"
            btnStartStop.Text = "Start";
            // make current task text box visible
            tbCurrentTask.Visible = true;
            //make current task label invisible
            lblCurrentTask.Visible = false;
            // make timer invisible
            lblCurrentTaskTime.Visible = false;
            btnStartStop.BackColor = TimerStatus.GetColor();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            TimerStatusChange(ref timeSpan);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCurrentTask_TextChanged(object sender, EventArgs e)
        {
            lblCurrentTask.Text = tbCurrentTask.Text;
        }

        private void timerForCurrentTask_Tick(object sender, EventArgs e)
        {
            lblCurrentTaskTime.Text = (DateTime.Now - TimerStatus.GetTimeOfEvent()).Hours.ToString() + "h " +
                (DateTime.Now - TimerStatus.GetTimeOfEvent()).Minutes.ToString() + "m " +
                (DateTime.Now - TimerStatus.GetTimeOfEvent()).Seconds.ToString() + "s";
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            Process.Start("Log.txt");
        }

        private void tbCurrentTask_Enter(object sender, EventArgs e)
        {
            if (tbCurrentTask.Text.Equals("Current Task")) tbCurrentTask.Text = "";
        }

        private void tbCurrentTask_Leave(object sender, EventArgs e)
        {
            if (tbCurrentTask.Text.Trim().Equals("")) tbCurrentTask.Text = "Current Task";
        }

        private void TimeTrackerMain_Click(object sender, EventArgs e)
        {
            btnStartStop.Focus();
        }

        private void breakBar_Click(object sender, EventArgs e)
        {
            breakBar.Value = 0;
        }

        private void timerForBreaks_Tick(object sender, EventArgs e)
        {
            breakBar.Value++;
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HoursBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No fucntionality yet. Need to add up hours using TotalTime Class/r/nAlso need to fix break timer, and reformat the date in log");
        }
    }
}
