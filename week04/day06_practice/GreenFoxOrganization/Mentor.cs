﻿using System;

namespace GreenFoxOrganization
{
    public class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.level = level;
        }

        public Mentor()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            this.level = "intermediate";
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor.", name, age, gender, level);
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
    }
}