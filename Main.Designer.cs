namespace Pomodoro
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ShowTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Notf = new System.Windows.Forms.NotifyIcon(this.components);
            this.startWork = new System.Windows.Forms.Button();
            this.countStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowTime
            // 
            this.ShowTime.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTime.ForeColor = System.Drawing.Color.Lime;
            this.ShowTime.Location = new System.Drawing.Point(80, 10);
            this.ShowTime.Name = "ShowTime";
            this.ShowTime.Size = new System.Drawing.Size(140, 35);
            this.ShowTime.TabIndex = 0;
            this.ShowTime.Text = "Time";
            this.ShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Notf
            // 
            this.Notf.Icon = ((System.Drawing.Icon)(resources.GetObject("Notf.Icon")));
            this.Notf.Text = "Notification";
            this.Notf.Visible = true;
            this.Notf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notf_DoubleClick);
            // 
            // startWork
            // 
            this.startWork.ForeColor = System.Drawing.Color.Black;
            this.startWork.Location = new System.Drawing.Point(110, 110);
            this.startWork.Name = "startWork";
            this.startWork.Size = new System.Drawing.Size(80, 37);
            this.startWork.TabIndex = 1;
            this.startWork.Text = "Start!";
            this.startWork.UseVisualStyleBackColor = true;
            this.startWork.Click += new System.EventHandler(this.startWork_Click);
            // 
            // countStatus
            // 
            this.countStatus.BackColor = System.Drawing.Color.Black;
            this.countStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countStatus.ForeColor = System.Drawing.Color.Red;
            this.countStatus.Location = new System.Drawing.Point(12, 60);
            this.countStatus.Name = "countStatus";
            this.countStatus.Size = new System.Drawing.Size(260, 28);
            this.countStatus.TabIndex = 2;
            this.countStatus.Text = "Status";
            this.countStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.countStatus);
            this.Controls.Add(this.startWork);
            this.Controls.Add(this.ShowTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.Text = "Pomodoro Technique";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ShowTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon Notf;
        private System.Windows.Forms.Button startWork;
        private System.Windows.Forms.Label countStatus;
    }
}

