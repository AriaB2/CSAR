﻿namespace _380Prototype
{
    partial class prototypeForm
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
            this.classTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.recommendTab = new System.Windows.Forms.TabPage();
            this.scheduleListBox = new System.Windows.Forms.ListBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.scheduleCalendar = new System.Windows.Forms.MonthCalendar();
            this.recommendLabel = new System.Windows.Forms.Label();
            this.recommendListBox = new System.Windows.Forms.ListBox();
            this.checkRequirementsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.noMajorCheckBox = new System.Windows.Forms.CheckBox();
            this.minorComboBox = new System.Windows.Forms.ComboBox();
            this.minorLabel = new System.Windows.Forms.Label();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.classStandingLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.classTabs.SuspendLayout();
            this.recommendTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // classTabs
            // 
            this.classTabs.Controls.Add(this.recommendTab);
            this.classTabs.Controls.Add(this.tabPage1);
            this.classTabs.Controls.Add(this.tabPage2);
            this.classTabs.Controls.Add(this.tabPage3);
            this.classTabs.Controls.Add(this.tabPage4);
            this.classTabs.Controls.Add(this.tabPage5);
            this.classTabs.Location = new System.Drawing.Point(2, 2);
            this.classTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.classTabs.Name = "classTabs";
            this.classTabs.SelectedIndex = 0;
            this.classTabs.Size = new System.Drawing.Size(1175, 865);
            this.classTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.classTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1167, 836);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "my class schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1167, 836);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1167, 836);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "drop";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(1167, 836);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "swap";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Size = new System.Drawing.Size(1167, 836);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "edit";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // recommendTab
            // 
            this.recommendTab.Controls.Add(this.scheduleListBox);
            this.recommendTab.Controls.Add(this.dateLabel);
            this.recommendTab.Controls.Add(this.dateTextBox);
            this.recommendTab.Controls.Add(this.scheduleLabel);
            this.recommendTab.Controls.Add(this.scheduleCalendar);
            this.recommendTab.Controls.Add(this.recommendLabel);
            this.recommendTab.Controls.Add(this.recommendListBox);
            this.recommendTab.Controls.Add(this.checkRequirementsButton);
            this.recommendTab.Controls.Add(this.logoutButton);
            this.recommendTab.Controls.Add(this.noMajorCheckBox);
            this.recommendTab.Controls.Add(this.minorComboBox);
            this.recommendTab.Controls.Add(this.minorLabel);
            this.recommendTab.Controls.Add(this.majorComboBox);
            this.recommendTab.Controls.Add(this.majorLabel);
            this.recommendTab.Controls.Add(this.classStandingLabel);
            this.recommendTab.Controls.Add(this.studentNameLabel);
            this.recommendTab.Controls.Add(this.studentIDLabel);
            this.recommendTab.Location = new System.Drawing.Point(4, 25);
            this.recommendTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recommendTab.Name = "recommendTab";
            this.recommendTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recommendTab.Size = new System.Drawing.Size(1167, 836);
            this.recommendTab.TabIndex = 5;
            this.recommendTab.Text = "recommend";
            this.recommendTab.UseVisualStyleBackColor = true;
            // 
            // scheduleListBox
            // 
            this.scheduleListBox.FormattingEnabled = true;
            this.scheduleListBox.ItemHeight = 16;
            this.scheduleListBox.Location = new System.Drawing.Point(536, 122);
            this.scheduleListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scheduleListBox.Name = "scheduleListBox";
            this.scheduleListBox.Size = new System.Drawing.Size(330, 148);
            this.scheduleListBox.TabIndex = 16;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(533, 78);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(131, 17);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "Daily Schedule For:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(669, 76);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(197, 22);
            this.dateTextBox.TabIndex = 14;
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Location = new System.Drawing.Point(533, 303);
            this.scheduleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(181, 17);
            this.scheduleLabel.TabIndex = 13;
            this.scheduleLabel.Text = "Suggested Class Schedule:";
            // 
            // scheduleCalendar
            // 
            this.scheduleCalendar.Location = new System.Drawing.Point(536, 326);
            this.scheduleCalendar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.scheduleCalendar.Name = "scheduleCalendar";
            this.scheduleCalendar.TabIndex = 12;
            this.scheduleCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // recommendLabel
            // 
            this.recommendLabel.AutoSize = true;
            this.recommendLabel.Location = new System.Drawing.Point(41, 277);
            this.recommendLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recommendLabel.Name = "recommendLabel";
            this.recommendLabel.Size = new System.Drawing.Size(302, 17);
            this.recommendLabel.TabIndex = 11;
            this.recommendLabel.Text = "We recommend you take the following classes:";
            // 
            // recommendListBox
            // 
            this.recommendListBox.FormattingEnabled = true;
            this.recommendListBox.ItemHeight = 16;
            this.recommendListBox.Location = new System.Drawing.Point(44, 323);
            this.recommendListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recommendListBox.Name = "recommendListBox";
            this.recommendListBox.Size = new System.Drawing.Size(380, 212);
            this.recommendListBox.TabIndex = 10;
            // 
            // checkRequirementsButton
            // 
            this.checkRequirementsButton.Location = new System.Drawing.Point(47, 174);
            this.checkRequirementsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkRequirementsButton.Name = "checkRequirementsButton";
            this.checkRequirementsButton.Size = new System.Drawing.Size(380, 71);
            this.checkRequirementsButton.TabIndex = 9;
            this.checkRequirementsButton.Text = "Check Course Requirements";
            this.checkRequirementsButton.UseVisualStyleBackColor = true;
            this.checkRequirementsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(729, 10);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(136, 28);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // noMajorCheckBox
            // 
            this.noMajorCheckBox.AutoSize = true;
            this.noMajorCheckBox.Location = new System.Drawing.Point(384, 75);
            this.noMajorCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noMajorCheckBox.Name = "noMajorCheckBox";
            this.noMajorCheckBox.Size = new System.Drawing.Size(87, 21);
            this.noMajorCheckBox.TabIndex = 7;
            this.noMajorCheckBox.Text = "No Major";
            this.noMajorCheckBox.UseVisualStyleBackColor = true;
            this.noMajorCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // minorComboBox
            // 
            this.minorComboBox.FormattingEnabled = true;
            this.minorComboBox.Location = new System.Drawing.Point(106, 115);
            this.minorComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minorComboBox.Name = "minorComboBox";
            this.minorComboBox.Size = new System.Drawing.Size(240, 24);
            this.minorComboBox.TabIndex = 6;
            this.minorComboBox.Text = "Select a Minor";
            // 
            // minorLabel
            // 
            this.minorLabel.AutoSize = true;
            this.minorLabel.Location = new System.Drawing.Point(41, 122);
            this.minorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minorLabel.Name = "minorLabel";
            this.minorLabel.Size = new System.Drawing.Size(47, 17);
            this.minorLabel.TabIndex = 5;
            this.minorLabel.Text = "Minor:";
            // 
            // majorComboBox
            // 
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Location = new System.Drawing.Point(106, 73);
            this.majorComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(240, 24);
            this.majorComboBox.TabIndex = 4;
            this.majorComboBox.Text = "Select a Major";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(41, 73);
            this.majorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(47, 17);
            this.majorLabel.TabIndex = 3;
            this.majorLabel.Text = "Major:";
            // 
            // classStandingLabel
            // 
            this.classStandingLabel.AutoSize = true;
            this.classStandingLabel.Location = new System.Drawing.Point(484, 22);
            this.classStandingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classStandingLabel.Name = "classStandingLabel";
            this.classStandingLabel.Size = new System.Drawing.Size(49, 17);
            this.classStandingLabel.TabIndex = 2;
            this.classStandingLabel.Text = "Senior";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(280, 22);
            this.studentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(144, 17);
            this.studentNameLabel.TabIndex = 1;
            this.studentNameLabel.Text = "Name: Karan Bhamra";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(36, 22);
            this.studentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(137, 17);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "Student: 106111328";
            // 
            // prototypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(965, 617);
            this.Controls.Add(this.classTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "prototypeForm";
            this.Text = "CSUN SOLAR PROTOTYPE WEBPAGE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.classTabs.ResumeLayout(false);
            this.recommendTab.ResumeLayout(false);
            this.recommendTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl classTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage recommendTab;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label classStandingLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.CheckBox noMajorCheckBox;
        private System.Windows.Forms.ComboBox minorComboBox;
        private System.Windows.Forms.Label minorLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button checkRequirementsButton;
        private System.Windows.Forms.Label recommendLabel;
        private System.Windows.Forms.ListBox recommendListBox;
        private System.Windows.Forms.MonthCalendar scheduleCalendar;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ListBox scheduleListBox;
    }
}

