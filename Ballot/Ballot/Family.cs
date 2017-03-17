using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballot
{
    class Family
    {
        private int iFamilyCode;
        private List<Student> listMember = new List<Student>();

        public Family()
        {
            iFamilyCode = 0;
        }

        public Family(int piFamilycode)
        {
            this.iFamilyCode = piFamilycode;

        }

        public void AddMember(Student s)
        {
            listMember.Add(s);
        }

        public int getCount()
        {
            return listMember.Count;
        }

        public int getFamilyCode()
        {
            return iFamilyCode;
        }

        public Student getMember(int index)
        {
            if (index >= 0 && index < listMember.Count)
                return listMember[index];
            else
                return null;
        }

        public string ToString()
        {
            string sLine = "";
            sLine = "家族：" + getFamilyCode() + "\n";
            for (int i = 0; i < listMember.Count; i++)
            {
                sLine += listMember[i].ToString() + "\t";
            }
            return sLine;
        }
    }
}
