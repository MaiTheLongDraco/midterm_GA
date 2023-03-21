using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiTheLong
{
    internal class Student
    {//Id, Name, Gender, Age, Date of birth, Class, Mark1, Mark 2, Mark 3 và 1 mark_AVG() : trả về mark trung bình của student. (2p)
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string Class { get; set; }
        public double Mark1 { get; set; }
        public double Mark2 { get; set; }
        public double Mark3 { get; set; }
        public double avgMark;



        public double mark_AVG()
        {
            avgMark=(Mark1+Mark2+ Mark3)/3;
            return avgMark;
        }
    }


}
