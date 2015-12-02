using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _380Prototype
{
    public partial class prototypeForm : Form
    {
     
        //set the directory to local storage in order to get the path for the xml files
        string fileDirectory = AppDomain.CurrentDomain.BaseDirectory;

        XmlDocument majorXmlDocument;
        List<Major> majorList;

        XmlDocument studentXmlDocument;
        List<Student> studentList;

        XmlDocument coursesXmlDocument;
        List<Course> courseList;

        public prototypeForm()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // set default tab to the recommend tab
            classTabs.SelectedTab = recommendTab;
            
            //initial loading of the xml docs
            majorXmlDocument = new XmlDocument();
            majorXmlDocument.Load(fileDirectory + "XmlDocs\\Majors.xml");

            majorList = new List<Major>();
            foreach (XmlElement xmlMajorElement in majorXmlDocument.GetElementsByTagName("Major"))
            {
                Major tempMajor = new Major();

                tempMajor.ID = int.Parse(xmlMajorElement.GetAttribute("id"));
                tempMajor.Name = xmlMajorElement.GetAttribute("name");

                //add the majors to major list and minor list (combobox1 and combobox2)
                majorComboBox.Items.Add(tempMajor.Name);
                minorComboBox.Items.Add(tempMajor.Name);

                majorList.Add(tempMajor);
            }

            coursesXmlDocument = new XmlDocument();
            coursesXmlDocument.Load(fileDirectory + "XmlDocs\\Courses.xml");

            courseList = new List<Course>();
            foreach (XmlElement xmlCourseElement in coursesXmlDocument.GetElementsByTagName("Course"))
            {
                Course tempCourse = new Course();

                tempCourse.ID = int.Parse(xmlCourseElement.GetAttribute("id"));
                tempCourse.Name = xmlCourseElement.GetAttribute("name");
                courseList.Add(tempCourse);
            }

            studentXmlDocument = new XmlDocument();
            studentXmlDocument.Load(fileDirectory + "XmlDocs\\Students.xml");

            studentList = new List<Student>();
            foreach (XmlElement xmlStudentElement in studentXmlDocument.GetElementsByTagName("Student"))
            {
                Student tempStudent = new Student();

                tempStudent.ID = int.Parse(xmlStudentElement.GetAttribute("id"));
                tempStudent.Name = xmlStudentElement.GetAttribute("name");
                studentList.Add(tempStudent);

                Major selectedMajor = null;

                int selectedMajorID = int.Parse(xmlStudentElement.GetAttribute("major"));


                //Will search for the major that the student has selected in the xml and fill
                //the property in the student class
                foreach (Major major in majorList)
                {
                    if (major.ID == selectedMajorID)
                    {
                        selectedMajor = major;
                        break;
                    }
                }

                //This is alternative ways of doing the above search that I usually prefer
                //but I will leave it as is and comment the next two methods if you guys
                //want to check them out

                //Doing the search using LINQ

                /*
                selectedMajor = (from m in majorList
                                 where m.ID == selectedMajorID
                                 select m).FirstOrDefault();
                */

                //Doing the search using LAMBDA
                /*
                selectedMajor = majorList.FirstOrDefault(m => m.ID == selectedMajorID);
                */

                if (selectedMajor == null)
                {
                    //major was not found
                    //do proper error handling
                }

                tempStudent.Major = selectedMajor;

                studentList.Add(tempStudent);
            }        

        }
 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // display a generic message for having clicked no major
            if (noMajorCheckBox.Checked)
            {
                MessageBox.Show("THIS IS THE QUIZ AND SURVEY PAGE TO DETERMINE YOUR INTERESTS!");
                noMajorCheckBox.Checked = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //TODO: match the schedule of classes, wed/wed, or all days etc.
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Clear the listbox to display fresh information
            scheduleListBox.Items.Clear();

            // Select the date and display it on the schedule label
            dateTextBox.Text = scheduleCalendar.SelectionStart.DayOfWeek.ToString() + " " + scheduleCalendar.SelectionStart.Date.ToShortDateString();


            Random r = new Random();

            var nums = new List<int> { };  // holds each instance of randomNumberOfClasses

            // How many classes to show per day
            int randomNumberOfClasses = r.Next(1, 4);

            // Add a variable number of classes randomly to daily schedule
            // TODO: remove duplicates
            for (int i = 0; i <= randomNumberOfClasses; i++)
            {
                int randomClassPicker = r.Next(courseList.Count);  // Generate number from 0 to number of classes

                if (!nums.Contains(randomClassPicker))   // Get a unique class each, so no duplicates
                {
                    nums.Add(randomClassPicker);

                    scheduleListBox.Items.Add(courseList[randomClassPicker].Name + "\tFrom:\tTo:\tRoom:");
                }
            }
                
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < courseList.Count; i++) // add each class to the listbox
                recommendListBox.Items.Add(courseList[i].Name);

            checkRequirementsButton.Enabled = false;  // disable the button to disable adding the same list of classes more than once

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
    }
}
