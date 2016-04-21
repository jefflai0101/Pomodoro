using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Main : Form
    {
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;

        int timerMode = 0;
        int timeCounter = 0;
        int fromCM = 0;

        int soundToPlay = 0;
        WMPLib.WindowsMediaPlayer a = new WMPLib.WindowsMediaPlayer();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();

            timer1.Enabled = true;
            timerMode = 0;
            ShowTime.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
            countStatus.Visible = false;
            Notf.Text = "Not in Schedule";
            startWork.BackColor = Color.Black;
            startWork.ForeColor = Color.Lime;

            // Initialize contextMenu1 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { this.menuItem1 });

            // Initialize menuItem1 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "E&xit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);

            // The ContextMenu property sets the menu that will 
            // appear when the systray icon is right clicked.
            Notf.ContextMenu = this.contextMenu1;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (fromCM == 0)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int mT, sT;

            switch (timerMode)
            {
                case 0:
                    ShowTime.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
                    countStatus.Visible = false;
                    break;

                case 1:
                    if (timeCounter >= 1)
                    {
                        timeCounter -= 1;
                        mT = timeCounter / 60;
                        sT = timeCounter % 60;
                        ShowTime.Text = mT + ":" + sT;
                        Notf.Text = mT + ":" + sT;
                        soundToPlay -= 1;
                        if (soundToPlay == 0)
                        {
                            a.controls.stop();
                            this.Hide();
                        }
                    } else {
                        timeCounter = 5 * 60;
                        countStatus.Text = "Time for break!";
                        soundToPlay = 5;
                        SoundPlayer sPlayer = new SoundPlayer(Pomodoro.Properties.Resources.Done);
                        sPlayer.Play();
                        timerMode = 2;
                        this.Visible = true;
                        this.Focus();
                    }
                    break;

                case 2:
                    if (timeCounter >= 1)
                    {
                        timeCounter -= 1;
                        mT = timeCounter / 60;
                        sT = timeCounter % 60;
                        ShowTime.Text = mT + ":" + sT;
                        Notf.Text = mT + ":" + sT;
                        soundToPlay -= 1;
                        if (soundToPlay == 0)
                        {
                            a.controls.stop();
                            this.Hide();
                        }
                    }
                    else
                    {
                        timeCounter = 25 * 60;
                        countStatus.Text = "Do your work!";
                        soundToPlay = 3;
                        SoundPlayer sPlayer = new SoundPlayer(Pomodoro.Properties.Resources.Start);
                        sPlayer.Play();
                        timerMode = 1;
                        this.Visible = true;
                        this.Focus();
                    }
                    break;

            }

        }

        private void startWork_Click(object sender, EventArgs e)
        {

            if (timerMode == 0)
            {
                    startWork.Text = "Stop!";
                    timerMode = 1;
                    timeCounter = 25 * 60;
                    timer1.Interval = 1000;
                    countStatus.Visible = true;
                    countStatus.Text = "Do your work!";
                    Main.ActiveForm.Visible = false;
                    SoundPlayer sPlayer = new SoundPlayer(Pomodoro.Properties.Resources.Start);
                    sPlayer.Play();

            } else {
                    startWork.Text = "Start!";
                    timerMode = 0;
                    timeCounter = 0;
                    timer1.Interval = 100;
                    Notf.Text = "Not in Schedule";
            }




        }

        private void Notf_DoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application. 
            fromCM = 1;
            this.Close();
        }
        
    }
}
