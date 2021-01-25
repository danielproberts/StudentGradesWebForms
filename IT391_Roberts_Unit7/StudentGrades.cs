using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace IT391_Roberts_Unit7
{
    public class StudentGrades
    {
        private ArrayList GradeList;

        public int MaxGrade = 0;
        public int MinGrade = 100;
        public int AvgGrade = 0;

        public StudentGrades()
        {
            GradeList = new ArrayList();
        }

        public StudentGrades(string gradeFileName)
        {
            GradeList = new ArrayList();
            ReadGradeDataFromXML(gradeFileName);
            AvgGrade = CalculateAverage();
            MaxGrade = CalculateMax();
            MinGrade = CalculateMin();
        }

        private void AddGrade(int grade)
        {
            GradeList.Add(grade);
        }

        private int CalculateMin()
        {
            GradeList.Sort();
            int min = (int)GradeList[0];
            return min;
        }

        private int CalculateMax()
        {
            GradeList.Sort();
            int max = (int)GradeList[GradeList.Count - 1];
            return max;
        }
        private int CalculateAverage()
        {
            int avg = 0;
            int sum = 0;
            foreach(int grade in GradeList)
            {
                sum += grade;
            }
            avg = sum / GradeList.Count;
            return avg;
        }
        private void ReadGradeDataFromXML(string gradeFileName)
        {
            XmlTextReader reader = new XmlTextReader(gradeFileName);
            while(reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.Element:
                        System.Diagnostics.Debug.Write("<" + reader.Name);
                        System.Diagnostics.Debug.Write(">");
                        break;
                    case XmlNodeType.Text:
                        System.Diagnostics.Debug.Write(reader.Value);
                        int val = Convert.ToInt32(reader.Value);
                        AddGrade(val);
                        break;
                    case XmlNodeType.EndElement:
                        System.Diagnostics.Debug.Write("</" + reader.Name);
                        System.Diagnostics.Debug.WriteLine(">");
                        break;
                }    
            }
        }
    }
}