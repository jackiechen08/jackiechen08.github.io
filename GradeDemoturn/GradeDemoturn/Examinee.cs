using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeDemoturn
{
    class Examinee 
    {
        private String name, testcode, group, sort;
        private int num;

        // default constructor
        public Examinee()
        {
            name = "";
            testcode = "";
            group = "";
            sort = "";
            num = 0;
        }

        public Examinee(String testcode, String name, String group, String sort)
        {
            this.name = name;
            this.group = group;
            this.testcode = testcode;
            this.sort = sort;
            num = 0;
        }

        // setters

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
            return getCode() + "測試,";
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //   Examinee objAsSM = obj as Examinee;
        //    if (objAsSM == null) return false;
        //    else return Equals(objAsSM);
        //}

        //public bool Equals(Examinee obj)
        //{
        //    if (obj == null)
        //        return false;
        //    return (this.num.Equals(obj.num));
        //}

        //public int SortGradeAscending(int g1, int g2)
        //{
        //    return g1.CompareTo(g2);
        //}

        //public int CompareTo(Examinee compareExam)
        //{
        //    if (compareExam == null)
        //        return 1;
        //    else
        //        return this.num.CompareTo(compareExam.num);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
}
