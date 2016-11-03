using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace VmsClientDemo
{
    partial class WaitBox : Form
    {
        BackgroundWorker m_BackgroundWorker;
        public WaitBox()
        {
            InitializeComponent();

            //获取当前工作区宽度和高度（工作区不包含状态栏）
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            //计算窗体显示的坐标值，可以根据需要微调几个像素
            int x = (ScreenWidth - this.Width) / 2;
            int y = (ScreenHeight - this.Height) / 2;

            this.Location = new Point(x, y);

            m_BackgroundWorker = new BackgroundWorker(); // 实例化后台对象
            m_BackgroundWorker.WorkerReportsProgress = true; // 设置可以通告进度
            m_BackgroundWorker.WorkerSupportsCancellation = true; // 设置可以取消
            m_BackgroundWorker.DoWork += new DoWorkEventHandler(DoWork);
            m_BackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgress);
            m_BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompletedWork);
            m_BackgroundWorker.RunWorkerAsync(this);
        }

        void DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            int i = 0;
            while (i <= 100)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                bw.ReportProgress(i++);
                Thread.Sleep(100);
            }
        }

        void UpdateProgress(object sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage;
            //ValueLab.Text = string.Format("{0}", progress);
        }

        void CompletedWork(object sender, RunWorkerCompletedEventArgs e)
        {
        }

    }
}
