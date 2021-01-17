using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormStudents : Form
    {
        StudentList studentList = new StudentList();
        bool flagForPicture = true;

        public FormStudents()
        {
            InitializeComponent();
            studentList.AddingNewStudent += ShowMessage;
            studentList.AddingNewStudentWithAverageScoreMoreThanNinetyPoints += ShowMessage;
            studentList.AddingNewStudentWithAverageScoreLessThanSixtyPoints += ShowMessage;
            studentList.StudentDeductions += ShowMessage;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddLessonAndPoint_Click(object sender, EventArgs e)
        {
            listBoxLessonAndPoint.Items.Add($"{textBoxLesson.Text}: {numericUpDownPoint.Value}");
            textBoxLesson.Clear();
            numericUpDownPoint.Value = 0;
        }
        
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            listBoxInformationAboutAllStudents.Items.Clear();
            Dictionary<string, int> dictionary = DictionaryLessonAndPoint(listBoxLessonAndPoint);
            Student student = new Student(textBoxFirstName.Text, textBoxLastName.Text, textBoxPatronymic.Text, textBoxGroup.Text, (int)numericUpDownCourse.Value, dictionary);

            studentList.AddStudent(student);
            studentList.ShowInfoOnListBox(listBoxInformationAboutAllStudents);

            numericUpDownStudentNumberDelete.Maximum += 1;

            listBoxLessonAndPoint.Items.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPatronymic.Clear();
            textBoxGroup.Clear();
            numericUpDownCourse.Value = 1;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int value = (int)numericUpDownStudentNumberDelete.Value;
            if (studentList.Count() >= value)
            {
                listBoxInformationAboutAllStudents.Items.Clear();
                studentList.RemoveStudent(value - 1);
                studentList.ShowInfoOnListBox(listBoxInformationAboutAllStudents);
                numericUpDownStudentNumberDelete.Value = 1;
                numericUpDownStudentNumberDelete.Maximum -= 1;
            }
        }

        private Dictionary<string, int> DictionaryLessonAndPoint(ListBox listBox)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] line = new string[2];
            foreach (string s in listBox.Items)
            {
                Regex regex = new Regex(@"(.*): (\d+)");
                Match match = regex.Match(s);
                string NameLesson = match.Groups[1].Value;
                int num = int.Parse(match.Groups[2].Value);
                dictionary[NameLesson] = num;
            }
            return dictionary;
        }

        private void ShowMessage(object sender, StudentEventArgs e)
        {
            labelEvent.Text = $"Подія: {e.Message}";
        }

        private void pictureBoxDemonstrationOfWork_Click(object sender, EventArgs e)
        {
            pictureBoxDemonstrationOfWork.BringToFront();
            if (flagForPicture)
            {
                pictureBoxDemonstrationOfWork.Width = this.Width - 30;
                pictureBoxDemonstrationOfWork.Height = this.Height - 30;
                pictureBoxDemonstrationOfWork.Location = new Point(0, 0);
                flagForPicture = false;
            }
            else
            {
                pictureBoxDemonstrationOfWork.Width = 64;
                pictureBoxDemonstrationOfWork.Height = 44;
                pictureBoxDemonstrationOfWork.Location = new Point(buttonExit.Location.X - 91, buttonExit.Location.Y - 9);
                flagForPicture = true;
            }
        }
    }
}
