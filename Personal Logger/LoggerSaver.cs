using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PersonalLogger
{
    class LoggerSaver
    {
        public LoggerSaver(string folderpath, ListBox.ObjectCollection collection)
        {
            DocumentFolder = folderpath;
            this.collection = collection;
            Date = DateTime.Now;
            try
            {
                Directory.CreateDirectory(DocumentFolder);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Can not access directory: " + DocumentFolder + "\n" + ex.Message);
                Application.Exit();
            }
            
        }
        ListBox.ObjectCollection collection;
        private string _folder;
        private DateTime oldDate;
        public string DocumentFolder
        {
            set 
            {
                string newPath = value;

                if (newPath.EndsWith(@"\") == false)
                {
                    newPath += @"\";
                }

                if (Directory.Exists(newPath) == false)
                {
                    Directory.CreateDirectory(newPath);
                }
                _folder = newPath;
            }

            get
            {
                return _folder;
            }
        }
        private DateTime _date;
        public DateTime Date
        {
            set
            {
                _date = value.Date;
                UpdateLogFile();
            }
            get
            {
                return _date.Date;
            }
        }

        
        public void UpdateLogFile()
        {
            if (oldDate != null)
            {
                // save current list to file.
                SaveToFile();
            }

            if (oldDate != Date)
            {

                try
                {
                    collection.Clear();

                    FileStream fs = new FileStream(DocumentFolder + @"\" + Date.ToString("yyyy-MM-dd") + ".txt", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);


                    while (true)
                    {
                        string line = sr.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (line.Trim().Length == 0)
                        {
                            continue;
                        }
                        collection.Add(line);

                    }

                    sr.Close();
                }
                catch
                {

                }
            }
            oldDate = Date;
        }

        private void SaveToFile()
        {
            string filePath = DocumentFolder + @"\" + oldDate.ToString("yyyy-MM-dd") + ".txt";
            try
            {
	            if (collection.Count == 0)
                {
                    File.Delete(filePath);
                    return;
                }


                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
	
                foreach (string s in collection)
                {
                    sw.WriteLine(s);
                }
	
                sw.Close();
            }
            catch (System.Exception ex)
            {
            	
            }
        }
    }
}
