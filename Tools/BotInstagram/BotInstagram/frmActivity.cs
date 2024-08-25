using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp;

namespace BotInstagram
{
    public partial class frmActivity : Form
    {
        public frmActivity()
        {
            InitializeComponent();
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var recentActivity = ctx.api
                .UserProcessor.GetRecentActivityFeedAsync(PaginationParameters.MaxPagesToLoad(1)).Result;
            progressBar1.Invoke((MethodInvoker) delegate
            {
                progressBar1.Maximum = recentActivity.Value.Items.Count;
            });
           for (int i = 0; i < recentActivity.Value.Items.Count; i++)
           {
               listBox1.Invoke((MethodInvoker) delegate
               {
                   listBox1.Items.Add(recentActivity.Value.Items[i].Text);
               });
                backgroundWorker1.ReportProgress(i+1);
            }
        }
    }
}
