using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballot
{
    class Student
    {
        private String name, image, gender;
        private int family, grade;

        // default constructor
        public Student()
        {
            name = "";
            family = 0;
            grade = 0;
            image = "";
            gender = "";

        }

        public Student( int family, int grade ,String name ,String image ,String gender)
        {
            this.name = name;
            this.family = family;
            this.grade = grade;
            this.image = image;
            this.gender = gender;
        }

        // setters

        public void setName(String n)
        {
            name = n;
        }
        public void setImage(String i)
        {
            image = i;
        }
        public void setGender(String s)
        {
            gender = s;
        }
        public void setFamily(int f)
        {
            family = f;
        }
        public void setCode(int g)
        {
            grade = g;
        }

        // getters
        public String getName()
        {
            return name;
        }

        public String getImage()
        {
            return image;
        }

        public String getGender()
        {
            return gender;
        }

        public int getFamily()
        {
            return family;
        }

        public int getGrade()
        {
            return grade;
        }


        public override String ToString()
        {
            return getGrade() + "年級," + getName() + "\n";
        }
    }
}
