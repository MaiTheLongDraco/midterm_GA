using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiTheLong
{
     class TestStudent
    {
        private List<Student> ListStudent = null;

        public TestStudent()
        {
            ListStudent = new List<Student>();
        }
       
        public  void InputInfo()
        { 
            Student student=new Student();
            Console.WriteLine("nhap id : ");
            student.Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap name : ");
            student.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("nhap gender : ");
            student.Gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("nhap age : ");
            student.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ngay sinh : ");
            student.dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("nhap class : ");
            student.Class = Convert.ToString(Console.ReadLine());
            Console.WriteLine("nhap mark1 : ");
            student.Mark1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap mark2 : ");
            student.Mark2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap mark3 : ");
            student.Mark3 = Convert.ToDouble(Console.ReadLine());
        }
        public void UpdateStudentInfo(int id,Student student)
        {
            if(student.Id==id)
            {
                if(student!=null)
                {
                    Console.WriteLine("nhap id : ");
                    int newId= Convert.ToInt32(Console.ReadLine());
                    if(newId!=null) { 

                    student.Id = newId;
                    }

                    Console.WriteLine("nhap name : ");
                    string newName = Convert.ToString(Console.ReadLine());
                    {
                        if(newName!=null&&newName.Length>0) {
                        student.Name= newName;}
                    }
                    Console.WriteLine("nhap gender : ");
                    bool newGender = Convert.ToBoolean(Console.ReadLine());
                   if(newGender!=null)
                    {
                        student.Gender = newGender;
                    }
                    Console.WriteLine("nhap age : ");
                   int newAge= Convert.ToInt32(Console.ReadLine());
                   if(newAge>0)
                    {
                        student.Age = newAge;
                    }

                    Console.WriteLine("nhap ngay sinh : ");
                    DateTime newBirth= Convert.ToDateTime(Console.ReadLine());
                    if(newBirth!=null)
                    {
                        student.dateOfBirth= newBirth;
                    }
                    Console.WriteLine("nhap class : ");
                    string newClass= Convert.ToString(Console.ReadLine());
                   if(newClass != null&& newClass.Length>0)
                    {
                        student.Class = newClass;
                    }
                    Console.WriteLine("nhap mark1 : ");
                    double newMark1= Convert.ToDouble(Console.ReadLine());
                    if(newMark1>=0&&newMark1<=10) {
                        student.Mark1= newMark1;
                    }
                    Console.WriteLine("nhap mark2 : ");
                    double newMark2 = Convert.ToDouble(Console.ReadLine());
                    if (newMark2 >= 0 && newMark2 <= 10)
                    {
                        student.Mark2 = newMark2;
                    }
                    Console.WriteLine("nhap mark3 : ");
                    double newMark3 = Convert.ToDouble(Console.ReadLine());
                    if (newMark3 >= 0 && newMark3 <= 10)
                    {
                        student.Mark3 = newMark3;
                    }
                }
            }
        }
        public Student FindByID(int ID)

        {
            Student searchResult = null;
            if (ListStudent != null && ListStudent.Count > 0)
            {
                foreach (Student sv in ListStudent)
                {
                    if (sv.Id == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }

        public bool DeleteById(int ID)
        {
            bool IsDeleted = false;
            // tìm kiếm sinh viên theo ID
            Student sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = ListStudent.Remove(sv);
            }
            return IsDeleted;
        }
        public List<Student> FindByName(String keyword)
        {
            List<Student> searchResult = new List<Student>();
            if (ListStudent != null && ListStudent.Count > 0)
            {
                foreach (Student sv in ListStudent)
                {
                    if (sv.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }
        public void ShowSinhVien(List<Student> listSV)
        {
           
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (Student sv in listSV)
                {
                    Console.WriteLine("ID hoc sinh la : " + sv.Id);
                    Console.WriteLine("ten hoc sinh la : "+sv.Name);
                    Console.WriteLine("gioi tinh hoc sinh la : "+sv.Gender);
                    Console.WriteLine("tuoi hoc sinh la : "+sv.Age);
                    Console.WriteLine("lop hoc sinh la : "+sv.Class);
                    Console.WriteLine("mark1 hoc sinh la : "+sv.Mark1);
                    Console.WriteLine("mark2 hoc sinh la : "+sv.Mark2);
                    Console.WriteLine("mark3 hoc sinh la : "+sv.Mark3);
                    sv.mark_AVG();
                    Console.WriteLine("diem trung binh hoc sinh la : "+sv.avgMark);
                }
            }
            Console.WriteLine();
        }
        public void SortByDiemTB()
        {
            ListStudent.Sort(delegate (Student sv1, Student sv2) {
                return sv1.avgMark.CompareTo(sv2.avgMark);
            });
        }
        
        public List<Student> getListStudents() {
            return ListStudent;
        }
    }
}
