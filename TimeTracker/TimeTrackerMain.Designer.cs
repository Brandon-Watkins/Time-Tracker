namespace TimeTracker
{
    partial class TimeTrackerMain
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblCurrentTask = new System.Windows.Forms.Label();
            this.lblCurrentTaskTime = new System.Windows.Forms.Label();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.tbCurrentTask = new System.Windows.Forms.TextBox();
            this.timerForCurrentTask = new System.Windows.Forms.Timer(this.components);
            this.breakBar = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.timerForBreaks = new System.Windows.Forms.Timer(this.components);
            this.btnMinimize = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTimeTracker = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.hoursBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.breakBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(219, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(70, 153);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(183, 48);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Do Stuff";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblCurrentTask
            // 
            this.lblCurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTask.Location = new System.Drawing.Point(14, 44);
            this.lblCurrentTask.Name = "lblCurrentTask";
            this.lblCurrentTask.Size = new System.Drawing.Size(289, 29);
            this.lblCurrentTask.TabIndex = 4;
            this.lblCurrentTask.Text = "Current Task";
            this.lblCurrentTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentTask.Visible = false;
            // 
            // lblCurrentTaskTime
            // 
            this.lblCurrentTaskTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTaskTime.Location = new System.Drawing.Point(12, 111);
            this.lblCurrentTaskTime.Name = "lblCurrentTaskTime";
            this.lblCurrentTaskTime.Size = new System.Drawing.Size(291, 39);
            this.lblCurrentTaskTime.TabIndex = 5;
            this.lblCurrentTaskTime.Text = "Time";
            this.lblCurrentTaskTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(12, 218);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(116, 28);
            this.btnViewLog.TabIndex = 7;
            this.btnViewLog.Text = "View Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // tbCurrentTask
            // 
            this.tbCurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentTask.Location = new System.Drawing.Point(12, 41);
            this.tbCurrentTask.Name = "tbCurrentTask";
            this.tbCurrentTask.Size = new System.Drawing.Size(291, 35);
            this.tbCurrentTask.TabIndex = 8;
            this.tbCurrentTask.Text = "Current Task";
            this.tbCurrentTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentTask.TextChanged += new System.EventHandler(this.tbCurrentTask_TextChanged);
            this.tbCurrentTask.Enter += new System.EventHandler(this.tbCurrentTask_Enter);
            this.tbCurrentTask.Leave += new System.EventHandler(this.tbCurrentTask_Leave);
            // 
            // timerForCurrentTask
            // 
            this.timerForCurrentTask.Tick += new System.EventHandler(this.timerForCurrentTask_Tick);
            // 
            // breakBar
            // 
            this.breakBar.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube;
            this.breakBar.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.breakBar.BackSegments = false;
            this.breakBar.BackTubeEndColor = System.Drawing.Color.MediumSpringGreen;
            this.breakBar.BackTubeStartColor = System.Drawing.Color.PaleTurquoise;
            this.breakBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breakBar.CustomText = "Break";
            this.breakBar.CustomWaitingRender = false;
            this.breakBar.ForegroundImage = null;
            this.breakBar.ForeSegments = false;
            this.breakBar.Location = new System.Drawing.Point(13, 83);
            this.breakBar.Maximum = 135;
            this.breakBar.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.breakBar.Name = "breakBar";
            this.breakBar.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.breakBar.SegmentWidth = 12;
            this.breakBar.Size = new System.Drawing.Size(290, 18);
            this.breakBar.TabIndex = 9;
            this.breakBar.Text = "breakBar";
            this.breakBar.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.breakBar.ThemeName = "Tube";
            this.breakBar.ThemesEnabled = false;
            this.breakBar.TubeEndColor = System.Drawing.Color.MediumBlue;
            this.breakBar.TubeStartColor = System.Drawing.Color.RoyalBlue;
            this.breakBar.Value = 0;
            this.breakBar.Visible = false;
            this.breakBar.WaitingGradientWidth = 400;
            this.breakBar.Click += new System.EventHandler(this.breakBar_Click);
            // 
            // timerForBreaks
            // 
            this.timerForBreaks.Interval = 20000;
            this.timerForBreaks.Tick += new System.EventHandler(this.timerForBreaks_Tick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AccessibleName = "Button";
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMinimize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(262, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 22);
            this.btnMinimize.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMinimize.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfButton1.Location = new System.Drawing.Point(289, 4);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(21, 22);
            this.sfButton1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfButton1.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sfButton1.TabIndex = 12;
            this.sfButton1.Text = "X";
            this.sfButton1.UseVisualStyleBackColor = false;
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // lblTimeTracker
            // 
            this.lblTimeTracker.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.SkyBlue, System.Drawing.Color.RoyalBlue);
            this.lblTimeTracker.BeforeTouchSize = new System.Drawing.Size(252, 22);
            this.lblTimeTracker.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblTimeTracker.Location = new System.Drawing.Point(4, 4);
            this.lblTimeTracker.Name = "lblTimeTracker";
            this.lblTimeTracker.Size = new System.Drawing.Size(252, 22);
            this.lblTimeTracker.TabIndex = 13;
            this.lblTimeTracker.Text = "Time Tracker";
            this.lblTimeTracker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursBtn
            // 
            this.hoursBtn.Location = new System.Drawing.Point(134, 218);
            this.hoursBtn.Name = "hoursBtn";
            this.hoursBtn.Size = new System.Drawing.Size(79, 28);
            this.hoursBtn.TabIndex = 14;
            this.hoursBtn.Text = "Hours";
            this.hoursBtn.UseVisualStyleBackColor = true;
            this.hoursBtn.Click += new System.EventHandler(this.HoursBtn_Click);
            // 
            // TimeTrackerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 255);
            this.ControlBox = false;
            this.Controls.Add(this.hoursBtn);
            this.Controls.Add(this.lblTimeTracker);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.breakBar);
            this.Controls.Add(this.tbCurrentTask);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.lblCurrentTaskTime);
            this.Controls.Add(this.lblCurrentTask);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "TimeTrackerMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Brandon Watkins\' Time Tracker";
            this.Load += new System.EventHandler(this.TimeTrackerMain_Load);
            this.Click += new System.EventHandler(this.TimeTrackerMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.breakBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblCurrentTask;
        private System.Windows.Forms.Label lblCurrentTaskTime;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.TextBox tbCurrentTask;
        private System.Windows.Forms.Timer timerForCurrentTask;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv breakBar;
        private System.Windows.Forms.Timer timerForBreaks;
        private Syncfusion.WinForms.Controls.SfButton btnMinimize;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblTimeTracker;
        private System.Windows.Forms.Button hoursBtn;
    }
}

