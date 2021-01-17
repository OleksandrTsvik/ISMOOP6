using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public class StudentList
    {
        public delegate void StudentStateHandler(object sender, StudentEventArgs e);
        public event StudentStateHandler AddingNewStudent;
        public event StudentStateHandler StudentDeductions;
        public event StudentStateHandler AddingNewStudentWithAverageScoreMoreThanNinetyPoints;
        public event StudentStateHandler AddingNewStudentWithAverageScoreLessThanSixtyPoints;

        protected List<Student> Students;

        public StudentList()
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            if (student.CalculateAverageScore() >= 90 && AddingNewStudentWithAverageScoreMoreThanNinetyPoints != null)
                AddingNewStudentWithAverageScoreMoreThanNinetyPoints(this, new StudentEventArgs("Додано нового студента-відмінника!"));
            else if (student.CalculateAverageScore() < 60 && AddingNewStudentWithAverageScoreLessThanSixtyPoints != null)
                AddingNewStudentWithAverageScoreLessThanSixtyPoints(this, new StudentEventArgs("Додано нового студента-двієчника!"));
            else if (AddingNewStudent != null)
                AddingNewStudent(this, new StudentEventArgs("Додано нового студента!"));
        }

        public void RemoveStudent(int studentNumber)
        {
            Students.RemoveAt(studentNumber);
            if (StudentDeductions != null)
                StudentDeductions(this, new StudentEventArgs("Студента відраховано!"));
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public Student this[int index]
        {
            get
            {
                return Students[index];
            }
        }

        public int Count()
        {
            return Students.Count;
        }

        public void ShowInfoOnListBox(ListBox listBox)
        {
            int i = 0;
            foreach (Student student in Students)
                listBox.Items.Add($"{(++i).ToString()}) " + student);
        }
    }
}
