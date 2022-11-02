using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _dal;
        public StudentManager(IStudentDal studentDal)
        {
            _dal = studentDal;
        }
        public int AddStudent(Student student)
        {
            return _dal.Add(student); 
        }

        public int DeleteStudent(Student student)
        {
            return _dal.Delete(student);
        }

        public List<Student> ListAddStudent()
        {
            return _dal.ListAll();
        }

        public int UpdateStudent(Student student)
        {
            return _dal.Update(student);
        }
    }
}
