using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;
        public Student(string lineWithAllData)
        {
            string[] linesWiThDataAboutOneStudent = lineWithAllData.Split(' ');

            this.surName = linesWiThDataAboutOneStudent[0];
            this.firstName = linesWiThDataAboutOneStudent[1];
            this.patronymic = linesWiThDataAboutOneStudent[2];
            this.sex = Convert.ToChar(linesWiThDataAboutOneStudent[3]);
            this.dateOfBirth = linesWiThDataAboutOneStudent[4];
            this.mathematicsMark = Convert.ToChar(linesWiThDataAboutOneStudent[5]);
            this.physicsMark = Convert.ToChar(linesWiThDataAboutOneStudent[6]);
            this.informaticsMark = Convert.ToChar(linesWiThDataAboutOneStudent[7]);
            this.scholarship = Convert.ToInt32(linesWiThDataAboutOneStudent[8]);
        }
    }
}