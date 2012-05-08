using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PersonalLogger
{
    public partial class LoggerForm : Form
    {
        public LoggerForm()
        {
            InitializeComponent();


            if (Properties.Settings.Default.SavePath.Length > 0)
            {
                folderPath = Properties.Settings.Default.SavePath;
            }
            else
            {
                UseMyDocumentFolder();
            }

            saver = new LoggerSaver(folderPath, logListBox.Items);
            dateTimePicker.Value = DateTime.Today;
            
        }

        private void UseMyDocumentFolder()
        {
            folderPath = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PersonalLogger\");
        }
        string folderPath;
        LoggerSaver saver;

        private void logButton_Click(object sender, EventArgs e)
        {
            GetInput();
        }

        private void GetInput()
        {
            string log = inputTextBox.Text.Trim();
            if (log.Length != 0)
            {
                dateTimePicker.Value = DateTime.Now.Date;
                logListBox.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "]: " + log);
                
                logListBox.TopIndex = logListBox.Items.Count-1;
            }
            saver.UpdateLogFile();
            inputTextBox.Text = ""; 
            inputTextBox.Focus();
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                GetInput();
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool isToday = (dateTimePicker.Value.Date == DateTime.Now.Date);
            inputTextBox.Enabled = isToday;
            logButton.Enabled = isToday;

            saver.Date = dateTimePicker.Value.Date;
            saver.UpdateLogFile();
        }

        #region date maniputation buttons
        private void todayButton_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Today;
        }

        private void tomorrowButton_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddMonths(1);
        }

        private void yesterdayButton_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);
        }

        private void previousMonthButton_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddMonths(-1);
        }
        #endregion


        private void LoggerForm_Activated(object sender, EventArgs e)
        {
            //dateTimePicker.MaxDate = DateTime.Now.Date;
        }

        

    }
}
