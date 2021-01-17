using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class Student
    {
        protected string FirstName;
        protected string LastName;
        protected string Patronymic;
        protected string Group;
        protected int Course;
        protected Dictionary<string, int> ResultsTestsAndExams;

        public Student(string lastName, string firstName, string patronymic, string group, int course, Dictionary<string, int> resultsTestsAndExams)
        {
            SetLastName(lastName);
            SetFirstName(firstName);
            SetPatronymic(patronymic);
            SetGroup(group);
            SetCourse(course);
            ResultsTestsAndExams = resultsTestsAndExams;
        }

        public Student(string lastName, string firstName)
        {
            SetLastName(lastName);
            SetFirstName(firstName);
            Patronymic = "Unknow";
            Group = "Unknow";
            Course = 1;
            ResultsTestsAndExams = new Dictionary<string, int>();
        }

        public void SetLastName(string lastName)
        {
            if (lastName.Length > 0 && !WhetherDigitInLine(lastName))
                LastName = lastName;
            else
                LastName = "Unknow";
        }

        public void SetFirstName(string firstName)
        {
            if (firstName.Length > 0 && !WhetherDigitInLine(firstName))
                FirstName = firstName;
            else
                FirstName = "Unknow";
        }

        public void SetPatronymic(string patronymic)
        {
            if (patronymic.Length > 0 && !WhetherDigitInLine(patronymic))
                Patronymic = patronymic;
            else
                Patronymic = "Unknow";
        }

        public void SetGroup(string group)
        {
            if (group.Length > 0)
                Group = group;
            else
                Group = "Unknow";
        }

        public void SetCourse(int course)
        {
            if (course >= 1 && course <= 12)
                Course = course;
            else
                Course = 1;
        }

        public void SetResultsTestsAndExams(string key, int value)
        {
            if (key.Length > 0 && value >= 0 && value <= 100)
                ResultsTestsAndExams[key] = value;
        }

        public void AddResultsTestsAndExams(string key, int value)
        {
            if (key.Length > 0 && value >= 0 && value <= 100)
                ResultsTestsAndExams.Add(key, value);
        }

        public void RemoveResultsTestsAndExams(string key)
        {
            ResultsTestsAndExams.Remove(key);
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetPatronymic()
        {
            return Patronymic;
        }

        public string GetGroup()
        {
            return Group;
        }

        public int GetCourse()
        {
            return Course;
        }

        public Dictionary<string, int> GetResultsTestsAndExams()
        {
            return ResultsTestsAndExams;
        }

        public override string ToString()
        {
            StringBuilder outputLine = new StringBuilder($"{FirstName} {LastName} {Patronymic}, Група: {Group}, Курс: {Course}");
            foreach (KeyValuePair<string, int> keyValue in ResultsTestsAndExams)
            {
                outputLine.Append($"; {keyValue.Key} - {keyValue.Value}");
            }
            return outputLine.ToString();
        }

        public double CalculateAverageScore()
        {
            double average = 0;
            foreach (int value in ResultsTestsAndExams.Values)
                average += value;

            return average / ResultsTestsAndExams.Count;
        }

        private bool WhetherDigitInLine(string line)
        {
            for (int i = 0; i < line.Length; i++)
                if (Char.IsDigit(line[i]))
                    return true;
            return false;
        }
    }
}
