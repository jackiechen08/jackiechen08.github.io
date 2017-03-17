using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeDemoturn
{
    class StudentAugust : IEquatable<StudentAugust>, IComparable<StudentAugust>
    {
        private double math;
        private double chinese;
        private double english;
        private double total;
        private String name, testcode, group, sort;

        public StudentAugust()
        {
            setCode("");
            setName("");
            setGroup("");
            setSort("");
            setMath(0.0);
            setChinese(0.0);
            setEnglish(0.0);
        }

        public StudentAugust(String c, String n, String gp, String s, double m, double ch, double e)
        {
            setCode(c);
            setName(n);
            setGroup(gp);
            setSort(s);
            setMath(m);
            setChinese(ch);
            setEnglish(e);
        }

        public void setMath(double m) 
	{
		if(m < 0) 
		{
            MessageBox.Show(" Math error!", "Set Math Grade_Error", MessageBoxButtons.OK);
		}
		else
		{
			math = m;
			sumTotal();	
		}
		 
	}

        public void setChinese(double ch) 
	{
		if(ch < 0) 
		{
            MessageBox.Show(" Chinese error!", "Set Chinese Grade_Error", MessageBoxButtons.OK);
		}
		else
		{
		  chinese = ch;
		  sumTotal();
		}
	}

        public void setEnglish(double e) 
	{
		if(e < 0) 
		{
		    MessageBox.Show(" English error!", "Set English Grade_Error", MessageBoxButtons.OK);
		}
		else
		{
		  english = e;
		  sumTotal();
		}
	}

        public void sumTotal()
        {
            total = chinese + ((english + math) * 2);
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

        public double getMath()
        {
            return math;
        }

        public double getChinese()
        {
            return chinese;
        }

        public double getEnglish()
        {
            return english;
        }

        public double getTotal()
        {
            return total;
        }

        public String ToString()
        {
            return getGroup() + "學生" + getCode() + "," + getName() + " 的加權總分為 " + getTotal() + ",結果:" + getSort();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            StudentAugust objAsSM = obj as StudentAugust;
            if (objAsSM == null) return false;
            else return Equals(objAsSM);
        }

        public bool Equals(StudentAugust obj) //比較物件內容
        {
            if (obj == null)
                return false;
            return ((this.math.Equals(obj.math)) && (this.chinese.Equals(obj.chinese))  && (this.english.Equals(obj.english)));
        }

        public int SortGradeAscending(int g1, int g2)
        {
            return g1.CompareTo(g2);
        }

        public int CompareTo(StudentAugust compareSA) //排序基準
        {
           /* if (compareSA == null)
                return 1;
            else
                return this.math.CompareTo(compareSA.math);*/
            double dValue = this.total - compareSA.total;
            if (dValue > 0.0)
            { return 1; }
            if (dValue < 0.0)
            { return -1; }
            else
            {
                double g1 = this.english - compareSA.english;
                if (g1 > 0.0)
                { return 1; }
                if (g1 < 0.0)
                { return -1; }
                else
                {
                    double g2 = this.math - compareSA.math;
                    if (g2 > 0.0)
                    { return 1; }
                    if (g2 < 0.0)
                    { return -1; }
                    else
                    {
                        double g3 = this.chinese - compareSA.chinese;
                        if (g3 > 0.0)
                        { return 1; }
                        else
                        { return -1; }
                    }
                }
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
