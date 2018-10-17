using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FormExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int characterCount = 0;

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }

        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            //with thread
            Thread thread = new Thread(() =>
            {
                characterCount = CountCharacters();
                Action action = new Action(SetLabelTextProperty);
                this.BeginInvoke(action);
            });

            thread.Start();
            lblCount.Text = "Processing file. Please wait...";

            //with task
            /*Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            lblCount.Text = "Processing file. Please wait...";
            int count = await task;
            lblCount.Text = count.ToString() + " characters in file";*/
        }

        private void SetLabelTextProperty()
        {
            lblCount.Text = characterCount.ToString() + " characters in file";
        }
    }
}
