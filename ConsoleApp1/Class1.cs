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
                if (Age > 0 && Age < 150)
                {
                    this.age = Age;
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
                if(Weight > 10 && Weight < 500)
                {
                    this.weight = Weight;
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
                if(Name != null)
                {
                    this.name = Name;
                }
            }
        }

        public Human()
        {
            unique_id = count;
            this.Age = 20;
            this.Weight = 70;
            this.Name = "Dodik";
            count++;
        }

        public Human(int age, int weight, string name)
        {
            unique_id = count;
            this.Age = age;
            this.Weight = weight;
            this.Name = name;
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
            this.Name = input;
            Console.WriteLine("Write weight");
            input = Console.ReadLine();
            this.Weight = Int32.Parse(input);
            Console.WriteLine("Write age");
            input = Console.ReadLine();
            this.Age = Int32.Parse(input);
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
            this.Marks = marks;
            this.Subjects = subjects;
            this.University_Name = "Default university name";
        }

        public Student(int age, int weight, string name, string univer_name) : base(age, weight, name)
        {
            this.University_Name = univer_name;
        }

        public Student(int age, int weight, string name, string univer_name,string[] subjects,int[] marks) : this(age,weight,name,univer_name)
        {
            this.Subjects = subjects;
            this.Marks = marks;
        }

        public string University_Name
        {
            get
            {
               return this.university_name;
            }
            set
            {
                if(University_Name != null)
                {
                    this.university_name = University_Name;
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
                if (subjects != null)
                {
                    this.subjects = Subjects;
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
                if(Marks != null)
                {
                    this.marks = Marks;
                }
            }
        }

        public override string Display()
        {
            string output = base.Display();
            output += "\nUniversity name:" + University_Name;
            output += "\nMarks:\n";
            for (int i = 0; i < this.Marks.Length; i++)
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
