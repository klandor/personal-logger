namespace PersonalLogger
{
    partial class LoggerForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggerForm));
            this.logButton = new System.Windows.Forms.Button();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.nextMonthButton = new System.Windows.Forms.Button();
            this.tomorrowButton = new System.Windows.Forms.Button();
            this.yesterdayButton = new System.Windows.Forms.Button();
            this.previousMonthButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logButton
            // 
            this.logButton.AccessibleDescription = "";
            this.logButton.AccessibleName = "";
            this.logButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logButton.Location = new System.Drawing.Point(266, 353);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 23);
            this.logButton.TabIndex = 1;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // logListBox
            // 
            this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 12;
            this.logListBox.Location = new System.Drawing.Point(12, 36);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(329, 304);
            this.logListBox.TabIndex = 2;
            this.logListBox.TabStop = false;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(12, 353);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(248, 22);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // nextMonthButton
            // 
            this.nextMonthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextMonthButton.Location = new System.Drawing.Point(308, 7);
            this.nextMonthButton.Name = "nextMonthButton";
            this.nextMonthButton.Size = new System.Drawing.Size(32, 23);
            this.nextMonthButton.TabIndex = 3;
            this.nextMonthButton.Text = ">>";
            this.nextMonthButton.UseVisualStyleBackColor = true;
            this.nextMonthButton.Click += new System.EventHandler(this.nextMonthButton_Click);
            // 
            // tomorrowButton
            // 
            this.tomorrowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tomorrowButton.Location = new System.Drawing.Point(270, 7);
            this.tomorrowButton.Name = "tomorrowButton";
            this.tomorrowButton.Size = new System.Drawing.Size(32, 23);
            this.tomorrowButton.TabIndex = 3;
            this.tomorrowButton.Text = ">";
            this.tomorrowButton.UseVisualStyleBackColor = true;
            this.tomorrowButton.Click += new System.EventHandler(this.tomorrowButton_Click);
            // 
            // yesterdayButton
            // 
            this.yesterdayButton.Location = new System.Drawing.Point(50, 7);
            this.yesterdayButton.Name = "yesterdayButton";
            this.yesterdayButton.Size = new System.Drawing.Size(32, 23);
            this.yesterdayButton.TabIndex = 3;
            this.yesterdayButton.Text = "<";
            this.yesterdayButton.UseVisualStyleBackColor = true;
            this.yesterdayButton.Click += new System.EventHandler(this.yesterdayButton_Click);
            // 
            // previousMonthButton
            // 
            this.previousMonthButton.Location = new System.Drawing.Point(12, 7);
            this.previousMonthButton.Name = "previousMonthButton";
            this.previousMonthButton.Size = new System.Drawing.Size(32, 23);
            this.previousMonthButton.TabIndex = 3;
            this.previousMonthButton.Text = "<<";
            this.previousMonthButton.UseVisualStyleBackColor = true;
            this.previousMonthButton.Click += new System.EventHandler(this.previousMonthButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(88, 7);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(124, 22);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2012, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // todayButton
            // 
            this.todayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.todayButton.Location = new System.Drawing.Point(218, 7);
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(46, 23);
            this.todayButton.TabIndex = 3;
            this.todayButton.Text = "Today";
            this.todayButton.UseVisualStyleBackColor = true;
            this.todayButton.Click += new System.EventHandler(this.todayButton_Click);
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 387);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.previousMonthButton);
            this.Controls.Add(this.yesterdayButton);
            this.Controls.Add(this.todayButton);
            this.Controls.Add(this.tomorrowButton);
            this.Controls.Add(this.nextMonthButton);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.inputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoggerForm";
            this.Text = "PersonalLogger";
            this.Activated += new System.EventHandler(this.LoggerForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button nextMonthButton;
        private System.Windows.Forms.Button tomorrowButton;
        private System.Windows.Forms.Button yesterdayButton;
        private System.Windows.Forms.Button previousMonthButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button todayButton;
    }
}

