using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncAwaitLib;

namespace AsyncAwaitUI
{
    public partial class FrmTesting : Form
    {
        public FrmTesting()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PrepareUI();

            IOBoundOperation ioBound = new IOBoundOperation();

            Task<RequestResult> slowTask = ioBound.GetWordCountInWebSite(txtURL.Text.Trim(), txtWord.Text.Trim());

            // Any other work on the UI thread can be done here, such as enabling a Progress Bar.
            // This is important to do here, before the "await" call, so that the user
            // sees the progress bar before execution of this method is yielded.
            progressBar1.Enabled = true;
            progressBar1.Visible = true;

            timer1.Interval = 100;
            timer1.Enabled = true;
            timer1.Tick += IncrementProgressBar;

            // Here we will need to evaluate the count of the words, so here we "await" the GetWordCountInWebSite() to finish  
            RequestResult reqResult = await slowTask;

            txtResult.Text = String.Format("The word \"{0}\" appears {1} times in the URL \"{2}\"", reqResult.Word, reqResult.Count, txtURL.Text);

            progressBar1.Enabled = false;
            timer1.Stop();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            ProcessRequests();
        }

        private async Task ProcessRequests()
        {
            // https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/async/start-multiple-async-tasks-and-process-them-as-they-complete
            PrepareUI();

            List<string> lstWords = GetWordsList(); // Transforms a comma separated string in a list of words

            IOBoundOperation ioBound = new IOBoundOperation();

            var lstTasks = new List<Task<RequestResult>>();
            foreach (string word in lstWords)
            {
                lstTasks.Add(ioBound.GetWordCountInWebSite(txtUrl2.Text, word));
            }

            // Any other work on the UI thread can be done here, such as enabling a Progress Bar.
            // This is important to do here, before the "await" call, so that the user
            // sees the progress bar before execution of this method is yielded.
            progressBar1.Enabled = true;
            progressBar1.Visible = true;

            timer1.Interval = 100;
            timer1.Enabled = true;
            timer1.Tick += IncrementProgressBar;

            int totalWords = 0;

            // Here we will need to evaluate the count of the words, so here loop the tasks and "await" each one to ends their job
            while (lstTasks.Any()) // if theres any task in the list
            {
                var currentTask = await Task.WhenAny(lstTasks); // When any of the task finishes it will be returned in the currentTask variable
                lstTasks.Remove(currentTask);

                //https://docs.microsoft.com/en-us/dotnet/standard/async-in-depth
                // Best explanation about await, so far...
                // Using await allows your application or service to perform useful work while a task is running by yielding control to its caller until 
                // the task is done. Your code does not need to rely on callbacks or events to continue execution after the task has been completed.
                // The language and task API integration does that for you. If you’re using Task<T>, the await keyword will additionally "unwrap" the value returned 
                // when the Task is complete. The details of how this works are explained further below.
                var result = await currentTask;
                totalWords = totalWords + result.Count;
                ProcessCompletedTask(result);
            }

            // Same of the above but with better performance
            //foreach (var bucket in TasksUtil.Interleaved(enumerableOfTasks))
            //{
            //    var currentTask = await bucket;
            //    ProcessCompletedTask(currentTask.Result);
            //}

            txtResult.Text = txtResult.Text + String.Format("All words appears {0} times in the URL \"{1}\"", totalWords, txtURL.Text) + Environment.NewLine;

            progressBar1.Enabled = false;
            timer1.Stop();
        }

        

        private void ProcessCompletedTask(RequestResult result)
        {
            txtResult.Text = txtResult.Text + String.Format("The word \"{0}\" appears {1} times in the URL \"{2}\". Finished At: {3}.",
                                                            result.Word,
                                                            result.Count,
                                                            txtURL.Text,
                                                            result.FinishedAt.ToString("yyyy.MM.dd HH:mm:ss:ffff")) + Environment.NewLine;
        }

        private void PrepareUI()
        {
            txtResult.Text = String.Empty;
            progressBar1.Enabled = true;
            progressBar1.Value = 0;
            timer1.Stop();
        }

        private void IncrementProgressBar(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
        }

        private List<string> GetWordsList()
        {
            List<string> lstWords = txtListWords.Text.Trim().Split(',').ToList();
            lstWords.ForEach(w => w.Trim());
            return lstWords;
        }

    }
}
