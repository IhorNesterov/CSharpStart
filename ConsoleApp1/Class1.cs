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
        public int unique_id;

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            { 
                if (value > 0 && value < 150)
                { 
                    age = value;
                }
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if(value > 10 && value < 500)
                {
                    weight = value;
                }
            }

        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if(value != null)
                {
                    name = value;
                }
            }
        }

        public Human()
        {
            unique_id = count;
            Age = 20;
            Weight = 70;
            Name = "Dodik";
            count++;
        }

        public Human(int age, int weight, string name)
        {
            unique_id = count;
            Age = age;
            Weight = weight;
            Name = name;
            count++;
        }

        public virtual string Display()
        {
            string output = "";
            output += "Name: " + this.Name;
            output += "\nAge: " + this.Age;
            output += "\nWeight: " + this.Weight;
            return output;
        }

        public virtual void Write()
        {
            Console.WriteLine("Hello,write name)");
            string input = Console.ReadLine();
            Name = input;
            Console.WriteLine("Write weight");
            input = Console.ReadLine();
            Weight = Int32.Parse(input);
            Console.WriteLine("Write age");
            input = Console.ReadLine();
            Age = Int32.Parse(input);
        }
    };

    class Student : Human
    {
        private int[] marks;
        private string[] subjects;
        private string university_name;

        public Student() : base()
        {
            int[] marks = { 3 };
            string[] subjects = { "Default"};
            Marks = marks;
            Subjects = subjects;
            University_Name = "Default university name";
        }

        public Student(int age, int weight, string name, string univer_name) : base(age, weight, name)
        {
            University_Name = univer_name;
        }

        public Student(int age, int weight, string name, string univer_name,string[] subjects,int[] marks) : this(age,weight,name,univer_name)
        {
            Subjects = subjects;
            Marks = marks;
        }

        public string University_Name
        {
            get
            {
               return this.university_name;
            }
            set
            {
                if(value != null)
                {
                    university_name = value;
                }
            }
        }

        public string[] Subjects
        {
            get
            {
                return this.subjects;
            }
            set
            {
                if (value != null)
                {
                    subjects = value;
                }
            }
        }

        public int[] Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                if (value != null)
                {
                    marks = value;
                }
            }
        }

        public override string Display()
        {
            string output = base.Display();
            output += "\nUniversity name:" + University_Name;
            output += "\nMarks:\n";
            for (int i = 0; i < Marks.Length; i++)
            {
                output += this.Subjects[i] + ":" + this.Marks[i] + "\n";
            }
            return output;
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine("\nWrite university name");
            this.University_Name = Console.ReadLine();
        }

    }

}
