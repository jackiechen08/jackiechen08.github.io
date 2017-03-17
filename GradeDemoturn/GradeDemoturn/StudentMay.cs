using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GradeDemoturn
{
    class StudentMay : IEquatable<StudentMay>, IComparable<StudentMay> 
    {
        private int grade;
        private String name, testcode, group, sort;

        public StudentMay()
        {
            setCode("");
            setName("");
            setGroup("");
            setSort("");
            setGrade(0);
        }

        public StudentMay(String c, String n, String gp, String s, int g)
        {
            setCode(c);
            setName(n);
            setGroup(gp);
            setSort(s);
            setGrade(g);
        }

        public void setGrade(int g) 
	    {
		    if(g < 0) 
		    {
		        MessageBox.Show(getName() + " Grade error!", "Set Grade_Error", MessageBoxButtons.OK);
		    }
		    else
		      grade = g;
	    }

        public int getGrade()
        {
            return grade;
        }
        public void setName(String n)
        {
            name = n;
        }
        public void setGroup(String g)
        {
            group = g;
        }
        public void setCode(String c)
        {
            testcode = c;
        }
        public void setSort(String s)
        {
            sort = s;
        }

        // getters
        public String getName()
        {
            return name;
        }

        public String getGroup()
        {
            return group;
        }

        public String getCode()
        {
            return testcode;
        }

        public String getSort()
        {
            return sort;
        }

        public override String ToString()
        {
            return getGroup() + "考生" + getCode() + "," + getName() + " 的總級分為 " + getGrade() + ",結果:" + getSort();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            StudentMay objAsSM = obj as StudentMay;
            if (objAsSM == null) return false;
            else return Equals(objAsSM);
        }

        public bool Equals(StudentMay obj)
        {
            if (obj == null)
                return false;
            return (this.grade.Equals(obj.grade));
        }

        public int SortGradeAscending(int g1, int g2)
        {
            return g1.CompareTo(g2);
        }
             
        public int CompareTo(StudentMay compareSM)
        {
            if (compareSM == null)
                return 1;
            else
                return this.grade.CompareTo(compareSM.grade); 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
