using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Human
    {
        private int age;
        private int weight;
        private string name;
        public static int count;
        public static int id;

        public Human()
        {
            id = count;
            SetAge(20);
            SetWeight(70);
            SetName("Dodik");
            count++;
        }

        public Human(int age, int weight, string name)
        {
            id = count;
            SetAge(age);
            SetWeight(weight);
            SetName(name);
            count++;
        }

        public void SetAge(int age)
        {
            if (age > 0 && age < 150)
            {
                this.age = age;
            }
        }
        public int GetAge()
        {
            return age;
        }

        public void SetWeight(int weight)
        {
            if (weight > 10 && age < 400)
            {
                this.weight = weight;
            }
        }
        public int GetWeight()
        {
            return weight;
        }

        public void SetName(string name)
        {
            if (name != null)
            {
                this.name = name;
            }
        }
        public string GetName()
        {
            return name;
        }

        public virtual string Display()
        {
            string output = "";
            output += "Name: " + this.GetName();
            output += "\nAge: " + this.GetAge();
            output += "\nWeight: " + this.GetWeight();
            return output;
        }

        public virtual void Write()
        {
            Console.WriteLine("Hello,write name)");
            string input = Console.ReadLine();
            this.SetName(input);
            Console.WriteLine("Write weight");
            input = Console.ReadLine();
            this.SetWeight(Int32.Parse(input));
            Console.WriteLine("Write age");
            input = Console.ReadLine();
            this.SetAge(Int32.Parse(input));
        }
    };

    class Student : Human
    {
        private int[] marks;
        private string[] subjects;
        private string university_name;

        public Student() : base()
        {
            int[] mark = { 3, 3};
            string[] subject = { "Default", "Default" };
            this.Setmarks(mark);
            this.SetSubjects(subject);
            this.university_name = "Default university name";
        }

        public Student(int age, int weight, string name, string univer_name) : base(age, weight, name)
        {
            if (univer_name != null)
            {
                this.university_name = univer_name;
            }
        }

        public void SetUniversityName(string univer_name)
        {
            if (univer_name != null)
            {
                this.university_name = univer_name;
            }
        }
        public string GetUniversityName()
        {
            return this.university_name;
        }

        public void SetSubjects(string[] subjects)
        {
            if (subjects != null)
            {
                this.subjects = subjects;
            }
        }
        public string[] GetSubject()
        {
            return this.subjects;
        }

        public string GetSubject(int pos)
        {
            return this.subjects[pos];
        }

        public int[] GetMarks()
        {
            return this.marks;
        }

        public int GetMarks(int pos)
        {
            return this.marks[pos];
        }

        public void Setmarks(int[] mark)
        {
            if (mark != null)
            {
                this.marks = mark;
            }
        }

        public override string Display()
        {
            string output = base.Display();
            output += "\nUniversity name:" + GetUniversityName();
            output += "\nMarks:\n";
            for (int i = 0; i < this.marks.Length - 1; i++)
            {
                output += this.GetSubject(i) + ":" + this.marks[i] + "\n";
            }
            return output;
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine("\nWrite university name");
            this.SetUniversityName(Console.ReadLine());

        }

        
    }

}
